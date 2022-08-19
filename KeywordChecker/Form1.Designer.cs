namespace KeywordChecker
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.txtToCheck = new System.Windows.Forms.TextBox();
            this.txtAvoid = new System.Windows.Forms.TextBox();
            this.txtMatch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKeywords = new System.Windows.Forms.Label();
            this.lblMatches = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToCheck
            // 
            this.txtToCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtToCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToCheck.Location = new System.Drawing.Point(12, 32);
            this.txtToCheck.Multiline = true;
            this.txtToCheck.Name = "txtToCheck";
            this.txtToCheck.Size = new System.Drawing.Size(563, 98);
            this.txtToCheck.TabIndex = 0;
            this.txtToCheck.TextChanged += new System.EventHandler(this.txtToCheck_TextChanged);
            // 
            // txtAvoid
            // 
            this.txtAvoid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAvoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtAvoid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAvoid.Location = new System.Drawing.Point(12, 198);
            this.txtAvoid.Multiline = true;
            this.txtAvoid.Name = "txtAvoid";
            this.txtAvoid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAvoid.Size = new System.Drawing.Size(191, 228);
            this.txtAvoid.TabIndex = 1;
            this.txtAvoid.WordWrap = false;
            this.txtAvoid.TextChanged += new System.EventHandler(this.txtAvoid_TextChanged);
            // 
            // txtMatch
            // 
            this.txtMatch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatch.Location = new System.Drawing.Point(384, 198);
            this.txtMatch.Multiline = true;
            this.txtMatch.Name = "txtMatch";
            this.txtMatch.ReadOnly = true;
            this.txtMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatch.Size = new System.Drawing.Size(191, 228);
            this.txtMatch.TabIndex = 2;
            this.txtMatch.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Paste your text here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Keywords to Avoid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(404, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Keywords Present";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(264, 198);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Result";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKeywords
            // 
            this.lblKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblKeywords.AutoSize = true;
            this.lblKeywords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKeywords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeywords.ForeColor = System.Drawing.Color.Black;
            this.lblKeywords.Location = new System.Drawing.Point(92, 175);
            this.lblKeywords.Name = "lblKeywords";
            this.lblKeywords.Size = new System.Drawing.Size(19, 20);
            this.lblKeywords.TabIndex = 8;
            this.lblKeywords.Text = "0";
            this.lblKeywords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMatches
            // 
            this.lblMatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMatches.AutoSize = true;
            this.lblMatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatches.ForeColor = System.Drawing.Color.Black;
            this.lblMatches.Location = new System.Drawing.Point(472, 175);
            this.lblMatches.Name = "lblMatches";
            this.lblMatches.Size = new System.Drawing.Size(19, 20);
            this.lblMatches.TabIndex = 9;
            this.lblMatches.Text = "0";
            this.lblMatches.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(580, 438);
            this.Controls.Add(this.lblMatches);
            this.Controls.Add(this.lblKeywords);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatch);
            this.Controls.Add(this.txtAvoid);
            this.Controls.Add(this.txtToCheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyword Checker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtToCheck;
        public System.Windows.Forms.TextBox txtAvoid;
        public System.Windows.Forms.TextBox txtMatch;
        public System.Windows.Forms.Label lblKeywords;
        public System.Windows.Forms.Label lblMatches;
    }
}

