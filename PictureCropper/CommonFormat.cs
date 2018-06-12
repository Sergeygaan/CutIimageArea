using System;
using System.Windows.Forms;

namespace CutImageArea
{
    public partial class CommonFormat : Form
    {
        public CommonFormat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string GoodDat = "-info " + textBox1.Text + " ";
            string GoodVec = "-vec " + textBox2.Text + "\\" + textBox3.Text + ".vec ";
            string Width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string Height = " -h " + HeightNumericUpDown.Value.ToString() + " ";

            textBoxResult.Text = GoodDat + GoodVec + Width + Height;
        }
    }
}
