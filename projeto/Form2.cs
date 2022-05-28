using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class frmCadastrFunc : Form
    {
        public frmCadastrFunc()
        {
            InitializeComponent();
        }

        private void btnCadF_Click(object sender, EventArgs e)
        {
            string name = txtBName.Text;
            int age = (int)nUDIdade.Value;
            string phone = txtBNumero.Text;
            string dailySal = txtBSalario.Text;

            if ((name != "") && (phone != "") && (dailySal != "")) {
                if ((float.Parse(dailySal) >= 5000) && (float.Parse(dailySal) <= 10000)) {
                    if(phone.Length == 9) {
                        MessageBox.Show("Funcionário Cadastrado com Sucesso!", "Cadastro de Funcionários");

                        this.Hide();
                        fimCadast cad = new fimCadast(name, age, phone, dailySal);
                        cad.FormClosed += (s, args) => this.Close();
                        cad.Show();
                    } else {
                        MessageBox.Show("O número de telefone deve conter 9 dígitos!", "Número Inválido");
                    }
                } else {
                    MessageBox.Show("O salário deve ser de 5000 a 10000 AKZ", "ERRO NO SALÁRIO DIÁRIO");
                }
            } else {
                MessageBox.Show("Preencha todos os campos!", "Campos Vazios");
            }

        }

        private void txtBName_TextChanged(object sender, EventArgs e)
        {
            if (txtBName.Text != "") {
                placeHolderNome.Hide();
            } else {
                placeHolderNome.Show();
            }
        }

        private void txtBName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.Handled = !(Char.IsLetter(e.KeyChar))) && (e.Handled = !(Char.IsControl(e.KeyChar))) && (e.Handled = !(Char.IsWhiteSpace(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void txtBNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtBNumero.Text != "") {
                placeHolderTelefone.Hide();
            } else {
                placeHolderTelefone.Show();
            }

            string numero = txtBNumero.Text;

            if ((numero.Length != 0) && (numero[0] != '9')) {
                MessageBox.Show("O primeiro número deve ser nove (9)");
                txtBNumero.Text = "";
            }
        }

        private void txtBNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.Handled = !(Char.IsNumber(e.KeyChar))) && (e.Handled = !(Char.IsControl(e.KeyChar)))) {
                e.Handled = true;
            }
        }

        private void txtBSalario_TextChanged(object sender, EventArgs e)
        {
            if (txtBSalario.Text != "") {
                placeHolderSalarioD.Hide();
            } else {
                placeHolderSalarioD.Show();
            }
        }

        private void txtBSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.Handled = !(Char.IsNumber(e.KeyChar))) && (e.Handled = !(Char.IsControl(e.KeyChar)))) {
                e.Handled = true;
            }
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
            txtBName.Focus();
        }

        private void lblIdade_Click(object sender, EventArgs e)
        {
            nUDIdade.Focus();
        }

        private void lblTelefone_Click(object sender, EventArgs e)
        {
            txtBNumero.Focus();
        }

        private void lblSalarioDiario_Click(object sender, EventArgs e)
        {
            txtBSalario.Focus();
        }
    }
}