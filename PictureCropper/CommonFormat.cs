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

        private void button_GoodDat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_GoodDat.Text = openFileDialog1.FileName;
        }

        private void button_GoodVec_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_GoodVec.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void button_Format_Click(object sender, EventArgs e)
        {
            string GoodDat = "-info " + textBox_GoodDat.Text + " ";
            string GoodVec = "-vec " + textBox_GoodVec.Text + "\\" + textBox_NameVec.Text + ".vec ";
            string Width = "-w " + WidthNumericUpDown.Value.ToString() + " ";
            string Height = " -h " + HeightNumericUpDown.Value.ToString() + " ";

            textBoxResult.Text = GoodDat + GoodVec + Width + Height;
        }
    }
}
