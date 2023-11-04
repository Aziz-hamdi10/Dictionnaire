namespace Dict.Forms
    

{
    partial class Adminmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adminmenu));
            this.welcome = new System.Windows.Forms.Label();
            this.adduser = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Modif = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.logpanel = new System.Windows.Forms.Panel();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.roundpic1 = new Dict.Forms.roundpic();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundpic1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcome.Location = new System.Drawing.Point(262, 25);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(113, 33);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome :";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.adduser.FlatAppearance.BorderSize = 0;
            this.adduser.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduser.ForeColor = System.Drawing.Color.Black;
            this.adduser.Image = ((System.Drawing.Image)(resources.GetObject("adduser.Image")));
            this.adduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduser.Location = new System.Drawing.Point(175, 86);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(200, 50);
            this.adduser.TabIndex = 3;
            this.adduser.Text = "Add user";
            this.adduser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adduser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Black;
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.Location = new System.Drawing.Point(175, 154);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(200, 50);
            this.add.TabIndex = 4;
            this.add.Text = "Add word";
            this.add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modif
            // 
            this.Modif.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Modif.FlatAppearance.BorderSize = 0;
            this.Modif.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modif.ForeColor = System.Drawing.Color.Black;
            this.Modif.Image = ((System.Drawing.Image)(resources.GetObject("Modif.Image")));
            this.Modif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modif.Location = new System.Drawing.Point(175, 218);
            this.Modif.Name = "Modif";
            this.Modif.Size = new System.Drawing.Size(200, 50);
            this.Modif.TabIndex = 5;
            this.Modif.Text = "Modif ward";
            this.Modif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Modif.UseVisualStyleBackColor = false;
            this.Modif.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.Font = new System.Drawing.Font("Oswald", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.Location = new System.Drawing.Point(175, 282);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(200, 50);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete word";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // logout
            // 
            this.logout.BackColor = System.Drawing.SystemColors.Control;
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.Font = new System.Drawing.Font("Oswald", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Black;
            this.logout.Image = ((System.Drawing.Image)(resources.GetObject("logout.Image")));
            this.logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.Location = new System.Drawing.Point(26, 29);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(70, 29);
            this.logout.TabIndex = 7;
            this.logout.Text = "Log out ";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // logpanel
            // 
            this.logpanel.Location = new System.Drawing.Point(46, 65);
            this.logpanel.Name = "logpanel";
            this.logpanel.Size = new System.Drawing.Size(50, 1);
            this.logpanel.TabIndex = 8;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.roundpic1);
            this.panelAccount.Controls.Add(this.label1);
            this.panelAccount.Controls.Add(this.logout);
            this.panelAccount.Controls.Add(this.welcome);
            this.panelAccount.Location = new System.Drawing.Point(0, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(565, 80);
            this.panelAccount.TabIndex = 9;
            // 
            // roundpic1
            // 
            this.roundpic1.Image = ((System.Drawing.Image)(resources.GetObject("roundpic1.Image")));
            this.roundpic1.Location = new System.Drawing.Point(504, 18);
            this.roundpic1.Name = "roundpic1";
            this.roundpic1.Size = new System.Drawing.Size(48, 48);
            this.roundpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundpic1.TabIndex = 10;
            this.roundpic1.TabStop = false;
            this.roundpic1.Click += new System.EventHandler(this.roundpic1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hamdi Aziz";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Adminmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 367);
            this.Controls.Add(this.panelAccount);
            this.Controls.Add(this.logpanel);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Modif);
            this.Controls.Add(this.add);
            this.Controls.Add(this.adduser);
            this.Name = "Adminmenu";
            this.Text = "Adminmenu";
            this.Load += new System.EventHandler(this.Adminmenu_Load);
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundpic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Modif;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel logpanel;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Label label1;
        private roundpic roundpic1;
    }
}