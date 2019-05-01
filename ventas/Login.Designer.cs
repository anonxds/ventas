namespace ventas
{
    partial class Login
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
            this.txtusuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcontrasena = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btningresar = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtusuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusuario.HintForeColor = System.Drawing.Color.Empty;
            this.txtusuario.HintText = "";
            this.txtusuario.isPassword = false;
            this.txtusuario.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtusuario.LineIdleColor = System.Drawing.Color.Gray;
            this.txtusuario.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtusuario.LineThickness = 3;
            this.txtusuario.Location = new System.Drawing.Point(102, 109);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(137, 36);
            this.txtusuario.TabIndex = 0;
            this.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtusuario.OnValueChanged += new System.EventHandler(this.txtusuario_OnValueChanged);
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcontrasena.HintForeColor = System.Drawing.Color.Empty;
            this.txtcontrasena.HintText = "";
            this.txtcontrasena.isPassword = false;
            this.txtcontrasena.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcontrasena.LineIdleColor = System.Drawing.Color.Gray;
            this.txtcontrasena.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcontrasena.LineThickness = 3;
            this.txtcontrasena.Location = new System.Drawing.Point(102, 151);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.Size = new System.Drawing.Size(137, 35);
            this.txtcontrasena.TabIndex = 1;
            this.txtcontrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 133);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Usuario";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(29, 173);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(61, 13);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Contrasena";
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.Transparent;
            this.btningresar.Image = global::ventas.Properties.Resources.login;
            this.btningresar.ImageActive = global::ventas.Properties.Resources.login__1_;
            this.btningresar.Location = new System.Drawing.Point(139, 200);
            this.btningresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(47, 46);
            this.btningresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btningresar.TabIndex = 4;
            this.btningresar.TabStop = false;
            this.btningresar.Zoom = 10;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 261);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtusuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(13, 39, 13, 13);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btningresar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusuario;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcontrasena;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuImageButton btningresar;
    }
}