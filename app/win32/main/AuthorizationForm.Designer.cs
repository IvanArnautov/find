
namespace main
{
    partial class AuthorizationForm
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
            this.Login = new System.Windows.Forms.Label();
            this.userid_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userid_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(115, 49);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(187, 31);
            this.Login.TabIndex = 0;
            this.Login.Text = "Authentication";
            // 
            // userid_label
            // 
            this.userid_label.AutoSize = true;
            this.userid_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userid_label.Location = new System.Drawing.Point(42, 107);
            this.userid_label.Name = "userid_label";
            this.userid_label.Size = new System.Drawing.Size(76, 24);
            this.userid_label.TabIndex = 1;
            this.userid_label.Text = ": UserID";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(16, 155);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(102, 24);
            this.password_label.TabIndex = 1;
            this.password_label.Text = ": Password";
            // 
            // userid_textBox
            // 
            this.userid_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userid_textBox.Location = new System.Drawing.Point(115, 102);
            this.userid_textBox.Name = "userid_textBox";
            this.userid_textBox.Size = new System.Drawing.Size(191, 29);
            this.userid_textBox.TabIndex = 1;
            this.userid_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_textBox.Location = new System.Drawing.Point(115, 150);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(191, 29);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.Location = new System.Drawing.Point(115, 80);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(36, 16);
            this.error_label.TabIndex = 4;
            this.error_label.Text = "error";
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_button.Location = new System.Drawing.Point(115, 201);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(191, 40);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit_button.Location = new System.Drawing.Point(330, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(72, 37);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "close";
            this.exit_button.UseVisualStyleBackColor = false;
            this.exit_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.ControlBox = false;
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.userid_textBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.userid_label);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuthorizationForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label userid_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userid_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}