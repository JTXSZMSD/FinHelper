namespace FinHelper
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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            CurrentMoneyTextBox = new TextBox();
            TimeTextBox = new TextBox();
            label3 = new Label();
            PercentTextBox = new TextBox();
            label4 = new Label();
            InflationTextBox = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            FutureMoneyTextBox = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            ProfitTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(450, 15);
            label1.Name = "label1";
            label1.Size = new Size(114, 50);
            label1.TabIndex = 0;
            label1.Text = "Hewo";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(361, 26);
            label2.TabIndex = 1;
            label2.Text = "Введите сумму ваших инвестиций";
            // 
            // CurrentMoneyTextBox
            // 
            CurrentMoneyTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentMoneyTextBox.Location = new Point(12, 145);
            CurrentMoneyTextBox.Name = "CurrentMoneyTextBox";
            CurrentMoneyTextBox.Size = new Size(395, 33);
            CurrentMoneyTextBox.TabIndex = 2;
            CurrentMoneyTextBox.Text = "0";
            CurrentMoneyTextBox.TextChanged += CurrentMoneyTextBox_TextChanged;
            CurrentMoneyTextBox.KeyPress += CurrentMoneyTextBox_KeyPress;
            // 
            // TimeTextBox
            // 
            TimeTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            TimeTextBox.Location = new Point(12, 262);
            TimeTextBox.Name = "TimeTextBox";
            TimeTextBox.Size = new Size(395, 33);
            TimeTextBox.TabIndex = 4;
            TimeTextBox.Text = "0";
            TimeTextBox.TextChanged += TimeTextBox_TextChanged;
            TimeTextBox.KeyPress += TimeTextBox_KeyPress;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 219);
            label3.Name = "label3";
            label3.Size = new Size(222, 26);
            label3.TabIndex = 3;
            label3.Text = "Срок вклада (месяц)";
            // 
            // PercentTextBox
            // 
            PercentTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PercentTextBox.Location = new Point(12, 370);
            PercentTextBox.Name = "PercentTextBox";
            PercentTextBox.Size = new Size(395, 33);
            PercentTextBox.TabIndex = 6;
            PercentTextBox.Text = "0";
            PercentTextBox.TextChanged += PercentTextBox_TextChanged;
            PercentTextBox.KeyPress += PercentTextBox_KeyPress;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 327);
            label4.Name = "label4";
            label4.Size = new Size(395, 26);
            label4.TabIndex = 5;
            label4.Text = "Введите годовой процент инвестиции";
            // 
            // InflationTextBox
            // 
            InflationTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            InflationTextBox.Location = new Point(12, 472);
            InflationTextBox.Name = "InflationTextBox";
            InflationTextBox.Size = new Size(395, 33);
            InflationTextBox.TabIndex = 10;
            InflationTextBox.Text = "0";
            InflationTextBox.TextChanged += InflationTextBox_TextChanged;
            InflationTextBox.KeyPress += InflationTextBox_KeyPress;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 429);
            label6.Name = "label6";
            label6.Size = new Size(476, 26);
            label6.TabIndex = 9;
            label6.Text = "Введите процент инфляции за последний год\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(811, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // FutureMoneyTextBox
            // 
            FutureMoneyTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            FutureMoneyTextBox.Location = new Point(12, 577);
            FutureMoneyTextBox.Name = "FutureMoneyTextBox";
            FutureMoneyTextBox.ReadOnly = true;
            FutureMoneyTextBox.Size = new Size(395, 33);
            FutureMoneyTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 534);
            label5.Name = "label5";
            label5.Size = new Size(742, 26);
            label5.TabIndex = 12;
            label5.Text = "В конце срока вы будете иметь средств (капитализация каждый месяц)\r\n";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 632);
            label7.Name = "label7";
            label7.Size = new Size(520, 26);
            label7.TabIndex = 14;
            label7.Text = "С учётом инфляции ваш капитал приумножится в\r\n";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(644, 632);
            label8.Name = "label8";
            label8.Size = new Size(47, 26);
            label8.TabIndex = 16;
            label8.Text = "раз";
            // 
            // ProfitTextBox
            // 
            ProfitTextBox.Font = new Font("Bernard MT Condensed", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ProfitTextBox.Location = new Point(538, 629);
            ProfitTextBox.Name = "ProfitTextBox";
            ProfitTextBox.ReadOnly = true;
            ProfitTextBox.Size = new Size(100, 33);
            ProfitTextBox.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(ProfitTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(FutureMoneyTextBox);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(InflationTextBox);
            Controls.Add(label6);
            Controls.Add(PercentTextBox);
            Controls.Add(label4);
            Controls.Add(TimeTextBox);
            Controls.Add(label3);
            Controls.Add(CurrentMoneyTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinHelper";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CurrentMoneyTextBox;
        private TextBox TimeTextBox;
        private Label label3;
        private TextBox PercentTextBox;
        private Label label4;
        private TextBox InflationTextBox;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox FutureMoneyTextBox;
        private Label label5;
        private Label label7;
        private Label label8;
        private TextBox ProfitTextBox;
    }
}