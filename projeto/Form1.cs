using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCadastrFunc cadast = new frmCadastrFunc();
            cadast.Closed += (s, args) => this.Close();
            cadast.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
