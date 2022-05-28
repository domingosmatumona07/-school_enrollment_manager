
namespace projeto
{
    partial class EliminarCandidato
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
            this.btnEliminarCandidato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nUDnumeroInsc = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.linkVoltarAoMenuPrincipal = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminarCandidato
            // 
            this.btnEliminarCandidato.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCandidato.Location = new System.Drawing.Point(252, 163);
            this.btnEliminarCandidato.Name = "btnEliminarCandidato";
            this.btnEliminarCandidato.Size = new System.Drawing.Size(118, 40);
            this.btnEliminarCandidato.TabIndex = 15;
            this.btnEliminarCandidato.Text = "Eliminar";
            this.btnEliminarCandidato.UseVisualStyleBackColor = true;
            this.btnEliminarCandidato.Click += new System.EventHandler(this.btnEliminarCandidato_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(360, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "____________________________________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 36);
            this.label3.TabIndex = 13;
            this.label3.Text = "Eliminar Candidato";
            // 
            // nUDnumeroInsc
            // 
            this.nUDnumeroInsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDnumeroInsc.Location = new System.Drawing.Point(361, 114);
            this.nUDnumeroInsc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDnumeroInsc.Name = "nUDnumeroInsc";
            this.nUDnumeroInsc.Size = new System.Drawing.Size(152, 34);
            this.nUDnumeroInsc.TabIndex = 12;
            this.nUDnumeroInsc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Número de Inscrição";
            // 
            // linkVoltarAoMenuPrincipal
            // 
            this.linkVoltarAoMenuPrincipal.AutoSize = true;
            this.linkVoltarAoMenuPrincipal.Location = new System.Drawing.Point(27, 213);
            this.linkVoltarAoMenuPrincipal.Name = "linkVoltarAoMenuPrincipal";
            this.linkVoltarAoMenuPrincipal.Size = new System.Drawing.Size(162, 17);
            this.linkVoltarAoMenuPrincipal.TabIndex = 17;
            this.linkVoltarAoMenuPrincipal.TabStop = true;
            this.linkVoltarAoMenuPrincipal.Text = "Voltar ao Menu Principal";
            this.linkVoltarAoMenuPrincipal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkVoltarAoMenuPrincipal_LinkClicked);
            // 
            // EliminarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 239);
            this.Controls.Add(this.linkVoltarAoMenuPrincipal);
            this.Controls.Add(this.btnEliminarCandidato);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nUDnumeroInsc);
            this.Controls.Add(this.label1);
            this.Name = "EliminarCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.nUDnumeroInsc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarCandidato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDnumeroInsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkVoltarAoMenuPrincipal;
    }
}