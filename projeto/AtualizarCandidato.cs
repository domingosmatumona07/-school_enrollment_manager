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
    public partial class AtualizarCandidato : Form
    {
        bool clickedSearchButton = false;
        int numeroInscricao;
        public AtualizarCandidato()
        {
            InitializeComponent();
        }

        private void AtualizarCandidato_Load(object sender, EventArgs e)
        {
            cmbCurso.SelectedIndex = 0;
        }

        private void btnPesquisarCandidato_Click(object sender, EventArgs e)
        {
            numeroInscricao = (int)nUDnumeroInsc.Value;
            clickedSearchButton = true;

            if (Candidatos.inscritionNumbers.Contains(numeroInscricao)) {
                txtBNome.Text = (Candidatos.names[numeroInscricao - 1]).ToString();
                cmbCurso.SelectedItem = (Candidatos.courses[numeroInscricao - 1]);

                if((char)Candidatos.sexs[numeroInscricao-1] == 'M') {
                    rdBMasc.Select();
                } else {
                    rdBFem.Select();
                }
                numUpIdade.Value = (int)(Candidatos.ages[numeroInscricao - 1]);
            } else {
                MessageBox.Show("Número de Inscrição Inválido!", "Candidato Inexistente");
            }
        }

        private void btnAtualizarCandidato_Click(object sender, EventArgs e)
        {
            if (Candidatos.posicoesCandidatosEliminados.Contains((int)nUDnumeroInsc.Value-1)) {
                MessageBox.Show("Este candidato foi eliminado do sistema!", "Candidato Inexistente");
            } else if(clickedSearchButton) {
                if ((txtBNome.Text != "") && ((cmbCurso.SelectedIndex != 0) && (cmbCurso.SelectedItem != null))) {
                    char sexo = (rdBFem.Checked) ? 'F' : 'M';

                    AtualizarDadosCandidato updateCandidateDatas = new AtualizarDadosCandidato(txtBNome.Text, cmbCurso.SelectedItem.ToString(), sexo, (int)numUpIdade.Value, numeroInscricao - 1);
                    updateCandidateDatas.updateName();
                    updateCandidateDatas.updateSex();
                    updateCandidateDatas.updateAge();
                    updateCandidateDatas.updateCourse();

                    MessageBox.Show("Dados Atualizados com Sucesso!", "Atualização de Candidato");
                    clickedSearchButton = false;
                    limpaCampos();
                } else {
                    MessageBox.Show("Não pode haver campos vazios!", "Dados Insuficientes");
                }
            } else {
                MessageBox.Show("Primeiro pesquise o candidato, e depois preencha os dados a alterar!", "Dados Insuficientes");
                clickedSearchButton = false;
            }
        }

        private void linkVoltarAoMenuPrincipal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void limpaCampos() {
            txtBNome.Clear();
            rdBMasc.Checked = false;
            rdBFem.Checked = false;
            numUpIdade.Value = 12;
            cmbCurso.SelectedIndex = 0;
        }

        private void nUDnumeroInsc_ValueChanged(object sender, EventArgs e)
        {
            clickedSearchButton = false;
        }
    }
}