namespace UnitConverters
{
    partial class UnitConverters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitConverters));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Length = new System.Windows.Forms.TabPage();
            this.Temperature = new System.Windows.Forms.TabPage();
            this.Area = new System.Windows.Forms.TabPage();
            this.Volume = new System.Windows.Forms.TabPage();
            this.Weight = new System.Windows.Forms.TabPage();
            this.Time = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnSwap = new System.Windows.Forms.Button();
            this.lblSearchTo = new System.Windows.Forms.Label();
            this.lblSearchFrom = new System.Windows.Forms.Label();
            this.txtSearchTo = new System.Windows.Forms.TextBox();
            this.txtSearchFrom = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Length);
            this.tabControl1.Controls.Add(this.Temperature);
            this.tabControl1.Controls.Add(this.Area);
            this.tabControl1.Controls.Add(this.Volume);
            this.tabControl1.Controls.Add(this.Weight);
            this.tabControl1.Controls.Add(this.Time);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 30);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Length
            // 
            this.Length.BackColor = System.Drawing.Color.LightGray;
            this.Length.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Length.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(4, 32);
            this.Length.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Length.Name = "Length";
            this.Length.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Length.Size = new System.Drawing.Size(942, 0);
            this.Length.TabIndex = 0;
            this.Length.Text = "Length";
            // 
            // Temperature
            // 
            this.Temperature.BackColor = System.Drawing.Color.LightGray;
            this.Temperature.Location = new System.Drawing.Point(4, 32);
            this.Temperature.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Temperature.Name = "Temperature";
            this.Temperature.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Temperature.Size = new System.Drawing.Size(942, 0);
            this.Temperature.TabIndex = 1;
            this.Temperature.Text = "Temperature";
            // 
            // Area
            // 
            this.Area.BackColor = System.Drawing.Color.LightGray;
            this.Area.Location = new System.Drawing.Point(4, 32);
            this.Area.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Area.Name = "Area";
            this.Area.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Area.Size = new System.Drawing.Size(942, 0);
            this.Area.TabIndex = 2;
            this.Area.Text = "Area";
            // 
            // Volume
            // 
            this.Volume.BackColor = System.Drawing.Color.LightGray;
            this.Volume.Location = new System.Drawing.Point(4, 32);
            this.Volume.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volume.Name = "Volume";
            this.Volume.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Volume.Size = new System.Drawing.Size(942, 0);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "Volume";
            // 
            // Weight
            // 
            this.Weight.BackColor = System.Drawing.Color.LightGray;
            this.Weight.Location = new System.Drawing.Point(4, 32);
            this.Weight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weight.Name = "Weight";
            this.Weight.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Weight.Size = new System.Drawing.Size(942, 0);
            this.Weight.TabIndex = 4;
            this.Weight.Text = "Weight";
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.Color.LightGray;
            this.Time.Location = new System.Drawing.Point(4, 32);
            this.Time.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Time.Name = "Time";
            this.Time.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Time.Size = new System.Drawing.Size(942, 0);
            this.Time.TabIndex = 5;
            this.Time.Text = "Time";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnTheme);
            this.panel1.Controls.Add(this.btnSwap);
            this.panel1.Controls.Add(this.lblSearchTo);
            this.panel1.Controls.Add(this.lblSearchFrom);
            this.panel1.Controls.Add(this.txtSearchTo);
            this.panel1.Controls.Add(this.txtSearchFrom);
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Controls.Add(this.lstTo);
            this.panel1.Controls.Add(this.lstFrom);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 712);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTheme
            // 
            this.btnTheme.Location = new System.Drawing.Point(851, 8);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(75, 37);
            this.btnTheme.TabIndex = 13;
            this.btnTheme.Text = "button1";
            this.btnTheme.UseVisualStyleBackColor = true;
            this.btnTheme.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTheme_Click);
            // 
            // btnSwap
            // 
            this.btnSwap.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwap.Location = new System.Drawing.Point(415, 169);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(51, 40);
            this.btnSwap.TabIndex = 12;
            this.btnSwap.Text = "⇄";
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click_1);
            this.btnSwap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSwap_Click);
            // 
            // lblSearchTo
            // 
            this.lblSearchTo.AutoSize = true;
            this.lblSearchTo.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchTo.Location = new System.Drawing.Point(478, 122);
            this.lblSearchTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchTo.Name = "lblSearchTo";
            this.lblSearchTo.Size = new System.Drawing.Size(103, 32);
            this.lblSearchTo.TabIndex = 11;
            this.lblSearchTo.Text = "To Unit:";
            // 
            // lblSearchFrom
            // 
            this.lblSearchFrom.AutoSize = true;
            this.lblSearchFrom.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFrom.Location = new System.Drawing.Point(51, 122);
            this.lblSearchFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchFrom.Name = "lblSearchFrom";
            this.lblSearchFrom.Size = new System.Drawing.Size(135, 32);
            this.lblSearchFrom.TabIndex = 10;
            this.lblSearchFrom.Text = "From Unit:";
            // 
            // txtSearchTo
            // 
            this.txtSearchTo.Font = new System.Drawing.Font("Segoe UI", 13.875F);
            this.txtSearchTo.Location = new System.Drawing.Point(484, 169);
            this.txtSearchTo.Name = "txtSearchTo";
            this.txtSearchTo.Size = new System.Drawing.Size(342, 38);
            this.txtSearchTo.TabIndex = 9;
            this.txtSearchTo.TextChanged += new System.EventHandler(this.txtSearchTo_TextChanged);
            // 
            // txtSearchFrom
            // 
            this.txtSearchFrom.Font = new System.Drawing.Font("Segoe UI", 13.875F);
            this.txtSearchFrom.Location = new System.Drawing.Point(57, 169);
            this.txtSearchFrom.Name = "txtSearchFrom";
            this.txtSearchFrom.Size = new System.Drawing.Size(342, 38);
            this.txtSearchFrom.TabIndex = 8;
            this.txtSearchFrom.TextChanged += new System.EventHandler(this.txtSearchFrom_TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(841, 56);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(97, 38);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(261, 654);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 6;
            // 
            // lstTo
            // 
            this.lstTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTo.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTo.FormattingEnabled = true;
            this.lstTo.IntegralHeight = false;
            this.lstTo.ItemHeight = 25;
            this.lstTo.Location = new System.Drawing.Point(485, 239);
            this.lstTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTo.Name = "lstTo";
            this.lstTo.ScrollAlwaysVisible = true;
            this.lstTo.Size = new System.Drawing.Size(341, 373);
            this.lstTo.TabIndex = 5;
            this.lstTo.SelectedIndexChanged += new System.EventHandler(this.lstTo_SelectedIndexChanged);
            // 
            // lstFrom
            // 
            this.lstFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstFrom.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.IntegralHeight = false;
            this.lstFrom.ItemHeight = 25;
            this.lstFrom.Location = new System.Drawing.Point(59, 239);
            this.lstFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.ScrollAlwaysVisible = true;
            this.lstFrom.Size = new System.Drawing.Size(341, 373);
            this.lstFrom.TabIndex = 4;
            this.lstFrom.SelectedIndexChanged += new System.EventHandler(this.lstFrom_SelectedIndexChanged);
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(484, 56);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(342, 38);
            this.txtTo.TabIndex = 3;
            this.txtTo.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // txtFrom
            // 
            this.txtFrom.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(58, 56);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(342, 38);
            this.txtFrom.TabIndex = 2;
            this.txtFrom.TextChanged += new System.EventHandler(this.txtFrom_TextChanged);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(478, 13);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(48, 32);
            this.lblTo.TabIndex = 1;
            this.lblTo.Text = "To:";
            this.lblTo.Click += new System.EventHandler(this.lblTo_Click);
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(52, 13);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(80, 32);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // UnitConverters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 742);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "UnitConverters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converters";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Length;
        private System.Windows.Forms.TabPage Temperature;
        private System.Windows.Forms.TabPage Area;
        private System.Windows.Forms.TabPage Volume;
        private System.Windows.Forms.TabPage Weight;
        private System.Windows.Forms.TabPage Time;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.ListBox lstFrom;
        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblSearchTo;
        private System.Windows.Forms.Label lblSearchFrom;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.TextBox txtSearchFrom;
        private System.Windows.Forms.TextBox txtSearchTo;
        private System.Windows.Forms.Button btnTheme;
    }
}

