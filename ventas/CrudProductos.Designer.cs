namespace ventas
{
    partial class CrudProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvinfo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtporcion = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbUnidad = new System.Windows.Forms.ComboBox();
            this.txtprecio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbdisponible = new System.Windows.Forms.ComboBox();
            this.lblid = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnayuda = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnmodificar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnregresar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnayuda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinfo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.DoubleBuffered = true;
            this.dgvinfo.EnableHeadersVisualStyles = false;
            this.dgvinfo.HeaderBgColor = System.Drawing.Color.Honeydew;
            this.dgvinfo.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvinfo.Location = new System.Drawing.Point(10, 92);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvinfo.RowTemplate.Height = 28;
            this.dgvinfo.Size = new System.Drawing.Size(776, 325);
            this.dgvinfo.TabIndex = 0;
            this.dgvinfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfo_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 552);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Porcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "U. Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nombre";
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
            this.txtporcion.Location = new System.Drawing.Point(327, 478);
            this.txtporcion.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtporcion.Name = "txtporcion";
            this.txtporcion.Size = new System.Drawing.Size(112, 45);
            this.txtporcion.TabIndex = 7;
            this.txtporcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtnombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtnombre.BorderThickness = 3;
            this.txtnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnombre.isPassword = false;
            this.txtnombre.Location = new System.Drawing.Point(104, 425);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(249, 51);
            this.txtnombre.TabIndex = 8;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(442, 431);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(68, 26);
            this.numericUpDown1.TabIndex = 9;
            // 
            // cbUnidad
            // 
            this.cbUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidad.FormattingEnabled = true;
            this.cbUnidad.Location = new System.Drawing.Point(104, 494);
            this.cbUnidad.Name = "cbUnidad";
            this.cbUnidad.Size = new System.Drawing.Size(121, 28);
            this.cbUnidad.TabIndex = 10;
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
            this.txtprecio.Location = new System.Drawing.Point(104, 529);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(112, 45);
            this.txtprecio.TabIndex = 11;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbdisponible
            // 
            this.cbdisponible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbdisponible.FormattingEnabled = true;
            this.cbdisponible.Location = new System.Drawing.Point(352, 549);
            this.cbdisponible.Name = "cbdisponible";
            this.cbdisponible.Size = new System.Drawing.Size(121, 28);
            this.cbdisponible.TabIndex = 12;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(388, 682);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 20);
            this.lblid.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 682);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eliminar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 682);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salvar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(718, 682);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Menu";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(261, 60);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(60, 20);
            this.lblnombre.TabIndex = 20;
            this.lblnombre.Text = "label10";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 682);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Limpiar";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = global::ventas.Properties.Resources.sweep__1_;
            this.bunifuImageButton1.ImageActive = global::ventas.Properties.Resources.sweep;
            this.bunifuImageButton1.Location = new System.Drawing.Point(251, 608);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(70, 71);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 22;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnayuda
            // 
            this.btnayuda.BackColor = System.Drawing.Color.Transparent;
            this.btnayuda.Image = global::ventas.Properties.Resources.information__1_;
            this.btnayuda.ImageActive = global::ventas.Properties.Resources.information;
            this.btnayuda.Location = new System.Drawing.Point(734, 425);
            this.btnayuda.Name = "btnayuda";
            this.btnayuda.Size = new System.Drawing.Size(52, 53);
            this.btnayuda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnayuda.TabIndex = 21;
            this.btnayuda.TabStop = false;
            this.btnayuda.Zoom = 10;
            this.btnayuda.Click += new System.EventHandler(this.btnayuda_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar.Image = global::ventas.Properties.Resources.save;
            this.btnmodificar.ImageActive = global::ventas.Properties.Resources.save__1_;
            this.btnmodificar.Location = new System.Drawing.Point(146, 608);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(70, 71);
            this.btnmodificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnmodificar.TabIndex = 15;
            this.btnmodificar.TabStop = false;
            this.btnmodificar.Zoom = 10;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Transparent;
            this.btneliminar.Image = global::ventas.Properties.Resources.delete;
            this.btneliminar.ImageActive = global::ventas.Properties.Resources.delete__2_;
            this.btneliminar.Location = new System.Drawing.Point(34, 608);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(70, 71);
            this.btneliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btneliminar.TabIndex = 14;
            this.btneliminar.TabStop = false;
            this.btneliminar.Zoom = 10;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.Image = global::ventas.Properties.Resources.house_outline;
            this.btnregresar.ImageActive = global::ventas.Properties.Resources.house_outline__1_;
            this.btnregresar.Location = new System.Drawing.Point(706, 608);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(70, 71);
            this.btnregresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnregresar.TabIndex = 13;
            this.btnregresar.TabStop = false;
            this.btnregresar.Zoom = 10;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // CrudProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 712);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnayuda);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.cbdisponible);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.cbUnidad);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtporcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvinfo);
            this.MaximizeBox = false;
            this.Name = "CrudProductos";
            this.Padding = new System.Windows.Forms.Padding(20, 92, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.CrudProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnayuda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnmodificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btneliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtporcion;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbUnidad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprecio;
        private System.Windows.Forms.ComboBox cbdisponible;
        private Bunifu.Framework.UI.BunifuImageButton btnregresar;
        private Bunifu.Framework.UI.BunifuImageButton btneliminar;
        private Bunifu.Framework.UI.BunifuImageButton btnmodificar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblnombre;
        private Bunifu.Framework.UI.BunifuImageButton btnayuda;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label10;
    }
}