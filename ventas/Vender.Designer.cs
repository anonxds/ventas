namespace ventas
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.listadoProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.USD = new System.Windows.Forms.RadioButton();
            this.mxn = new System.Windows.Forms.RadioButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbldesarrollar = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblhidderprice = new System.Windows.Forms.Label();
            this.lblmonera = new System.Windows.Forms.Label();
            this.lblusd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnticket = new Bunifu.Framework.UI.BunifuImageButton();
            this.btninventario = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnpagar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnreportes = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.lblprecioU = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.btnagregar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnreportes)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoProductos
            // 
            this.listadoProductos.FormattingEnabled = true;
            this.listadoProductos.ItemHeight = 20;
            this.listadoProductos.Location = new System.Drawing.Point(504, 150);
            this.listadoProductos.Name = "listadoProductos";
            this.listadoProductos.Size = new System.Drawing.Size(317, 364);
            this.listadoProductos.TabIndex = 0;
            this.listadoProductos.DoubleClick += new System.EventHandler(this.listadoProductos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(623, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(731, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // cbproducto
            // 
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(27, 216);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(159, 28);
            this.cbproducto.TabIndex = 4;
            this.cbproducto.SelectedIndexChanged += new System.EventHandler(this.cbproducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 46);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(665, 561);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(43, 46);
            this.lblprecio.TabIndex = 12;
            this.lblprecio.Text = "0";
            // 
            // USD
            // 
            this.USD.AutoSize = true;
            this.USD.Location = new System.Drawing.Point(446, 601);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(69, 24);
            this.USD.TabIndex = 13;
            this.USD.Text = "USD";
            this.USD.UseVisualStyleBackColor = true;
            this.USD.CheckedChanged += new System.EventHandler(this.USD_CheckedChanged);
            // 
            // mxn
            // 
            this.mxn.AutoSize = true;
            this.mxn.Checked = true;
            this.mxn.Location = new System.Drawing.Point(446, 561);
            this.mxn.Name = "mxn";
            this.mxn.Size = new System.Drawing.Size(69, 24);
            this.mxn.TabIndex = 14;
            this.mxn.TabStop = true;
            this.mxn.Text = "MXN";
            this.mxn.UseVisualStyleBackColor = true;
            this.mxn.CheckedChanged += new System.EventHandler(this.mxn_CheckedChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-15, 502);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(958, 54);
            this.bunifuSeparator1.TabIndex = 15;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbldesarrollar
            // 
            this.lbldesarrollar.AutoSize = true;
            this.lbldesarrollar.Location = new System.Drawing.Point(23, 78);
            this.lbldesarrollar.Name = "lbldesarrollar";
            this.lbldesarrollar.Size = new System.Drawing.Size(65, 20);
            this.lbldesarrollar.TabIndex = 21;
            this.lbldesarrollar.Text = "Nombre";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(106, 78);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(13, 20);
            this.lblnombre.TabIndex = 22;
            this.lblnombre.Text = ".";
            this.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblhidderprice
            // 
            this.lblhidderprice.AutoSize = true;
            this.lblhidderprice.Location = new System.Drawing.Point(8, 526);
            this.lblhidderprice.Name = "lblhidderprice";
            this.lblhidderprice.Size = new System.Drawing.Size(13, 20);
            this.lblhidderprice.TabIndex = 27;
            this.lblhidderprice.Text = " ";
            this.lblhidderprice.Visible = false;
            // 
            // lblmonera
            // 
            this.lblmonera.AutoSize = true;
            this.lblmonera.Location = new System.Drawing.Point(22, 577);
            this.lblmonera.Name = "lblmonera";
            this.lblmonera.Size = new System.Drawing.Size(71, 20);
            this.lblmonera.TabIndex = 28;
            this.lblmonera.Text = "Moneda:";
            // 
            // lblusd
            // 
            this.lblusd.AutoSize = true;
            this.lblusd.Location = new System.Drawing.Point(99, 577);
            this.lblusd.Name = "lblusd";
            this.lblusd.Size = new System.Drawing.Size(13, 20);
            this.lblusd.TabIndex = 29;
            this.lblusd.Text = ".";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(23, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Imprimir Recibo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(384, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cancelar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(223, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "Inventario";
            // 
            // btnticket
            // 
            this.btnticket.BackColor = System.Drawing.Color.Transparent;
            this.btnticket.Image = global::ventas.Properties.Resources.recibo2;
            this.btnticket.ImageActive = global::ventas.Properties.Resources.recibo;
            this.btnticket.Location = new System.Drawing.Point(41, 408);
            this.btnticket.Name = "btnticket";
            this.btnticket.Size = new System.Drawing.Size(71, 71);
            this.btnticket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnticket.TabIndex = 20;
            this.btnticket.TabStop = false;
            this.btnticket.Zoom = 10;
            this.btnticket.Click += new System.EventHandler(this.btnticket_Click);
            // 
            // btninventario
            // 
            this.btninventario.BackColor = System.Drawing.Color.Transparent;
            this.btninventario.Image = global::ventas.Properties.Resources.storage;
            this.btninventario.ImageActive = global::ventas.Properties.Resources.storage__1_;
            this.btninventario.Location = new System.Drawing.Point(227, 408);
            this.btninventario.Name = "btninventario";
            this.btninventario.Size = new System.Drawing.Size(71, 71);
            this.btninventario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btninventario.TabIndex = 19;
            this.btninventario.TabStop = false;
            this.btninventario.Zoom = 10;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::ventas.Properties.Resources.house_outline;
            this.btnsalir.ImageActive = global::ventas.Properties.Resources.house_outline__1_;
            this.btnsalir.Location = new System.Drawing.Point(588, 27);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(71, 71);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 18;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.Transparent;
            this.btnpagar.Image = global::ventas.Properties.Resources.paga2;
            this.btnpagar.ImageActive = global::ventas.Properties.Resources.Pagar;
            this.btnpagar.Location = new System.Drawing.Point(351, 551);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(84, 74);
            this.btnpagar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnpagar.TabIndex = 17;
            this.btnpagar.TabStop = false;
            this.btnpagar.Zoom = 10;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.Color.Transparent;
            this.btnreportes.Image = global::ventas.Properties.Resources.error;
            this.btnreportes.ImageActive = global::ventas.Properties.Resources.error__1_;
            this.btnreportes.Location = new System.Drawing.Point(385, 408);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(71, 71);
            this.btnreportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnreportes.TabIndex = 16;
            this.btnreportes.TabStop = false;
            this.btnreportes.Zoom = 10;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.txtcantidad);
            this.bunifuGradientPanel1.Controls.Add(this.lblprecioU);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.lbldescripcion);
            this.bunifuGradientPanel1.Controls.Add(this.btnagregar);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Silver;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 150);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(486, 230);
            this.bunifuGradientPanel1.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Productos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(197, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(191, 66);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(79, 26);
            this.txtcantidad.TabIndex = 23;
            this.txtcantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtcantidad.ValueChanged += new System.EventHandler(this.txtcantidad_ValueChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            this.txtcantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcantidad_MouseClick);
            // 
            // lblprecioU
            // 
            this.lblprecioU.AutoSize = true;
            this.lblprecioU.BackColor = System.Drawing.Color.Transparent;
            this.lblprecioU.Location = new System.Drawing.Point(410, 74);
            this.lblprecioU.Name = "lblprecioU";
            this.lblprecioU.Size = new System.Drawing.Size(13, 20);
            this.lblprecioU.TabIndex = 25;
            this.lblprecioU.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(391, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(288, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lbldescripcion.Location = new System.Drawing.Point(318, 74);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(13, 20);
            this.lbldescripcion.TabIndex = 10;
            this.lbldescripcion.Text = ".";
            // 
            // btnagregar
            // 
            this.btnagregar.ActiveBorderThickness = 1;
            this.btnagregar.ActiveCornerRadius = 20;
            this.btnagregar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnagregar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.ButtonText = "Agregar";
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.IdleBorderThickness = 1;
            this.btnagregar.IdleCornerRadius = 20;
            this.btnagregar.IdleFillColor = System.Drawing.Color.White;
            this.btnagregar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnagregar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnagregar.Location = new System.Drawing.Point(172, 132);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(159, 72);
            this.btnagregar.TabIndex = 7;
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 648);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblusd);
            this.Controls.Add(this.lblmonera);
            this.Controls.Add(this.lblhidderprice);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lbldesarrollar);
            this.Controls.Add(this.btnticket);
            this.Controls.Add(this.btninventario);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.mxn);
            this.Controls.Add(this.USD);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listadoProductos);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.MaximizeBox = false;
            this.Name = "Vender";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btninventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnpagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnreportes)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listadoProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbproducto;
        private Bunifu.Framework.UI.BunifuThinButton2 btnagregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.RadioButton USD;
        private System.Windows.Forms.RadioButton mxn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnreportes;
        private Bunifu.Framework.UI.BunifuImageButton btnpagar;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private Bunifu.Framework.UI.BunifuImageButton btninventario;
        private Bunifu.Framework.UI.BunifuImageButton btnticket;
        private System.Windows.Forms.Label lbldesarrollar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblprecioU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblhidderprice;
        private System.Windows.Forms.Label lblmonera;
        private System.Windows.Forms.Label lblusd;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}