namespace ventas
{
    partial class VENTAS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VENTAS));
            this.listaproductos = new System.Windows.Forms.ListBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.precio = new System.Windows.Forms.Label();
            this.cbcarrito = new System.Windows.Forms.ComboBox();
            this.btnquitar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnpagar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listaproductos
            // 
            this.listaproductos.FormattingEnabled = true;
            this.listaproductos.ItemHeight = 20;
            this.listaproductos.Location = new System.Drawing.Point(477, 52);
            this.listaproductos.Name = "listaproductos";
            this.listaproductos.Size = new System.Drawing.Size(311, 344);
            this.listaproductos.TabIndex = 0;
            this.listaproductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listaproductos_MouseDoubleClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(330, 115);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 35);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(330, 83);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(75, 26);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.Text = "1";
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(330, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.Location = new System.Drawing.Point(473, 436);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(13, 20);
            this.precio.TabIndex = 4;
            this.precio.Text = ".";
            // 
            // cbcarrito
            // 
            this.cbcarrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcarrito.FormattingEnabled = true;
            this.cbcarrito.Location = new System.Drawing.Point(667, 402);
            this.cbcarrito.Name = "cbcarrito";
            this.cbcarrito.Size = new System.Drawing.Size(121, 28);
            this.cbcarrito.TabIndex = 5;
            // 
            // btnquitar
            // 
            this.btnquitar.Location = new System.Drawing.Point(667, 436);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(75, 40);
            this.btnquitar.TabIndex = 6;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Carrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Buscar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Descripcion";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(344, 181);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(13, 20);
            this.lbldescripcion.TabIndex = 12;
            this.lbldescripcion.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(569, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Descripcion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(723, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Precio";
            // 
            // btnpagar
            // 
            this.btnpagar.ActiveBorderThickness = 1;
            this.btnpagar.ActiveCornerRadius = 20;
            this.btnpagar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnpagar.ActiveForecolor = System.Drawing.Color.White;
            this.btnpagar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnpagar.BackColor = System.Drawing.SystemColors.Control;
            this.btnpagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpagar.BackgroundImage")));
            this.btnpagar.ButtonText = "pagar";
            this.btnpagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnpagar.IdleBorderThickness = 1;
            this.btnpagar.IdleCornerRadius = 20;
            this.btnpagar.IdleFillColor = System.Drawing.Color.White;
            this.btnpagar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnpagar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnpagar.Location = new System.Drawing.Point(477, 475);
            this.btnpagar.Margin = new System.Windows.Forms.Padding(5);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(181, 41);
            this.btnpagar.TabIndex = 7;
            this.btnpagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(330, 18);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(100, 26);
            this.txtbuscar.TabIndex = 18;
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 530);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.lbldescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnquitar);
            this.Controls.Add(this.cbcarrito);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.listaproductos);
            this.Name = "VENTAS";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaproductos;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.ComboBox cbcarrito;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbldescripcion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnpagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbuscar;
    }
}

