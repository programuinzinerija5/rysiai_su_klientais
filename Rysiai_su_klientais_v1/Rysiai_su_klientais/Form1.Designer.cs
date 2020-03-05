namespace Rysiai_su_klientais
{
    partial class pradinis_langas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pradinis_langas));
            this.prisijungimas_button = new System.Windows.Forms.Button();
            this.registracija_button = new System.Windows.Forms.Button();
            this.neturi_label = new System.Windows.Forms.Label();
            this.turi_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // prisijungimas_button
            // 
            this.prisijungimas_button.AccessibleName = "prisijungimas_button";
            this.prisijungimas_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prisijungimas_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.prisijungimas_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.prisijungimas_button.Location = new System.Drawing.Point(191, 67);
            this.prisijungimas_button.Name = "prisijungimas_button";
            this.prisijungimas_button.Size = new System.Drawing.Size(92, 23);
            this.prisijungimas_button.TabIndex = 0;
            this.prisijungimas_button.Text = "Prisijungimas";
            this.prisijungimas_button.UseVisualStyleBackColor = false;
            this.prisijungimas_button.Click += new System.EventHandler(this.prisijungimas_button_Click);
            // 
            // registracija_button
            // 
            this.registracija_button.AccessibleName = "registracija_button";
            this.registracija_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registracija_button.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.registracija_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.registracija_button.Location = new System.Drawing.Point(191, 30);
            this.registracija_button.Name = "registracija_button";
            this.registracija_button.Size = new System.Drawing.Size(92, 23);
            this.registracija_button.TabIndex = 1;
            this.registracija_button.Text = "Registracija";
            this.registracija_button.UseVisualStyleBackColor = false;
            this.registracija_button.Click += new System.EventHandler(this.registracija_button_Click);
            // 
            // neturi_label
            // 
            this.neturi_label.AccessibleName = "naujas_vartotojas_lbl";
            this.neturi_label.AutoSize = true;
            this.neturi_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.neturi_label.Location = new System.Drawing.Point(37, 33);
            this.neturi_label.Name = "neturi_label";
            this.neturi_label.Size = new System.Drawing.Size(143, 16);
            this.neturi_label.TabIndex = 2;
            this.neturi_label.Text = "Jei neturite paskyros:";
            // 
            // turi_label
            // 
            this.turi_label.AccessibleName = "registruojas_vartotojas_lbl";
            this.turi_label.AutoSize = true;
            this.turi_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.turi_label.Location = new System.Drawing.Point(37, 70);
            this.turi_label.Name = "turi_label";
            this.turi_label.Size = new System.Drawing.Size(121, 16);
            this.turi_label.TabIndex = 3;
            this.turi_label.Text = "Jei turite paskyrą:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pradinis_langas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(295, 139);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.turi_label);
            this.Controls.Add(this.neturi_label);
            this.Controls.Add(this.registracija_button);
            this.Controls.Add(this.prisijungimas_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pradinis_langas";
            this.Text = "Ryšių su klientais valdymas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prisijungimas_button;
        private System.Windows.Forms.Button registracija_button;
        private System.Windows.Forms.Label neturi_label;
        private System.Windows.Forms.Label turi_label;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

