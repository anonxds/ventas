namespace ventas
{
    partial class Receta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receta));
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.cbingredientes = new System.Windows.Forms.ComboBox();
            this.btnagregarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnconfirma = new Bunifu.Framework.UI.BunifuImageButton();
            this.listado = new System.Windows.Forms.ListBox();
            this.txtcantidad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtporcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblprecioP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcantidadP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnagregarI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnconfirma)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.White;
            this.txtnombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtnombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtnombre.BorderThickness = 3;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.isPassword = false;
            this.txtnombre.Location = new System.Drawing.Point(118, 21);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(221, 44);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbingredientes
            // 
            this.cbingredientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbingredientes.FormattingEnabled = true;
            this.cbingredientes.Location = new System.Drawing.Point(118, 91);
            this.cbingredientes.Name = "cbingredientes";
            this.cbingredientes.Size = new System.Drawing.Size(121, 28);
            this.cbingredientes.TabIndex = 1;
            this.cbingredientes.SelectedIndexChanged += new System.EventHandler(this.cbingredientes_SelectedIndexChanged);
            // 
            // btnagregarI
            // 
            this.btnagregarI.BackColor = System.Drawing.Color.Transparent;
            this.btnagregarI.Image = global::ventas.Properties.Resources.spa_bowl_to_mix_treatments_ingredients;
            this.btnagregarI.ImageActive = global::ventas.Properties.Resources.spa_bowl_to_mix_treatments_ingredients__1_;
            this.btnagregarI.Location = new System.Drawing.Point(402, 167);
            this.btnagregarI.Name = "btnagregarI";
            this.btnagregarI.Size = new System.Drawing.Size(71, 71);
            this.btnagregarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnagregarI.TabIndex = 2;
            this.btnagregarI.TabStop = false;
            this.btnagregarI.Zoom = 10;
            this.btnagregarI.Click += new System.EventHandler(this.btnagregarI_Click);
            // 
            // btnconfirma
            // 
            this.btnconfirma.BackColor = System.Drawing.Color.Transparent;
            this.btnconfirma.Image = global::ventas.Properties.Resources.completar2;
            this.btnconfirma.ImageActive = global::ventas.Properties.Resources.completar;
            this.btnconfirma.Location = new System.Drawing.Point(728, 486);
            this.btnconfirma.Name = "btnconfirma";
            this.btnconfirma.Size = new System.Drawing.Size(71, 71);
            this.btnconfirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnconfirma.TabIndex = 3;
            this.btnconfirma.TabStop = false;
            this.btnconfirma.Zoom = 10;
            this.btnconfirma.Click += new System.EventHandler(this.btnconfirma_Click);
            // 
            // listado
            // 
            this.listado.FormattingEnabled = true;
            this.listado.ItemHeight = 20;
            this.listado.Location = new System.Drawing.Point(531, 110);
            this.listado.Name = "listado";
            this.listado.Size = new System.Drawing.Size(268, 264);
            this.listado.TabIndex = 4;
            this.listado.DoubleClick += new System.EventHandler(this.listado_DoubleClick);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcantidad.HintForeColor = System.Drawing.Color.Empty;
            this.txtcantidad.HintText = "";
            this.txtcantidad.isPassword = false;
            this.txtcantidad.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcantidad.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcantidad.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcantidad.LineThickness = 3;
            this.txtcantidad.Location = new System.Drawing.Point(118, 134);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(140, 44);
            this.txtcantidad.TabIndex = 5;
            this.txtcantidad.Text = "0";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcantidad.OnValueChanged += new System.EventHandler(this.txtcantidad_OnValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingredientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cantidad";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtprecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtprecio.HintForeColor = System.Drawing.Color.Empty;
            this.txtprecio.HintText = "";
            this.txtprecio.isPassword = false;
            this.txtprecio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtprecio.LineIdleColor = System.Drawing.Color.Gray;
            this.txtprecio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtprecio.LineThickness = 3;
            this.txtprecio.Location = new System.Drawing.Point(531, 513);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(140, 44);
            this.txtprecio.TabIndex = 9;
            this.txtprecio.Text = "0";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Porcion";
            // 
            // txtporcion
            // 
            this.txtporcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtporcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtporcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtporcion.HintForeColor = System.Drawing.Color.Empty;
            this.txtporcion.HintText = "";
            this.txtporcion.isPassword = false;
            this.txtporcion.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtporcion.LineIdleColor = System.Drawing.Color.Gray;
            this.txtporcion.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtporcion.LineThickness = 3;
            this.txtporcion.Location = new System.Drawing.Point(108, 441);
            this.txtporcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtporcion.Name = "txtporcion";
            this.txtporcion.Size = new System.Drawing.Size(140, 44);
            this.txtporcion.TabIndex = 11;
            this.txtporcion.Text = "0";
            this.txtporcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(527, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio Sugerido";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(651, 388);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(18, 20);
            this.lblprecio.TabIndex = 14;
            this.lblprecio.Text = "0";
            // 
            // lblprecioP
            // 
            this.lblprecioP.AutoSize = true;
            this.lblprecioP.BackColor = System.Drawing.Color.Transparent;
            this.lblprecioP.Location = new System.Drawing.Point(252, 99);
            this.lblprecioP.Name = "lblprecioP";
            this.lblprecioP.Size = new System.Drawing.Size(18, 20);
            this.lblprecioP.TabIndex = 15;
            this.lblprecioP.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad";
            // 
            // txtcantidadP
            // 
            this.txtcantidadP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcantidadP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcantidadP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcantidadP.HintForeColor = System.Drawing.Color.Empty;
            this.txtcantidadP.HintText = "";
            this.txtcantidadP.isPassword = false;
            this.txtcantidadP.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcantidadP.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcantidadP.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcantidadP.LineThickness = 3;
            this.txtcantidadP.Location = new System.Drawing.Point(108, 513);
            this.txtcantidadP.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidadP.Name = "txtcantidadP";
            this.txtcantidadP.Size = new System.Drawing.Size(140, 44);
            this.txtcantidadP.TabIndex = 16;
            this.txtcantidadP.Text = "0";
            this.txtcantidadP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtnombre);
            this.bunifuGradientPanel1.Controls.Add(this.lblprecioP);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.cbingredientes);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.txtcantidad);
            this.bunifuGradientPanel1.Controls.Add(this.btnagregarI);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkRed;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(23, 110);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(489, 251);
            this.bunifuGradientPanel1.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(407, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Agregar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Preparar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Informacion del Producto";
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.Image = global::ventas.Properties.Resources.error;
            this.btneliminar.ImageActive = global::ventas.Properties.Resources.error__1_;
            this.btneliminar.Location = new System.Drawing.Point(728, 388);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(71, 71);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 20;
            this.btneliminar.TabStop = false;
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // Receta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 598);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcantidadP);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtporcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.btnconfirma);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Receta";
            this.Resizable = false;
            this.Text = "Receta";
            ((System.ComponentModel.ISupportInitialize)(this.btnagregarI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnconfirma)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private System.Windows.Forms.ComboBox cbingredientes;
        private Bunifu.Framework.UI.BunifuImageButton btnagregarI;
        private Bunifu.Framework.UI.BunifuImageButton btnconfirma;
        private System.Windows.Forms.ListBox listado;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtporcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblprecioP;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcantidadP;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private System.Windows.Forms.Label label10;
    }
}