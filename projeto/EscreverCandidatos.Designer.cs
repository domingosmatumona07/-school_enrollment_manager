
namespace projeto
{
    partial class EscreverCandidatos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.rdBMasc = new System.Windows.Forms.RadioButton();
            this.rdBFem = new System.Windows.Forms.RadioButton();
            this.numUpIdade = new System.Windows.Forms.NumericUpDown();
            this.txtBNumeroBI = new System.Windows.Forms.TextBox();
            this.btnCadastrarCandidato = new System.Windows.Forms.Button();
            this.linkVoltarAoMenuPrincipal = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscrever Candidato";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Curso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Idade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Número do BI";
            // 
            // txtBNome
            // 
            this.txtBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNome.Location = new System.Drawing.Point(74, 152);
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(402, 36);
            this.txtBNome.TabIndex = 6;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "",
            "Técnico de Informática",
            "Téc. Gest. de Sist. Informáticos",
            "Técnico de Obras",
            "Desenhador Projectista",
            "Técnico de Energia e Inst. Eléctricas",
            "Técnico de Electricidade",
            "Química Industrial",
            "Bioquímica",
            "Petroquímica",
            "Técnico de  Mecatrónica",
            "Técnico de Metalomecânica",
            "Técnico de Máquinas e Motores"});
            this.cmbCurso.Location = new System.Drawing.Point(74, 240);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(402, 37);
            this.cmbCurso.TabIndex = 7;
            // 
            // rdBMasc
            // 
            this.rdBMasc.AutoSize = true;
            this.rdBMasc.Checked = true;
            this.rdBMasc.Location = new System.Drawing.Point(120, 333);
            this.rdBMasc.Name = "rdBMasc";
            this.rdBMasc.Size = new System.Drawing.Size(92, 21);
            this.rdBMasc.TabIndex = 8;
            this.rdBMasc.TabStop = true;
            this.rdBMasc.Text = "Masculino";
            this.rdBMasc.UseVisualStyleBackColor = true;
            // 
            // rdBFem
            // 
            this.rdBFem.AutoSize = true;
            this.rdBFem.Location = new System.Drawing.Point(120, 361);
            this.rdBFem.Name = "rdBFem";
            this.rdBFem.Size = new System.Drawing.Size(86, 21);
            this.rdBFem.TabIndex = 9;
            this.rdBFem.Text = "Feminino";
            this.rdBFem.UseVisualStyleBackColor = true;
            // 
            // numUpIdade
            // 
            this.numUpIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpIdade.Location = new System.Drawing.Point(74, 439);
            this.numUpIdade.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUpIdade.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpIdade.Name = "numUpIdade";
            this.numUpIdade.ReadOnly = true;
            this.numUpIdade.Size = new System.Drawing.Size(402, 36);
            this.numUpIdade.TabIndex = 10;
            this.numUpIdade.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txtBNumeroBI
            // 
            this.txtBNumeroBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNumeroBI.Location = new System.Drawing.Point(74, 531);
            this.txtBNumeroBI.Name = "txtBNumeroBI";
            this.txtBNumeroBI.Size = new System.Drawing.Size(402, 36);
            this.txtBNumeroBI.TabIndex = 11;
            // 
            // btnCadastrarCandidato
            // 
            this.btnCadastrarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCandidato.Location = new System.Drawing.Point(74, 596);
            this.btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            this.btnCadastrarCandidato.Size = new System.Drawing.Size(402, 45);
            this.btnCadastrarCandidato.TabIndex = 12;
            this.btnCadastrarCandidato.Text = "Cadastrar";
            this.btnCadastrarCandidato.UseVisualStyleBackColor = true;
            this.btnCadastrarCandidato.Click += new System.EventHandler(this.btnCadastrarCandidato_Click);
            // 
            // linkVoltarAoMenuPrincipal
            // 
            this.linkVoltarAoMenuPrincipal.AutoSize = true;
            this.linkVoltarAoMenuPrincipal.Location = new System.Drawing.Point(25, 669);
            this.linkVoltarAoMenuPrincipal.Name = "linkVoltarAoMenuPrincipal";
            this.linkVoltarAoMenuPrincipal.Size = new System.Drawing.Size(162, 17);
            this.linkVoltarAoMenuPrincipal.TabIndex = 14;
            this.linkVoltarAoMenuPrincipal.TabStop = true;
            this.linkVoltarAoMenuPrincipal.Text = "Voltar ao Menu Principal";
            this.linkVoltarAoMenuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltarAoMenuPrincipal_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(360, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "____________________________________________";
            // 
            // EscreverCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 695);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkVoltarAoMenuPrincipal);
            this.Controls.Add(this.btnCadastrarCandidato);
            this.Controls.Add(this.txtBNumeroBI);
            this.Controls.Add(this.numUpIdade);
            this.Controls.Add(this.rdBFem);
            this.Controls.Add(this.rdBMasc);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.txtBNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EscreverCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrever Candidatos";
            this.Load += new System.EventHandler(this.EscreverCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.RadioButton rdBMasc;
        private System.Windows.Forms.RadioButton rdBFem;
        private System.Windows.Forms.NumericUpDown numUpIdade;
        private System.Windows.Forms.TextBox txtBNumeroBI;
        private System.Windows.Forms.Button btnCadastrarCandidato;
        private System.Windows.Forms.LinkLabel linkVoltarAoMenuPrincipal;
        private System.Windows.Forms.Label label7;
    }
}