using System.IO.Ports;

namespace Velodrome
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        string dataOUT;
        string dataIN;
        private Form2 form2Instance; // 全局变量用于存储 Form2 实例
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
            // 读取 5 个字节的数据
            byte[] buffer = new byte[5];
            serialPort1.Read(buffer, 0, 5);

            // 解析数据类型
            byte type = buffer[0];
            if (type == 0x80) // 数据类型为 uint32
            {
                uint data = BitConverter.ToUInt32(buffer, 1);
                Packet_Int packetInt = new Packet_Int { type = type, data = data };
                // 处理 Packet_Int 数据
                Console.WriteLine($"Received Packet_Int: Type={packetInt.type}, Data={packetInt.data}");
                dataIN = packetInt.data.ToString();
            }
            else if (type == 2) // 数据类型为 float
            {
                float data = BitConverter.ToSingle(buffer, 1);
                Packet_Float packetFloat = new Packet_Float { type = type, data = data };
                // 处理 Packet_Float 数据
                Console.WriteLine($"Received Packet_Float: Type={packetFloat.type}, Data={packetFloat.data}");
                dataIN = packetFloat.data.ToString();
            }
            else
            {
                // 错误的数据类型
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
                // 如果 Form2 实例为空或已被释放，则创建新的实例
                form2Instance = new Form2();
                form2Instance.Show();
            }
            else
            {
                // 如果 Form2 实例已存在，则将其带到前台
                form2Instance.Focus();
            }
        }
    }

    // 定义两个Packet结构体，表示接收/发送的参数包，一个用于int类型参数，另一个用于float类型参数
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