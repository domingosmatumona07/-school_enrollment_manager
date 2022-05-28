using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class fimCadast : Form
    {
        private string nome, numeroTelefone, salarioDiario;
        private int idade;

        public fimCadast()
        {
            InitializeComponent();
        }

        public fimCadast(string name, int age, string phone, string dailySal)
        {
            InitializeComponent();
            this.nome = name;
            this.idade = age; 
            this.numeroTelefone = phone; 
            this.salarioDiario = dailySal;
        }

        private void btnSeeDatas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome: " + this.nome.ToString() + "\nIdade: " + this.idade.ToString() + "\nTelemóvel: " + this.numeroTelefone.ToString() + "\nSalário Diário: " + this.salarioDiario.ToString(), "Dados do Funcionário");
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Closed += (s, args) => this.Close();
	        menu.Show();
        }
    }
}
