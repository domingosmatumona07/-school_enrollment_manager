using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projeto
{
    public partial class ConfirmarEliminar : Form
    {
        private string nome, curso, biNumber;
        private int idade, inscNum;
        private char sexo;

        public ConfirmarEliminar()
        {
            InitializeComponent();
        }

        public ConfirmarEliminar(string name, string course, char sex, int age, string biNumber, int inscNum)
        {
            InitializeComponent();
            this.nome = name;
            this.curso = course;
            this.idade = age;
            this.sexo = sex;
            this.biNumber = biNumber;
            this.inscNum = inscNum;

            Thread.Sleep(200);
            EliminarSimNao elimin = new EliminarSimNao(inscNum);
            elimin.FormClosed += (s, args) => this.Close();
            elimin.Show();
        }

        private void ConfirmarEliminar_Load(object sender, EventArgs e)
        {
            txtBNome.Text = nome;
            txtBNumeroBI.Text = biNumber;
            numUpIdade.Value = idade;
            cmbCurso.SelectedItem = curso;

            if (sexo == 'F') rdBFem.Select();
        }
    }
}
