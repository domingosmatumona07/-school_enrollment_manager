using System.Windows.Forms;

namespace projeto
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnEscreverCandidatos_Click(object sender, System.EventArgs e)
        {
            EscreverCandidatos escreverCdt = new EscreverCandidatos();
            escreverCdt.Show();
        }
        
        private void btnConsultarCandidato_Click(object sender, System.EventArgs e)
        {
            if((aindaNaoHouveCadastro()) || (Candidatos.names.Count == Candidatos.posicoesCandidatosEliminados.Count)) {
                semCandidatosCadastrados();
            } else {
                ConsultarCandidato consultar = new ConsultarCandidato();
                consultar.Show();
            }
        }

        private void btnListarCandidatos_Click(object sender, System.EventArgs e)
        {
            if ((aindaNaoHouveCadastro()) || (Candidatos.names.Count == Candidatos.posicoesCandidatosEliminados.Count)) {
                semCandidatosCadastrados();
            } else {
                ListagemCandidatos listar = new ListagemCandidatos();
                listar.Show();
            }
        }

        private void btnEliminarCandidato_Click(object sender, System.EventArgs e)
        {
            if ((aindaNaoHouveCadastro()) || (Candidatos.names.Count == Candidatos.posicoesCandidatosEliminados.Count)) {
                semCandidatosCadastrados();
            } else {
                EliminarCandidato eliminarCdt = new EliminarCandidato();
                eliminarCdt.Show();
            }
        }

        private void btnAtualizarCandidato_Click(object sender, System.EventArgs e)
        {
            if ((aindaNaoHouveCadastro()) || (Candidatos.names.Count == Candidatos.posicoesCandidatosEliminados.Count)) {
                semCandidatosCadastrados();
            } else {
                AtualizarCandidato atualizarCdt = new AtualizarCandidato();
                atualizarCdt.Show();
            }
        }

        private void btnEstatistica_Click(object sender, System.EventArgs e)
        {
            if ((aindaNaoHouveCadastro()) || (Candidatos.names.Count == Candidatos.posicoesCandidatosEliminados.Count)) {
                semCandidatosCadastrados();
            } else {
                Estatística estatistica = new Estatística();
                estatistica.Show();
            }
        }

        private void btnIntegrantesGrupo_Click(object sender, System.EventArgs e)
        {
            IntegrantesGrupo integrantesGrp = new IntegrantesGrupo();
            integrantesGrp.Show();
        }

        private bool aindaNaoHouveCadastro() {
            return (Candidatos.names.Count == 0) ? true : false;
        }

        private void semCandidatosCadastrados() {
            MessageBox.Show("Não há candidatos cadastrados no sistema!", "Sem Candidatos Cadastrados");
        } 
    }
}
