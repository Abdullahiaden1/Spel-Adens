namespace Spel_Adens
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStörstaTalet = new System.Windows.Forms.Label();
            this.lblDator = new System.Windows.Forms.Label();
            this.lblGissa = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblDatornsTal = new System.Windows.Forms.Label();
            this.tbxGissa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxMinaResultat = new System.Windows.Forms.TextBox();
            this.lblMinaResultat = new System.Windows.Forms.Label();
            this.btnSpelaIgen = new System.Windows.Forms.Button();
            this.btnStartaSpelet = new System.Windows.Forms.Button();
            this.lbxStörstaTalet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStörstaTalet
            // 
            this.lblStörstaTalet.AutoSize = true;
            this.lblStörstaTalet.Location = new System.Drawing.Point(59, 96);
            this.lblStörstaTalet.Name = "lblStörstaTalet";
            this.lblStörstaTalet.Size = new System.Drawing.Size(72, 15);
            this.lblStörstaTalet.TabIndex = 0;
            this.lblStörstaTalet.Text = "Största talet:";
            this.lblStörstaTalet.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDator
            // 
            this.lblDator.AutoSize = true;
            this.lblDator.Location = new System.Drawing.Point(41, 176);
            this.lblDator.Name = "lblDator";
            this.lblDator.Size = new System.Drawing.Size(67, 15);
            this.lblDator.TabIndex = 1;
            this.lblDator.Text = "Datorns tal:";
            // 
            // lblGissa
            // 
            this.lblGissa.AutoSize = true;
            this.lblGissa.Location = new System.Drawing.Point(37, 246);
            this.lblGissa.Name = "lblGissa";
            this.lblGissa.Size = new System.Drawing.Size(71, 15);
            this.lblGissa.TabIndex = 2;
            this.lblGissa.Text = "Gissa ett Tal:";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultat.Location = new System.Drawing.Point(86, 312);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(100, 32);
            this.lblResultat.TabIndex = 3;
            this.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDatornsTal
            // 
            this.lblDatornsTal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatornsTal.Location = new System.Drawing.Point(126, 172);
            this.lblDatornsTal.Name = "lblDatornsTal";
            this.lblDatornsTal.Size = new System.Drawing.Size(100, 23);
            this.lblDatornsTal.TabIndex = 4;
            this.lblDatornsTal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDatornsTal.Click += new System.EventHandler(this.lblDatornsTal_Click);
            // 
            // tbxGissa
            // 
            this.tbxGissa.Location = new System.Drawing.Point(126, 238);
            this.tbxGissa.Name = "tbxGissa";
            this.tbxGissa.Size = new System.Drawing.Size(100, 23);
            this.tbxGissa.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Gissa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxMinaResultat
            // 
            this.tbxMinaResultat.Enabled = false;
            this.tbxMinaResultat.Location = new System.Drawing.Point(455, 292);
            this.tbxMinaResultat.Multiline = true;
            this.tbxMinaResultat.Name = "tbxMinaResultat";
            this.tbxMinaResultat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMinaResultat.Size = new System.Drawing.Size(90, 60);
            this.tbxMinaResultat.TabIndex = 7;
            // 
            // lblMinaResultat
            // 
            this.lblMinaResultat.AutoSize = true;
            this.lblMinaResultat.Location = new System.Drawing.Point(466, 246);
            this.lblMinaResultat.Name = "lblMinaResultat";
            this.lblMinaResultat.Size = new System.Drawing.Size(79, 15);
            this.lblMinaResultat.TabIndex = 8;
            this.lblMinaResultat.Text = "Mina Resultat";
            // 
            // btnSpelaIgen
            // 
            this.btnSpelaIgen.Enabled = false;
            this.btnSpelaIgen.Location = new System.Drawing.Point(620, 145);
            this.btnSpelaIgen.Name = "btnSpelaIgen";
            this.btnSpelaIgen.Size = new System.Drawing.Size(75, 23);
            this.btnSpelaIgen.TabIndex = 9;
            this.btnSpelaIgen.Text = "Sepla igen";
            this.btnSpelaIgen.UseVisualStyleBackColor = true;
            // 
            // btnStartaSpelet
            // 
            this.btnStartaSpelet.Location = new System.Drawing.Point(620, 96);
            this.btnStartaSpelet.Name = "btnStartaSpelet";
            this.btnStartaSpelet.Size = new System.Drawing.Size(75, 23);
            this.btnStartaSpelet.TabIndex = 10;
            this.btnStartaSpelet.Text = "Starta spelet";
            this.btnStartaSpelet.UseVisualStyleBackColor = true;
            // 
            // lbxStörstaTalet
            // 
            this.lbxStörstaTalet.FormattingEnabled = true;
            this.lbxStörstaTalet.Location = new System.Drawing.Point(161, 96);
            this.lbxStörstaTalet.Name = "lbxStörstaTalet";
            this.lbxStörstaTalet.Size = new System.Drawing.Size(121, 23);
            this.lbxStörstaTalet.TabIndex = 11;
            this.lbxStörstaTalet.SelectedIndexChanged += new System.EventHandler(this.lbxStörstaTalet_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxStörstaTalet);
            this.Controls.Add(this.btnStartaSpelet);
            this.Controls.Add(this.btnSpelaIgen);
            this.Controls.Add(this.lblMinaResultat);
            this.Controls.Add(this.tbxMinaResultat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxGissa);
            this.Controls.Add(this.lblDatornsTal);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblGissa);
            this.Controls.Add(this.lblDator);
            this.Controls.Add(this.lblStörstaTalet);
            this.Enabled = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnGissa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStörstaTalet;
        private Label lblDator;
        private Label lblGissa;
        private Label lblResultat;
        private Label lblDatornsTal;
        private TextBox tbxGissa;
        private Button button1;
        private TextBox tbxMinaResultat;
        private Label lblMinaResultat;
        private Button btnSpelaIgen;
        private Button btnStartaSpelet;
        private ComboBox lbxStörstaTalet;
    }
}