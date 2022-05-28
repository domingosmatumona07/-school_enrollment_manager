
namespace projeto
{
    partial class EliminarSimNao
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
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNão = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSim
            // 
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSim.Location = new System.Drawing.Point(147, 105);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(148, 55);
            this.btnSim.TabIndex = 0;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNão
            // 
            this.btnNão.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNão.Location = new System.Drawing.Point(361, 105);
            this.btnNão.Name = "btnNão";
            this.btnNão.Size = new System.Drawing.Size(146, 55);
            this.btnNão.TabIndex = 1;
            this.btnNão.Text = "Não";
            this.btnNão.UseVisualStyleBackColor = true;
            this.btnNão.Click += new System.EventHandler(this.btnNão_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tens certeza que desejas eliminar o candidato?";
            // 
            // EliminarSimNao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 173);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNão);
            this.Controls.Add(this.btnSim);
            this.Name = "EliminarSimNao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminarSimNao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNão;
        private System.Windows.Forms.Label label1;
    }
}