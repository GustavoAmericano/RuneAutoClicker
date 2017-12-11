namespace RuneAutoClicker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.cbDoubleClick = new System.Windows.Forms.CheckBox();
            this.nudRandom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMinDC = new System.Windows.Forms.Label();
            this.nudMinDouble = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.lblMaxDC = new System.Windows.Forms.Label();
            this.nudMaxDouble = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDouble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDouble)).BeginInit();
            this.SuspendLayout();
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(12, 53);
            this.nudDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(94, 20);
            this.nudDelay.TabIndex = 0;
            this.nudDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDelay.ValueChanged += new System.EventHandler(this.nudDelay_ValueChanged);
            // 
            // cbDoubleClick
            // 
            this.cbDoubleClick.AutoSize = true;
            this.cbDoubleClick.Location = new System.Drawing.Point(133, 8);
            this.cbDoubleClick.Name = "cbDoubleClick";
            this.cbDoubleClick.Size = new System.Drawing.Size(143, 17);
            this.cbDoubleClick.TabIndex = 1;
            this.cbDoubleClick.Text = "Doubleclick (For alching)";
            this.cbDoubleClick.UseVisualStyleBackColor = true;
            this.cbDoubleClick.CheckedChanged += new System.EventHandler(this.cbDoubleClick_CheckedChanged);
            // 
            // nudRandom
            // 
            this.nudRandom.Location = new System.Drawing.Point(12, 92);
            this.nudRandom.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRandom.Name = "nudRandom";
            this.nudRandom.Size = new System.Drawing.Size(94, 20);
            this.nudRandom.TabIndex = 2;
            this.nudRandom.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudRandom.ValueChanged += new System.EventHandler(this.nudRandom_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Delay (ms)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "random Delay (ms)";
            // 
            // lblMinDC
            // 
            this.lblMinDC.AutoSize = true;
            this.lblMinDC.Enabled = false;
            this.lblMinDC.Location = new System.Drawing.Point(130, 37);
            this.lblMinDC.Name = "lblMinDC";
            this.lblMinDC.Size = new System.Drawing.Size(152, 13);
            this.lblMinDC.TabIndex = 6;
            this.lblMinDC.Text = "Min. time between dClicks (ms)";
            // 
            // nudMinDouble
            // 
            this.nudMinDouble.Enabled = false;
            this.nudMinDouble.Location = new System.Drawing.Point(133, 53);
            this.nudMinDouble.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMinDouble.Name = "nudMinDouble";
            this.nudMinDouble.Size = new System.Drawing.Size(143, 20);
            this.nudMinDouble.TabIndex = 5;
            this.nudMinDouble.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMinDouble.ValueChanged += new System.EventHandler(this.nudMinDouble_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CTRL + L to start/stop";
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick_1);
            // 
            // lblMaxDC
            // 
            this.lblMaxDC.AutoSize = true;
            this.lblMaxDC.Enabled = false;
            this.lblMaxDC.Location = new System.Drawing.Point(131, 76);
            this.lblMaxDC.Name = "lblMaxDC";
            this.lblMaxDC.Size = new System.Drawing.Size(152, 13);
            this.lblMaxDC.TabIndex = 9;
            this.lblMaxDC.Text = "Min. time between dClicks (ms)";
            // 
            // nudMaxDouble
            // 
            this.nudMaxDouble.Enabled = false;
            this.nudMaxDouble.Location = new System.Drawing.Point(134, 92);
            this.nudMaxDouble.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMaxDouble.Name = "nudMaxDouble";
            this.nudMaxDouble.Size = new System.Drawing.Size(143, 20);
            this.nudMaxDouble.TabIndex = 8;
            this.nudMaxDouble.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudMaxDouble.ValueChanged += new System.EventHandler(this.nudMaxDouble_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 119);
            this.Controls.Add(this.lblMaxDC);
            this.Controls.Add(this.nudMaxDouble);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMinDC);
            this.Controls.Add(this.nudMinDouble);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRandom);
            this.Controls.Add(this.cbDoubleClick);
            this.Controls.Add(this.nudDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Runescape Autoclicker";
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDouble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxDouble)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.CheckBox cbDoubleClick;
        private System.Windows.Forms.NumericUpDown nudRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMinDC;
        private System.Windows.Forms.NumericUpDown nudMinDouble;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.Label lblMaxDC;
        private System.Windows.Forms.NumericUpDown nudMaxDouble;
    }
}

