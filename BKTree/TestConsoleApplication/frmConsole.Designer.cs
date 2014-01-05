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
            this.label4 = new System.Windows.Forms.Label();
            this.numTolerance = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.numTolerance)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Tolerance:";
            // 
            // numTolerance
            // 
            this.numTolerance.Location = new System.Drawing.Point(72, 42);
            this.numTolerance.Name = "numTolerance";
            this.numTolerance.Size = new System.Drawing.Size(91, 20);
            this.numTolerance.TabIndex = 33;
            this.numTolerance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTolerance.ValueChanged += new System.EventHandler(this.numTolerance_ValueChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(381, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 32;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Dictionary:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(293, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 23);
            this.btnBrowse.TabIndex = 30;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(72, 12);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(215, 20);
            this.txtDictionary.TabIndex = 29;
            // 
            // lblProcessingTime
            // 
            this.lblProcessingTime.AutoSize = true;
            this.lblProcessingTime.Location = new System.Drawing.Point(107, 456);
            this.lblProcessingTime.Name = "lblProcessingTime";
            this.lblProcessingTime.Size = new System.Drawing.Size(10, 13);
            this.lblProcessingTime.TabIndex = 28;
            this.lblProcessingTime.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Processing Time:";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(98, 110);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(10, 13);
            this.lblResultCount.TabIndex = 26;
            this.lblResultCount.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Suggestions:";
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 130);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(451, 316);
            this.lbResult.TabIndex = 24;
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(12, 78);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(451, 20);
            this.txtSearchWord.TabIndex = 23;
            this.txtSearchWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchWord_KeyUp);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 487);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTolerance;
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
    }
}

