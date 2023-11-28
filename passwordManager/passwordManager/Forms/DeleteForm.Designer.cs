namespace passwordManager
{
    partial class DeleteForm
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
            this.infoText = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.transferBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoText
            // 
            this.infoText.Cursor = System.Windows.Forms.Cursors.Default;
            this.infoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoText.Location = new System.Drawing.Point(-1, 45);
            this.infoText.Name = "infoText";
            this.infoText.ReadOnly = true;
            this.infoText.Size = new System.Drawing.Size(224, 28);
            this.infoText.TabIndex = 0;
            this.infoText.Text = "Enter ID";
            this.infoText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // idTxt
            // 
            this.idTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(-1, 167);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(224, 28);
            this.idTxt.TabIndex = 1;
            this.idTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transferBtn
            // 
            this.transferBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferBtn.Location = new System.Drawing.Point(36, 242);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(128, 59);
            this.transferBtn.TabIndex = 2;
            this.transferBtn.Text = "Transfer";
            this.transferBtn.UseVisualStyleBackColor = true;
            this.transferBtn.Click += new System.EventHandler(this.transferBtn_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 356);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.infoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.Load += new System.EventHandler(this.DeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoText;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button transferBtn;
    }
}