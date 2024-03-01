namespace Velodrome
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            tBoxWheelRadius = new TextBox();
            label4 = new Label();
            tBoxCoefficient = new TextBox();
            label3 = new Label();
            tBoxOffset = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            tBoxPtS4 = new TextBox();
            label8 = new Label();
            tBoxPtS3 = new TextBox();
            label7 = new Label();
            tBoxPtS2 = new TextBox();
            label6 = new Label();
            tBoxPtS1 = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            btnLoad = new Button();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(353, 24);
            label1.TabIndex = 0;
            label1.Text = "Calibrate parameters of the cycler here: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tBoxWheelRadius);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tBoxCoefficient);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tBoxOffset);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(31, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 145);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sensor Calibration";
            // 
            // tBoxWheelRadius
            // 
            tBoxWheelRadius.Location = new Point(244, 102);
            tBoxWheelRadius.Name = "tBoxWheelRadius";
            tBoxWheelRadius.Size = new Size(150, 30);
            tBoxWheelRadius.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 105);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 4;
            label4.Text = "Wheel Radius: ";
            // 
            // tBoxCoefficient
            // 
            tBoxCoefficient.Location = new Point(244, 66);
            tBoxCoefficient.Name = "tBoxCoefficient";
            tBoxCoefficient.Size = new Size(150, 30);
            tBoxCoefficient.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 69);
            label3.Name = "label3";
            label3.Size = new Size(111, 24);
            label3.TabIndex = 2;
            label3.Text = "Coefficient: ";
            // 
            // tBoxOffset
            // 
            tBoxOffset.Location = new Point(244, 30);
            tBoxOffset.Name = "tBoxOffset";
            tBoxOffset.Size = new Size(150, 30);
            tBoxOffset.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 33);
            label2.Name = "label2";
            label2.Size = new Size(71, 24);
            label2.TabIndex = 0;
            label2.Text = "Offset: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tBoxPtS4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(tBoxPtS3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(tBoxPtS2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tBoxPtS1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(31, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(406, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Power to speed coefficients";
            // 
            // tBoxPtS4
            // 
            tBoxPtS4.Location = new Point(244, 137);
            tBoxPtS4.Name = "tBoxPtS4";
            tBoxPtS4.Size = new Size(150, 30);
            tBoxPtS4.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 140);
            label8.Name = "label8";
            label8.Size = new Size(206, 24);
            label8.TabIndex = 9;
            label8.Text = "Power to Speed(Back): ";
            // 
            // tBoxPtS3
            // 
            tBoxPtS3.Location = new Point(244, 101);
            tBoxPtS3.Name = "tBoxPtS3";
            tBoxPtS3.Size = new Size(150, 30);
            tBoxPtS3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 104);
            label7.Name = "label7";
            label7.Size = new Size(196, 24);
            label7.TabIndex = 7;
            label7.Text = "Power to Speed(3rd): ";
            // 
            // tBoxPtS2
            // 
            tBoxPtS2.Location = new Point(244, 65);
            tBoxPtS2.Name = "tBoxPtS2";
            tBoxPtS2.Size = new Size(150, 30);
            tBoxPtS2.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 68);
            label6.Name = "label6";
            label6.Size = new Size(200, 24);
            label6.TabIndex = 5;
            label6.Text = "Power to Speed(2nd): ";
            // 
            // tBoxPtS1
            // 
            tBoxPtS1.Location = new Point(244, 29);
            tBoxPtS1.Name = "tBoxPtS1";
            tBoxPtS1.Size = new Size(150, 30);
            tBoxPtS1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 32);
            label5.Name = "label5";
            label5.Size = new Size(212, 24);
            label5.TabIndex = 3;
            label5.Text = "Power to Speed(Front): ";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(440, 64);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(168, 96);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(440, 176);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(168, 96);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(440, 288);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(168, 96);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 392);
            Controls.Add(btnReset);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Calibration";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tBoxWheelRadius;
        private Label label4;
        private TextBox tBoxCoefficient;
        private Label label3;
        private TextBox tBoxOffset;
        private Label label2;
        private TextBox tBoxPtS4;
        private Label label8;
        private TextBox tBoxPtS3;
        private Label label7;
        private TextBox tBoxPtS2;
        private Label label6;
        private TextBox tBoxPtS1;
        private Label label5;
        private Button btnSave;
        private Button btnLoad;
        private Button btnReset;
    }
}