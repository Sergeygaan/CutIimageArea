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
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureWindow
            // 
            this.PictureWindow.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.PictureWindow.Location = new System.Drawing.Point(3, 3);
            this.PictureWindow.Name = "PictureWindow";
            this.PictureWindow.Size = new System.Drawing.Size(461, 446);
            this.PictureWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureWindow.TabIndex = 2;
            this.PictureWindow.TabStop = false;
            this.PictureWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureWindow_MouseDown);
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
            this.button2.Location = new System.Drawing.Point(470, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Пропустить изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NextImage_Button);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Сохранить выбранную область";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveImage_Button);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 466);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PictureWindow);
            this.Name = "Form1";
            this.Text = "CropPic";
            ((System.ComponentModel.ISupportInitialize)(this.PictureWindow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox PictureWindow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

