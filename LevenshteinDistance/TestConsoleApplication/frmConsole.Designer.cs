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
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.lblProcessingTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chkApplyDamerauDistance = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(381, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 20;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Dictionary:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(293, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 23);
            this.btnBrowse.TabIndex = 18;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(72, 15);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(215, 20);
            this.txtDictionary.TabIndex = 17;
            // 
            // lblProcessingTime
            // 
            this.lblProcessingTime.AutoSize = true;
            this.lblProcessingTime.Location = new System.Drawing.Point(107, 512);
            this.lblProcessingTime.Name = "lblProcessingTime";
            this.lblProcessingTime.Size = new System.Drawing.Size(10, 13);
            this.lblProcessingTime.TabIndex = 16;
            this.lblProcessingTime.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Processing Time:";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(98, 94);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(10, 13);
            this.lblResultCount.TabIndex = 14;
            this.lblResultCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Suggestions:";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 147);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(451, 355);
            this.lbResult.TabIndex = 12;
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(12, 71);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(451, 20);
            this.txtSearchWord.TabIndex = 11;
            this.txtSearchWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchWord_KeyUp);
            // 
            // numTolerance
            // 
            this.numTolerance.Location = new System.Drawing.Point(72, 45);
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(91, 20);
            this.numTolerance.TabIndex = 21;
            this.numTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTolerance.ValueChanged += new System.EventHandler(this.numTolerance_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tolerance:";
            // 
            // chkApplyDamerauDistance
            // 
            this.chkApplyDamerauDistance.AutoSize = true;
            this.chkApplyDamerauDistance.Location = new System.Drawing.Point(184, 48);
            this.chkApplyDamerauDistance.Name = "chkApplyDamerauDistance";
            this.chkApplyDamerauDistance.Size = new System.Drawing.Size(143, 17);
            this.chkApplyDamerauDistance.TabIndex = 23;
            this.chkApplyDamerauDistance.Text = "Apply Damerau Distance";
            this.chkApplyDamerauDistance.UseVisualStyleBackColor = true;
            this.chkApplyDamerauDistance.CheckedChanged += new System.EventHandler(this.chkApplyDamerauDistance_CheckedChanged);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 553);
            this.Controls.Add(this.chkApplyDamerauDistance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTolerance);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDictionary);
            this.Controls.Add(this.lblProcessingTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResultCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtSearchWord);
            this.Name = "frmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Console Application";
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.Label lblProcessingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.NumericUpDown numTolerance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkApplyDamerauDistance;
    }
}

