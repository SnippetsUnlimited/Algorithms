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
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProcessingTime = new System.Windows.Forms.Label();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(12, 40);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(451, 20);
            this.txtSearchWord.TabIndex = 1;
            this.txtSearchWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchWord_KeyUp);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Location = new System.Drawing.Point(12, 90);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(451, 355);
            this.lbResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Auto Complete:";
            // 
            // lblResultCount
            // 
            this.lblResultCount.AutoSize = true;
            this.lblResultCount.Location = new System.Drawing.Point(97, 74);
            this.lblResultCount.Name = "lblResultCount";
            this.lblResultCount.Size = new System.Drawing.Size(10, 13);
            this.lblResultCount.TabIndex = 4;
            this.lblResultCount.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Processing Time:";
            // 
            // lblProcessingTime
            // 
            this.lblProcessingTime.AutoSize = true;
            this.lblProcessingTime.Location = new System.Drawing.Point(107, 455);
            this.lblProcessingTime.Name = "lblProcessingTime";
            this.lblProcessingTime.Size = new System.Drawing.Size(10, 13);
            this.lblProcessingTime.TabIndex = 6;
            this.lblProcessingTime.Text = "-";
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(72, 11);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(215, 20);
            this.txtDictionary.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(293, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Dictionary:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(381, 8);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 480);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.ListBox lbResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProcessingTime;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoad;
    }
}

