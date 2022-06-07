namespace Ballistic_Physics
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.heightNum = new System.Windows.Forms.NumericUpDown();
            this.accelTimeNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.angleNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.accelNum = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resNum = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gravityNum = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.deciamlsNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.updatesNum = new System.Windows.Forms.NumericUpDown();
            this.bigTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelTimeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gravityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deciamlsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatesNum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.heightNum);
            this.groupBox2.Controls.Add(this.accelTimeNum);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.angleNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.accelNum);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velocity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "height";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // heightNum
            // 
            this.heightNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heightNum.DecimalPlaces = 1;
            this.heightNum.Location = new System.Drawing.Point(49, 97);
            this.heightNum.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.heightNum.Name = "heightNum";
            this.heightNum.Size = new System.Drawing.Size(66, 20);
            this.heightNum.TabIndex = 12;
            this.heightNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // accelTimeNum
            // 
            this.accelTimeNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accelTimeNum.DecimalPlaces = 2;
            this.accelTimeNum.Location = new System.Drawing.Point(49, 71);
            this.accelTimeNum.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.accelTimeNum.Name = "accelTimeNum";
            this.accelTimeNum.Size = new System.Drawing.Size(66, 20);
            this.accelTimeNum.TabIndex = 5;
            this.accelTimeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "angle";
            // 
            // angleNum
            // 
            this.angleNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.angleNum.DecimalPlaces = 2;
            this.angleNum.Location = new System.Drawing.Point(49, 45);
            this.angleNum.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.angleNum.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.angleNum.Name = "angleNum";
            this.angleNum.Size = new System.Drawing.Size(66, 20);
            this.angleNum.TabIndex = 3;
            this.angleNum.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "accel/s";
            // 
            // accelNum
            // 
            this.accelNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accelNum.DecimalPlaces = 2;
            this.accelNum.Location = new System.Drawing.Point(49, 19);
            this.accelNum.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.accelNum.Name = "accelNum";
            this.accelNum.Size = new System.Drawing.Size(66, 20);
            this.accelNum.TabIndex = 1;
            this.accelNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "acl. time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "resulution";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resNum
            // 
            this.resNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resNum.DecimalPlaces = 3;
            this.resNum.Location = new System.Drawing.Point(67, 182);
            this.resNum.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.resNum.Name = "resNum";
            this.resNum.Size = new System.Drawing.Size(63, 20);
            this.resNum.TabIndex = 3;
            this.resNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.gravityNum);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gravity";
            // 
            // gravityNum
            // 
            this.gravityNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gravityNum.DecimalPlaces = 2;
            this.gravityNum.Location = new System.Drawing.Point(6, 18);
            this.gravityNum.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.gravityNum.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            -2147483648});
            this.gravityNum.Name = "gravityNum";
            this.gravityNum.Size = new System.Drawing.Size(109, 20);
            this.gravityNum.TabIndex = 0;
            this.gravityNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // Calculate
            // 
            this.Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate.Location = new System.Drawing.Point(6, 260);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(124, 28);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "decimanls";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deciamlsNum
            // 
            this.deciamlsNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deciamlsNum.Location = new System.Drawing.Point(67, 208);
            this.deciamlsNum.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.deciamlsNum.Name = "deciamlsNum";
            this.deciamlsNum.Size = new System.Drawing.Size(63, 20);
            this.deciamlsNum.TabIndex = 7;
            this.deciamlsNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "updates";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updatesNum
            // 
            this.updatesNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updatesNum.Location = new System.Drawing.Point(67, 234);
            this.updatesNum.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.updatesNum.Name = "updatesNum";
            this.updatesNum.Size = new System.Drawing.Size(63, 20);
            this.updatesNum.TabIndex = 9;
            this.updatesNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // bigTextBox
            // 
            this.bigTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bigTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.bigTextBox.Location = new System.Drawing.Point(136, 3);
            this.bigTextBox.Multiline = true;
            this.bigTextBox.Name = "bigTextBox";
            this.bigTextBox.Size = new System.Drawing.Size(287, 285);
            this.bigTextBox.TabIndex = 11;
            // 
            // Settings
            // 
            this.AcceptButton = this.Calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 293);
            this.Controls.Add(this.bigTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updatesNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deciamlsNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.resNum);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Ballistic Physics Calculator";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelTimeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gravityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deciamlsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updatesNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown resNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown accelNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown gravityNum;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown angleNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown deciamlsNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown accelTimeNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown heightNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updatesNum;
        private System.Windows.Forms.TextBox bigTextBox;

    }
}

