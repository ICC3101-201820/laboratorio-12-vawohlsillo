namespace Lab12
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblComida = new System.Windows.Forms.Label();
            this.lblPr = new System.Windows.Forms.Label();
            this.lblGrasas = new System.Windows.Forms.Label();
            this.lblCarboh = new System.Windows.Forms.Label();
            this.tBxComida = new System.Windows.Forms.TextBox();
            this.tBxProt = new System.Windows.Forms.TextBox();
            this.tBxCarbo = new System.Windows.Forms.TextBox();
            this.tBxGras = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.ChLBxAlimentos = new System.Windows.Forms.CheckedListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(263, 252);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(13, 37);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(44, 13);
            this.lblComida.TabIndex = 1;
            this.lblComida.Text = "Nombre";
            // 
            // lblPr
            // 
            this.lblPr.AllowDrop = true;
            this.lblPr.AutoSize = true;
            this.lblPr.Location = new System.Drawing.Point(13, 80);
            this.lblPr.Name = "lblPr";
            this.lblPr.Size = new System.Drawing.Size(51, 13);
            this.lblPr.TabIndex = 2;
            this.lblPr.Text = "Proteinas";
            // 
            // lblGrasas
            // 
            this.lblGrasas.AutoSize = true;
            this.lblGrasas.Location = new System.Drawing.Point(13, 115);
            this.lblGrasas.Name = "lblGrasas";
            this.lblGrasas.Size = new System.Drawing.Size(40, 13);
            this.lblGrasas.TabIndex = 3;
            this.lblGrasas.Text = "Grasas";
            // 
            // lblCarboh
            // 
            this.lblCarboh.AutoSize = true;
            this.lblCarboh.Location = new System.Drawing.Point(16, 156);
            this.lblCarboh.Name = "lblCarboh";
            this.lblCarboh.Size = new System.Drawing.Size(72, 13);
            this.lblCarboh.TabIndex = 4;
            this.lblCarboh.Text = "Carbohidratos";
            // 
            // tBxComida
            // 
            this.tBxComida.Location = new System.Drawing.Point(64, 37);
            this.tBxComida.Name = "tBxComida";
            this.tBxComida.Size = new System.Drawing.Size(177, 20);
            this.tBxComida.TabIndex = 5;
            // 
            // tBxProt
            // 
            this.tBxProt.Location = new System.Drawing.Point(70, 77);
            this.tBxProt.Name = "tBxProt";
            this.tBxProt.Size = new System.Drawing.Size(48, 20);
            this.tBxProt.TabIndex = 6;
            // 
            // tBxCarbo
            // 
            this.tBxCarbo.Location = new System.Drawing.Point(86, 153);
            this.tBxCarbo.Name = "tBxCarbo";
            this.tBxCarbo.Size = new System.Drawing.Size(32, 20);
            this.tBxCarbo.TabIndex = 7;
            // 
            // tBxGras
            // 
            this.tBxGras.Location = new System.Drawing.Point(70, 108);
            this.tBxGras.Name = "tBxGras";
            this.tBxGras.Size = new System.Drawing.Size(48, 20);
            this.tBxGras.TabIndex = 8;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(43, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(171, 34);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // ChLBxAlimentos
            // 
            this.ChLBxAlimentos.FormattingEnabled = true;
            this.ChLBxAlimentos.Location = new System.Drawing.Point(286, 13);
            this.ChLBxAlimentos.Name = "ChLBxAlimentos";
            this.ChLBxAlimentos.Size = new System.Drawing.Size(714, 169);
            this.ChLBxAlimentos.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(440, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(332, 51);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 252);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.ChLBxAlimentos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tBxGras);
            this.Controls.Add(this.tBxCarbo);
            this.Controls.Add(this.tBxProt);
            this.Controls.Add(this.tBxComida);
            this.Controls.Add(this.lblCarboh);
            this.Controls.Add(this.lblGrasas);
            this.Controls.Add(this.lblPr);
            this.Controls.Add(this.lblComida);
            this.Controls.Add(this.splitter1);
            this.Name = "Form1";
            this.Text = "Listado de comidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Label lblPr;
        private System.Windows.Forms.Label lblGrasas;
        private System.Windows.Forms.Label lblCarboh;
        private System.Windows.Forms.TextBox tBxComida;
        private System.Windows.Forms.TextBox tBxProt;
        private System.Windows.Forms.TextBox tBxCarbo;
        private System.Windows.Forms.TextBox tBxGras;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckedListBox ChLBxAlimentos;
        private System.Windows.Forms.Button btnEliminar;
    }
}

