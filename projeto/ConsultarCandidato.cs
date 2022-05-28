using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class ConsultarCandidato : Form
    {
        public ConsultarCandidato()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int numeroInscricao = (int)nUDnumeroInsc.Value;

            if (Candidatos.inscritionNumbers.Contains(numeroInscricao)) {
                lblNome.Text = (Candidatos.names[numeroInscricao - 1]).ToString();
                lblIdade.Text = (Candidatos.ages[numeroInscricao - 1]).ToString();
                lblSexo.Text = (Candidatos.sexs[numeroInscricao - 1]).ToString();
                lblCurso.Text = (Candidatos.courses[numeroInscricao - 1]).ToString();
                lblNumeroBI.Text = (Candidatos.biNumbers[numeroInscricao - 1]).ToString();
            } else {
                lblNome.Text = lblIdade.Text = lblSexo.Text = lblCurso.Text = lblNumeroBI.Text = "-";
                MessageBox.Show("Número de Inscrição Inválido!", "Candidato Inexistente!");
            }
  

        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
