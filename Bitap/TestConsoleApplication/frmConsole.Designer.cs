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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsole));
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.txtSearchableText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFuzzySearch = new System.Windows.Forms.Button();
            this.numDistance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchWord.Location = new System.Drawing.Point(103, 13);
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(328, 20);
            this.txtSearchWord.TabIndex = 0;
            // 
            // txtSearchableText
            // 
            this.txtSearchableText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchableText.HideSelection = false;
            this.txtSearchableText.Location = new System.Drawing.Point(103, 79);
            this.txtSearchableText.Multiline = true;
            this.txtSearchableText.Name = "txtSearchableText";
            this.txtSearchableText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSearchableText.Size = new System.Drawing.Size(328, 284);
            this.txtSearchableText.TabIndex = 1;
            this.txtSearchableText.Text = resources.GetString("txtSearchableText.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Word:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text:";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(334, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Exact Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFuzzySearch
            // 
            this.btnFuzzySearch.Location = new System.Drawing.Point(183, 39);
            this.btnFuzzySearch.Name = "btnFuzzySearch";
            this.btnFuzzySearch.Size = new System.Drawing.Size(94, 23);
            this.btnFuzzySearch.TabIndex = 5;
            this.btnFuzzySearch.Text = "Fuzzy Search";
            this.btnFuzzySearch.UseVisualStyleBackColor = true;
            this.btnFuzzySearch.Click += new System.EventHandler(this.btnFuzzySearch_Click);
            // 
            // numDistance
            // 
            this.numDistance.Location = new System.Drawing.Point(103, 42);
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(74, 20);
            this.numDistance.TabIndex = 6;
            this.numDistance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fuzzy Distance:";
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 378);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.btnFuzzySearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchableText);
            this.Controls.Add(this.txtSearchWord);
            this.Name = "frmConsole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test Console Application";
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchWord;
        private System.Windows.Forms.TextBox txtSearchableText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFuzzySearch;
        private System.Windows.Forms.NumericUpDown numDistance;
        private System.Windows.Forms.Label label3;
    }
}

