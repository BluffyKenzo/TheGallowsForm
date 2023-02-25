namespace TheGallowsForm
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
            this.button_startGame = new System.Windows.Forms.Button();
            this.button_description = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_startGame
            // 
            this.button_startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_startGame.Location = new System.Drawing.Point(98, 207);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(231, 51);
            this.button_startGame.TabIndex = 0;
            this.button_startGame.Text = "Начать игру";
            this.button_startGame.UseVisualStyleBackColor = true;
            this.button_startGame.Click += new System.EventHandler(this.button_startGame_Click);
            // 
            // button_description
            // 
            this.button_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button_description.Location = new System.Drawing.Point(98, 264);
            this.button_description.Name = "button_description";
            this.button_description.Size = new System.Drawing.Size(231, 51);
            this.button_description.TabIndex = 1;
            this.button_description.Text = "Описание";
            this.button_description.UseVisualStyleBackColor = true;
            this.button_description.Click += new System.EventHandler(this.button_description_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игра Виселица";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_description);
            this.Controls.Add(this.button_startGame);
            this.Name = "Form1";
            this.Text = "Виселица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_startGame;
        private System.Windows.Forms.Button button_description;
        private System.Windows.Forms.Label label1;
    }
}

