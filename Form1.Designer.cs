namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonCopyPassword = new System.Windows.Forms.Button();
            this.labelPasswordLength = new System.Windows.Forms.Label();
            this.trackBarPasswordLength = new System.Windows.Forms.TrackBar();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPassword.Location = new System.Drawing.Point(52, 65);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(706, 56);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCopyPassword
            // 
            this.buttonCopyPassword.BackColor = System.Drawing.Color.Purple;
            this.buttonCopyPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCopyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonCopyPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCopyPassword.Location = new System.Drawing.Point(129, 146);
            this.buttonCopyPassword.Name = "buttonCopyPassword";
            this.buttonCopyPassword.Size = new System.Drawing.Size(524, 56);
            this.buttonCopyPassword.TabIndex = 1;
            this.buttonCopyPassword.Text = "Copy Password";
            this.buttonCopyPassword.UseVisualStyleBackColor = false;
            this.buttonCopyPassword.Click += new System.EventHandler(this.buttonCopyPassword_Click);
            // 
            // labelPasswordLength
            // 
            this.labelPasswordLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelPasswordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelPasswordLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelPasswordLength.Location = new System.Drawing.Point(122, 205);
            this.labelPasswordLength.Name = "labelPasswordLength";
            this.labelPasswordLength.Size = new System.Drawing.Size(531, 56);
            this.labelPasswordLength.TabIndex = 2;
            this.labelPasswordLength.Text = "Password Length: 5";
            this.labelPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarPasswordLength
            // 
            this.trackBarPasswordLength.Location = new System.Drawing.Point(129, 303);
            this.trackBarPasswordLength.Name = "trackBarPasswordLength";
            this.trackBarPasswordLength.Size = new System.Drawing.Size(524, 45);
            this.trackBarPasswordLength.TabIndex = 3;
            this.trackBarPasswordLength.Scroll += new System.EventHandler(this.trackBarPasswordLength_Scroll);
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.BackColor = System.Drawing.Color.Purple;
            this.buttonGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGeneratePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.buttonGeneratePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonGeneratePassword.Location = new System.Drawing.Point(129, 354);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(524, 56);
            this.buttonGeneratePassword.TabIndex = 4;
            this.buttonGeneratePassword.Text = "Generate Password";
            this.buttonGeneratePassword.UseVisualStyleBackColor = false;
            this.buttonGeneratePassword.Click += new System.EventHandler(this.buttonGeneratePassword_Click);
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGeneratePassword);
            this.Controls.Add(this.trackBarPasswordLength);
            this.Controls.Add(this.labelPasswordLength);
            this.Controls.Add(this.buttonCopyPassword);
            this.Controls.Add(this.labelPassword);
            this.Name = "PasswordGenerator";
            this.Text = "PasswordGenerator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonCopyPassword;
        private System.Windows.Forms.Label labelPasswordLength;
        private System.Windows.Forms.TrackBar trackBarPasswordLength;
        private System.Windows.Forms.Button buttonGeneratePassword;
    }
}

