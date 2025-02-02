namespace WindowsFormsApp1
{
    partial class FormCompeticiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompeticiones));
            this.Titulo = new System.Windows.Forms.Label();
            this.cbCompeticiones = new System.Windows.Forms.ComboBox();
            this.btnEliminarCompeticion = new System.Windows.Forms.Button();
            this.btnModificarCompeticion = new System.Windows.Forms.Button();
            this.btnNuevaCompeticion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBuscarCompeticion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Transparent;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Titulo.Location = new System.Drawing.Point(24, 21);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(200, 18);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "MENÚ COMPETICIONES";
            // 
            // cbCompeticiones
            // 
            this.cbCompeticiones.FormattingEnabled = true;
            this.cbCompeticiones.Location = new System.Drawing.Point(27, 92);
            this.cbCompeticiones.Name = "cbCompeticiones";
            this.cbCompeticiones.Size = new System.Drawing.Size(345, 21);
            this.cbCompeticiones.TabIndex = 5;
            // 
            // btnEliminarCompeticion
            // 
            this.btnEliminarCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCompeticion.Location = new System.Drawing.Point(27, 230);
            this.btnEliminarCompeticion.Name = "btnEliminarCompeticion";
            this.btnEliminarCompeticion.Size = new System.Drawing.Size(221, 33);
            this.btnEliminarCompeticion.TabIndex = 8;
            this.btnEliminarCompeticion.Text = "Eliminar competición";
            this.btnEliminarCompeticion.UseVisualStyleBackColor = true;
            this.btnEliminarCompeticion.Click += new System.EventHandler(this.btnEliminarCompeticion_Click);
            // 
            // btnModificarCompeticion
            // 
            this.btnModificarCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCompeticion.Location = new System.Drawing.Point(27, 181);
            this.btnModificarCompeticion.Name = "btnModificarCompeticion";
            this.btnModificarCompeticion.Size = new System.Drawing.Size(221, 33);
            this.btnModificarCompeticion.TabIndex = 7;
            this.btnModificarCompeticion.Text = "Modificar competición";
            this.btnModificarCompeticion.UseVisualStyleBackColor = true;
            this.btnModificarCompeticion.Click += new System.EventHandler(this.btnModificarCompeticion_Click);
            // 
            // btnNuevaCompeticion
            // 
            this.btnNuevaCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaCompeticion.Location = new System.Drawing.Point(27, 325);
            this.btnNuevaCompeticion.Name = "btnNuevaCompeticion";
            this.btnNuevaCompeticion.Size = new System.Drawing.Size(221, 33);
            this.btnNuevaCompeticion.TabIndex = 6;
            this.btnNuevaCompeticion.Text = "Crear una nueva competición";
            this.btnNuevaCompeticion.UseVisualStyleBackColor = true;
            this.btnNuevaCompeticion.Click += new System.EventHandler(this.btnNuevaCompeticion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecciona una competición para gestionar los ciclistas:";
            // 
            // buttonBuscarCompeticion
            // 
            this.buttonBuscarCompeticion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCompeticion.Location = new System.Drawing.Point(27, 127);
            this.buttonBuscarCompeticion.Name = "buttonBuscarCompeticion";
            this.buttonBuscarCompeticion.Size = new System.Drawing.Size(221, 36);
            this.buttonBuscarCompeticion.TabIndex = 10;
            this.buttonBuscarCompeticion.Text = "Gestionar competición";
            this.buttonBuscarCompeticion.UseVisualStyleBackColor = true;
            this.buttonBuscarCompeticion.Click += new System.EventHandler(this.buttonBuscarCompeticion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(24, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "¿Quieres crear una nueva competición?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cerrar sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormCompeticiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBuscarCompeticion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminarCompeticion);
            this.Controls.Add(this.btnModificarCompeticion);
            this.Controls.Add(this.btnNuevaCompeticion);
            this.Controls.Add(this.cbCompeticiones);
            this.Controls.Add(this.Titulo);
            this.Name = "FormCompeticiones";
            this.Text = "APP DE REGISTRO DE CICLISTAS - MENÚ PRNCIPAL";
            this.Load += new System.EventHandler(this.FormCompeticiones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.ComboBox cbCompeticiones;
        private System.Windows.Forms.Button btnEliminarCompeticion;
        private System.Windows.Forms.Button btnModificarCompeticion;
        private System.Windows.Forms.Button btnNuevaCompeticion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBuscarCompeticion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}