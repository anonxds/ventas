namespace ventas.Usuarios
{
    partial class tipodeusuario
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
            this.txtnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnagregar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneliminar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtpostnombre = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnmod = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnregresar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.DoubleBuffered = true;
            this.dgvinfo.EnableHeadersVisualStyles = false;
            this.dgvinfo.HeaderBgColor = System.Drawing.Color.AliceBlue;
            this.dgvinfo.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvinfo.Location = new System.Drawing.Point(322, 129);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvinfo.RowTemplate.Height = 28;
            this.dgvinfo.Size = new System.Drawing.Size(360, 425);
            this.dgvinfo.TabIndex = 1;
            this.dgvinfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfo_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
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
            this.txtnombre.Location = new System.Drawing.Point(91, 150);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(161, 44);
            this.txtnombre.TabIndex = 5;
            this.txtnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnagregar
            // 
            this.btnagregar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnagregar.BorderRadius = 0;
            this.btnagregar.ButtonText = "  Agregar Nuevo Rol";
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.DisabledColor = System.Drawing.Color.Gray;
            this.btnagregar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnagregar.Iconimage = global::ventas.Properties.Resources.plus_button;
            this.btnagregar.Iconimage_right = null;
            this.btnagregar.Iconimage_right_Selected = null;
            this.btnagregar.Iconimage_Selected = null;
            this.btnagregar.IconMarginLeft = 0;
            this.btnagregar.IconMarginRight = 0;
            this.btnagregar.IconRightVisible = true;
            this.btnagregar.IconRightZoom = 0D;
            this.btnagregar.IconVisible = true;
            this.btnagregar.IconZoom = 90D;
            this.btnagregar.IsTab = false;
            this.btnagregar.Location = new System.Drawing.Point(65, 203);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnagregar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnagregar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnagregar.selected = false;
            this.btnagregar.Size = new System.Drawing.Size(216, 135);
            this.btnagregar.TabIndex = 6;
            this.btnagregar.Text = "  Agregar Nuevo Rol";
            this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnagregar.Textcolor = System.Drawing.Color.White;
            this.btnagregar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Activecolor = System.Drawing.Color.DarkRed;
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btneliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneliminar.BorderRadius = 0;
            this.btneliminar.ButtonText = "Eliminar";
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.DisabledColor = System.Drawing.Color.Gray;
            this.btneliminar.Iconcolor = System.Drawing.Color.Transparent;
            this.btneliminar.Iconimage = null;
            this.btneliminar.Iconimage_right = null;
            this.btneliminar.Iconimage_right_Selected = null;
            this.btneliminar.Iconimage_Selected = null;
            this.btneliminar.IconMarginLeft = 0;
            this.btneliminar.IconMarginRight = 0;
            this.btneliminar.IconRightVisible = true;
            this.btneliminar.IconRightZoom = 0D;
            this.btneliminar.IconVisible = true;
            this.btneliminar.IconZoom = 90D;
            this.btneliminar.IsTab = false;
            this.btneliminar.Location = new System.Drawing.Point(187, 503);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btneliminar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminar.OnHoverTextColor = System.Drawing.Color.White;
            this.btneliminar.selected = false;
            this.btneliminar.Size = new System.Drawing.Size(119, 51);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneliminar.Textcolor = System.Drawing.Color.White;
            this.btneliminar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtpostnombre
            // 
            this.txtpostnombre.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtpostnombre.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpostnombre.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtpostnombre.BorderThickness = 3;
            this.txtpostnombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpostnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtpostnombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpostnombre.isPassword = false;
            this.txtpostnombre.Location = new System.Drawing.Point(91, 435);
            this.txtpostnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtpostnombre.Name = "txtpostnombre";
            this.txtpostnombre.Size = new System.Drawing.Size(161, 44);
            this.txtpostnombre.TabIndex = 8;
            this.txtpostnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnmod
            // 
            this.btnmod.Activecolor = System.Drawing.Color.Yellow;
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmod.BorderRadius = 0;
            this.btnmod.ButtonText = "Actualizar";
            this.btnmod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmod.DisabledColor = System.Drawing.Color.Gray;
            this.btnmod.Iconcolor = System.Drawing.Color.Transparent;
            this.btnmod.Iconimage = null;
            this.btnmod.Iconimage_right = null;
            this.btnmod.Iconimage_right_Selected = null;
            this.btnmod.Iconimage_Selected = null;
            this.btnmod.IconMarginLeft = 0;
            this.btnmod.IconMarginRight = 0;
            this.btnmod.IconRightVisible = true;
            this.btnmod.IconRightZoom = 0D;
            this.btnmod.IconVisible = true;
            this.btnmod.IconZoom = 90D;
            this.btnmod.IsTab = false;
            this.btnmod.Location = new System.Drawing.Point(44, 503);
            this.btnmod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmod.Name = "btnmod";
            this.btnmod.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnmod.OnHovercolor = System.Drawing.Color.Yellow;
            this.btnmod.OnHoverTextColor = System.Drawing.Color.White;
            this.btnmod.selected = false;
            this.btnmod.Size = new System.Drawing.Size(119, 51);
            this.btnmod.TabIndex = 9;
            this.btnmod.Text = "Actualizar";
            this.btnmod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnmod.Textcolor = System.Drawing.Color.White;
            this.btnmod.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Rol";
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.Transparent;
            this.btnregresar.Image = global::ventas.Properties.Resources.house_outline;
            this.btnregresar.ImageActive = global::ventas.Properties.Resources.house_outline__1_;
            this.btnregresar.Location = new System.Drawing.Point(629, 569);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(71, 71);
            this.btnregresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnregresar.TabIndex = 11;
            this.btnregresar.TabStop = false;
            this.btnregresar.Zoom = 10;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(174, 343);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(0, 20);
            this.lblid.TabIndex = 12;
            this.lblid.Visible = false;
            // 
            // tipodeusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 663);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.txtpostnombre);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvinfo);
            this.MaximizeBox = false;
            this.Name = "tipodeusuario";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Tipos de Roles";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnregresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvinfo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtnombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnagregar;
        private Bunifu.Framework.UI.BunifuFlatButton btneliminar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtpostnombre;
        private Bunifu.Framework.UI.BunifuFlatButton btnmod;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnregresar;
        private System.Windows.Forms.Label lblid;
    }
}