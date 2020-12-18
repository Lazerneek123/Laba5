namespace ImitationPolymorphism
{
    partial class ImitationPolymorphismForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImitationPolymorphismForm));
            this.close = new System.Windows.Forms.Button();
            this.collapse = new System.Windows.Forms.Button();
            this.BCircle = new System.Windows.Forms.Button();
            this.BSquare = new System.Windows.Forms.Button();
            this.BRhomb = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.White;
            this.close.BackgroundImage = global::ImitationPolymorphism.Properties.Resources.Закрыть;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Location = new System.Drawing.Point(665, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(23, 23);
            this.close.TabIndex = 7;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // collapse
            // 
            this.collapse.BackColor = System.Drawing.Color.White;
            this.collapse.BackgroundImage = global::ImitationPolymorphism.Properties.Resources.Свернуть;
            this.collapse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collapse.Location = new System.Drawing.Point(636, 12);
            this.collapse.Name = "collapse";
            this.collapse.Size = new System.Drawing.Size(23, 23);
            this.collapse.TabIndex = 8;
            this.collapse.UseVisualStyleBackColor = false;
            this.collapse.Click += new System.EventHandler(this.collapse_Click);
            // 
            // BCircle
            // 
            this.BCircle.BackColor = System.Drawing.Color.Aqua;
            this.BCircle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCircle.Location = new System.Drawing.Point(12, 323);
            this.BCircle.Name = "BCircle";
            this.BCircle.Size = new System.Drawing.Size(147, 65);
            this.BCircle.TabIndex = 9;
            this.BCircle.Text = "Коло";
            this.BCircle.UseVisualStyleBackColor = false;
            this.BCircle.Click += new System.EventHandler(this.BCircle_Click);
            // 
            // BSquare
            // 
            this.BSquare.BackColor = System.Drawing.Color.Red;
            this.BSquare.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSquare.Location = new System.Drawing.Point(275, 323);
            this.BSquare.Name = "BSquare";
            this.BSquare.Size = new System.Drawing.Size(147, 65);
            this.BSquare.TabIndex = 10;
            this.BSquare.Text = "Прямокутник";
            this.BSquare.UseVisualStyleBackColor = false;
            this.BSquare.Click += new System.EventHandler(this.BSquare_Click);
            // 
            // BRhomb
            // 
            this.BRhomb.BackColor = System.Drawing.Color.Yellow;
            this.BRhomb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRhomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BRhomb.Location = new System.Drawing.Point(541, 323);
            this.BRhomb.Name = "BRhomb";
            this.BRhomb.Size = new System.Drawing.Size(147, 65);
            this.BRhomb.TabIndex = 11;
            this.BRhomb.Text = "Ромб";
            this.BRhomb.UseVisualStyleBackColor = false;
            this.BRhomb.Click += new System.EventHandler(this.BRhomb_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 276);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Статус:";
            // 
            // ImitationPolymorphismForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BRhomb);
            this.Controls.Add(this.BSquare);
            this.Controls.Add(this.BCircle);
            this.Controls.Add(this.collapse);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImitationPolymorphismForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImitationPolymorphism";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button collapse;
        private System.Windows.Forms.Button BCircle;
        private System.Windows.Forms.Button BSquare;
        private System.Windows.Forms.Button BRhomb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

