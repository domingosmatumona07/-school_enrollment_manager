using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class ListagemCandidatos : Form
    {
        public ListagemCandidatos()
        {
            InitializeComponent();
        }

        private void ListagemCandidatos_Load(object sender, EventArgs e)
        {
            int qtdCandidatos = Candidatos.names.Count;

            int linha = -1;
            for (int i = 0; i < qtdCandidatos; i++) {
                if(Candidatos.posicoesCandidatosEliminados.Contains(i)) {
                    if(i == (qtdCandidatos - 1)) {
                        break;
                    } else {
                        continue;
                    }
                }

                dtgvListaCandidatos.Rows.Add();
                linha++;
                dtgvListaCandidatos[0, linha].Value = Candidatos.names[i];
                dtgvListaCandidatos[1, linha].Value = Candidatos.sexs[i];
                dtgvListaCandidatos[2, linha].Value = Candidatos.ages[i];
                dtgvListaCandidatos[3, linha].Value = Candidatos.biNumbers[i];
                dtgvListaCandidatos[4, linha].Value = Candidatos.courses[i];
                dtgvListaCandidatos[5, linha].Value = Candidatos.inscritionNumbers[i];
            }
        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
