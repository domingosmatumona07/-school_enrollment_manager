
namespace projeto
{
    partial class fimCadast
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
            this.btnSeeDatas = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeeDatas
            // 
            this.btnSeeDatas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeDatas.Location = new System.Drawing.Point(33, 270);
            this.btnSeeDatas.Name = "btnSeeDatas";
            this.btnSeeDatas.Size = new System.Drawing.Size(178, 53);
            this.btnSeeDatas.TabIndex = 0;
            this.btnSeeDatas.Text = "VER OS DADOS";
            this.btnSeeDatas.UseVisualStyleBackColor = true;
            this.btnSeeDatas.Click += new System.EventHandler(this.btnSeeDatas_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(252, 270);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(149, 53);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "CONTINUAR";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::projeto.Properties.Resources.clipboards__2_;
            this.pictureBox1.Location = new System.Drawing.Point(98, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 229);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // fimCadast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnSeeDatas);
            this.Name = "fimCadast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Finalizado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSeeDatas;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}