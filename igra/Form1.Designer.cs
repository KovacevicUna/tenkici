namespace igra
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panTenk = new System.Windows.Forms.Panel();
            this.panProzor = new System.Windows.Forms.Panel();
            this.panMeta = new System.Windows.Forms.Panel();
            this.pbarUspeh = new System.Windows.Forms.ProgressBar();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLevo = new System.Windows.Forms.Button();
            this.btnPucaj = new System.Windows.Forms.Button();
            this.labPoeni = new System.Windows.Forms.Label();
            this.labRezultat = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tajmer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panProzor.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.labPoeni);
            this.splitContainer1.Panel2.Controls.Add(this.labRezultat);
            this.splitContainer1.Panel2.Controls.Add(this.btnRestart);
            this.splitContainer1.Panel2.Controls.Add(this.btnStart);
            this.splitContainer1.Size = new System.Drawing.Size(1844, 951);
            this.splitContainer1.SplitterDistance = 1475;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer2.Panel1.Controls.Add(this.panTenk);
            this.splitContainer2.Panel1.Controls.Add(this.panProzor);
            this.splitContainer2.Panel1.Controls.Add(this.pbarUspeh);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel2.Controls.Add(this.btnDesno);
            this.splitContainer2.Panel2.Controls.Add(this.btnLevo);
            this.splitContainer2.Panel2.Controls.Add(this.btnPucaj);
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.splitContainer2.Size = new System.Drawing.Size(1475, 951);
            this.splitContainer2.SplitterDistance = 813;
            this.splitContainer2.TabIndex = 0;
            // 
            // panTenk
            // 
            this.panTenk.BackColor = System.Drawing.SystemColors.ControlText;
            this.panTenk.Location = new System.Drawing.Point(652, 691);
            this.panTenk.Name = "panTenk";
            this.panTenk.Size = new System.Drawing.Size(129, 119);
            this.panTenk.TabIndex = 2;
            // 
            // panProzor
            // 
            this.panProzor.Controls.Add(this.panMeta);
            this.panProzor.Location = new System.Drawing.Point(24, 92);
            this.panProzor.Name = "panProzor";
            this.panProzor.Size = new System.Drawing.Size(1426, 260);
            this.panProzor.TabIndex = 1;
            // 
            // panMeta
            // 
            this.panMeta.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panMeta.Location = new System.Drawing.Point(977, 141);
            this.panMeta.Name = "panMeta";
            this.panMeta.Size = new System.Drawing.Size(413, 95);
            this.panMeta.TabIndex = 0;
            // 
            // pbarUspeh
            // 
            this.pbarUspeh.Location = new System.Drawing.Point(24, 12);
            this.pbarUspeh.Name = "pbarUspeh";
            this.pbarUspeh.Size = new System.Drawing.Size(1426, 46);
            this.pbarUspeh.TabIndex = 0;
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(843, 23);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(150, 99);
            this.btnDesno.TabIndex = 2;
            this.btnDesno.Text = "--->";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLevo
            // 
            this.btnLevo.Location = new System.Drawing.Point(460, 23);
            this.btnLevo.Name = "btnLevo";
            this.btnLevo.Size = new System.Drawing.Size(150, 99);
            this.btnLevo.TabIndex = 1;
            this.btnLevo.Text = "<---";
            this.btnLevo.UseVisualStyleBackColor = true;
            // 
            // btnPucaj
            // 
            this.btnPucaj.Location = new System.Drawing.Point(652, 23);
            this.btnPucaj.Name = "btnPucaj";
            this.btnPucaj.Size = new System.Drawing.Size(150, 99);
            this.btnPucaj.TabIndex = 0;
            this.btnPucaj.Text = "PUC PUC";
            this.btnPucaj.UseVisualStyleBackColor = true;
            this.btnPucaj.Click += new System.EventHandler(this.btnPucaj_Click);
            // 
            // labPoeni
            // 
            this.labPoeni.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labPoeni.Location = new System.Drawing.Point(26, 446);
            this.labPoeni.Name = "labPoeni";
            this.labPoeni.Size = new System.Drawing.Size(292, 436);
            this.labPoeni.TabIndex = 5;
            this.labPoeni.Text = "R\r\nE\r\nA\r\nD\r\nY\r\n?\r\n";
            this.labPoeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labRezultat
            // 
            this.labRezultat.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labRezultat.Location = new System.Drawing.Point(57, 328);
            this.labRezultat.Name = "labRezultat";
            this.labRezultat.Size = new System.Drawing.Size(251, 72);
            this.labRezultat.TabIndex = 4;
            this.labRezultat.Text = "Score : 0";
            this.labRezultat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(196, 148);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRestart.Size = new System.Drawing.Size(122, 113);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(43, 148);
            this.btnStart.Name = "btnStart";
            this.btnStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnStart.Size = new System.Drawing.Size(122, 113);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // tajmer
            // 
            this.tajmer.Enabled = true;
            this.tajmer.Interval = 30;
            this.tajmer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 951);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "TENKICI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Iskljuceno);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Ukljuceno);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panProzor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button btnPucaj;
        private Panel panProzor;
        private ProgressBar pbarUspeh;
        private Button btnDesno;
        private Button btnLevo;
        private Panel panTenk;
        private Panel panMeta;
        private System.Windows.Forms.Timer tajmer;
        private Button btnStart;
        private Button btnRestart;
        private Label labRezultat;
        private Label labPoeni;
    }
}