namespace CutImageArea
{
    partial class CascadeTraining
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
            this.PathGoodDat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Haarcascade = new System.Windows.Forms.Button();
            this.textBox_Haarcascade = new System.Windows.Forms.TextBox();
            this.textBox_GoodVec = new System.Windows.Forms.TextBox();
            this.button_GoodVec = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_BadDat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_NumStages = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Minhitrate = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_MaxFalseAlarmRate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown_NumPos = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown_NumNeg = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown_Precalc = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumStages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minhitrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxFalseAlarmRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumNeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precalc)).BeginInit();
            this.SuspendLayout();
            // 
            // PathGoodDat
            // 
            this.PathGoodDat.AutoSize = true;
            this.PathGoodDat.Location = new System.Drawing.Point(392, 6);
            this.PathGoodDat.Name = "PathGoodDat";
            this.PathGoodDat.Size = new System.Drawing.Size(175, 13);
            this.PathGoodDat.TabIndex = 0;
            this.PathGoodDat.Text = "Расположение готового каскада\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Расположение файла .vec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота шаблона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина шаблона";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Haarcascade
            // 
            this.button_Haarcascade.Location = new System.Drawing.Point(689, 23);
            this.button_Haarcascade.Name = "button_Haarcascade";
            this.button_Haarcascade.Size = new System.Drawing.Size(26, 20);
            this.button_Haarcascade.TabIndex = 4;
            this.button_Haarcascade.Text = "...";
            this.button_Haarcascade.UseVisualStyleBackColor = true;
            this.button_Haarcascade.Click += new System.EventHandler(this.Button_Click_PathCascade);
            // 
            // textBox_Haarcascade
            // 
            this.textBox_Haarcascade.Location = new System.Drawing.Point(395, 23);
            this.textBox_Haarcascade.Name = "textBox_Haarcascade";
            this.textBox_Haarcascade.Size = new System.Drawing.Size(288, 20);
            this.textBox_Haarcascade.TabIndex = 5;
            // 
            // textBox_GoodVec
            // 
            this.textBox_GoodVec.Location = new System.Drawing.Point(395, 68);
            this.textBox_GoodVec.Name = "textBox_GoodVec";
            this.textBox_GoodVec.Size = new System.Drawing.Size(288, 20);
            this.textBox_GoodVec.TabIndex = 6;
            // 
            // button_GoodVec
            // 
            this.button_GoodVec.Location = new System.Drawing.Point(689, 68);
            this.button_GoodVec.Name = "button_GoodVec";
            this.button_GoodVec.Size = new System.Drawing.Size(26, 20);
            this.button_GoodVec.TabIndex = 9;
            this.button_GoodVec.Text = "...";
            this.button_GoodVec.UseVisualStyleBackColor = true;
            this.button_GoodVec.Click += new System.EventHandler(this.Button_Click_GoodVec);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(279, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Начать обучение";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click_Result);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(395, 168);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(288, 20);
            this.textBoxResult.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Расположение файла \"opencv_traincascade.exe\"";
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(12, 143);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HeightNumericUpDown.TabIndex = 15;
            this.HeightNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Location = new System.Drawing.Point(12, 104);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.WidthNumericUpDown.TabIndex = 16;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 20);
            this.button1.TabIndex = 21;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BadDat_Click);
            // 
            // textBox_BadDat
            // 
            this.textBox_BadDat.Location = new System.Drawing.Point(395, 119);
            this.textBox_BadDat.Name = "textBox_BadDat";
            this.textBox_BadDat.Size = new System.Drawing.Size(288, 20);
            this.textBox_BadDat.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(392, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Расположение файла Bad.dat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = " Количество уровней каскада";
            // 
            // numericUpDown_NumStages
            // 
            this.numericUpDown_NumStages.Location = new System.Drawing.Point(212, 22);
            this.numericUpDown_NumStages.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown_NumStages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumStages.Name = "numericUpDown_NumStages";
            this.numericUpDown_NumStages.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_NumStages.TabIndex = 23;
            this.numericUpDown_NumStages.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDown_Minhitrate
            // 
            this.numericUpDown_Minhitrate.DecimalPlaces = 3;
            this.numericUpDown_Minhitrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_Minhitrate.Location = new System.Drawing.Point(212, 61);
            this.numericUpDown_Minhitrate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Minhitrate.Name = "numericUpDown_Minhitrate";
            this.numericUpDown_Minhitrate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Minhitrate.TabIndex = 25;
            this.numericUpDown_Minhitrate.Value = new decimal(new int[] {
            999,
            0,
            0,
            196608});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Коэффициент качества обучения";
            // 
            // numericUpDown_MaxFalseAlarmRate
            // 
            this.numericUpDown_MaxFalseAlarmRate.DecimalPlaces = 1;
            this.numericUpDown_MaxFalseAlarmRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_MaxFalseAlarmRate.Location = new System.Drawing.Point(212, 100);
            this.numericUpDown_MaxFalseAlarmRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_MaxFalseAlarmRate.Name = "numericUpDown_MaxFalseAlarmRate";
            this.numericUpDown_MaxFalseAlarmRate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_MaxFalseAlarmRate.TabIndex = 27;
            this.numericUpDown_MaxFalseAlarmRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = " Уровень ложных тревог\r\n";
            // 
            // numericUpDown_NumPos
            // 
            this.numericUpDown_NumPos.Location = new System.Drawing.Point(12, 22);
            this.numericUpDown_NumPos.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_NumPos.Name = "numericUpDown_NumPos";
            this.numericUpDown_NumPos.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_NumPos.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Количество позитивных примеров";
            // 
            // numericUpDown_NumNeg
            // 
            this.numericUpDown_NumNeg.Location = new System.Drawing.Point(12, 61);
            this.numericUpDown_NumNeg.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDown_NumNeg.Name = "numericUpDown_NumNeg";
            this.numericUpDown_NumNeg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_NumNeg.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Количество негативных примеров";
            // 
            // numericUpDown_Precalc
            // 
            this.numericUpDown_Precalc.Location = new System.Drawing.Point(212, 143);
            this.numericUpDown_Precalc.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Precalc.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numericUpDown_Precalc.Name = "numericUpDown_Precalc";
            this.numericUpDown_Precalc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Precalc.TabIndex = 33;
            this.numericUpDown_Precalc.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(209, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Выделяемая под процесс память";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(689, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 20);
            this.button2.TabIndex = 34;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Opencv_Traincascade_Click);
            // 
            // CascadeTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 233);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown_Precalc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numericUpDown_NumNeg);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown_NumPos);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDown_MaxFalseAlarmRate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDown_Minhitrate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown_NumStages);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_BadDat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_GoodVec);
            this.Controls.Add(this.textBox_GoodVec);
            this.Controls.Add(this.textBox_Haarcascade);
            this.Controls.Add(this.button_Haarcascade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathGoodDat);
            this.Name = "CascadeTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CommonFormat";
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumStages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Minhitrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_MaxFalseAlarmRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumNeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Precalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathGoodDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Haarcascade;
        private System.Windows.Forms.TextBox textBox_Haarcascade;
        private System.Windows.Forms.TextBox textBox_GoodVec;
        private System.Windows.Forms.Button button_GoodVec;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_BadDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumStages;
        private System.Windows.Forms.NumericUpDown numericUpDown_Minhitrate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_MaxFalseAlarmRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumPos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumNeg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown_Precalc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
    }
}