namespace Rysiai_su_klientais
{
    partial class Prisijungimo_langas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prisijungimo_langas));
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.slaptazodzio_ivedimas = new System.Windows.Forms.TextBox();
            this.username_ivedimas = new System.Windows.Forms.TextBox();
            this.prisijungti_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AccessibleName = "prisijungimo_vardas_lbl";
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.username_label.Location = new System.Drawing.Point(38, 30);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(138, 16);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Prisijungimo vardas:";
            // 
            // password_label
            // 
            this.password_label.AccessibleName = "prisijungimo_slaptazodis_lbl";
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.password_label.Location = new System.Drawing.Point(38, 84);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(86, 16);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Slaptažodis:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // slaptazodzio_ivedimas
            // 
            this.slaptazodzio_ivedimas.AccessibleName = "slaptazodzio_ivedimas";
            this.slaptazodzio_ivedimas.Location = new System.Drawing.Point(41, 105);
            this.slaptazodzio_ivedimas.Name = "slaptazodzio_ivedimas";
            this.slaptazodzio_ivedimas.PasswordChar = '*';
            this.slaptazodzio_ivedimas.Size = new System.Drawing.Size(100, 20);
            this.slaptazodzio_ivedimas.TabIndex = 9;
            // 
            // username_ivedimas
            // 
            this.username_ivedimas.AccessibleName = "username_ivedimas";
            this.username_ivedimas.Location = new System.Drawing.Point(41, 61);
            this.username_ivedimas.Name = "username_ivedimas";
            this.username_ivedimas.Size = new System.Drawing.Size(100, 20);
            this.username_ivedimas.TabIndex = 10;
            // 
            // prisijungti_button
            // 
            this.prisijungti_button.AccessibleName = "prisijungti_button";
            this.prisijungti_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prisijungti_button.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.prisijungti_button.Location = new System.Drawing.Point(66, 149);
            this.prisijungti_button.Name = "prisijungti_button";
            this.prisijungti_button.Size = new System.Drawing.Size(75, 23);
            this.prisijungti_button.TabIndex = 11;
            this.prisijungti_button.Text = "Prisijungti";
            this.prisijungti_button.UseVisualStyleBackColor = false;
            // 
            // Prisijungimo_langas
            // 
            this.AccessibleName = "prisijungimo_langas";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(206, 184);
            this.Controls.Add(this.prisijungti_button);
            this.Controls.Add(this.username_ivedimas);
            this.Controls.Add(this.slaptazodzio_ivedimas);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prisijungimo_langas";
            this.Text = "Prisijungimas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox slaptazodzio_ivedimas;
        private System.Windows.Forms.TextBox username_ivedimas;
        private System.Windows.Forms.Button prisijungti_button;
    }
}