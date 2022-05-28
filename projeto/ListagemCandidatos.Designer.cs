
namespace projeto
{
    partial class ListagemCandidatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkVoltarAoMenuPrincipal = new System.Windows.Forms.LinkLabel();
            this.dtgvListaCandidatos = new System.Windows.Forms.DataGridView();
            this.Nomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerosBI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerosInscricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listagem de Candidatos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "____________________________________________";
            // 
            // linkVoltarAoMenuPrincipal
            // 
            this.linkVoltarAoMenuPrincipal.AutoSize = true;
            this.linkVoltarAoMenuPrincipal.Location = new System.Drawing.Point(21, 512);
            this.linkVoltarAoMenuPrincipal.Name = "linkVoltarAoMenuPrincipal";
            this.linkVoltarAoMenuPrincipal.Size = new System.Drawing.Size(162, 17);
            this.linkVoltarAoMenuPrincipal.TabIndex = 16;
            this.linkVoltarAoMenuPrincipal.TabStop = true;
            this.linkVoltarAoMenuPrincipal.Text = "Voltar ao Menu Principal";
            this.linkVoltarAoMenuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltarAoMenuPrincipal_LinkClicked);
            // 
            // dtgvListaCandidatos
            // 
            this.dtgvListaCandidatos.AllowUserToAddRows = false;
            this.dtgvListaCandidatos.AllowUserToOrderColumns = true;
            this.dtgvListaCandidatos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgvListaCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListaCandidatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nomes,
            this.Sexos,
            this.Idades,
            this.NumerosBI,
            this.Cursos,
            this.NumerosInscricao});
            this.dtgvListaCandidatos.Location = new System.Drawing.Point(2, 120);
            this.dtgvListaCandidatos.Name = "dtgvListaCandidatos";
            this.dtgvListaCandidatos.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvListaCandidatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvListaCandidatos.RowHeadersWidth = 51;
            this.dtgvListaCandidatos.RowTemplate.Height = 24;
            this.dtgvListaCandidatos.Size = new System.Drawing.Size(1347, 375);
            this.dtgvListaCandidatos.TabIndex = 17;
            // 
            // Nomes
            // 
            this.Nomes.HeaderText = "Nome";
            this.Nomes.MinimumWidth = 6;
            this.Nomes.Name = "Nomes";
            this.Nomes.ReadOnly = true;
            this.Nomes.Width = 267;
            // 
            // Sexos
            // 
            this.Sexos.HeaderText = "Sexo";
            this.Sexos.MinimumWidth = 6;
            this.Sexos.Name = "Sexos";
            this.Sexos.ReadOnly = true;
            this.Sexos.Width = 70;
            // 
            // Idades
            // 
            this.Idades.HeaderText = "Idade";
            this.Idades.MinimumWidth = 6;
            this.Idades.Name = "Idades";
            this.Idades.ReadOnly = true;
            this.Idades.Width = 70;
            // 
            // NumerosBI
            // 
            this.NumerosBI.HeaderText = "Número do BI";
            this.NumerosBI.MinimumWidth = 6;
            this.NumerosBI.Name = "NumerosBI";
            this.NumerosBI.ReadOnly = true;
            this.NumerosBI.Width = 175;
            // 
            // Cursos
            // 
            this.Cursos.HeaderText = "Curso";
            this.Cursos.MinimumWidth = 6;
            this.Cursos.Name = "Cursos";
            this.Cursos.ReadOnly = true;
            this.Cursos.Width = 287;
            // 
            // NumerosInscricao
            // 
            this.NumerosInscricao.HeaderText = "Nº de Inscrição";
            this.NumerosInscricao.MinimumWidth = 6;
            this.NumerosInscricao.Name = "NumerosInscricao";
            this.NumerosInscricao.ReadOnly = true;
            this.NumerosInscricao.Width = 88;
            // 
            // ListagemCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 538);
            this.Controls.Add(this.dtgvListaCandidatos);
            this.Controls.Add(this.linkVoltarAoMenuPrincipal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "ListagemCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listagem de Candidatos";
            this.Load += new System.EventHandler(this.ListagemCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListaCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkVoltarAoMenuPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idades;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerosBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerosInscricao;
        private System.Windows.Forms.DataGridView dtgvListaCandidatos;
    }
}