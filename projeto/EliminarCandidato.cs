using System;
using System.Windows.Forms;
using System.Collections;

namespace projeto
{
    public partial class EliminarCandidato : Form
    {
        public EliminarCandidato()
        {
            InitializeComponent();
        }

        private void btnEliminarCandidato_Click(object sender, EventArgs e)
        {
            int numInsc = (int)nUDnumeroInsc.Value;

            if(Candidatos.inscritionNumbers.Contains(numInsc)) {
                ConfirmarEliminar confimEli = new ConfirmarEliminar(Candidatos.names[numInsc-1].ToString(), Candidatos.courses[numInsc-1].ToString(), (char)Candidatos.sexs[numInsc-1], (int)Candidatos.ages[numInsc-1], Candidatos.biNumbers[numInsc-1].ToString(), (numInsc-1));
                confimEli.Show();
            } else {
                MessageBox.Show("Número de inscrição inválido!", "Candidato Inexistente");
            }

            if(Candidatos.posicoesCandidatosEliminados.Count == Candidatos.names.Count) {
                Candidatos.names.Clear();
                Candidatos.sexs.Clear();
                Candidatos.ages.Clear();
                Candidatos.courses.Clear();
                Candidatos.biNumbers.Clear();
                Candidatos.inscritionNumbers.Clear();
                Candidatos.posicoesCandidatosEliminados.Clear();
            }
        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
