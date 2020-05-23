using System;

namespace Sikilat
{
    partial class FormMenu
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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.BtnContact = new FontAwesome.Sharp.IconButton();
            this.BtnLokasi = new FontAwesome.Sharp.IconButton();
            this.BtnService = new FontAwesome.Sharp.IconButton();
            this.BtnOngkir = new FontAwesome.Sharp.IconButton();
            this.BtnCekresi = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.paneltittlebar = new System.Windows.Forms.Panel();
            this.btnminimize = new FontAwesome.Sharp.IconButton();
            this.btnmaximize = new FontAwesome.Sharp.IconButton();
            this.btnexit = new FontAwesome.Sharp.IconButton();
            this.lbltittlechildform = new System.Windows.Forms.Label();
            this.iconcurrentchildform = new FontAwesome.Sharp.IconPictureBox();
            this.panelshadow = new System.Windows.Forms.Panel();
            this.paneldesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelmenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.paneltittlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).BeginInit();
            this.paneldesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelmenu.Controls.Add(this.BtnContact);
            this.panelmenu.Controls.Add(this.BtnLokasi);
            this.panelmenu.Controls.Add(this.BtnService);
            this.panelmenu.Controls.Add(this.BtnOngkir);
            this.panelmenu.Controls.Add(this.BtnCekresi);
            this.panelmenu.Controls.Add(this.panellogo);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(150, 450);
            this.panelmenu.TabIndex = 0;
            // 
            // BtnContact
            // 
            this.BtnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContact.FlatAppearance.BorderSize = 0;
            this.BtnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnContact.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContact.ForeColor = System.Drawing.Color.White;
            this.BtnContact.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.BtnContact.IconColor = System.Drawing.Color.White;
            this.BtnContact.IconSize = 25;
            this.BtnContact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContact.Location = new System.Drawing.Point(0, 344);
            this.BtnContact.Name = "BtnContact";
            this.BtnContact.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnContact.Rotation = 0D;
            this.BtnContact.Size = new System.Drawing.Size(150, 50);
            this.BtnContact.TabIndex = 6;
            this.BtnContact.Text = "Contact";
            this.BtnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnContact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnContact.UseVisualStyleBackColor = true;
            this.BtnContact.Click += new System.EventHandler(this.BtnContact_Click);
            // 
            // BtnLokasi
            // 
            this.BtnLokasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLokasi.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnLokasi.FlatAppearance.BorderSize = 0;
            this.BtnLokasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLokasi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnLokasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLokasi.ForeColor = System.Drawing.Color.White;
            this.BtnLokasi.IconChar = FontAwesome.Sharp.IconChar.MapMarkedAlt;
            this.BtnLokasi.IconColor = System.Drawing.Color.White;
            this.BtnLokasi.IconSize = 25;
            this.BtnLokasi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLokasi.Location = new System.Drawing.Point(0, 294);
            this.BtnLokasi.Name = "BtnLokasi";
            this.BtnLokasi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnLokasi.Rotation = 0D;
            this.BtnLokasi.Size = new System.Drawing.Size(150, 50);
            this.BtnLokasi.TabIndex = 5;
            this.BtnLokasi.Text = "Lokasi";
            this.BtnLokasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLokasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLokasi.UseVisualStyleBackColor = true;
            this.BtnLokasi.Click += new System.EventHandler(this.BtnLokasi_Click);
            // 
            // BtnService
            // 
            this.BtnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnService.FlatAppearance.BorderSize = 0;
            this.BtnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnService.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnService.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnService.ForeColor = System.Drawing.Color.White;
            this.BtnService.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.BtnService.IconColor = System.Drawing.Color.White;
            this.BtnService.IconSize = 25;
            this.BtnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnService.Location = new System.Drawing.Point(0, 244);
            this.BtnService.Name = "BtnService";
            this.BtnService.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnService.Rotation = 0D;
            this.BtnService.Size = new System.Drawing.Size(150, 50);
            this.BtnService.TabIndex = 4;
            this.BtnService.Text = "Service";
            this.BtnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnService.UseVisualStyleBackColor = true;
            this.BtnService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // BtnOngkir
            // 
            this.BtnOngkir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOngkir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnOngkir.FlatAppearance.BorderSize = 0;
            this.BtnOngkir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOngkir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnOngkir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOngkir.ForeColor = System.Drawing.Color.White;
            this.BtnOngkir.IconChar = FontAwesome.Sharp.IconChar.ShippingFast;
            this.BtnOngkir.IconColor = System.Drawing.Color.White;
            this.BtnOngkir.IconSize = 25;
            this.BtnOngkir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOngkir.Location = new System.Drawing.Point(0, 194);
            this.BtnOngkir.Name = "BtnOngkir";
            this.BtnOngkir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnOngkir.Rotation = 0D;
            this.BtnOngkir.Size = new System.Drawing.Size(150, 50);
            this.BtnOngkir.TabIndex = 3;
            this.BtnOngkir.Text = "Ongkir";
            this.BtnOngkir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOngkir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOngkir.UseVisualStyleBackColor = true;
            this.BtnOngkir.Click += new System.EventHandler(this.BtnOngkir_Click);
            // 
            // BtnCekresi
            // 
            this.BtnCekresi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCekresi.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCekresi.FlatAppearance.BorderSize = 0;
            this.BtnCekresi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCekresi.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCekresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCekresi.ForeColor = System.Drawing.Color.White;
            this.BtnCekresi.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.BtnCekresi.IconColor = System.Drawing.Color.White;
            this.BtnCekresi.IconSize = 25;
            this.BtnCekresi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCekresi.Location = new System.Drawing.Point(0, 144);
            this.BtnCekresi.Name = "BtnCekresi";
            this.BtnCekresi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCekresi.Rotation = 0D;
            this.BtnCekresi.Size = new System.Drawing.Size(150, 50);
            this.BtnCekresi.TabIndex = 2;
            this.BtnCekresi.Text = "Cek Resi";
            this.BtnCekresi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCekresi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCekresi.UseVisualStyleBackColor = true;
            this.BtnCekresi.Click += new System.EventHandler(this.BtnCekresi_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panellogo.Controls.Add(this.pictureBox1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(150, 144);
            this.panellogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Sikilat.Properties.Resources.SiKilat_revisi_3;
            this.pictureBox1.Location = new System.Drawing.Point(3, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // paneltittlebar
            // 
            this.paneltittlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paneltittlebar.Controls.Add(this.btnminimize);
            this.paneltittlebar.Controls.Add(this.btnmaximize);
            this.paneltittlebar.Controls.Add(this.btnexit);
            this.paneltittlebar.Controls.Add(this.lbltittlechildform);
            this.paneltittlebar.Controls.Add(this.iconcurrentchildform);
            this.paneltittlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltittlebar.Location = new System.Drawing.Point(150, 0);
            this.paneltittlebar.Name = "paneltittlebar";
            this.paneltittlebar.Size = new System.Drawing.Size(650, 50);
            this.paneltittlebar.TabIndex = 1;
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnminimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnminimize.IconColor = System.Drawing.Color.White;
            this.btnminimize.IconSize = 16;
            this.btnminimize.Location = new System.Drawing.Point(593, -3);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Rotation = 0D;
            this.btnminimize.Size = new System.Drawing.Size(24, 17);
            this.btnminimize.TabIndex = 4;
            this.btnminimize.UseVisualStyleBackColor = true;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // btnmaximize
            // 
            this.btnmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaximize.FlatAppearance.BorderSize = 0;
            this.btnmaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnmaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnmaximize.IconColor = System.Drawing.Color.White;
            this.btnmaximize.IconSize = 16;
            this.btnmaximize.Location = new System.Drawing.Point(612, -2);
            this.btnmaximize.Name = "btnmaximize";
            this.btnmaximize.Rotation = 0D;
            this.btnmaximize.Size = new System.Drawing.Size(24, 17);
            this.btnmaximize.TabIndex = 3;
            this.btnmaximize.UseVisualStyleBackColor = true;
            this.btnmaximize.Click += new System.EventHandler(this.btnmaximize_Click);
            // 
            // btnexit
            // 
            this.btnexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnexit.IconColor = System.Drawing.Color.White;
            this.btnexit.IconSize = 16;
            this.btnexit.Location = new System.Drawing.Point(631, -2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Rotation = 0D;
            this.btnexit.Size = new System.Drawing.Size(24, 17);
            this.btnexit.TabIndex = 2;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lbltittlechildform
            // 
            this.lbltittlechildform.AutoSize = true;
            this.lbltittlechildform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittlechildform.ForeColor = System.Drawing.Color.White;
            this.lbltittlechildform.Location = new System.Drawing.Point(52, 21);
            this.lbltittlechildform.Name = "lbltittlechildform";
            this.lbltittlechildform.Size = new System.Drawing.Size(49, 16);
            this.lbltittlechildform.TabIndex = 1;
            this.lbltittlechildform.Text = "Home";
            // 
            // iconcurrentchildform
            // 
            this.iconcurrentchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconcurrentchildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconcurrentchildform.IconColor = System.Drawing.Color.White;
            this.iconcurrentchildform.IconSize = 30;
            this.iconcurrentchildform.Location = new System.Drawing.Point(19, 12);
            this.iconcurrentchildform.Name = "iconcurrentchildform";
            this.iconcurrentchildform.Size = new System.Drawing.Size(32, 32);
            this.iconcurrentchildform.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconcurrentchildform.TabIndex = 0;
            this.iconcurrentchildform.TabStop = false;
            this.iconcurrentchildform.Click += new System.EventHandler(this.iconcurrentchildform_Click);
            // 
            // panelshadow
            // 
            this.panelshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelshadow.Location = new System.Drawing.Point(150, 50);
            this.panelshadow.Name = "panelshadow";
            this.panelshadow.Size = new System.Drawing.Size(650, 9);
            this.panelshadow.TabIndex = 2;
            // 
            // paneldesktop
            // 
            this.paneldesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.paneldesktop.Controls.Add(this.pictureBox2);
            this.paneldesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesktop.Location = new System.Drawing.Point(150, 59);
            this.paneldesktop.Name = "paneldesktop";
            this.paneldesktop.Size = new System.Drawing.Size(650, 391);
            this.paneldesktop.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Sikilat.Properties.Resources.SiKilat_revisi_3;
            this.pictureBox2.Location = new System.Drawing.Point(160, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 152);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneldesktop);
            this.Controls.Add(this.panelshadow);
            this.Controls.Add(this.paneltittlebar);
            this.Controls.Add(this.panelmenu);
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.panelmenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.paneltittlebar.ResumeLayout(false);
            this.paneltittlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).EndInit();
            this.paneldesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void iconcurrentchildform_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton BtnContact;
        private FontAwesome.Sharp.IconButton BtnLokasi;
        private FontAwesome.Sharp.IconButton BtnService;
        private FontAwesome.Sharp.IconButton BtnOngkir;
        private FontAwesome.Sharp.IconButton BtnCekresi;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel paneltittlebar;
        private FontAwesome.Sharp.IconPictureBox iconcurrentchildform;
        private System.Windows.Forms.Label lbltittlechildform;
        private System.Windows.Forms.Panel panelshadow;
        private System.Windows.Forms.Panel paneldesktop;
        private System.Windows.Forms.PictureBox pictureBox2;
        private FontAwesome.Sharp.IconButton btnminimize;
        private FontAwesome.Sharp.IconButton btnmaximize;
        private FontAwesome.Sharp.IconButton btnexit;
    }
}

