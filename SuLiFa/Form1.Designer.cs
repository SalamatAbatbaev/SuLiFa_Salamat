namespace SuLiFa
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Player_Box = new System.Windows.Forms.PictureBox();
            this.Comp_Box = new System.Windows.Forms.PictureBox();
            this.btn_бумага = new System.Windows.Forms.Button();
            this.btn_ножницы = new System.Windows.Forms.Button();
            this.btn_камень = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comp_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(2, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = " Kampyuterdin\' bali";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sizdin\' balin\'iz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(423, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kampyuter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Player_Box
            // 
            this.Player_Box.BackgroundImage = global::SuLiFa.Properties.Resources._1659860797_29_funart_pro_p_fon_s_voprositelnimi_znakami_krasivo_30;
            this.Player_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player_Box.Location = new System.Drawing.Point(626, 24);
            this.Player_Box.Name = "Player_Box";
            this.Player_Box.Size = new System.Drawing.Size(115, 100);
            this.Player_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_Box.TabIndex = 14;
            this.Player_Box.TabStop = false;
            // 
            // Comp_Box
            // 
            this.Comp_Box.BackgroundImage = global::SuLiFa.Properties.Resources._1661927971_j_371;
            this.Comp_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Comp_Box.Location = new System.Drawing.Point(417, 24);
            this.Comp_Box.Name = "Comp_Box";
            this.Comp_Box.Size = new System.Drawing.Size(115, 100);
            this.Comp_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Comp_Box.TabIndex = 13;
            this.Comp_Box.TabStop = false;
            this.Comp_Box.Click += new System.EventHandler(this.Comp_Box_Click);
            // 
            // btn_бумага
            // 
            this.btn_бумага.BackColor = System.Drawing.Color.Lime;
            this.btn_бумага.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_бумага.Location = new System.Drawing.Point(647, 330);
            this.btn_бумага.Name = "btn_бумага";
            this.btn_бумага.Size = new System.Drawing.Size(124, 43);
            this.btn_бумага.TabIndex = 12;
            this.btn_бумага.Tag = "Б";
            this.btn_бумага.Text = "Qag\'az";
            this.btn_бумага.UseVisualStyleBackColor = false;
            this.btn_бумага.Click += new System.EventHandler(this.btn_камень_Click);
            // 
            // btn_ножницы
            // 
            this.btn_ножницы.BackColor = System.Drawing.Color.Lime;
            this.btn_ножницы.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ножницы.Location = new System.Drawing.Point(457, 295);
            this.btn_ножницы.Name = "btn_ножницы";
            this.btn_ножницы.Size = new System.Drawing.Size(124, 43);
            this.btn_ножницы.TabIndex = 11;
            this.btn_ножницы.Tag = "Н";
            this.btn_ножницы.Text = "Qayshi";
            this.btn_ножницы.UseVisualStyleBackColor = false;
            this.btn_ножницы.Click += new System.EventHandler(this.btn_камень_Click);
            // 
            // btn_камень
            // 
            this.btn_камень.BackColor = System.Drawing.Color.Lime;
            this.btn_камень.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_камень.Location = new System.Drawing.Point(270, 330);
            this.btn_камень.Name = "btn_камень";
            this.btn_камень.Size = new System.Drawing.Size(124, 43);
            this.btn_камень.TabIndex = 10;
            this.btn_камень.Tag = "К";
            this.btn_камень.Text = "Tas";
            this.btn_камень.UseVisualStyleBackColor = false;
            this.btn_камень.Click += new System.EventHandler(this.btn_камень_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(675, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Siz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(64, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 19;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuLiFa.Properties.Resources._1612765065_4_p_fon_goluboi_gorod_4;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Player_Box);
            this.Controls.Add(this.Comp_Box);
            this.Controls.Add(this.btn_бумага);
            this.Controls.Add(this.btn_ножницы);
            this.Controls.Add(this.btn_камень);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Comp_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Player_Box;
        private System.Windows.Forms.PictureBox Comp_Box;
        private System.Windows.Forms.Button btn_бумага;
        private System.Windows.Forms.Button btn_ножницы;
        private System.Windows.Forms.Button btn_камень;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}

