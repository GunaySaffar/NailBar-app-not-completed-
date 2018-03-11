namespace NailBar
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.log_user = new System.Windows.Forms.TextBox();
            this.log_pass = new System.Windows.Forms.TextBox();
            this.signin_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.registr_btn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(24, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poor Richard", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(29, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // log_user
            // 
            this.log_user.Location = new System.Drawing.Point(149, 98);
            this.log_user.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.log_user.Name = "log_user";
            this.log_user.Size = new System.Drawing.Size(100, 21);
            this.log_user.TabIndex = 2;
            // 
            // log_pass
            // 
            this.log_pass.Location = new System.Drawing.Point(149, 156);
            this.log_pass.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.log_pass.Name = "log_pass";
            this.log_pass.Size = new System.Drawing.Size(100, 21);
            this.log_pass.TabIndex = 3;
            // 
            // signin_btn
            // 
            this.signin_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.signin_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signin_btn.Location = new System.Drawing.Point(149, 225);
            this.signin_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.signin_btn.Name = "signin_btn";
            this.signin_btn.Size = new System.Drawing.Size(100, 43);
            this.signin_btn.TabIndex = 4;
            this.signin_btn.Text = "Sign In";
            this.signin_btn.UseVisualStyleBackColor = false;
            this.signin_btn.Click += new System.EventHandler(this.signin_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(70, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome to our Nail Bar!";
            // 
            // registr_btn
            // 
            this.registr_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.registr_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registr_btn.Location = new System.Drawing.Point(32, 225);
            this.registr_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.registr_btn.Name = "registr_btn";
            this.registr_btn.Size = new System.Drawing.Size(100, 43);
            this.registr_btn.TabIndex = 6;
            this.registr_btn.Text = "Registr";
            this.registr_btn.UseVisualStyleBackColor = false;
            this.registr_btn.Click += new System.EventHandler(this.registr_btn_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.BackColor = System.Drawing.Color.Transparent;
            this.error_label.ForeColor = System.Drawing.Color.Maroon;
            this.error_label.Location = new System.Drawing.Point(146, 181);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 16);
            this.error_label.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NailBar.Properties.Resources.nail_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(548, 335);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.registr_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.signin_btn);
            this.Controls.Add(this.log_pass);
            this.Controls.Add(this.log_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox log_user;
        private System.Windows.Forms.TextBox log_pass;
        private System.Windows.Forms.Button signin_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button registr_btn;
        private System.Windows.Forms.Label error_label;
    }
}

