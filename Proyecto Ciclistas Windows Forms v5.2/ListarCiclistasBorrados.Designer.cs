namespace WindowsFormsApp1
{
    partial class FormListarCiclistasBorrados
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
            this.Titulo = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCiclistas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistas)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(181, -49);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(561, 18);
            this.Titulo.TabIndex = 10;
            this.Titulo.Text = "APLICACIÓN DE REGISTRO DE CICLISTAS - LISTA DE PARTICIPANTES";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(21, 18);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(100, 23);
            this.buttonVolver.TabIndex = 13;
            this.buttonVolver.Text = "Atrás";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "LISTADO DE BAJAS";
            // 
            // dgvCiclistas
            // 
            this.dgvCiclistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCiclistas.Location = new System.Drawing.Point(21, 58);
            this.dgvCiclistas.Name = "dgvCiclistas";
            this.dgvCiclistas.Size = new System.Drawing.Size(632, 510);
            this.dgvCiclistas.TabIndex = 11;
            // 
            // FormListarCiclistasBorrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bike_punks_1024x683;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCiclistas);
            this.Controls.Add(this.Titulo);
            this.Name = "FormListarCiclistasBorrados";
            this.Text = "APP DE REGISTRO DE CICLISTAS - LISTADO DE BAJAS ";
            this.Load += new System.EventHandler(this.ListarCiclistasBorrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCiclistas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCiclistas;
    }
}