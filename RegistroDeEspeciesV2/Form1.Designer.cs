namespace RegistroDeEspeciesV2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.Ejemplarestxt = new System.Windows.Forms.TextBox();
            this.ListaEspeciesdg = new System.Windows.Forms.DataGridView();
            this.Estadotxt = new System.Windows.Forms.ComboBox();
            this.Ejemplareslbl = new System.Windows.Forms.Label();
            this.Conservacionlbl = new System.Windows.Forms.Label();
            this.Nombrelbl = new System.Windows.Forms.Label();
            this.IDlbl = new System.Windows.Forms.Label();
            this.Registrarbtn = new System.Windows.Forms.Button();
            this.Buscarbtn = new System.Windows.Forms.Button();
            this.Actualizarbtn = new System.Windows.Forms.Button();
            this.Limpiarbtn = new System.Windows.Forms.Button();
            this.REAlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListaEspeciesdg)).BeginInit();
            this.SuspendLayout();
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(12, 78);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(97, 20);
            this.IDtxt.TabIndex = 0;
            this.IDtxt.TextChanged += new System.EventHandler(this.IDtxt_TextChanged);
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(145, 78);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(238, 20);
            this.Nombretxt.TabIndex = 1;
            // 
            // Ejemplarestxt
            // 
            this.Ejemplarestxt.Location = new System.Drawing.Point(420, 78);
            this.Ejemplarestxt.Name = "Ejemplarestxt";
            this.Ejemplarestxt.Size = new System.Drawing.Size(129, 20);
            this.Ejemplarestxt.TabIndex = 2;
            // 
            // ListaEspeciesdg
            // 
            this.ListaEspeciesdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaEspeciesdg.Location = new System.Drawing.Point(15, 144);
            this.ListaEspeciesdg.Name = "ListaEspeciesdg";
            this.ListaEspeciesdg.Size = new System.Drawing.Size(549, 252);
            this.ListaEspeciesdg.TabIndex = 4;
            // Estadotxt
            // 
            this.Estadotxt.FormattingEnabled = true;
            this.Estadotxt.Location = new System.Drawing.Point(604, 79);
            this.Estadotxt.Name = "Estadotxt";
            this.Estadotxt.Size = new System.Drawing.Size(195, 21);
            this.Estadotxt.TabIndex = 5;
            // 
            // Ejemplareslbl
            // 
            this.Ejemplareslbl.AutoSize = true;
            this.Ejemplareslbl.BackColor = System.Drawing.SystemColors.Control;
            this.Ejemplareslbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejemplareslbl.Location = new System.Drawing.Point(417, 56);
            this.Ejemplareslbl.Name = "Ejemplareslbl";
            this.Ejemplareslbl.Size = new System.Drawing.Size(159, 16);
            this.Ejemplareslbl.TabIndex = 6;
            this.Ejemplareslbl.Text = "Cantidad de ejemplares";
            // 
            // Conservacionlbl
            // 
            this.Conservacionlbl.AutoSize = true;
            this.Conservacionlbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conservacionlbl.Location = new System.Drawing.Point(615, 56);
            this.Conservacionlbl.Name = "Conservacionlbl";
            this.Conservacionlbl.Size = new System.Drawing.Size(161, 16);
            this.Conservacionlbl.TabIndex = 7;
            this.Conservacionlbl.Text = "Estado de conservacion";
            // 
            // Nombrelbl
            // 
            this.Nombrelbl.AutoSize = true;
            this.Nombrelbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombrelbl.Location = new System.Drawing.Point(142, 58);
            this.Nombrelbl.Name = "Nombrelbl";
            this.Nombrelbl.Size = new System.Drawing.Size(144, 16);
            this.Nombrelbl.TabIndex = 8;
            this.Nombrelbl.Text = "Nombre de la especie";
            // 
            // IDlbl
            // 
            this.IDlbl.AutoSize = true;
            this.IDlbl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlbl.Location = new System.Drawing.Point(12, 56);
            this.IDlbl.Name = "IDlbl";
            this.IDlbl.Size = new System.Drawing.Size(89, 16);
            this.IDlbl.TabIndex = 9;
            this.IDlbl.Text = "ID del animal";
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarbtn.Location = new System.Drawing.Point(570, 144);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Size = new System.Drawing.Size(114, 31);
            this.Registrarbtn.TabIndex = 10;
            this.Registrarbtn.Text = "Registrar";
            this.Registrarbtn.UseVisualStyleBackColor = true;
            this.Registrarbtn.Click += new System.EventHandler(this.Registrarbtn_Click);
            // 
            // Buscarbtn
            // 
            this.Buscarbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbtn.Location = new System.Drawing.Point(570, 218);
            this.Buscarbtn.Name = "Buscarbtn";
            this.Buscarbtn.Size = new System.Drawing.Size(114, 31);
            this.Buscarbtn.TabIndex = 11;
            this.Buscarbtn.Text = "Buscar";
            this.Buscarbtn.UseVisualStyleBackColor = true;
            this.Buscarbtn.Click += new System.EventHandler(this.Buscarbtn_Click);
            // 
            // Actualizarbtn
            // 
            this.Actualizarbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizarbtn.Location = new System.Drawing.Point(710, 144);
            this.Actualizarbtn.Name = "Actualizarbtn";
            this.Actualizarbtn.Size = new System.Drawing.Size(114, 31);
            this.Actualizarbtn.TabIndex = 12;
            this.Actualizarbtn.Text = "Actualizar";
            this.Actualizarbtn.UseVisualStyleBackColor = true;
            this.Actualizarbtn.Click += new System.EventHandler(this.Actualizarbtn_Click);
            // 
            // Limpiarbtn
            // 
            this.Limpiarbtn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiarbtn.Location = new System.Drawing.Point(710, 218);
            this.Limpiarbtn.Name = "Limpiarbtn";
            this.Limpiarbtn.Size = new System.Drawing.Size(114, 31);
            this.Limpiarbtn.TabIndex = 13;
            this.Limpiarbtn.Text = "Limpiar";
            this.Limpiarbtn.UseVisualStyleBackColor = true;
            this.Limpiarbtn.Click += new System.EventHandler(this.Limpiarbtn_Click);
            // 
            // REAlbl
            // 
            this.REAlbl.AutoSize = true;
            this.REAlbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REAlbl.Location = new System.Drawing.Point(255, 9);
            this.REAlbl.Name = "REAlbl";
            this.REAlbl.Size = new System.Drawing.Size(274, 18);
            this.REAlbl.TabIndex = 14;
            this.REAlbl.Text = "REGISTRO DE ESPECIES ANIMALES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 450);
            this.Controls.Add(this.REAlbl);
            this.Controls.Add(this.Limpiarbtn);
            this.Controls.Add(this.Actualizarbtn);
            this.Controls.Add(this.Buscarbtn);
            this.Controls.Add(this.Registrarbtn);
            this.Controls.Add(this.IDlbl);
            this.Controls.Add(this.Nombrelbl);
            this.Controls.Add(this.Conservacionlbl);
            this.Controls.Add(this.Ejemplareslbl);
            this.Controls.Add(this.Estadotxt);
            this.Controls.Add(this.ListaEspeciesdg);
            this.Controls.Add(this.Ejemplarestxt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.IDtxt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListaEspeciesdg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.TextBox Ejemplarestxt;
        private System.Windows.Forms.DataGridView ListaEspeciesdg;
        private System.Windows.Forms.ComboBox Estadotxt;
        private System.Windows.Forms.Label Ejemplareslbl;
        private System.Windows.Forms.Label Conservacionlbl;
        private System.Windows.Forms.Label Nombrelbl;
        private System.Windows.Forms.Label IDlbl;
        private System.Windows.Forms.Button Registrarbtn;
        private System.Windows.Forms.Button Buscarbtn;
        private System.Windows.Forms.Button Actualizarbtn;
        private System.Windows.Forms.Button Limpiarbtn;
        private System.Windows.Forms.Label REAlbl;
    }
}

