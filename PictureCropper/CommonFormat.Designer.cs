namespace CutImageArea
{
    partial class CommonFormat
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
            this.button_GoodDat = new System.Windows.Forms.Button();
            this.textBox_GoodDat = new System.Windows.Forms.TextBox();
            this.textBox_GoodVec = new System.Windows.Forms.TextBox();
            this.button_GoodVec = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox_NameVec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PathGoodDat
            // 
            this.PathGoodDat.AutoSize = true;
            this.PathGoodDat.Location = new System.Drawing.Point(12, 9);
            this.PathGoodDat.Name = "PathGoodDat";
            this.PathGoodDat.Size = new System.Drawing.Size(333, 13);
            this.PathGoodDat.TabIndex = 0;
            this.PathGoodDat.Text = "Путь до файла описания положительных изображений Good.dat\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Путь, куда сохранять выходной файл с приведенными к общему формату положительными" +
    " изображениями\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота шаблона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ширина шаблона";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_GoodDat
            // 
            this.button_GoodDat.Location = new System.Drawing.Point(351, 5);
            this.button_GoodDat.Name = "button_GoodDat";
            this.button_GoodDat.Size = new System.Drawing.Size(26, 20);
            this.button_GoodDat.TabIndex = 4;
            this.button_GoodDat.Text = "...";
            this.button_GoodDat.UseVisualStyleBackColor = true;
            this.button_GoodDat.Click += new System.EventHandler(this.button_GoodDat_Click);
            // 
            // textBox_GoodDat
            // 
            this.textBox_GoodDat.Location = new System.Drawing.Point(15, 26);
            this.textBox_GoodDat.Name = "textBox_GoodDat";
            this.textBox_GoodDat.Size = new System.Drawing.Size(589, 20);
            this.textBox_GoodDat.TabIndex = 5;
            // 
            // textBox_GoodVec
            // 
            this.textBox_GoodVec.Location = new System.Drawing.Point(15, 71);
            this.textBox_GoodVec.Name = "textBox_GoodVec";
            this.textBox_GoodVec.Size = new System.Drawing.Size(589, 20);
            this.textBox_GoodVec.TabIndex = 6;
            // 
            // button_GoodVec
            // 
            this.button_GoodVec.Location = new System.Drawing.Point(578, 48);
            this.button_GoodVec.Name = "button_GoodVec";
            this.button_GoodVec.Size = new System.Drawing.Size(26, 20);
            this.button_GoodVec.TabIndex = 9;
            this.button_GoodVec.Text = "...";
            this.button_GoodVec.UseVisualStyleBackColor = true;
            this.button_GoodVec.Click += new System.EventHandler(this.button_GoodVec_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "Формировать строку";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Format_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 260);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(592, 20);
            this.textBoxResult.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(544, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Данную строку необходимо передать в файл \"opencv_createsamples.exe\" в качестве вх" +
    "одного параметра\r\n";
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Location = new System.Drawing.Point(16, 191);
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
            this.WidthNumericUpDown.Location = new System.Drawing.Point(16, 152);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.WidthNumericUpDown.TabIndex = 16;
            this.WidthNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // textBox_NameVec
            // 
            this.textBox_NameVec.Location = new System.Drawing.Point(16, 113);
            this.textBox_NameVec.Name = "textBox_NameVec";
            this.textBox_NameVec.Size = new System.Drawing.Size(589, 20);
            this.textBox_NameVec.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(587, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Имя файла файл, в котором будет сохранена приведённая к общему формату база полож" +
    "ительных изображений";
            // 
            // CommonFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 287);
            this.Controls.Add(this.textBox_NameVec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_GoodVec);
            this.Controls.Add(this.textBox_GoodVec);
            this.Controls.Add(this.textBox_GoodDat);
            this.Controls.Add(this.button_GoodDat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PathGoodDat);
            this.Name = "CommonFormat";
            this.Text = "CommonFormat";
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathGoodDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_GoodDat;
        private System.Windows.Forms.TextBox textBox_GoodDat;
        private System.Windows.Forms.TextBox textBox_GoodVec;
        private System.Windows.Forms.Button button_GoodVec;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.TextBox textBox_NameVec;
        private System.Windows.Forms.Label label5;
    }
}