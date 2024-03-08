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
                    // Open a StreamWriter to write data
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        // Write data
                        string formattedData =
                            "Offset: " + tBoxOffset.Text + "\r\n" +
                            "Coefficient: " + tBoxCoefficient.Text + "\r\n" +
                            "Wheel Radius: " + tBoxWheelRadius.Text + "\r\n" +
                            "Power to Speed0: " + tBoxPtS0.Text + "\r\n" +
                            "Power to Speed1: " + tBoxPtS1.Text + "\r\n" +
                            "Power to Speed2: " + tBoxPtS1.Text + "\r\n" +
                            "Power to Speed3: " + tBoxPtS3.Text + "\r\n"; // Formalise the data
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
                    // Read txt file
                    string[] lines = File.ReadAllLines(filePath);

                    // Decode text
                    foreach (string line in lines)
                    {
                        string[] keyValue = line.Split(':');
                        if (keyValue.Length == 2)
                        {
                            string key = keyValue[0].Trim();
                            string value = keyValue[1].Trim();

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
