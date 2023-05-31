namespace Saving_ListBox_items
{
    partial class Form1
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnCopyToClip = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(407, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 14);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(389, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(388, 346);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(94, 23);
            this.btnSaveToFile.TabIndex = 2;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // btnCopyToClip
            // 
            this.btnCopyToClip.Location = new System.Drawing.Point(227, 346);
            this.btnCopyToClip.Name = "btnCopyToClip";
            this.btnCopyToClip.Size = new System.Drawing.Size(155, 23);
            this.btnCopyToClip.TabIndex = 3;
            this.btnCopyToClip.Text = "Copy To Clipboard";
            this.btnCopyToClip.UseVisualStyleBackColor = true;
            this.btnCopyToClip.Click += new System.EventHandler(this.btnCopyToClip_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 40);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(470, 303);
            this.listBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnCopyToClip);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnCopyToClip;
        private System.Windows.Forms.ListBox listBox;
    }
}

