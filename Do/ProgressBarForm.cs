using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do
{
    public partial class ProgressBarForm : Form
    {
        
        public ProgressBarForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }
        public void UpdateProgress(int progressValue, string progressText)
        {
            progressBar1.Value = progressValue;
            label2.Text = progressText;

        }


        private void ProgressBarForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//cancel
        {
            this.Close();
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
