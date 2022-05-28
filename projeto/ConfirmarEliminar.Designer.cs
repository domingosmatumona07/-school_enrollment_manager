
namespace projeto
{
    partial class ConfirmarEliminar
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
            this.txtBNumeroBI = new System.Windows.Forms.TextBox();
            this.numUpIdade = new System.Windows.Forms.NumericUpDown();
            this.rdBFem = new System.Windows.Forms.RadioButton();
            this.rdBMasc = new System.Windows.Forms.RadioButton();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtBNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBNumeroBI
            // 
            this.txtBNumeroBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNumeroBI.Location = new System.Drawing.Point(52, 482);
            this.txtBNumeroBI.Name = "txtBNumeroBI";
            this.txtBNumeroBI.Size = new System.Drawing.Size(402, 36);
            this.txtBNumeroBI.TabIndex = 23;
            // 
            // numUpIdade
            // 
            this.numUpIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpIdade.Location = new System.Drawing.Point(52, 390);
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
            this.numUpIdade.TabIndex = 22;
            this.numUpIdade.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // rdBFem
            // 
            this.rdBFem.AutoSize = true;
            this.rdBFem.Location = new System.Drawing.Point(98, 312);
            this.rdBFem.Name = "rdBFem";
            this.rdBFem.Size = new System.Drawing.Size(86, 21);
            this.rdBFem.TabIndex = 21;
            this.rdBFem.Text = "Feminino";
            this.rdBFem.UseVisualStyleBackColor = true;
            // 
            // rdBMasc
            // 
            this.rdBMasc.AutoSize = true;
            this.rdBMasc.Checked = true;
            this.rdBMasc.Location = new System.Drawing.Point(98, 284);
            this.rdBMasc.Name = "rdBMasc";
            this.rdBMasc.Size = new System.Drawing.Size(92, 21);
            this.rdBMasc.TabIndex = 20;
            this.rdBMasc.TabStop = true;
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
            this.cmbCurso.Location = new System.Drawing.Point(52, 191);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(402, 37);
            this.cmbCurso.TabIndex = 19;
            // 
            // txtBNome
            // 
            this.txtBNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNome.Location = new System.Drawing.Point(52, 103);
            this.txtBNome.Name = "txtBNome";
            this.txtBNome.Size = new System.Drawing.Size(402, 36);
            this.txtBNome.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 454);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Número do BI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, -33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 24;
            this.label1.Text = "Eliminar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConfirmarEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 567);
            this.Controls.Add(this.label1);
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
            this.Name = "ConfirmarEliminar";
            this.Text = "ConfirmarEliminar";
            this.Load += new System.EventHandler(this.ConfirmarEliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBNumeroBI;
        private System.Windows.Forms.NumericUpDown numUpIdade;
        private System.Windows.Forms.RadioButton rdBFem;
        private System.Windows.Forms.RadioButton rdBMasc;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.TextBox txtBNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}