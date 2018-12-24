namespace _1706020012_ThachHuynhDung
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Maphong = new System.Windows.Forms.TextBox();
            this.Tenphong = new System.Windows.Forms.TextBox();
            this.Dongia = new System.Windows.Forms.TextBox();
            this.Sogiuong = new System.Windows.Forms.TextBox();
            this.DgPhong = new System.Windows.Forms.DataGrid();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Lietke = new System.Windows.Forms.Button();
            this.Tinhtong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma phong";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten phong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Don gia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "So giuong";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trang thai";
            // 
            // Maphong
            // 
            this.Maphong.Location = new System.Drawing.Point(88, 42);
            this.Maphong.Name = "Maphong";
            this.Maphong.Size = new System.Drawing.Size(250, 20);
            this.Maphong.TabIndex = 5;
            this.Maphong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Tenphong
            // 
            this.Tenphong.Location = new System.Drawing.Point(88, 76);
            this.Tenphong.Name = "Tenphong";
            this.Tenphong.Size = new System.Drawing.Size(250, 20);
            this.Tenphong.TabIndex = 6;
            // 
            // Dongia
            // 
            this.Dongia.Location = new System.Drawing.Point(88, 109);
            this.Dongia.Name = "Dongia";
            this.Dongia.Size = new System.Drawing.Size(250, 20);
            this.Dongia.TabIndex = 7;
            this.Dongia.TextChanged += new System.EventHandler(this.Dongia_TextChanged);
            // 
            // Sogiuong
            // 
            this.Sogiuong.Location = new System.Drawing.Point(88, 140);
            this.Sogiuong.Name = "Sogiuong";
            this.Sogiuong.Size = new System.Drawing.Size(250, 20);
            this.Sogiuong.TabIndex = 8;
            // 
            // DgPhong
            // 
            this.DgPhong.DataMember = "";
            this.DgPhong.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.DgPhong.Location = new System.Drawing.Point(15, 326);
            this.DgPhong.Name = "DgPhong";
            this.DgPhong.Size = new System.Drawing.Size(517, 80);
            this.DgPhong.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(15, 240);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(118, 240);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 12;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(226, 240);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 23);
            this.Edit.TabIndex = 13;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(336, 240);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 14;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(445, 240);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 15;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(181, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 20);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Phong";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(88, 178);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Phong Trong";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(88, 202);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(73, 17);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "Co Khach";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Lietke
            // 
            this.Lietke.Location = new System.Drawing.Point(15, 278);
            this.Lietke.Name = "Lietke";
            this.Lietke.Size = new System.Drawing.Size(75, 23);
            this.Lietke.TabIndex = 20;
            this.Lietke.Text = "Liet Ke";
            this.Lietke.UseVisualStyleBackColor = true;
            this.Lietke.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tinhtong
            // 
            this.Tinhtong.Location = new System.Drawing.Point(118, 278);
            this.Tinhtong.Name = "Tinhtong";
            this.Tinhtong.Size = new System.Drawing.Size(75, 23);
            this.Tinhtong.TabIndex = 21;
            this.Tinhtong.Text = "Tinh Tong";
            this.Tinhtong.UseVisualStyleBackColor = true;
            this.Tinhtong.Click += new System.EventHandler(this.Tinhtong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tinhtong);
            this.Controls.Add(this.Lietke);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.DgPhong);
            this.Controls.Add(this.Sogiuong);
            this.Controls.Add(this.Dongia);
            this.Controls.Add(this.Tenphong);
            this.Controls.Add(this.Maphong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DgPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Maphong;
        private System.Windows.Forms.TextBox Tenphong;
        private System.Windows.Forms.TextBox Dongia;
        private System.Windows.Forms.TextBox Sogiuong;
        private System.Windows.Forms.DataGrid DgPhong;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button Lietke;
        private System.Windows.Forms.Button Tinhtong;
    }
}

