namespace NailBar
{
    partial class client_form
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.choose_mast = new System.Windows.Forms.ComboBox();
            this.choose_month = new System.Windows.Forms.ComboBox();
            this.choose_day = new System.Windows.Forms.ComboBox();
            this.choose_hour = new System.Windows.Forms.ComboBox();
            this.choose_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Choose free Hours  :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Month :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose Day  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose Master  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Magneto", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(-1, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(690, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Please enter details for entry in the Nail Bar";
            // 
            // choose_mast
            // 
            this.choose_mast.FormattingEnabled = true;
            this.choose_mast.Location = new System.Drawing.Point(204, 118);
            this.choose_mast.Name = "choose_mast";
            this.choose_mast.Size = new System.Drawing.Size(149, 21);
            this.choose_mast.TabIndex = 15;
            this.choose_mast.SelectedIndexChanged += new System.EventHandler(this.choose_mast_SelectedIndexChanged);
            // 
            // choose_month
            // 
            this.choose_month.FormattingEnabled = true;
            this.choose_month.Location = new System.Drawing.Point(204, 163);
            this.choose_month.Name = "choose_month";
            this.choose_month.Size = new System.Drawing.Size(149, 21);
            this.choose_month.TabIndex = 16;
            this.choose_month.SelectedIndexChanged += new System.EventHandler(this.choose_month_SelectedIndexChanged);
            // 
            // choose_day
            // 
            this.choose_day.FormattingEnabled = true;
            this.choose_day.Location = new System.Drawing.Point(204, 210);
            this.choose_day.Name = "choose_day";
            this.choose_day.Size = new System.Drawing.Size(149, 21);
            this.choose_day.TabIndex = 17;
            this.choose_day.SelectedIndexChanged += new System.EventHandler(this.choose_day_SelectedIndexChanged);
            // 
            // choose_hour
            // 
            this.choose_hour.FormattingEnabled = true;
            this.choose_hour.Location = new System.Drawing.Point(204, 252);
            this.choose_hour.Name = "choose_hour";
            this.choose_hour.Size = new System.Drawing.Size(149, 21);
            this.choose_hour.TabIndex = 18;
            // 
            // choose_confirm
            // 
            this.choose_confirm.BackColor = System.Drawing.Color.White;
            this.choose_confirm.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_confirm.ForeColor = System.Drawing.Color.DodgerBlue;
            this.choose_confirm.Location = new System.Drawing.Point(498, 338);
            this.choose_confirm.Name = "choose_confirm";
            this.choose_confirm.Size = new System.Drawing.Size(161, 40);
            this.choose_confirm.TabIndex = 19;
            this.choose_confirm.Text = "Confirm";
            this.choose_confirm.UseVisualStyleBackColor = false;
            this.choose_confirm.Click += new System.EventHandler(this.choose_confirm_Click);
            // 
            // client_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::NailBar.Properties.Resources.nail_6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 393);
            this.Controls.Add(this.choose_confirm);
            this.Controls.Add(this.choose_hour);
            this.Controls.Add(this.choose_day);
            this.Controls.Add(this.choose_month);
            this.Controls.Add(this.choose_mast);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "client_form";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.choose_confirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox choose_mast;
        private System.Windows.Forms.ComboBox choose_month;
        private System.Windows.Forms.ComboBox choose_day;
        private System.Windows.Forms.ComboBox choose_hour;
        private System.Windows.Forms.Button choose_confirm;
    }
}