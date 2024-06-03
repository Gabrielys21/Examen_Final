namespace exam_fin
{
    partial class BD_Libreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BD_Libreria));
            this.labelNomEmpre = new System.Windows.Forms.Label();
            this.labelCodProd = new System.Windows.Forms.Label();
            this.labelDescrip = new System.Windows.Forms.Label();
            this.labelPrecioCost = new System.Windows.Forms.Label();
            this.labelCant = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.textBoxPrecioCost = new System.Windows.Forms.TextBox();
            this.textBoxCant = new System.Windows.Forms.TextBox();
            this.labelBusq = new System.Windows.Forms.Label();
            this.textBoxBusq = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrecioVen = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDist = new System.Windows.Forms.TextBox();
            this.DTabla = new System.Windows.Forms.DataGridView();
            this.buttoMosT = new System.Windows.Forms.Button();
            this.textBoxElimCod = new System.Windows.Forms.TextBox();
            this.Eliminar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPruebaCon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNomEmpre
            // 
            this.labelNomEmpre.AutoSize = true;
            this.labelNomEmpre.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEmpre.Location = new System.Drawing.Point(266, 32);
            this.labelNomEmpre.Name = "labelNomEmpre";
            this.labelNomEmpre.Size = new System.Drawing.Size(351, 36);
            this.labelNomEmpre.TabIndex = 0;
            this.labelNomEmpre.Text = "Comercial \"El Centro\"";
            this.labelNomEmpre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCodProd
            // 
            this.labelCodProd.AutoSize = true;
            this.labelCodProd.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodProd.Location = new System.Drawing.Point(6, 144);
            this.labelCodProd.Name = "labelCodProd";
            this.labelCodProd.Size = new System.Drawing.Size(0, 20);
            this.labelCodProd.TabIndex = 1;
            // 
            // labelDescrip
            // 
            this.labelDescrip.AutoSize = true;
            this.labelDescrip.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescrip.Location = new System.Drawing.Point(18, 147);
            this.labelDescrip.Name = "labelDescrip";
            this.labelDescrip.Size = new System.Drawing.Size(117, 20);
            this.labelDescrip.TabIndex = 2;
            this.labelDescrip.Text = "Descripción:";
            // 
            // labelPrecioCost
            // 
            this.labelPrecioCost.AutoSize = true;
            this.labelPrecioCost.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioCost.Location = new System.Drawing.Point(18, 195);
            this.labelPrecioCost.Name = "labelPrecioCost";
            this.labelPrecioCost.Size = new System.Drawing.Size(126, 20);
            this.labelPrecioCost.TabIndex = 3;
            this.labelPrecioCost.Text = "Precio Costo:";
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(426, 140);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(90, 20);
            this.labelCant.TabIndex = 4;
            this.labelCant.Text = "Cantidad:";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.Location = new System.Drawing.Point(178, 140);
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(211, 27);
            this.textBoxDescrip.TabIndex = 6;
            this.textBoxDescrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPrecioCost
            // 
            this.textBoxPrecioCost.Location = new System.Drawing.Point(178, 188);
            this.textBoxPrecioCost.Name = "textBoxPrecioCost";
            this.textBoxPrecioCost.Size = new System.Drawing.Size(211, 27);
            this.textBoxPrecioCost.TabIndex = 7;
            this.textBoxPrecioCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCant
            // 
            this.textBoxCant.Location = new System.Drawing.Point(588, 137);
            this.textBoxCant.Name = "textBoxCant";
            this.textBoxCant.Size = new System.Drawing.Size(211, 27);
            this.textBoxCant.TabIndex = 8;
            this.textBoxCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelBusq
            // 
            this.labelBusq.AutoSize = true;
            this.labelBusq.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBusq.Location = new System.Drawing.Point(41, 311);
            this.labelBusq.Name = "labelBusq";
            this.labelBusq.Size = new System.Drawing.Size(131, 23);
            this.labelBusq.TabIndex = 9;
            this.labelBusq.Text = "BúsquedaID:";
            // 
            // textBoxBusq
            // 
            this.textBoxBusq.Location = new System.Drawing.Point(178, 307);
            this.textBoxBusq.Name = "textBoxBusq";
            this.textBoxBusq.Size = new System.Drawing.Size(211, 27);
            this.textBoxBusq.TabIndex = 10;
            this.textBoxBusq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.Location = new System.Drawing.Point(249, 340);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(50, 49);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(22, 403);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(161, 37);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(189, 403);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(160, 37);
            this.buttonModificar.TabIndex = 14;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(355, 403);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(161, 37);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(693, 403);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(157, 37);
            this.buttonSalir.TabIndex = 17;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Precio Venta:";
            // 
            // textBoxPrecioVen
            // 
            this.textBoxPrecioVen.Location = new System.Drawing.Point(178, 234);
            this.textBoxPrecioVen.Name = "textBoxPrecioVen";
            this.textBoxPrecioVen.Size = new System.Drawing.Size(211, 27);
            this.textBoxPrecioVen.TabIndex = 19;
            this.textBoxPrecioVen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(588, 186);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(211, 27);
            this.textBoxFecha.TabIndex = 21;
            this.textBoxFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Destribuidor:";
            // 
            // textBoxDist
            // 
            this.textBoxDist.Location = new System.Drawing.Point(588, 234);
            this.textBoxDist.Name = "textBoxDist";
            this.textBoxDist.Size = new System.Drawing.Size(211, 27);
            this.textBoxDist.TabIndex = 23;
            this.textBoxDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTabla
            // 
            this.DTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTabla.Location = new System.Drawing.Point(10, 495);
            this.DTabla.Name = "DTabla";
            this.DTabla.RowHeadersWidth = 51;
            this.DTabla.RowTemplate.Height = 24;
            this.DTabla.Size = new System.Drawing.Size(840, 170);
            this.DTabla.TabIndex = 24;
            // 
            // buttoMosT
            // 
            this.buttoMosT.Location = new System.Drawing.Point(522, 403);
            this.buttoMosT.Name = "buttoMosT";
            this.buttoMosT.Size = new System.Drawing.Size(161, 37);
            this.buttoMosT.TabIndex = 25;
            this.buttoMosT.Text = "Mostrar Tabla";
            this.buttoMosT.UseVisualStyleBackColor = true;
            this.buttoMosT.Click += new System.EventHandler(this.buttoMosT_Click);
            // 
            // textBoxElimCod
            // 
            this.textBoxElimCod.Location = new System.Drawing.Point(588, 310);
            this.textBoxElimCod.Name = "textBoxElimCod";
            this.textBoxElimCod.Size = new System.Drawing.Size(211, 27);
            this.textBoxElimCod.TabIndex = 26;
            this.textBoxElimCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSize = true;
            this.Eliminar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(426, 314);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(142, 23);
            this.Eliminar.TabIndex = 27;
            this.Eliminar.Text = "Eliminar_ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Modificar_ID";
            // 
            // buttonPruebaCon
            // 
            this.buttonPruebaCon.Location = new System.Drawing.Point(689, 446);
            this.buttonPruebaCon.Name = "buttonPruebaCon";
            this.buttonPruebaCon.Size = new System.Drawing.Size(161, 37);
            this.buttonPruebaCon.TabIndex = 29;
            this.buttonPruebaCon.Text = "Prueba Conexion";
            this.buttonPruebaCon.UseVisualStyleBackColor = true;
            this.buttonPruebaCon.Click += new System.EventHandler(this.buttonPruebaCon_Click);
            // 
            // BD_Libreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(862, 677);
            this.Controls.Add(this.buttonPruebaCon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.textBoxElimCod);
            this.Controls.Add(this.buttoMosT);
            this.Controls.Add(this.DTabla);
            this.Controls.Add(this.textBoxDist);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrecioVen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBusq);
            this.Controls.Add(this.labelBusq);
            this.Controls.Add(this.textBoxCant);
            this.Controls.Add(this.textBoxPrecioCost);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.labelCant);
            this.Controls.Add(this.labelPrecioCost);
            this.Controls.Add(this.labelDescrip);
            this.Controls.Add(this.labelCodProd);
            this.Controls.Add(this.labelNomEmpre);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BD_Libreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BDComercial\"ElCentro\"";
            this.Load += new System.EventHandler(this.BD_Libreria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNomEmpre;
        private System.Windows.Forms.Label labelCodProd;
        private System.Windows.Forms.Label labelDescrip;
        private System.Windows.Forms.Label labelPrecioCost;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.TextBox textBoxPrecioCost;
        private System.Windows.Forms.TextBox textBoxCant;
        private System.Windows.Forms.Label labelBusq;
        private System.Windows.Forms.TextBox textBoxBusq;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecioVen;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDist;
        private System.Windows.Forms.DataGridView DTabla;
        private System.Windows.Forms.Button buttoMosT;
        private System.Windows.Forms.TextBox textBoxElimCod;
        private System.Windows.Forms.Label Eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPruebaCon;
    }
}