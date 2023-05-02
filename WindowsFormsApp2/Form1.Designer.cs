
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_init = new System.Windows.Forms.TextBox();
            this.btn_init = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.Signup = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_login
            // 
            this.txt_login.Location = new System.Drawing.Point(108, 50);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(340, 25);
            this.txt_login.TabIndex = 1;
            // 
            // txt_init
            // 
            this.txt_init.Location = new System.Drawing.Point(108, 148);
            this.txt_init.Name = "txt_init";
            this.txt_init.Size = new System.Drawing.Size(340, 25);
            this.txt_init.TabIndex = 2;
            // 
            // btn_init
            // 
            this.btn_init.Location = new System.Drawing.Point(373, 214);
            this.btn_init.Name = "btn_init";
            this.btn_init.Size = new System.Drawing.Size(75, 23);
            this.btn_init.TabIndex = 4;
            this.btn_init.Text = "Init";
            this.btn_init.UseVisualStyleBackColor = true;
            this.btn_init.Click += new System.EventHandler(this.btn_init_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(108, 214);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(239, 214);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(75, 23);
            this.Signup.TabIndex = 6;
            this.Signup.Text = "Sign up";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(71, 53);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(20, 15);
            this.ID.TabIndex = 7;
            this.ID.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "PW";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 268);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_init);
            this.Controls.Add(this.txt_init);
            this.Controls.Add(this.txt_login);
            this.Name = "Form1";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_init;
        private System.Windows.Forms.Button btn_init;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label2;
    }
}

