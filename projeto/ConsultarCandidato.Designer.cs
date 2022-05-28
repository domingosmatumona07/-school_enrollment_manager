
namespace projeto
{
    partial class ConsultarCandidato
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
            this.nUDnumeroInsc = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblI = new System.Windows.Forms.Label();
            this.lblS = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblNBI = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.linkVoltarAoMenuPrincipal = new System.Windows.Forms.LinkLabel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNumeroBI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Inscrição";
            // 
            // nUDnumeroInsc
            // 
            this.nUDnumeroInsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDnumeroInsc.Location = new System.Drawing.Point(342, 113);
            this.nUDnumeroInsc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDnumeroInsc.Name = "nUDnumeroInsc";
            this.nUDnumeroInsc.Size = new System.Drawing.Size(152, 34);
            this.nUDnumeroInsc.TabIndex = 1;
            this.nUDnumeroInsc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dados do Candidato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consultar Candidato";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "____________________________________________";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN.Location = new System.Drawing.Point(42, 300);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(70, 25);
            this.lblN.TabIndex = 5;
            this.lblN.Text = "Nome:";
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblI.Location = new System.Drawing.Point(41, 339);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(67, 25);
            this.lblI.TabIndex = 6;
            this.lblI.Text = "Idade:";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS.Location = new System.Drawing.Point(41, 382);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(64, 25);
            this.lblS.TabIndex = 7;
            this.lblS.Text = "Sexo:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(41, 427);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(71, 25);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Curso:";
            // 
            // lblNBI
            // 
            this.lblNBI.AutoSize = true;
            this.lblNBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNBI.Location = new System.Drawing.Point(41, 471);
            this.lblNBI.Name = "lblNBI";
            this.lblNBI.Size = new System.Drawing.Size(137, 25);
            this.lblNBI.TabIndex = 9;
            this.lblNBI.Text = "Número do BI:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(233, 162);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(118, 40);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // linkVoltarAoMenuPrincipal
            // 
            this.linkVoltarAoMenuPrincipal.AutoSize = true;
            this.linkVoltarAoMenuPrincipal.Location = new System.Drawing.Point(409, 567);
            this.linkVoltarAoMenuPrincipal.Name = "linkVoltarAoMenuPrincipal";
            this.linkVoltarAoMenuPrincipal.Size = new System.Drawing.Size(162, 17);
            this.linkVoltarAoMenuPrincipal.TabIndex = 15;
            this.linkVoltarAoMenuPrincipal.TabStop = true;
            this.linkVoltarAoMenuPrincipal.Text = "Voltar ao Menu Principal";
            this.linkVoltarAoMenuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltarAoMenuPrincipal_LinkClicked);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(193, 299);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(22, 29);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "-";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(193, 338);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(22, 29);
            this.lblIdade.TabIndex = 17;
            this.lblIdade.Text = "-";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(193, 381);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(22, 29);
            this.lblSexo.TabIndex = 18;
            this.lblSexo.Text = "-";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(193, 426);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(22, 29);
            this.lblCurso.TabIndex = 19;
            this.lblCurso.Text = "-";
            // 
            // lblNumeroBI
            // 
            this.lblNumeroBI.AutoSize = true;
            this.lblNumeroBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroBI.Location = new System.Drawing.Point(193, 470);
            this.lblNumeroBI.Name = "lblNumeroBI";
            this.lblNumeroBI.Size = new System.Drawing.Size(22, 29);
            this.lblNumeroBI.TabIndex = 20;
            this.lblNumeroBI.Text = "-";
            // 
            // ConsultarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 593);
            this.Controls.Add(this.lblNumeroBI);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.linkVoltarAoMenuPrincipal);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblNBI);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblS);
            this.Controls.Add(this.lblI);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUDnumeroInsc);
            this.Controls.Add(this.label1);
            this.Name = "ConsultarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDnumeroInsc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblNBI;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.LinkLabel linkVoltarAoMenuPrincipal;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblNumeroBI;
    }
}