namespace TestConsoleApplication
{
    partial class frmConsole
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbSampled = new System.Windows.Forms.PictureBox();
            this.btnApplyToOriginal = new System.Windows.Forms.Button();
            this.txtExpectedRegionSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMinimumRegionSize = new System.Windows.Forms.TextBox();
            this.txtLogDelta = new System.Windows.Forms.TextBox();
            this.txtBorderThickness = new System.Windows.Forms.TextBox();
            this.txtApproxRegionCount = new System.Windows.Forms.TextBox();
            this.btnApplyAgain = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSuggestedLogDelta = new System.Windows.Forms.Label();
            this.lblPixelCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSampled)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(630, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImagePath
            // 
            this.txtImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImagePath.Location = new System.Drawing.Point(89, 26);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(535, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Path:";
            // 
            // pbOriginal
            // 
            this.pbOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOriginal.Location = new System.Drawing.Point(12, 65);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(240, 146);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 3;
            this.pbOriginal.TabStop = false;
            // 
            // pbSampled
            // 
            this.pbSampled.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSampled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSampled.Location = new System.Drawing.Point(12, 249);
            this.pbSampled.Name = "pbSampled";
            this.pbSampled.Size = new System.Drawing.Size(708, 249);
            this.pbSampled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSampled.TabIndex = 4;
            this.pbSampled.TabStop = false;
            // 
            // btnApplyToOriginal
            // 
            this.btnApplyToOriginal.Location = new System.Drawing.Point(397, 220);
            this.btnApplyToOriginal.Name = "btnApplyToOriginal";
            this.btnApplyToOriginal.Size = new System.Drawing.Size(94, 23);
            this.btnApplyToOriginal.TabIndex = 5;
            this.btnApplyToOriginal.Text = "Apply to Original";
            this.btnApplyToOriginal.UseVisualStyleBackColor = true;
            this.btnApplyToOriginal.Click += new System.EventHandler(this.btnApplyToOriginal_Click);
            // 
            // txtExpectedRegionSize
            // 
            this.txtExpectedRegionSize.Location = new System.Drawing.Point(394, 65);
            this.txtExpectedRegionSize.Name = "txtExpectedRegionSize";
            this.txtExpectedRegionSize.Size = new System.Drawing.Size(197, 20);
            this.txtExpectedRegionSize.TabIndex = 6;
            this.txtExpectedRegionSize.Text = "125";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expected Region Size:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minimum Region Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Log Delta Factor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Border Thickness:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Approx. Region Count:";
            // 
            // txtMinimumRegionSize
            // 
            this.txtMinimumRegionSize.Location = new System.Drawing.Point(394, 99);
            this.txtMinimumRegionSize.Name = "txtMinimumRegionSize";
            this.txtMinimumRegionSize.Size = new System.Drawing.Size(197, 20);
            this.txtMinimumRegionSize.TabIndex = 12;
            this.txtMinimumRegionSize.Text = "1000";
            // 
            // txtLogDelta
            // 
            this.txtLogDelta.Location = new System.Drawing.Point(394, 131);
            this.txtLogDelta.Name = "txtLogDelta";
            this.txtLogDelta.Size = new System.Drawing.Size(197, 20);
            this.txtLogDelta.TabIndex = 13;
            this.txtLogDelta.Text = "2";
            // 
            // txtBorderThickness
            // 
            this.txtBorderThickness.Location = new System.Drawing.Point(394, 158);
            this.txtBorderThickness.Name = "txtBorderThickness";
            this.txtBorderThickness.Size = new System.Drawing.Size(197, 20);
            this.txtBorderThickness.TabIndex = 14;
            this.txtBorderThickness.Text = "0";
            // 
            // txtApproxRegionCount
            // 
            this.txtApproxRegionCount.Location = new System.Drawing.Point(394, 190);
            this.txtApproxRegionCount.Name = "txtApproxRegionCount";
            this.txtApproxRegionCount.Size = new System.Drawing.Size(197, 20);
            this.txtApproxRegionCount.TabIndex = 15;
            this.txtApproxRegionCount.Text = "10";
            // 
            // btnApplyAgain
            // 
            this.btnApplyAgain.Location = new System.Drawing.Point(497, 220);
            this.btnApplyAgain.Name = "btnApplyAgain";
            this.btnApplyAgain.Size = new System.Drawing.Size(94, 23);
            this.btnApplyAgain.TabIndex = 16;
            this.btnApplyAgain.Text = "Apply Again";
            this.btnApplyAgain.UseVisualStyleBackColor = true;
            this.btnApplyAgain.Click += new System.EventHandler(this.btnApplyAgain_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(597, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(125)";
            // 
            // lblSuggestedLogDelta
            // 
            this.lblSuggestedLogDelta.AutoSize = true;
            this.lblSuggestedLogDelta.Location = new System.Drawing.Point(597, 102);
            this.lblSuggestedLogDelta.Name = "lblSuggestedLogDelta";
            this.lblSuggestedLogDelta.Size = new System.Drawing.Size(102, 13);
            this.lblSuggestedLogDelta.TabIndex = 7;
            this.lblSuggestedLogDelta.Text = "(0.001 * NoOfPixels)";
            // 
            // lblPixelCount
            // 
            this.lblPixelCount.AutoSize = true;
            this.lblPixelCount.Location = new System.Drawing.Point(107, 214);
            this.lblPixelCount.Name = "lblPixelCount";
            this.lblPixelCount.Size = new System.Drawing.Size(13, 13);
            this.lblPixelCount.TabIndex = 18;
            this.lblPixelCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Number of Pixels:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(597, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "(1)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(597, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "(10)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(597, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "(2)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 520);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPixelCount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnApplyAgain);
            this.Controls.Add(this.txtApproxRegionCount);
            this.Controls.Add(this.txtBorderThickness);
            this.Controls.Add(this.txtLogDelta);
            this.Controls.Add(this.txtMinimumRegionSize);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSuggestedLogDelta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtExpectedRegionSize);
            this.Controls.Add(this.btnApplyToOriginal);
            this.Controls.Add(this.pbSampled);
            this.Controls.Add(this.pbOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "Test Console Application";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSampled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbSampled;
        private System.Windows.Forms.Button btnApplyToOriginal;
        private System.Windows.Forms.TextBox txtExpectedRegionSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMinimumRegionSize;
        private System.Windows.Forms.TextBox txtLogDelta;
        private System.Windows.Forms.TextBox txtBorderThickness;
        private System.Windows.Forms.TextBox txtApproxRegionCount;
        private System.Windows.Forms.Button btnApplyAgain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSuggestedLogDelta;
        private System.Windows.Forms.Label lblPixelCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
    }
}

