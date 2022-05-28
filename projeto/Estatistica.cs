using System;
using System.Windows.Forms;

namespace projeto
{
    public partial class Estatística : Form
    {
        public Estatística()
        {
            InitializeComponent();
        }

        private void Estatística_Load(object sender, EventArgs e)
        {
            int qtdMasc = 0, qtdFem = 0;
            float percentMasc = 0.0f, percentFem = 0.0f;
            string percM, percF;

            foreach(char sexo in Candidatos.sexs) {
                if(sexo == 'M') {
                    qtdMasc++;
                } else {
                    qtdFem++;
                }
            }

            qtdMasc -= Candidatos.qtdMascEliminados;
            qtdFem -= Candidatos.qtdFemEliminados;

            int qtdEliminados = Candidatos.qtdMascEliminados + Candidatos.qtdFemEliminados;

            percentMasc = (qtdMasc * 100.0f) / (Candidatos.sexs.Count - qtdEliminados);
            percentFem = (qtdFem * 100.0f) / (Candidatos.sexs.Count - qtdEliminados);

            percM = percentMasc.ToString();
            percF = percentFem.ToString();

            qtdHomens.Text = qtdMasc.ToString();
            percentHomens.Text = ((percM.Length == 2) || (percM.Length == 3)) ? percM + "%" : (percM[0] + "" + percM[1] + percM[2] + percM[3] + "%");
            qtdMulheres.Text = qtdFem.ToString();
            percentMulheres.Text = ((percF.Length == 1) || (percF.Length == 2) || (percF.Length == 3)) ? percF + "%" : (percF[0] + "" + percF[1] + percF[2] + percF[3] + "%");
        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }
    }
}
