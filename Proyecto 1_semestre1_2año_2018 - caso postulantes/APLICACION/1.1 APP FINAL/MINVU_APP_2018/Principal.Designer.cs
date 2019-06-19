namespace MINVU_APP_2018
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEjecucionProceso = new System.Windows.Forms.Button();
            this.btnConsultaPostulante = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(238, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 84);
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 277);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(740, 38);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // btnEjecucionProceso
            // 
            this.btnEjecucionProceso.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecucionProceso.Image")));
            this.btnEjecucionProceso.Location = new System.Drawing.Point(122, 158);
            this.btnEjecucionProceso.Name = "btnEjecucionProceso";
            this.btnEjecucionProceso.Size = new System.Drawing.Size(238, 82);
            this.btnEjecucionProceso.TabIndex = 58;
            this.btnEjecucionProceso.UseVisualStyleBackColor = true;
            this.btnEjecucionProceso.Click += new System.EventHandler(this.btnEjecucionProceso_Click);
            // 
            // btnConsultaPostulante
            // 
            this.btnConsultaPostulante.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultaPostulante.Image")));
            this.btnConsultaPostulante.Location = new System.Drawing.Point(385, 158);
            this.btnConsultaPostulante.Name = "btnConsultaPostulante";
            this.btnConsultaPostulante.Size = new System.Drawing.Size(236, 82);
            this.btnConsultaPostulante.TabIndex = 60;
            this.btnConsultaPostulante.UseVisualStyleBackColor = true;
            this.btnConsultaPostulante.Click += new System.EventHandler(this.btnConsultaPostulante_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(248, 103);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(225, 32);
            this.label39.TabIndex = 62;
            this.label39.Text = "MENU PRINCIPAL";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(738, 315);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.btnConsultaPostulante);
            this.Controls.Add(this.btnEjecucionProceso);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Principal";
            this.Text = "Principal";
            
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEjecucionProceso;
        private System.Windows.Forms.Button btnConsultaPostulante;
        private System.Windows.Forms.Label label39;
    }
}