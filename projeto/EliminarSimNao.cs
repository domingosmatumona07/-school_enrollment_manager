using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto
{
    public partial class EliminarSimNao : Form
    {
        private int numInsc;

        public EliminarSimNao()
        {
            InitializeComponent();
        }

        public EliminarSimNao(int inscN)
        {
            InitializeComponent();
            this.numInsc = inscN;
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            Candidatos.names[numInsc] = "";
            Candidatos.sexs[numInsc] = ' ';
            Candidatos.ages[numInsc] = 0;
            Candidatos.biNumbers[numInsc] = "";
            Candidatos.courses[numInsc] = "";
            Candidatos.posicoesCandidatosEliminados.Add(numInsc);
            Candidatos.inscritionNumbers[numInsc] = "";

            if (Candidatos.sexs[numInsc].ToString() == "M") {
                Candidatos.qtdMascEliminados++;
            } else {
                Candidatos.qtdFemEliminados++;
            }
            MessageBox.Show("Candidato Eliminado!", "Sucesso na Eliminação");
            this.Close();
        }

        private void btnNão_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
