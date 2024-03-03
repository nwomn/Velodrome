using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velodrome
{
    public partial class Form2 : Form
    {
        private static CalibrationParameters DEFAULTPARAMETERS = new CalibrationParameters();
        public CalibrationParameters parameters = new CalibrationParameters();
        public Form2(Form1 sourceForm)
        {
            InitializeComponent();
            DEFAULTPARAMETERS = sourceForm.DEFAULTPARAMETERS;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetDefaultParameters();
        }
        private void SetDefaultParameters()
        {
            tBoxOffset.Text = DEFAULTPARAMETERS.offset;
            tBoxCoefficient.Text = DEFAULTPARAMETERS.coefficient;
            tBoxWheelRadius.Text = DEFAULTPARAMETERS.wheel_radius;
            tBoxPtS0.Text = DEFAULTPARAMETERS.p_to_s0;
            tBoxPtS1.Text = DEFAULTPARAMETERS.p_to_s1;
            tBoxPtS2.Text = DEFAULTPARAMETERS.p_to_s2;
            tBoxPtS3.Text = DEFAULTPARAMETERS.p_to_s3;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaultParameters();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            saveFileDialog.Title = "Save";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    // 将数据写入到文件中
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // 写入您想要保存的数据
                        string formattedData =
                            "Offset: " + tBoxOffset.Text + "\r\n" +
                            "Coefficient: " + tBoxCoefficient.Text + "\r\n" +
                            "Wheel Radius: " + tBoxWheelRadius.Text + "\r\n" +
                            "Power to Speed0: " + tBoxPtS0.Text + "\r\n" +
                            "Power to Speed1: " + tBoxPtS1.Text + "\r\n" +
                            "Power to Speed2: " + tBoxPtS1.Text + "\r\n" +
                            "Power to Speed3: " + tBoxPtS3.Text + "\r\n"; // 根据需要格式化数据
                        // 将格式化后的数据写入到文件中
                        writer.WriteLine(formattedData);
                    }

                    MessageBox.Show("Calibration Parameters save successfully! ", "Save successfully. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failure to save：{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text File (*.txt)|*.txt";
            openFileDialog.Title = "Select a file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // 读取选中的 txt 文件内容
                    string[] lines = File.ReadAllLines(filePath);

                    // 分解每行文本，并将值填充到相应的文本框中
                    foreach (string line in lines)
                    {
                        string[] keyValue = line.Split(':');
                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0].Trim();
                            string value = keyValue[1].Trim();

                            // 根据键的名称填充到相应的文本框中
                            switch (key)
                            {
                                case "Offset":
                                    tBoxOffset.Text = value;
                                    break;
                                case "Coefficient":
                                    tBoxCoefficient.Text = value;
                                    break;
                                case "Wheel Radius":
                                    tBoxWheelRadius.Text = value;
                                    break;
                                case "Power to Speed0":
                                    tBoxPtS0.Text = value;
                                    break;
                                case "Power to Speed1":
                                    tBoxPtS1.Text = value;
                                    break;
                                case "Power to Speed2":
                                    tBoxPtS2.Text = value;
                                    break;
                                case "Power to Speed3":
                                    tBoxPtS3.Text = value;
                                    break;
                            }
                        }
                    }

                    MessageBox.Show("Calibration Parameters load successfully! ", "Load successfully. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failure to load：{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Parameters_TextChanged(object sender, EventArgs e)
        {
            parameters.offset = tBoxOffset.Text;
            parameters.coefficient = tBoxCoefficient.Text;
            parameters.wheel_radius = tBoxWheelRadius.Text;
            parameters.p_to_s0 = tBoxPtS0.Text;
            parameters.p_to_s1 = tBoxPtS1.Text;
            parameters.p_to_s2 = tBoxPtS2.Text;
            parameters.p_to_s3 = tBoxPtS3.Text;
        }
    }
}
