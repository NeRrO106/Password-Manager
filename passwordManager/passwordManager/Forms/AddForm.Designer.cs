namespace passwordManager
{
    partial class AddForm
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
            this.info1 = new System.Windows.Forms.TextBox();
            this.textSite = new System.Windows.Forms.TextBox();
            this.textInfo2 = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.info3 = new System.Windows.Forms.TextBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // info1
            // 
            this.info1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info1.Cursor = System.Windows.Forms.Cursors.Default;
            this.info1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info1.Location = new System.Drawing.Point(0, 0);
            this.info1.Name = "info1";
            this.info1.ReadOnly = true;
            this.info1.Size = new System.Drawing.Size(242, 21);
            this.info1.TabIndex = 0;
            this.info1.Text = "Site";
            this.info1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textSite
            // 
            this.textSite.Location = new System.Drawing.Point(0, 50);
            this.textSite.Name = "textSite";
            this.textSite.Size = new System.Drawing.Size(242, 22);
            this.textSite.TabIndex = 1;
            // 
            // textInfo2
            // 
            this.textInfo2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInfo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInfo2.Location = new System.Drawing.Point(0, 216);
            this.textInfo2.Name = "textInfo2";
            this.textInfo2.ReadOnly = true;
            this.textInfo2.Size = new System.Drawing.Size(242, 21);
            this.textInfo2.TabIndex = 2;
            this.textInfo2.Text = "Password";
            this.textInfo2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(0, 273);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(242, 22);
            this.textPass.TabIndex = 3;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(30, 320);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(158, 48);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // info3
            // 
            this.info3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info3.Cursor = System.Windows.Forms.Cursors.Default;
            this.info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.Location = new System.Drawing.Point(0, 104);
            this.info3.Name = "info3";
            this.info3.ReadOnly = true;
            this.info3.Size = new System.Drawing.Size(242, 21);
            this.info3.TabIndex = 5;
            this.info3.Text = "User";
            this.info3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(0, 148);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(242, 22);
            this.textUser.TabIndex = 6;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 403);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.info3);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textInfo2);
            this.Controls.Add(this.textSite);
            this.Controls.Add(this.info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox info1;
        private System.Windows.Forms.TextBox textSite;
        private System.Windows.Forms.TextBox textInfo2;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox info3;
        private System.Windows.Forms.TextBox textUser;
    }
}