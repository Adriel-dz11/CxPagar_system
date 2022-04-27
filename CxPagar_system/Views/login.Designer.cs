namespace CxPagar_system.Views
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIngresar = new FontAwesome.Sharp.IconButton();
            this.Btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 361);
            this.panel1.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(407, 113);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(254, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(407, 205);
            this.txtContrasena.Multiline = true;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(254, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblUsername.Location = new System.Drawing.Point(403, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(93, 21);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            this.lblUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.lblContrasena.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.lblContrasena.Location = new System.Drawing.Point(403, 181);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(103, 21);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña:";
            this.lblContrasena.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.BtnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BtnIngresar.FlatAppearance.BorderSize = 0;
            this.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresar.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnIngresar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.BtnIngresar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.BtnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnIngresar.Location = new System.Drawing.Point(466, 266);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(140, 59);
            this.BtnIngresar.TabIndex = 6;
            this.BtnIngresar.Text = "Entrar";
            this.BtnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIngresar.UseVisualStyleBackColor = false;
            // 
            // Btnsalir
            // 
            this.Btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnsalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(240)))));
            this.Btnsalir.Location = new System.Drawing.Point(652, 0);
            this.Btnsalir.Name = "Btnsalir";
            this.Btnsalir.Size = new System.Drawing.Size(35, 33);
            this.Btnsalir.TabIndex = 7;
            this.Btnsalir.Text = "X";
            this.Btnsalir.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(38)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(687, 361);
            this.Controls.Add(this.Btnsalir);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton BtnIngresar;
        private System.Windows.Forms.Button Btnsalir;
    }
}