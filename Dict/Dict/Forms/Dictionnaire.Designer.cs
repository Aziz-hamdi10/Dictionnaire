namespace Dict.Forms
{
    partial class Dictionnaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionnaire));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tr1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tr2 = new System.Windows.Forms.TextBox();
            this.panellangue = new System.Windows.Forms.Panel();
            this.panelfr2 = new System.Windows.Forms.Panel();
            this.panelang2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.francais2 = new System.Windows.Forms.Button();
            this.Anglais2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Anglais = new System.Windows.Forms.Button();
            this.panellangue1 = new System.Windows.Forms.Panel();
            this.panelfr1 = new System.Windows.Forms.Panel();
            this.panelang1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Francais = new System.Windows.Forms.Button();
            this.excahnge = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panellangue.SuspendLayout();
            this.panellangue1.SuspendLayout();
            this.panelang1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.excahnge);
            this.panel1.Controls.Add(this.tr1);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panellangue);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(35, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 269);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tr1
            // 
            this.tr1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr1.Location = new System.Drawing.Point(13, 50);
            this.tr1.Multiline = true;
            this.tr1.Name = "tr1";
            this.tr1.Size = new System.Drawing.Size(203, 154);
            this.tr1.TabIndex = 26;
            this.tr1.TextChanged += new System.EventHandler(this.tr1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(232, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 231);
            this.panel5.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tr2);
            this.panel3.Location = new System.Drawing.Point(232, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(228, 230);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // tr2
            // 
            this.tr2.BackColor = System.Drawing.SystemColors.Control;
            this.tr2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tr2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tr2.Location = new System.Drawing.Point(11, 13);
            this.tr2.Multiline = true;
            this.tr2.Name = "tr2";
            this.tr2.Size = new System.Drawing.Size(203, 154);
            this.tr2.TabIndex = 27;
            this.tr2.Text = "Traduction";
            this.tr2.TextChanged += new System.EventHandler(this.tr2_TextChanged);
            // 
            // panellangue
            // 
            this.panellangue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panellangue.Controls.Add(this.panelfr2);
            this.panellangue.Controls.Add(this.panelang2);
            this.panellangue.Controls.Add(this.button1);
            this.panellangue.Controls.Add(this.francais2);
            this.panellangue.Controls.Add(this.Anglais2);
            this.panellangue.Location = new System.Drawing.Point(243, 4);
            this.panellangue.Name = "panellangue";
            this.panellangue.Size = new System.Drawing.Size(203, 30);
            this.panellangue.TabIndex = 2;
            // 
            // panelfr2
            // 
            this.panelfr2.Location = new System.Drawing.Point(108, 27);
            this.panelfr2.Name = "panelfr2";
            this.panelfr2.Size = new System.Drawing.Size(60, 2);
            this.panelfr2.TabIndex = 5;
            // 
            // panelang2
            // 
            this.panelang2.Location = new System.Drawing.Point(17, 27);
            this.panelang2.Name = "panelang2";
            this.panelang2.Size = new System.Drawing.Size(59, 2);
            this.panelang2.TabIndex = 5;
            this.panelang2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelang2_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(183, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // francais2
            // 
            this.francais2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.francais2.FlatAppearance.BorderSize = 0;
            this.francais2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.francais2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.francais2.ForeColor = System.Drawing.Color.Black;
            this.francais2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.francais2.Location = new System.Drawing.Point(95, 1);
            this.francais2.Name = "francais2";
            this.francais2.Size = new System.Drawing.Size(82, 30);
            this.francais2.TabIndex = 5;
            this.francais2.Text = "Francais";
            this.francais2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.francais2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.francais2.UseVisualStyleBackColor = false;
            this.francais2.Click += new System.EventHandler(this.francais2_Click);
            // 
            // Anglais2
            // 
            this.Anglais2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Anglais2.FlatAppearance.BorderSize = 0;
            this.Anglais2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anglais2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anglais2.ForeColor = System.Drawing.Color.Black;
            this.Anglais2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anglais2.Location = new System.Drawing.Point(17, 2);
            this.Anglais2.Name = "Anglais2";
            this.Anglais2.Size = new System.Drawing.Size(72, 27);
            this.Anglais2.TabIndex = 4;
            this.Anglais2.Text = "Anglais";
            this.Anglais2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anglais2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Anglais2.UseVisualStyleBackColor = false;
            this.Anglais2.Click += new System.EventHandler(this.Anglais2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(1, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 1);
            this.panel2.TabIndex = 0;
            // 
            // Anglais
            // 
            this.Anglais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Anglais.FlatAppearance.BorderSize = 0;
            this.Anglais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Anglais.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anglais.ForeColor = System.Drawing.Color.Black;
            this.Anglais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anglais.Location = new System.Drawing.Point(56, 1);
            this.Anglais.Name = "Anglais";
            this.Anglais.Size = new System.Drawing.Size(72, 32);
            this.Anglais.TabIndex = 4;
            this.Anglais.Text = "Anglais";
            this.Anglais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Anglais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Anglais.UseVisualStyleBackColor = false;
            this.Anglais.Click += new System.EventHandler(this.Anglais_Click);
            // 
            // panellangue1
            // 
            this.panellangue1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panellangue1.Controls.Add(this.panelfr1);
            this.panellangue1.Controls.Add(this.panelang1);
            this.panellangue1.Controls.Add(this.panel4);
            this.panellangue1.Controls.Add(this.label1);
            this.panellangue1.Controls.Add(this.Francais);
            this.panellangue1.Controls.Add(this.Anglais);
            this.panellangue1.Location = new System.Drawing.Point(38, 61);
            this.panellangue1.Name = "panellangue1";
            this.panellangue1.Size = new System.Drawing.Size(203, 30);
            this.panellangue1.TabIndex = 1;
            // 
            // panelfr1
            // 
            this.panelfr1.Location = new System.Drawing.Point(134, 28);
            this.panelfr1.Name = "panelfr1";
            this.panelfr1.Size = new System.Drawing.Size(57, 2);
            this.panelfr1.TabIndex = 5;
            // 
            // panelang1
            // 
            this.panelang1.Controls.Add(this.panel6);
            this.panelang1.Location = new System.Drawing.Point(62, 28);
            this.panelang1.Name = "panelang1";
            this.panelang1.Size = new System.Drawing.Size(57, 2);
            this.panelang1.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 2);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(59, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 40);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Condensed", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Langue";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Francais
            // 
            this.Francais.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Francais.FlatAppearance.BorderSize = 0;
            this.Francais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Francais.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Francais.ForeColor = System.Drawing.Color.Black;
            this.Francais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Francais.Location = new System.Drawing.Point(124, 2);
            this.Francais.Name = "Francais";
            this.Francais.Size = new System.Drawing.Size(82, 30);
            this.Francais.TabIndex = 5;
            this.Francais.Text = "Francais";
            this.Francais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Francais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Francais.UseVisualStyleBackColor = false;
            this.Francais.Click += new System.EventHandler(this.Francais_Click);
            // 
            // excahnge
            // 
            this.excahnge.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.excahnge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("excahnge.BackgroundImage")));
            this.excahnge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excahnge.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.excahnge.Location = new System.Drawing.Point(213, 8);
            this.excahnge.Name = "excahnge";
            this.excahnge.Size = new System.Drawing.Size(27, 23);
            this.excahnge.TabIndex = 27;
            this.excahnge.UseVisualStyleBackColor = false;
            this.excahnge.Click += new System.EventHandler(this.excahnge_Click);
            // 
            // Dictionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(566, 367);
            this.Controls.Add(this.panellangue1);
            this.Controls.Add(this.panel1);
            this.Name = "Dictionnaire";
            this.Text = "Dictionnaire";
            this.Load += new System.EventHandler(this.Dictionnaire_Load);
            this.MouseCaptureChanged += new System.EventHandler(this.Dictionnaire_MouseCaptureChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panellangue.ResumeLayout(false);
            this.panellangue1.ResumeLayout(false);
            this.panellangue1.PerformLayout();
            this.panelang1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Anglais;
        private System.Windows.Forms.Panel panellangue1;
        private System.Windows.Forms.Button Francais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panellangue;
        private System.Windows.Forms.Button francais2;
        private System.Windows.Forms.Button Anglais2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelang1;
        private System.Windows.Forms.Panel panelang2;
        private System.Windows.Forms.Panel panelfr2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelfr1;
        private System.Windows.Forms.TextBox tr1;
        private System.Windows.Forms.TextBox tr2;
        private System.Windows.Forms.Button excahnge;
    }
}