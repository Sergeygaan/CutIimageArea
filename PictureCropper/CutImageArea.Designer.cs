namespace CutImageArea
{
    partial class CutImageArea
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
            this.components = new System.ComponentModel.Container();
            this.PictureWindow = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CountImage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureWindow
            // 
            this.PictureWindow.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.PictureWindow.Location = new System.Drawing.Point(3, 3);
            this.PictureWindow.Name = "PictureWindow";
            this.PictureWindow.Size = new System.Drawing.Size(461, 432);
            this.PictureWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureWindow.TabIndex = 2;
            this.PictureWindow.TabStop = false;
            this.PictureWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureWindow_MouseDown);
            this.PictureWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureWindow_MouseMove);
            this.PictureWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureWindow_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Загрузка изображений";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LoadImage_Button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Пропустить изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NextImage_Button);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить выбранную область";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveImage_Button);
            // 
            // CountImage
            // 
            this.CountImage.AutoSize = true;
            this.CountImage.Location = new System.Drawing.Point(13, 442);
            this.CountImage.Name = "CountImage";
            this.CountImage.Size = new System.Drawing.Size(0, 13);
            this.CountImage.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "---------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "---------------------";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(470, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Единый шаблон";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(470, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(136, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Обучение каскада";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Haarcascade_Click);
            // 
            // CutImageArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 466);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureWindow);
            this.Name = "CutImageArea";
            this.Text = "CropPic";
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox PictureWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label CountImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

