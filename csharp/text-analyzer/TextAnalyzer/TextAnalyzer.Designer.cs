namespace TextAnalyzer
{
    partial class TextAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextAnalyzer));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WCount = new System.Windows.Forms.Button();
            this.ChCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TBWo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text Analyzer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Text";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.WCount);
            this.panel1.Controls.Add(this.ChCount);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.TB1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(29, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 560);
            this.panel1.TabIndex = 5;
            // 
            // WCount
            // 
            this.WCount.BackColor = System.Drawing.Color.LimeGreen;
            this.WCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WCount.ForeColor = System.Drawing.Color.White;
            this.WCount.Location = new System.Drawing.Point(606, 441);
            this.WCount.Name = "WCount";
            this.WCount.Size = new System.Drawing.Size(515, 84);
            this.WCount.TabIndex = 7;
            this.WCount.Text = "Count Words";
            this.WCount.UseVisualStyleBackColor = false;
            this.WCount.Click += new System.EventHandler(this.WCount_Click);
            // 
            // ChCount
            // 
            this.ChCount.BackColor = System.Drawing.Color.DodgerBlue;
            this.ChCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChCount.ForeColor = System.Drawing.Color.White;
            this.ChCount.Location = new System.Drawing.Point(47, 441);
            this.ChCount.Name = "ChCount";
            this.ChCount.Size = new System.Drawing.Size(515, 84);
            this.ChCount.TabIndex = 6;
            this.ChCount.Text = "Count Chars";
            this.ChCount.UseVisualStyleBackColor = false;
            this.ChCount.Click += new System.EventHandler(this.ChCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TBWo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TBCh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(20, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1146, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // TBWo
            // 
            this.TBWo.Location = new System.Drawing.Point(738, 43);
            this.TBWo.Name = "TBWo";
            this.TBWo.Size = new System.Drawing.Size(363, 50);
            this.TBWo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(557, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 45);
            this.label5.TabIndex = 2;
            this.label5.Text = "Word Filter";
            // 
            // TBCh
            // 
            this.TBCh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCh.Location = new System.Drawing.Point(188, 43);
            this.TBCh.Name = "TBCh";
            this.TBCh.Size = new System.Drawing.Size(363, 50);
            this.TBCh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(4, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Char Filter";
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB1.Location = new System.Drawing.Point(20, 51);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(1146, 218);
            this.TB1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TB2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(29, 736);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 304);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB2.Location = new System.Drawing.Point(20, 50);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.ReadOnly = true;
            this.TB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB2.Size = new System.Drawing.Size(1130, 237);
            this.TB2.TabIndex = 10;
            // 
            // TextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1253, 1143);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TextAnalyzer";
            this.Text = "Text Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBWo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ChCount;
        private System.Windows.Forms.Button WCount;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TB2;
    }
}

