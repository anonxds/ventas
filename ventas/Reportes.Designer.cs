namespace ventas
{
    partial class Reportes
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
            this.cbinfo = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtantes = new System.Windows.Forms.DateTimePicker();
            this.dtdespues = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.btnsalir = new Bunifu.Framework.UI.BunifuImageButton();
            this.btngenerarpdf = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngenerarpdf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfo
            // 
            this.dgvinfo.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvinfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvinfo.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvinfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvinfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvinfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.DoubleBuffered = true;
            this.dgvinfo.EnableHeadersVisualStyles = false;
            this.dgvinfo.HeaderBgColor = System.Drawing.Color.PaleTurquoise;
            this.dgvinfo.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvinfo.Location = new System.Drawing.Point(14, 274);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvinfo.RowTemplate.Height = 28;
            this.dgvinfo.Size = new System.Drawing.Size(776, 401);
            this.dgvinfo.TabIndex = 0;
            // 
            // cbinfo
            // 
            this.cbinfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbinfo.FormattingEnabled = true;
            this.cbinfo.Location = new System.Drawing.Point(23, 99);
            this.cbinfo.Name = "cbinfo";
            this.cbinfo.Size = new System.Drawing.Size(121, 28);
            this.cbinfo.TabIndex = 1;
            this.cbinfo.SelectedIndexChanged += new System.EventHandler(this.cbinfo_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // dtantes
            // 
            this.dtantes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtantes.Location = new System.Drawing.Point(329, 97);
            this.dtantes.Name = "dtantes";
            this.dtantes.Size = new System.Drawing.Size(143, 26);
            this.dtantes.TabIndex = 4;
            this.dtantes.ValueChanged += new System.EventHandler(this.dtantes_ValueChanged);
            // 
            // dtdespues
            // 
            this.dtdespues.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtdespues.Location = new System.Drawing.Point(329, 129);
            this.dtdespues.Name = "dtdespues";
            this.dtdespues.Size = new System.Drawing.Size(143, 26);
            this.dtdespues.TabIndex = 5;
            this.dtdespues.ValueChanged += new System.EventHandler(this.dtdespues_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Despues de";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(250, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(73, 20);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Antes de";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seleccionar";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(286, 32);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(51, 20);
            this.lblnombre.TabIndex = 11;
            this.lblnombre.Text = "label4";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.Image = global::ventas.Properties.Resources.house_outline;
            this.btnsalir.ImageActive = global::ventas.Properties.Resources.house_outline__1_;
            this.btnsalir.Location = new System.Drawing.Point(708, 12);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(71, 71);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsalir.TabIndex = 9;
            this.btnsalir.TabStop = false;
            this.btnsalir.Zoom = 10;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngenerarpdf
            // 
            this.btngenerarpdf.BackColor = System.Drawing.Color.Transparent;
            this.btngenerarpdf.Image = global::ventas.Properties.Resources.generar;
            this.btngenerarpdf.ImageActive = global::ventas.Properties.Resources.generar2;
            this.btngenerarpdf.Location = new System.Drawing.Point(23, 197);
            this.btngenerarpdf.Name = "btngenerarpdf";
            this.btngenerarpdf.Size = new System.Drawing.Size(71, 71);
            this.btngenerarpdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btngenerarpdf.TabIndex = 8;
            this.btngenerarpdf.TabStop = false;
            this.btngenerarpdf.Zoom = 10;
            this.btngenerarpdf.Click += new System.EventHandler(this.btngenerarpdf_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 684);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngenerarpdf);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtdespues);
            this.Controls.Add(this.dtantes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbinfo);
            this.Controls.Add(this.dgvinfo);
            this.MaximizeBox = false;
            this.Name = "Reportes";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btngenerarpdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvinfo;
        private System.Windows.Forms.ComboBox cbinfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtantes;
        private System.Windows.Forms.DateTimePicker dtdespues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl;
        private Bunifu.Framework.UI.BunifuImageButton btngenerarpdf;
        private Bunifu.Framework.UI.BunifuImageButton btnsalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblnombre;
    }
}