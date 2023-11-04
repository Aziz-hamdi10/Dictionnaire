namespace Dict.Forms
{
    partial class deleteword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteword));
            this.panelAccount = new System.Windows.Forms.Panel();
            this.roundpic1 = new Dict.Forms.roundpic();
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundpic1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.roundpic1);
            this.panelAccount.Controls.Add(this.label1);
            this.panelAccount.Controls.Add(this.logout);
            this.panelAccount.Location = new System.Drawing.Point(3, 3);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(584, 80);
            this.panelAccount.TabIndex = 12;
            // 
            // roundpic1
            // 
            this.roundpic1.Image = ((System.Drawing.Image)(resources.GetObject("roundpic1.Image")));
            this.roundpic1.Location = new System.Drawing.Point(508, 18);
            this.roundpic1.Name = "roundpic1";
            this.roundpic1.Size = new System.Drawing.Size(48, 48);
            this.roundpic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundpic1.TabIndex = 10;
            this.roundpic1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hamdi Aziz";
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
            this.logout.Location = new System.Drawing.Point(11, 25);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(70, 29);
            this.logout.TabIndex = 7;
            this.logout.Text = "Back";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout.UseVisualStyleBackColor = false;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // deleteword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 357);
            this.Controls.Add(this.panelAccount);
            this.Name = "deleteword";
            this.Text = "deleteword";
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundpic1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAccount;
        private roundpic roundpic1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
    }
}