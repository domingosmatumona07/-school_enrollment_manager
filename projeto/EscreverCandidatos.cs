using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class EscreverCandidatos : Form
    {
        public EscreverCandidatos()
        {
            InitializeComponent();
        }

        private void EscreverCandidatos_Load(object sender, EventArgs e)
        {
            cmbCurso.SelectedIndex = 0;
        }

        private void btnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            char sexo = 'M';

            if(rdBFem.Checked) {
                sexo = 'F';
            }

            if((txtBNome.Text != "" ) && ((cmbCurso.SelectedIndex !=  0) && (cmbCurso.SelectedItem != null)) && (txtBNumeroBI.Text != "")) {
                if(Candidatos.biNumbers.Contains(txtBNumeroBI.Text)) {
                    MessageBox.Show("Já foi cadastrado um candidato no sistema com este número de Bilhete!", "Número de BI já existente!");
                } else {
                    MessageBox.Show("Sucesso na Inscrição\nNúmero de Inscrição: " + (Candidatos.names.Count + 1).ToString(), "Inscrição de Candidatos");

                    Candidatos.saveName(txtBNome.Text);
                    Candidatos.saveSex(sexo);
                    Candidatos.saveAge((int)numUpIdade.Value);
                    Candidatos.saveCourse(cmbCurso.SelectedItem.ToString());
                    Candidatos.saveBiNumber(txtBNumeroBI.Text);
                    Candidatos.saveInscritionNumber(Candidatos.names.Count);

                    limpaCampos();

                    txtBNome.Focus();
                }
            } else {
                MessageBox.Show("Preencha todos os campos solicitados.", "Preenchimento inacabado");
            }
        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void limpaCampos() {
            txtBNome.Clear();
            rdBMasc.Select();
            numUpIdade.Value = 12;
            cmbCurso.SelectedIndex = 0;
            txtBNumeroBI.Clear();
        }
    }
}
