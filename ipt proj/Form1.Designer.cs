namespace ipt_proj
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
            this.u_fName = new System.Windows.Forms.TextBox();
            this.u_lName = new System.Windows.Forms.TextBox();
            this.u_pNo = new System.Windows.Forms.TextBox();
            this.Phonebook = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.u_Search = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Phonebook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lastname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone NO.";
            // 
            // u_fName
            // 
            this.u_fName.Location = new System.Drawing.Point(126, 149);
            this.u_fName.Name = "u_fName";
            this.u_fName.Size = new System.Drawing.Size(197, 20);
            this.u_fName.TabIndex = 3;
            // 
            // u_lName
            // 
            this.u_lName.Location = new System.Drawing.Point(126, 198);
            this.u_lName.Name = "u_lName";
            this.u_lName.Size = new System.Drawing.Size(197, 20);
            this.u_lName.TabIndex = 4;
            // 
            // u_pNo
            // 
            this.u_pNo.Location = new System.Drawing.Point(126, 250);
            this.u_pNo.Name = "u_pNo";
            this.u_pNo.Size = new System.Drawing.Size(197, 20);
            this.u_pNo.TabIndex = 5;
            this.u_pNo.TextChanged += new System.EventHandler(this.u_pNo_TextChanged);
            // 
            // Phonebook
            // 
            this.Phonebook.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Phonebook.Controls.Add(this.pictureBox2);
            this.Phonebook.Controls.Add(this.label5);
            this.Phonebook.Controls.Add(this.button3);
            this.Phonebook.Controls.Add(this.button2);
            this.Phonebook.Controls.Add(this.button1);
            this.Phonebook.Controls.Add(this.label2);
            this.Phonebook.Controls.Add(this.label3);
            this.Phonebook.Controls.Add(this.u_pNo);
            this.Phonebook.Controls.Add(this.u_fName);
            this.Phonebook.Controls.Add(this.u_lName);
            this.Phonebook.Controls.Add(this.label1);
            this.Phonebook.Location = new System.Drawing.Point(-2, -1);
            this.Phonebook.Name = "Phonebook";
            this.Phonebook.Size = new System.Drawing.Size(557, 437);
            this.Phonebook.TabIndex = 6;
            this.Phonebook.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(377, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 247);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 40);
            this.label5.TabIndex = 10;
            this.label5.Text = "PHONE BOOK";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Search";
            // 
            // u_Search
            // 
            this.u_Search.Location = new System.Drawing.Point(61, 13);
            this.u_Search.Name = "u_Search";
            this.u_Search.Size = new System.Drawing.Size(178, 20);
            this.u_Search.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox2.Controls.Add(this.u_Search);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(553, -1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 437);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ipt_proj.Properties.Resources.phone;
            this.pictureBox2.Location = new System.Drawing.Point(361, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 103);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 432);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Phonebook);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "phonebook";
            this.Phonebook.ResumeLayout(false);
            this.Phonebook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox u_fName;
        private System.Windows.Forms.TextBox u_lName;
        private System.Windows.Forms.TextBox u_pNo;
        private System.Windows.Forms.GroupBox Phonebook;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox u_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

