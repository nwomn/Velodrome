using System.IO.Ports;

namespace Velodrome
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        string dataOUT;
        string dataIN;
        private Form2 form2Instance; // ȫ�ֱ������ڴ洢 Form2 ʵ��
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
            serialPort1.DataReceived += serialPort1_DataReceived;
            chBoxAlwaysUpdate.Checked = false;
            chBoxAddToOldData.Checked = true;
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
                progressBar1.Value = 100;
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
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                // serialPort1.WriteLine(dataOUT);
                serialPort1.Write(dataOUT);
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ReceivePacket();
            // dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }
        private void ShowData(object? sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                tBoxDataIN.Text = dataIN;
            }
            else if (chBoxAddToOldData.Checked)
            {
                tBoxDataIN.Text += dataIN;
            }
        }
        private void ReceivePacket()
        {
            // ��ȡ 5 ���ֽڵ�����
            byte[] buffer = new byte[5];
            serialPort1.Read(buffer, 0, 5);

            // ������������
            byte type = buffer[0];
            if (type == 0x80) // ��������Ϊ uint32
            {
                uint data = BitConverter.ToUInt32(buffer, 1);
                Packet_Int packetInt = new Packet_Int { type = type, data = data };
                // ���� Packet_Int ����
                Console.WriteLine($"Received Packet_Int: Type={packetInt.type}, Data={packetInt.data}");
                dataIN = packetInt.data.ToString();
            }
            else if (type == 2) // ��������Ϊ float
            {
                float data = BitConverter.ToSingle(buffer, 1);
                Packet_Float packetFloat = new Packet_Float { type = type, data = data };
                // ���� Packet_Float ����
                Console.WriteLine($"Received Packet_Float: Type={packetFloat.type}, Data={packetFloat.data}");
                dataIN = packetFloat.data.ToString();
            }
            else
            {
                // �������������
                Console.WriteLine("Received unknown data type.");
            }
        }
        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddToOldData.Checked = false;
            }
            else
            {
                chBoxAddToOldData.Checked = true;
            }
        }

        private void chBoxAddToOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddToOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddToOldData.Checked = true;
            }
            else
            {
                chBoxAlwaysUpdate.Checked = true;
            }
        }

        private void btnCalibration_Click(object sender, EventArgs e)
        {
            if (form2Instance == null || form2Instance.IsDisposed)
            {
                // ��� Form2 ʵ��Ϊ�ջ��ѱ��ͷţ��򴴽��µ�ʵ��
                form2Instance = new Form2();
                form2Instance.Show();
            }
            else
            {
                // ��� Form2 ʵ���Ѵ��ڣ��������ǰ̨
                form2Instance.Focus();
            }
        }
    }

    // ��������Packet�ṹ�壬��ʾ����/���͵Ĳ�������һ������int���Ͳ�������һ������float���Ͳ���
    public struct Packet_Int
    {
        public Byte type;
        public UInt32 data;
    }
    public struct Packet_Float
    {
        public Byte type;
        public float data;
    }
}