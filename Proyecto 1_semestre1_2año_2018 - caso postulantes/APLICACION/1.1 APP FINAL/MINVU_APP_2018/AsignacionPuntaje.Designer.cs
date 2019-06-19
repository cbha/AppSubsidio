namespace MINVU_APP_2018
{
    partial class AsignacionPuntaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsignacionPuntaje));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.dgAsignacionPuntaje = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEjecutarProceso = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignacionPuntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(500, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(237, 84);
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(126, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(316, 13);
            this.label41.TabIndex = 54;
            this.label41.Text = "SISTEMA INTEGRADO DE SUBSIDIO HABITACIONAL";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(143, 9);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(288, 13);
            this.label40.TabIndex = 53;
            this.label40.Text = "INFORMACION GENERAL DEL POSTULANTE AL";
            // 
            // dgAsignacionPuntaje
            // 
            this.dgAsignacionPuntaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAsignacionPuntaje.Location = new System.Drawing.Point(24, 108);
            this.dgAsignacionPuntaje.Name = "dgAsignacionPuntaje";
            this.dgAsignacionPuntaje.Size = new System.Drawing.Size(713, 243);
            this.dgAsignacionPuntaje.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "PROCESO ASIGNACIÓN DE PUNTAJE";
            // 
            // btnEjecutarProceso
            // 
            this.btnEjecutarProceso.Location = new System.Drawing.Point(129, 73);
            this.btnEjecutarProceso.Name = "btnEjecutarProceso";
            this.btnEjecutarProceso.Size = new System.Drawing.Size(103, 29);
            this.btnEjecutarProceso.TabIndex = 59;
            this.btnEjecutarProceso.Text = "Ejecutar Proceso";
            this.btnEjecutarProceso.UseVisualStyleBackColor = true;
            this.btnEjecutarProceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(383, 73);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 29);
            this.btnVolver.TabIndex = 60;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // AsignacionPuntaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(749, 363);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEjecutarProceso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgAsignacionPuntaje);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Name = "AsignacionPuntaje";
            this.Text = "AsignacionPuntaje";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAsignacionPuntaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DataGridView dgAsignacionPuntaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEjecutarProceso;
        private System.Windows.Forms.Button btnVolver;
    }
}