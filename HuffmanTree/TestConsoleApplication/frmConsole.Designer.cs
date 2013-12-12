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
            this.txtBinaryData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpleEncode = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOriginalLength = new System.Windows.Forms.Label();
            this.lblCompressedLength = new System.Windows.Forms.Label();
            this.lblCompressionPercentage = new System.Windows.Forms.Label();
            this.btnCanonicalize = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.txtTree = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopyToInput = new System.Windows.Forms.Button();
            this.txtEncodedTree = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBinaryData
            // 
            this.txtBinaryData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBinaryData.Location = new System.Drawing.Point(51, 12);
            this.txtBinaryData.Multiline = true;
            this.txtBinaryData.Name = "txtBinaryData";
            this.txtBinaryData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBinaryData.Size = new System.Drawing.Size(879, 145);
            this.txtBinaryData.TabIndex = 0;
            this.txtBinaryData.Text = "A QUICK BROWN FOX JUMPS RIGHT OVER THE LAZY DOG";
            this.txtBinaryData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBinaryData_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data:";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(51, 195);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(455, 224);
            this.txtResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result:";
            // 
            // btnSimpleEncode
            // 
            this.btnSimpleEncode.Location = new System.Drawing.Point(58, 163);
            this.btnSimpleEncode.Name = "btnSimpleEncode";
            this.btnSimpleEncode.Size = new System.Drawing.Size(107, 23);
            this.btnSimpleEncode.TabIndex = 4;
            this.btnSimpleEncode.Text = "Simple Encode";
            this.btnSimpleEncode.UseVisualStyleBackColor = true;
            this.btnSimpleEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Original Length:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Compressed Length:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compression:";
            // 
            // lblOriginalLength
            // 
            this.lblOriginalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOriginalLength.AutoSize = true;
            this.lblOriginalLength.Location = new System.Drawing.Point(629, 202);
            this.lblOriginalLength.Name = "lblOriginalLength";
            this.lblOriginalLength.Size = new System.Drawing.Size(13, 13);
            this.lblOriginalLength.TabIndex = 9;
            this.lblOriginalLength.Text = "0";
            // 
            // lblCompressedLength
            // 
            this.lblCompressedLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompressedLength.AutoSize = true;
            this.lblCompressedLength.Location = new System.Drawing.Point(629, 228);
            this.lblCompressedLength.Name = "lblCompressedLength";
            this.lblCompressedLength.Size = new System.Drawing.Size(13, 13);
            this.lblCompressedLength.TabIndex = 10;
            this.lblCompressedLength.Text = "0";
            // 
            // lblCompressionPercentage
            // 
            this.lblCompressionPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompressionPercentage.AutoSize = true;
            this.lblCompressionPercentage.Location = new System.Drawing.Point(629, 254);
            this.lblCompressionPercentage.Name = "lblCompressionPercentage";
            this.lblCompressionPercentage.Size = new System.Drawing.Size(21, 13);
            this.lblCompressionPercentage.TabIndex = 11;
            this.lblCompressionPercentage.Text = "0%";
            // 
            // btnCanonicalize
            // 
            this.btnCanonicalize.Location = new System.Drawing.Point(837, 163);
            this.btnCanonicalize.Name = "btnCanonicalize";
            this.btnCanonicalize.Size = new System.Drawing.Size(93, 23);
            this.btnCanonicalize.TabIndex = 12;
            this.btnCanonicalize.Text = "Canonicalize";
            this.btnCanonicalize.UseVisualStyleBackColor = true;
            this.btnCanonicalize.Click += new System.EventHandler(this.btncanonicalize_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Location = new System.Drawing.Point(171, 163);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(172, 23);
            this.btnDecode.TabIndex = 13;
            this.btnDecode.Text = "Simple Decode Using Encoded Tree";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // txtTree
            // 
            this.txtTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTree.Location = new System.Drawing.Point(718, 199);
            this.txtTree.Multiline = true;
            this.txtTree.Name = "txtTree";
            this.txtTree.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTree.Size = new System.Drawing.Size(212, 105);
            this.txtTree.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tree:";
            // 
            // btnCopyToInput
            // 
            this.btnCopyToInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopyToInput.Location = new System.Drawing.Point(396, 425);
            this.btnCopyToInput.Name = "btnCopyToInput";
            this.btnCopyToInput.Size = new System.Drawing.Size(110, 23);
            this.btnCopyToInput.TabIndex = 16;
            this.btnCopyToInput.Text = "Copy To Input";
            this.btnCopyToInput.UseVisualStyleBackColor = true;
            this.btnCopyToInput.Click += new System.EventHandler(this.btnCopyToInput_Click);
            // 
            // txtEncodedTree
            // 
            this.txtEncodedTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEncodedTree.Location = new System.Drawing.Point(718, 310);
            this.txtEncodedTree.Multiline = true;
            this.txtEncodedTree.Name = "txtEncodedTree";
            this.txtEncodedTree.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncodedTree.Size = new System.Drawing.Size(212, 122);
            this.txtEncodedTree.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Encoded Tree:";
            // 
            // frmConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 454);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEncodedTree);
            this.Controls.Add(this.btnCopyToInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTree);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnCanonicalize);
            this.Controls.Add(this.lblCompressionPercentage);
            this.Controls.Add(this.lblCompressedLength);
            this.Controls.Add(this.lblOriginalLength);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSimpleEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBinaryData);
            this.Name = "frmConsole";
            this.Text = "Test Console Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBinaryData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpleEncode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblOriginalLength;
        private System.Windows.Forms.Label lblCompressedLength;
        private System.Windows.Forms.Label lblCompressionPercentage;
        private System.Windows.Forms.Button btnCanonicalize;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtTree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopyToInput;
        private System.Windows.Forms.TextBox txtEncodedTree;
        private System.Windows.Forms.Label label7;
    }
}

