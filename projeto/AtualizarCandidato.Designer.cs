
namespace projeto
{
    partial class AtualizarCandidato
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDnumeroInsc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numUpIdade = new System.Windows.Forms.NumericUpDown();
            this.rdBFem = new System.Windows.Forms.RadioButton();
            this.rdBMasc = new System.Windows.Forms.RadioButton();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAtualizarCandidato = new System.Windows.Forms.Button();
            this.linkVoltarAoMenuPrincipal = new System.Windows.Forms.LinkLabel();
            this.btnPesquisarCandidato = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "____________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(180, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Atualizar Candidato";
            // 
            // nUDnumeroInsc
            // 
            this.nUDnumeroInsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDnumeroInsc.Location = new System.Drawing.Point(314, 123);
            this.nUDnumeroInsc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDnumeroInsc.Name = "nUDnumeroInsc";
            this.nUDnumeroInsc.Size = new System.Drawing.Size(152, 34);
            this.nUDnumeroInsc.TabIndex = 16;
            this.nUDnumeroInsc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDnumeroInsc.ValueChanged += new System.EventHandler(this.nUDnumeroInsc_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Número de Inscrição";
            // 
            // numUpIdade
            // 
            this.numUpIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpIdade.Location = new System.Drawing.Point(157, 426);
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
            this.numUpIdade.TabIndex = 28;
            this.numUpIdade.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // rdBFem
            // 
            this.rdBFem.AutoSize = true;
            this.rdBFem.Location = new System.Drawing.Point(137, 382);
            this.rdBFem.Name = "rdBFem";
            this.rdBFem.Size = new System.Drawing.Size(86, 21);
            this.rdBFem.TabIndex = 27;
            this.rdBFem.Text = "Feminino";
            this.rdBFem.UseVisualStyleBackColor = true;
            // 
            // rdBMasc
            // 
            this.rdBMasc.AutoSize = true;
            this.rdBMasc.Location = new System.Drawing.Point(137, 354);
            this.rdBMasc.Name = "rdBMasc";
            this.rdBMasc.Size = new System.Drawing.Size(92, 21);
            this.rdBMasc.TabIndex = 26;
            this.rdBMasc.Text = "Masculino";
            this.rdBMasc.UseVisualStyleBackColor = true;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "",
            "Técnico de Informática",
            "Técnico de Gest. de Sist. Informáticos",
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
            this.cmbCurso.Location = new System.Drawing.Point(157, 262);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(402, 37);
            this.cmbCurso.TabIndex = 25;
            // 
            // txtBNome
            // 
            this.txtBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNome.Location = new System.Drawing.Point(157, 194);
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(402, 36);
            this.txtBNome.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(86, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sexo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Curso";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nome";
            // 
            // btnAtualizarCandidato
            // 
            this.btnAtualizarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarCandidato.Location = new System.Drawing.Point(192, 493);
            this.btnAtualizarCandidato.Name = "btnAtualizarCandidato";
            this.btnAtualizarCandidato.Size = new System.Drawing.Size(274, 45);
            this.btnAtualizarCandidato.TabIndex = 30;
            this.btnAtualizarCandidato.Text = "Atualizar";
            this.btnAtualizarCandidato.UseVisualStyleBackColor = true;
            this.btnAtualizarCandidato.Click += new System.EventHandler(this.btnAtualizarCandidato_Click);
            // 
            // linkVoltarAoMenuPrincipal
            // 
            this.linkVoltarAoMenuPrincipal.AutoSize = true;
            this.linkVoltarAoMenuPrincipal.Location = new System.Drawing.Point(12, 600);
            this.linkVoltarAoMenuPrincipal.Name = "linkVoltarAoMenuPrincipal";
            this.linkVoltarAoMenuPrincipal.Size = new System.Drawing.Size(162, 17);
            this.linkVoltarAoMenuPrincipal.TabIndex = 31;
            this.linkVoltarAoMenuPrincipal.TabStop = true;
            this.linkVoltarAoMenuPrincipal.Text = "Voltar ao Menu Principal";
            this.linkVoltarAoMenuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltarAoMenuPrincipal_LinkClicked);
            // 
            // btnPesquisarCandidato
            // 
            this.btnPesquisarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPesquisarCandidato.Location = new System.Drawing.Point(485, 123);
            this.btnPesquisarCandidato.Name = "btnPesquisarCandidato";
            this.btnPesquisarCandidato.Size = new System.Drawing.Size(105, 34);
            this.btnPesquisarCandidato.TabIndex = 32;
            this.btnPesquisarCandidato.Text = "Pesquisar";
            this.btnPesquisarCandidato.UseVisualStyleBackColor = true;
            this.btnPesquisarCandidato.Click += new System.EventHandler(this.btnPesquisarCandidato_Click);
            // 
            // AtualizarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 621);
            this.Controls.Add(this.btnPesquisarCandidato);
            this.Controls.Add(this.linkVoltarAoMenuPrincipal);
            this.Controls.Add(this.btnAtualizarCandidato);
            this.Controls.Add(this.numUpIdade);
            this.Controls.Add(this.rdBFem);
            this.Controls.Add(this.rdBMasc);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.txtBNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDnumeroInsc);
            this.Controls.Add(this.label1);
            this.Name = "AtualizarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtualizarCandidato";
            this.Load += new System.EventHandler(this.AtualizarCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDnumeroInsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUpIdade;
        private System.Windows.Forms.RadioButton rdBFem;
        private System.Windows.Forms.RadioButton rdBMasc;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAtualizarCandidato;
        private System.Windows.Forms.LinkLabel linkVoltarAoMenuPrincipal;
        private System.Windows.Forms.Button btnPesquisarCandidato;
    }
}