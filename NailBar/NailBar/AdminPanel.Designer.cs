namespace NailBar
{
    partial class AdminPanel
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
            this.day_box = new System.Windows.Forms.ComboBox();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.month_box = new System.Windows.Forms.ComboBox();
            this.hours_box = new System.Windows.Forms.ComboBox();
            this.master_name_box = new System.Windows.Forms.ComboBox();
            this.add_master_btn = new System.Windows.Forms.Button();
            this.delete_master_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.master_add_box = new System.Windows.Forms.TextBox();
            this.mast_id_box = new System.Windows.Forms.ComboBox();
            this.prev_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // day_box
            // 
            this.day_box.FormattingEnabled = true;
            this.day_box.Location = new System.Drawing.Point(169, 94);
            this.day_box.Name = "day_box";
            this.day_box.Size = new System.Drawing.Size(47, 21);
            this.day_box.TabIndex = 5;
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.confirm_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirm_btn.Location = new System.Drawing.Point(192, 180);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(89, 34);
            this.confirm_btn.TabIndex = 6;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of the Master :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = " Master free day :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = " Master free hours:";
            // 
            // month_box
            // 
            this.month_box.FormattingEnabled = true;
            this.month_box.Location = new System.Drawing.Point(234, 94);
            this.month_box.Name = "month_box";
            this.month_box.Size = new System.Drawing.Size(47, 21);
            this.month_box.TabIndex = 9;
            // 
            // hours_box
            // 
            this.hours_box.FormattingEnabled = true;
            this.hours_box.Location = new System.Drawing.Point(169, 132);
            this.hours_box.Name = "hours_box";
            this.hours_box.Size = new System.Drawing.Size(112, 21);
            this.hours_box.TabIndex = 10;
            // 
            // master_name_box
            // 
            this.master_name_box.DisplayMember = "Gunay";
            this.master_name_box.FormattingEnabled = true;
            this.master_name_box.Location = new System.Drawing.Point(169, 48);
            this.master_name_box.Name = "master_name_box";
            this.master_name_box.Size = new System.Drawing.Size(112, 21);
            this.master_name_box.TabIndex = 11;
            this.master_name_box.ValueMember = "1";
            this.master_name_box.SelectedIndexChanged += new System.EventHandler(this.master_name_box_SelectedIndexChanged);
            // 
            // add_master_btn
            // 
            this.add_master_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.add_master_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_master_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_master_btn.Location = new System.Drawing.Point(357, 71);
            this.add_master_btn.Name = "add_master_btn";
            this.add_master_btn.Size = new System.Drawing.Size(89, 34);
            this.add_master_btn.TabIndex = 12;
            this.add_master_btn.Text = "Add";
            this.add_master_btn.UseVisualStyleBackColor = false;
            this.add_master_btn.Click += new System.EventHandler(this.add_master_btn_Click);
            // 
            // delete_master_btn
            // 
            this.delete_master_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.delete_master_btn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_master_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_master_btn.Location = new System.Drawing.Point(357, 138);
            this.delete_master_btn.Name = "delete_master_btn";
            this.delete_master_btn.Size = new System.Drawing.Size(89, 34);
            this.delete_master_btn.TabIndex = 13;
            this.delete_master_btn.Text = "Delete";
            this.delete_master_btn.UseVisualStyleBackColor = false;
            this.delete_master_btn.Click += new System.EventHandler(this.delete_master_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Add masters free time";
            // 
            // master_add_box
            // 
            this.master_add_box.Location = new System.Drawing.Point(357, 45);
            this.master_add_box.Name = "master_add_box";
            this.master_add_box.Size = new System.Drawing.Size(184, 20);
            this.master_add_box.TabIndex = 15;
            // 
            // mast_id_box
            // 
            this.mast_id_box.FormattingEnabled = true;
            this.mast_id_box.Location = new System.Drawing.Point(357, 111);
            this.mast_id_box.Name = "mast_id_box";
            this.mast_id_box.Size = new System.Drawing.Size(184, 21);
            this.mast_id_box.TabIndex = 16;
            // 
            // prev_btn
            // 
            this.prev_btn.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.prev_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.prev_btn.Location = new System.Drawing.Point(36, 311);
            this.prev_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(100, 31);
            this.prev_btn.TabIndex = 17;
            this.prev_btn.Text = "Previous";
            this.prev_btn.UseVisualStyleBackColor = false;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NailBar.Properties.Resources.nail_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(607, 355);
            this.Controls.Add(this.prev_btn);
            this.Controls.Add(this.mast_id_box);
            this.Controls.Add(this.master_add_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.delete_master_btn);
            this.Controls.Add(this.add_master_btn);
            this.Controls.Add(this.master_name_box);
            this.Controls.Add(this.hours_box);
            this.Controls.Add(this.month_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.day_box);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox day_box;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox month_box;
        private System.Windows.Forms.ComboBox hours_box;
        private System.Windows.Forms.ComboBox master_name_box;
        private System.Windows.Forms.Button add_master_btn;
        private System.Windows.Forms.Button delete_master_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox master_add_box;
        private System.Windows.Forms.ComboBox mast_id_box;
        private System.Windows.Forms.Button prev_btn;
    }
}