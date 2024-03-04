using System.IO.Ports;
using System.Linq.Expressions;

namespace Velodrome
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        string dataOUT;
        string dataIN;
        private Form2 form2Instance; // ȫ�ֱ������ڴ洢 Form2 ʵ��
        private bool correct_port = false;

        // ������λ�ó�������
        const UInt32 FRONT = 1;
        const UInt32 SECOND = 2;
        const UInt32 THIRD = 3;
        const UInt32 BACK = 4;

        // ���ݰ�ͷ��ʶ������
        const byte OFFSET = 0x00;
        const byte COEFFICIENT = 0x01;
        const byte WHEELRADIUS = 0x02;
        const byte P2S0 = 0x10;
        const byte P2S1 = 0x11;
        const byte P2S2 = 0x12;
        const byte P2S3 = 0x13;
        const byte POSITION = 0x21;
        const byte TARGETSPEED = 0x22;
        const byte OPEN = 0x30;
        const byte CLOSE = 0x31;
        const byte POWER = 0x80;
        const byte SPEED = 0x81;
        const byte ADJSPEED = 0x82;
        const byte CADENCE = 0x83;
        const byte GETPARAM = 0x90;
        const byte ACKOPEN = 0x91;
        const byte ACKCLOSE = 0x92;

        // ����Ĭ��У������
        public CalibrationParameters DEFAULTPARAMETERS = new CalibrationParameters
        {
            offset = "1",
            coefficient = "2",
            wheel_radius = "3",
            p_to_s0 = "4",
            p_to_s1 = "5",
            p_to_s2 = "6",
            p_to_s3 = "7",
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            serialPort1.DataReceived += serialPort1_DataReceived;
            //chBoxAlwaysUpdate.Checked = true;
            //chBoxAddToOldData.Checked = false;
            lblOffline.Visible = true;
            lblOnline.Visible = false;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);

                serialPort1.Open();
                //progressBar1.Value = 100;
                lblOffline.Visible = false;
                lblOnline.Visible = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                //progressBar1.Value = 0;
                lblOffline.Visible = true;
                lblOnline.Visible = false;
            }
        }

        //private void btnSendData_Click(object sender, EventArgs e)
        //{
        //    if (serialPort1.IsOpen)
        //    {
        //        // dataOUT = tBoxDataOut.Text;
        //        // serialPort1.WriteLine(dataOUT);
        //        serialPort1.Write(dataOUT);
        //    }
        //}
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(ReceivePacket));
            // dataIN = serialPort1.ReadExisting();
            // this.Invoke(new EventHandler(ShowData));
        }
        //private void ShowData(object? sender, EventArgs e)
        //{
        //    if (chBoxAlwaysUpdate.Checked)
        //    {
        //        tBoxDataIN.Text = dataIN;
        //    }
        //    else if (chBoxAddToOldData.Checked)
        //    {
        //        tBoxDataIN.Text += dataIN;
        //    }
        //}
        private void ReceivePacket(object? sender, EventArgs e)
        {
            // ��ȡ 5 ���ֽڵ�����
            byte[] buffer = new byte[5];
            serialPort1.Read(buffer, 0, 5);

            // ������������
            byte type = buffer[0];
            byte[] dataBuffer = new byte[4];
            Array.Copy(buffer, 1, dataBuffer, 0, 4); // �� buffer �� 1-4 λ�����ݸ��Ƶ� subBuffer ��
            Array.Reverse(dataBuffer); // ��ת subBuffer �е��ֽ�˳��
            switch (type)
            {
                case POWER: // ���չ��ʲ�����Power��
                    var powerData = ConvertFloatData(type, dataBuffer);
                    // ���� Packet_Float ����
                    dataIN = powerData.ToString();
                    tBoxPower.Text = powerData.ToString();
                    break;
                case SPEED: // �����ٶȲ�����Speed��
                    var speedData = ConvertFloatData(type, dataBuffer);
                    // ���� Packet_Float ����
                    dataIN = speedData.ToString();
                    tBoxSpeed.Text = speedData.ToString();
                    break;
                case ADJSPEED: // ���յ����ٶȲ�����Adjust Speed��
                    var adjSpeedData = ConvertFloatData(type, dataBuffer);
                    // ���� Packet_Float ����
                    dataIN = adjSpeedData.ToString();
                    tBoxAdjSpeed.Text = adjSpeedData.ToString();
                    break;
                case CADENCE: // ���ս��������Cadence��
                    var cadenceData = ConvertFloatData(type, dataBuffer);
                    // ���� Packet_Float ����
                    dataIN = cadenceData.ToString();
                    tBoxCadence.Text = cadenceData.ToString();
                    break;
                case GETPARAM: // ���շ���У����������Get_param��
                    CalibrationParameters calibrationParameters = (form2Instance == null) ? DEFAULTPARAMETERS : form2Instance.parameters;
                    SendCalibrationParameter<uint>(OFFSET, calibrationParameters.offset);
                    SendCalibrationParameter<float>(COEFFICIENT, calibrationParameters.coefficient);
                    SendCalibrationParameter<float>(WHEELRADIUS, calibrationParameters.wheel_radius);
                    SendCalibrationParameter<float>(P2S0, calibrationParameters.p_to_s0);
                    SendCalibrationParameter<float>(P2S1, calibrationParameters.p_to_s1);
                    SendCalibrationParameter<float>(P2S2, calibrationParameters.p_to_s2);
                    SendCalibrationParameter<float>(P2S3, calibrationParameters.p_to_s3);
                    break;
                case ACKOPEN: // ���ն˿�ȷ���źţ�Ack_Open��
                    correct_port = true;
                    break;
                default:
                    // �������������
                    Console.WriteLine("Received unknown data type.");
                    break;
            }
        }
        private static float ConvertFloatData(byte type, byte[] dataBuffer)
        {
            float data = BitConverter.ToSingle(dataBuffer, 0);
            // Packet_Float packetInt = new Packet_Float { type = type, data = data };
            return data;
        }
        private void SendCalibrationParameter<T>(byte type, string calibrationParameter) where T : struct
        {
            try
            {
                if (!serialPort1.IsOpen)
                    throw new Exception("Must Connect to the cycler first.");

                byte[] dataBytes;
                if (typeof(T) == typeof(uint))
                {
                    if (!uint.TryParse(calibrationParameter, out uint data))
                        throw new Exception("Input Calibration Parameters are not the correct format.");

                    // ��������ת��Ϊ 4 �ֽڵ��ֽ�����
                    dataBytes = BitConverter.GetBytes(data);
                    Array.Reverse(dataBytes);
                }
                else if (typeof(T) == typeof(float))
                {
                    if (!float.TryParse(calibrationParameter, out float data))
                        throw new Exception("Input Calibration Parameters are not the correct format.");

                    // ��������ת��Ϊ 4 �ֽڵ��ֽ�����
                    dataBytes = BitConverter.GetBytes(data);
                    Array.Reverse(dataBytes);

                }
                else
                {
                    throw new Exception("Invalid data type. Only uint and float are supported.");
                }

                // ��װ���ݰ�
                byte[] packet = new byte[5];
                packet[0] = type; // ���ݰ�ͷ
                Array.Copy(dataBytes, 0, packet, 1, 4); // ���������ֽ����鸴�Ƶ����ݰ���
                serialPort1.Write(packet, 0, packet.Length); // �������ݰ�������
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxAlwaysUpdate.Checked)
        //    {
        //        chBoxAlwaysUpdate.Checked = true;
        //        chBoxAddToOldData.Checked = false;
        //    }
        //    else
        //    {
        //        chBoxAddToOldData.Checked = true;
        //    }
        //}

        //private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (chBoxAddToOldData.Checked)
        //    {
        //        chBoxAlwaysUpdate.Checked = false;
        //        chBoxAddToOldData.Checked = true;
        //    }
        //    else
        //    {
        //        chBoxAlwaysUpdate.Checked = true;
        //    }
        //}

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                // ��� Form2 ʵ��Ϊ�ջ��ѱ��ͷţ��򴴽��µ�ʵ��
                form2Instance = new Form2(this);
                form2Instance.Show();
            }
            else
            {
                // ��� Form2 ʵ���Ѵ��ڣ��������ǰ̨
                form2Instance.Focus();
            }
        }

        private void btnEnterSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    throw new Exception("Must Connect to the cycler first.");
                if (!float.TryParse(tBoxTargetSpeed.Text, out float data))
                    throw new Exception("Input Target Speed is not the correct format.");

                // ��������ת��Ϊ 4 �ֽڵ��ֽ�����
                byte[] dataBytes = BitConverter.GetBytes(data);
                Array.Reverse(dataBytes);

                // ��װ���ݰ�
                byte[] packet = new byte[5];
                packet[0] = TARGETSPEED; // ���ݰ�ͷ
                Array.Copy(dataBytes, 0, packet, 1, 4); // ���������ֽ����鸴�Ƶ����ݰ���
                dataOUT = tBoxTargetSpeed.Text;
                serialPort1.Write(packet, 0, packet.Length); // �������ݰ�������
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearSpeed_Click(object sender, EventArgs e)
        {
            tBoxTargetSpeed.Clear();
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            ChangePosition(FRONT);
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {
            ChangePosition(SECOND);
        }

        private void btnThird_Click(object sender, EventArgs e)
        {
            ChangePosition(THIRD);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChangePosition(BACK);
        }
        private void ChangePosition(UInt32 pos)
        {
            try
            {
                if (!serialPort1.IsOpen)
                    throw new Exception("Must Connect to the cycler first.");

                // ��������ת��Ϊ 4 �ֽڵ��ֽ�����
                UInt32 data = pos;
                byte[] dataBytes = BitConverter.GetBytes(data);
                Array.Reverse(dataBytes);

                // ��װ���ݰ�
                byte[] packet = new byte[5];
                packet[0] = POSITION; // ���ݰ�ͷ
                Array.Copy(dataBytes, 0, packet, 1, 4); // ���������ֽ����鸴�Ƶ����ݰ���
                dataOUT = tBoxTargetSpeed.Text;
                serialPort1.Write(packet, 0, packet.Length); // �������ݰ�������
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        //// ��������Packet�ṹ�壬��ʾ����/���͵Ĳ�������һ������int���Ͳ�������һ������float���Ͳ���
        //public struct Packet_Int
        //{
        //    public Byte type;
        //    public UInt32 data;
        //}
        //public struct Packet_Float
        //{
        //    public Byte type;
        //    public float data;
        //}
    }
    public struct CalibrationParameters
    {
        public string offset;
        public string coefficient;
        public string wheel_radius;
        public string p_to_s0;
        public string p_to_s1;
        public string p_to_s2;
        public string p_to_s3;
    }
}