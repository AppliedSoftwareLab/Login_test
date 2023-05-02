
namespace WindowsFormsApp2
{
    partial class Signup
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
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.txt_init = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.SignupButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "PW";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(51, 49);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 15);
            this.ID.TabIndex = 11;
            this.ID.Text = "ID";
            // 
            // txt_init
            // 
            this.txt_init.Location = new System.Drawing.Point(88, 144);
            this.txt_init.Name = "txt_init";
            this.txt_init.Size = new System.Drawing.Size(340, 25);
            this.txt_init.TabIndex = 10;
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(88, 46);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(340, 25);
            this.txt_login.TabIndex = 9;
            // 
            // SignupButton
            // 
            this.SignupButton.Location = new System.Drawing.Point(192, 215);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Size = new System.Drawing.Size(75, 23);
            this.SignupButton.TabIndex = 13;
            this.SignupButton.Text = "Signup";
            this.SignupButton.UseVisualStyleBackColor = true;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 246);
            this.Controls.Add(this.SignupButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_init);
            this.Controls.Add(this.txt_login);
            this.Name = "Signup";
            this.Text = "Sign  up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox txt_init;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Button SignupButton;
    }
}