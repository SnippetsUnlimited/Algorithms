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
            this.lbHashFunctions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtDictionary = new System.Windows.Forms.TextBox();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lbResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHashFunctions
            // 
            this.lbHashFunctions.FormattingEnabled = true;
            this.lbHashFunctions.Location = new System.Drawing.Point(12, 66);
            this.lbHashFunctions.Name = "lbHashFunctions";
            this.lbHashFunctions.Size = new System.Drawing.Size(194, 355);
            this.lbHashFunctions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Hash Functions";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(382, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 23);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Dictionary:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(294, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 23);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDictionary
            // 
            this.txtDictionary.Location = new System.Drawing.Point(73, 12);
            this.txtDictionary.Name = "txtDictionary";
            this.txtDictionary.Size = new System.Drawing.Size(215, 20);
            this.txtDictionary.TabIndex = 21;
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(212, 66);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(252, 355);
            this.lbWords.Sorted = true;
            this.lbWords.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(63, 433);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(320, 20);
            this.txtSearch.TabIndex = 28;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(389, 433);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 29;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.Location = new System.Drawing.Point(470, 66);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(194, 355);
            this.lbResults.TabIndex = 30;
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 461);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWords);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtDictionary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbHashFunctions);
            this.Name = "frmConsole";
            this.Text = "Test Console Application";
            this.Load += new System.EventHandler(this.frmConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbHashFunctions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtDictionary;
        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lbResults;
    }
}

