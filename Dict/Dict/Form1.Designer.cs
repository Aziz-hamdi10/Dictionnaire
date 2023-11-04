namespace Dict
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorique = new System.Windows.Forms.Button();
            this.btnsetting = new System.Windows.Forms.Button();
            this.btnDictionnaire = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.panellogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.paneltitre = new System.Windows.Forms.Panel();
            this.Labeltitre = new System.Windows.Forms.Label();
            this.paneldesk = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panellogo.SuspendLayout();
            this.paneltitre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnHistorique);
            this.panelMenu.Controls.Add(this.btnsetting);
            this.panelMenu.Controls.Add(this.btnDictionnaire);
            this.panelMenu.Controls.Add(this.btnAdmin);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 0;
            // 
            // btnHistorique
            // 
            this.btnHistorique.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHistorique.FlatAppearance.BorderSize = 0;
            this.btnHistorique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorique.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorique.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHistorique.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorique.Image")));
            this.btnHistorique.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorique.Location = new System.Drawing.Point(0, 260);
            this.btnHistorique.Name = "btnHistorique";
            this.btnHistorique.Size = new System.Drawing.Size(220, 60);
            this.btnHistorique.TabIndex = 5;
            this.btnHistorique.Text = "History";
            this.btnHistorique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorique.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorique.UseVisualStyleBackColor = true;
            this.btnHistorique.Click += new System.EventHandler(this.btnHistorique_Click);
            // 
            // btnsetting
            // 
            this.btnsetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsetting.FlatAppearance.BorderSize = 0;
            this.btnsetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnsetting.Image = ((System.Drawing.Image)(resources.GetObject("btnsetting.Image")));
            this.btnsetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.Location = new System.Drawing.Point(0, 200);
            this.btnsetting.Name = "btnsetting";
            this.btnsetting.Size = new System.Drawing.Size(220, 60);
            this.btnsetting.TabIndex = 4;
            this.btnsetting.Text = "Setting";
            this.btnsetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsetting.UseVisualStyleBackColor = true;
            this.btnsetting.Click += new System.EventHandler(this.btnsetting_Click);
            // 
            // btnDictionnaire
            // 
            this.btnDictionnaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDictionnaire.FlatAppearance.BorderSize = 0;
            this.btnDictionnaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDictionnaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDictionnaire.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDictionnaire.Image = ((System.Drawing.Image)(resources.GetObject("btnDictionnaire.Image")));
            this.btnDictionnaire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDictionnaire.Location = new System.Drawing.Point(0, 140);
            this.btnDictionnaire.Name = "btnDictionnaire";
            this.btnDictionnaire.Size = new System.Drawing.Size(220, 60);
            this.btnDictionnaire.TabIndex = 3;
            this.btnDictionnaire.Text = "Dictionnaire";
            this.btnDictionnaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDictionnaire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDictionnaire.UseVisualStyleBackColor = true;
            this.btnDictionnaire.Click += new System.EventHandler(this.btnDictionnaire_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FlatAppearance.BorderSize = 0;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.Location = new System.Drawing.Point(0, 80);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(220, 60);
            this.btnAdmin.TabIndex = 2;
            this.btnAdmin.Text = " Admin";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // panellogo
            // 
            this.panellogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panellogo.Controls.Add(this.label1);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(220, 80);
            this.panellogo.TabIndex = 1;
            this.panellogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panellogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(41, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dictionnaire";
            // 
            // paneltitre
            // 
            this.paneltitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.paneltitre.Controls.Add(this.Labeltitre);
            this.paneltitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitre.Location = new System.Drawing.Point(220, 0);
            this.paneltitre.Name = "paneltitre";
            this.paneltitre.Size = new System.Drawing.Size(580, 80);
            this.paneltitre.TabIndex = 1;
            // 
            // Labeltitre
            // 
            this.Labeltitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Labeltitre.AutoSize = true;
            this.Labeltitre.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeltitre.ForeColor = System.Drawing.Color.AliceBlue;
            this.Labeltitre.Location = new System.Drawing.Point(245, 28);
            this.Labeltitre.Name = "Labeltitre";
            this.Labeltitre.Size = new System.Drawing.Size(79, 27);
            this.Labeltitre.TabIndex = 2;
            this.Labeltitre.Text = "Home";
            // 
            // paneldesk
            // 
            this.paneldesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldesk.Location = new System.Drawing.Point(220, 80);
            this.paneldesk.Name = "paneldesk";
            this.paneldesk.Size = new System.Drawing.Size(580, 370);
            this.paneldesk.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paneldesk);
            this.Controls.Add(this.paneltitre);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panelMenu.ResumeLayout(false);
            this.panellogo.ResumeLayout(false);
            this.panellogo.PerformLayout();
            this.paneltitre.ResumeLayout(false);
            this.paneltitre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panellogo;
        private System.Windows.Forms.Button btnHistorique;
        private System.Windows.Forms.Button btnsetting;
        private System.Windows.Forms.Button btnDictionnaire;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel paneltitre;
        private System.Windows.Forms.Label Labeltitre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel paneldesk;
    }
}

