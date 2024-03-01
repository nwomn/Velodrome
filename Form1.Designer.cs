namespace Velodrome
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label5 = new Label();
            cBoxParityBits = new ComboBox();
            label4 = new Label();
            cBoxStopBits = new ComboBox();
            label3 = new Label();
            cBoxDataBits = new ComboBox();
            label2 = new Label();
            cBoxBaudRate = new ComboBox();
            label1 = new Label();
            cBoxCOMPORT = new ComboBox();
            groupBox2 = new GroupBox();
            btnClose = new Button();
            progressBar1 = new ProgressBar();
            btnOpen = new Button();
            btnSendData = new Button();
            tBoxDataOut = new TextBox();
            groupBox3 = new GroupBox();
            chBoxAddToOldData = new CheckBox();
            chBoxAlwaysUpdate = new CheckBox();
            tBoxDataIN = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cBoxParityBits);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cBoxStopBits);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cBoxDataBits);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cBoxBaudRate);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cBoxCOMPORT);
            groupBox1.Location = new Point(8, 8);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(237, 184);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Com Port Control";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 140);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 17);
            label5.TabIndex = 9;
            label5.Text = "PARITY BITS";
            // 
            // cBoxParityBits
            // 
            cBoxParityBits.FormattingEnabled = true;
            cBoxParityBits.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cBoxParityBits.Location = new Point(102, 138);
            cBoxParityBits.Margin = new Padding(2, 2, 2, 2);
            cBoxParityBits.Name = "cBoxParityBits";
            cBoxParityBits.Size = new Size(117, 25);
            cBoxParityBits.TabIndex = 8;
            cBoxParityBits.Text = "None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(69, 17);
            label4.TabIndex = 7;
            label4.Text = "STOP BITS";
            // 
            // cBoxStopBits
            // 
            cBoxStopBits.FormattingEnabled = true;
            cBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            cBoxStopBits.Location = new Point(102, 111);
            cBoxStopBits.Margin = new Padding(2, 2, 2, 2);
            cBoxStopBits.Name = "cBoxStopBits";
            cBoxStopBits.Size = new Size(117, 25);
            cBoxStopBits.TabIndex = 6;
            cBoxStopBits.Text = "One";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 86);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 17);
            label3.TabIndex = 5;
            label3.Text = "DATA BITS";
            // 
            // cBoxDataBits
            // 
            cBoxDataBits.FormattingEnabled = true;
            cBoxDataBits.Items.AddRange(new object[] { "6", "7", "8" });
            cBoxDataBits.Location = new Point(102, 84);
            cBoxDataBits.Margin = new Padding(2, 2, 2, 2);
            cBoxDataBits.Name = "cBoxDataBits";
            cBoxDataBits.Size = new Size(117, 25);
            cBoxDataBits.TabIndex = 4;
            cBoxDataBits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 60);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 17);
            label2.TabIndex = 3;
            label2.Text = "BAUD RATE";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "2400", "4800", "9600", "115200" });
            cBoxBaudRate.Location = new Point(102, 57);
            cBoxBaudRate.Margin = new Padding(2, 2, 2, 2);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(117, 25);
            cBoxBaudRate.TabIndex = 2;
            cBoxBaudRate.Text = "115200";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 1;
            label1.Text = "COM PORT";
            // 
            // cBoxCOMPORT
            // 
            cBoxCOMPORT.FormattingEnabled = true;
            cBoxCOMPORT.Location = new Point(102, 30);
            cBoxCOMPORT.Margin = new Padding(2, 2, 2, 2);
            cBoxCOMPORT.Name = "cBoxCOMPORT";
            cBoxCOMPORT.Size = new Size(117, 25);
            cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClose);
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(btnOpen);
            groupBox2.Location = new Point(8, 197);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(133, 82);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(68, 21);
            btnClose.Margin = new Padding(2, 2, 2, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(54, 24);
            btnClose.TabIndex = 3;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(10, 49);
            progressBar1.Margin = new Padding(2, 2, 2, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(112, 24);
            progressBar1.TabIndex = 2;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(10, 21);
            btnOpen.Margin = new Padding(2, 2, 2, 2);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(54, 24);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "OPEN";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(154, 207);
            btnSendData.Margin = new Padding(2, 2, 2, 2);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(90, 72);
            btnSendData.TabIndex = 2;
            btnSendData.Text = "Send Data";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // tBoxDataOut
            // 
            tBoxDataOut.Location = new Point(255, 15);
            tBoxDataOut.Margin = new Padding(2, 2, 2, 2);
            tBoxDataOut.Multiline = true;
            tBoxDataOut.Name = "tBoxDataOut";
            tBoxDataOut.Size = new Size(236, 265);
            tBoxDataOut.TabIndex = 3;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chBoxAddToOldData);
            groupBox3.Controls.Add(chBoxAlwaysUpdate);
            groupBox3.Controls.Add(tBoxDataIN);
            groupBox3.Location = new Point(493, 15);
            groupBox3.Margin = new Padding(2, 2, 2, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 2, 2, 2);
            groupBox3.Size = new Size(295, 264);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Receiver Control";
            // 
            // chBoxAddToOldData
            // 
            chBoxAddToOldData.AutoSize = true;
            chBoxAddToOldData.Location = new Point(4, 206);
            chBoxAddToOldData.Margin = new Padding(2, 2, 2, 2);
            chBoxAddToOldData.Name = "chBoxAddToOldData";
            chBoxAddToOldData.Size = new Size(126, 21);
            chBoxAddToOldData.TabIndex = 7;
            chBoxAddToOldData.Text = "Add To Old Data";
            chBoxAddToOldData.UseVisualStyleBackColor = true;
            chBoxAddToOldData.CheckedChanged += chBoxAddToOldData_CheckedChanged;
            // 
            // chBoxAlwaysUpdate
            // 
            chBoxAlwaysUpdate.AutoSize = true;
            chBoxAlwaysUpdate.Location = new Point(4, 182);
            chBoxAlwaysUpdate.Margin = new Padding(2, 2, 2, 2);
            chBoxAlwaysUpdate.Name = "chBoxAlwaysUpdate";
            chBoxAlwaysUpdate.Size = new Size(113, 21);
            chBoxAlwaysUpdate.TabIndex = 6;
            chBoxAlwaysUpdate.Text = "Always Update";
            chBoxAlwaysUpdate.UseVisualStyleBackColor = true;
            chBoxAlwaysUpdate.CheckedChanged += chBoxAlwaysUpdate_CheckedChanged;
            // 
            // tBoxDataIN
            // 
            tBoxDataIN.Location = new Point(4, 21);
            tBoxDataIN.Margin = new Padding(2, 2, 2, 2);
            tBoxDataIN.Multiline = true;
            tBoxDataIN.Name = "tBoxDataIN";
            tBoxDataIN.Size = new Size(289, 158);
            tBoxDataIN.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 612);
            Controls.Add(groupBox3);
            Controls.Add(tBoxDataOut);
            Controls.Add(btnSendData);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "C# COM PORT SERIAL";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private ComboBox cBoxParityBits;
        private Label label4;
        private ComboBox cBoxStopBits;
        private Label label3;
        private ComboBox cBoxDataBits;
        private Label label2;
        private ComboBox cBoxBaudRate;
        private Label label1;
        private ComboBox cBoxCOMPORT;
        private GroupBox groupBox2;
        private Button btnClose;
        private ProgressBar progressBar1;
        private Button btnOpen;
        private Button btnSendData;
        private TextBox tBoxDataOut;
        private GroupBox groupBox3;
        private CheckBox chBoxAddToOldData;
        private CheckBox chBoxAlwaysUpdate;
        private TextBox tBoxDataIN;
    }
}