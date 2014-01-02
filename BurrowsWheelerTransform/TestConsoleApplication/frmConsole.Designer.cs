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
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.txtTransform = new System.Windows.Forms.TextBox();
            this.txtInverse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInverse
            // 
            this.btnInverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInverse.Location = new System.Drawing.Point(582, 447);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(101, 23);
            this.btnInverse.TabIndex = 7;
            this.btnInverse.Text = "Inverse";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTransform.Location = new System.Drawing.Point(239, 447);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(101, 23);
            this.btnTransform.TabIndex = 6;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // txtTransform
            // 
            this.txtTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransform.Location = new System.Drawing.Point(349, 12);
            this.txtTransform.Multiline = true;
            this.txtTransform.Name = "txtTransform";
            this.txtTransform.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTransform.Size = new System.Drawing.Size(334, 429);
            this.txtTransform.TabIndex = 5;
            // 
            // txtInverse
            // 
            this.txtInverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInverse.Location = new System.Drawing.Point(12, 12);
            this.txtInverse.Multiline = true;
            this.txtInverse.Name = "txtInverse";
            this.txtInverse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInverse.Size = new System.Drawing.Size(328, 429);
            this.txtInverse.TabIndex = 4;
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 482);
            this.Controls.Add(this.btnInverse);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.txtTransform);
            this.Controls.Add(this.txtInverse);
            this.Name = "frmConsole";
            this.Text = "Test Console Application";
            this.Load += new System.EventHandler(this.frmConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.TextBox txtTransform;
        private System.Windows.Forms.TextBox txtInverse;
    }
}

