
namespace projeto
{
    partial class frmCadastrFunc
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblSalarioDiario = new System.Windows.Forms.Label();
            this.txtBName = new System.Windows.Forms.TextBox();
            this.txtBNumero = new System.Windows.Forms.TextBox();
            this.nUDIdade = new System.Windows.Forms.NumericUpDown();
            this.txtBSalario = new System.Windows.Forms.TextBox();
            this.btnCadF = new System.Windows.Forms.Button();
            this.placeHolderNome = new System.Windows.Forms.Label();
            this.placeHolderTelefone = new System.Windows.Forms.Label();
            this.placeHolderSalarioD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUDIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(86, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(65, 254);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(64, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(65, 349);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(61, 25);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(65, 438);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(89, 25);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblSalarioDiario
            // 
            this.lblSalarioDiario.AutoSize = true;
            this.lblSalarioDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioDiario.Location = new System.Drawing.Point(65, 528);
            this.lblSalarioDiario.Name = "lblSalarioDiario";
            this.lblSalarioDiario.Size = new System.Drawing.Size(125, 25);
            this.lblSalarioDiario.TabIndex = 6;
            this.lblSalarioDiario.Text = "Salário diário";
            this.lblSalarioDiario.Click += new System.EventHandler(this.lblSalarioDiario_Click);
            // 
            // txtBName
            // 
            this.txtBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBName.Location = new System.Drawing.Point(70, 282);
            this.txtBName.MaxLength = 50;
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(384, 38);
            this.txtBName.TabIndex = 7;
            this.txtBName.TextChanged += new System.EventHandler(this.txtBName_TextChanged);
            this.txtBName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBName_KeyPress);
            // 
            // txtBNumero
            // 
            this.txtBNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBNumero.Location = new System.Drawing.Point(70, 466);
            this.txtBNumero.MaxLength = 9;
            this.txtBNumero.Name = "txtBNumero";
            this.txtBNumero.Size = new System.Drawing.Size(384, 38);
            this.txtBNumero.TabIndex = 9;
            this.txtBNumero.TextChanged += new System.EventHandler(this.txtBNumero_TextChanged);
            this.txtBNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBNumero_KeyPress);
            // 
            // nUDIdade
            // 
            this.nUDIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDIdade.Location = new System.Drawing.Point(70, 377);
            this.nUDIdade.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nUDIdade.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nUDIdade.Name = "nUDIdade";
            this.nUDIdade.ReadOnly = true;
            this.nUDIdade.Size = new System.Drawing.Size(381, 38);
            this.nUDIdade.TabIndex = 8;
            this.nUDIdade.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // txtBSalario
            // 
            this.txtBSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBSalario.Location = new System.Drawing.Point(70, 556);
            this.txtBSalario.MaxLength = 5;
            this.txtBSalario.Name = "txtBSalario";
            this.txtBSalario.Size = new System.Drawing.Size(384, 38);
            this.txtBSalario.TabIndex = 10;
            this.txtBSalario.TextChanged += new System.EventHandler(this.txtBSalario_TextChanged);
            this.txtBSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBSalario_KeyPress);
            // 
            // btnCadF
            // 
            this.btnCadF.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadF.ForeColor = System.Drawing.Color.White;
            this.btnCadF.Location = new System.Drawing.Point(70, 623);
            this.btnCadF.Name = "btnCadF";
            this.btnCadF.Size = new System.Drawing.Size(384, 53);
            this.btnCadF.TabIndex = 11;
            this.btnCadF.Text = "Cadastrar-se";
            this.btnCadF.UseVisualStyleBackColor = false;
            this.btnCadF.Click += new System.EventHandler(this.btnCadF_Click);
            // 
            // placeHolderNome
            // 
            this.placeHolderNome.AutoSize = true;
            this.placeHolderNome.BackColor = System.Drawing.Color.White;
            this.placeHolderNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolderNome.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderNome.Location = new System.Drawing.Point(76, 293);
            this.placeHolderNome.Name = "placeHolderNome";
            this.placeHolderNome.Size = new System.Drawing.Size(145, 24);
            this.placeHolderNome.TabIndex = 12;
            this.placeHolderNome.Text = "Nome completo";
            this.placeHolderNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // placeHolderTelefone
            // 
            this.placeHolderTelefone.AutoSize = true;
            this.placeHolderTelefone.BackColor = System.Drawing.Color.White;
            this.placeHolderTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolderTelefone.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderTelefone.Location = new System.Drawing.Point(76, 477);
            this.placeHolderTelefone.Name = "placeHolderTelefone";
            this.placeHolderTelefone.Size = new System.Drawing.Size(236, 24);
            this.placeHolderTelefone.TabIndex = 13;
            this.placeHolderTelefone.Text = "Número de telefone (+244)";
            this.placeHolderTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // placeHolderSalarioD
            // 
            this.placeHolderSalarioD.AutoSize = true;
            this.placeHolderSalarioD.BackColor = System.Drawing.Color.White;
            this.placeHolderSalarioD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeHolderSalarioD.ForeColor = System.Drawing.Color.Gray;
            this.placeHolderSalarioD.Location = new System.Drawing.Point(76, 567);
            this.placeHolderSalarioD.Name = "placeHolderSalarioD";
            this.placeHolderSalarioD.Size = new System.Drawing.Size(172, 24);
            this.placeHolderSalarioD.TabIndex = 14;
            this.placeHolderSalarioD.Text = "Salário diário (AKZ)";
            this.placeHolderSalarioD.Click += new System.EventHandler(this.lblSalarioDiario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto.Properties.Resources.user__2_;
            this.pictureBox1.Location = new System.Drawing.Point(192, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadastrFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 706);
            this.Controls.Add(this.placeHolderSalarioD);
            this.Controls.Add(this.placeHolderTelefone);
            this.Controls.Add(this.placeHolderNome);
            this.Controls.Add(this.btnCadF);
            this.Controls.Add(this.txtBSalario);
            this.Controls.Add(this.nUDIdade);
            this.Controls.Add(this.txtBNumero);
            this.Controls.Add(this.txtBName);
            this.Controls.Add(this.lblSalarioDiario);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de Insc. Escolar - Cadastar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.nUDIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblSalarioDiario;
        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.TextBox txtBNumero;
        private System.Windows.Forms.NumericUpDown nUDIdade;
        private System.Windows.Forms.TextBox txtBSalario;
        private System.Windows.Forms.Button btnCadF;
        private System.Windows.Forms.Label placeHolderNome;
        private System.Windows.Forms.Label placeHolderTelefone;
        private System.Windows.Forms.Label placeHolderSalarioD;
    }
}