namespace TheGallowsForm
{
    partial class startGame
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
            this.button_onePlayer = new System.Windows.Forms.Button();
            this.button_twoPlayer = new System.Windows.Forms.Button();
            this.button_description = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите количество игроков";
            // 
            // button_onePlayer
            // 
            this.button_onePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_onePlayer.Location = new System.Drawing.Point(141, 167);
            this.button_onePlayer.Name = "button_onePlayer";
            this.button_onePlayer.Size = new System.Drawing.Size(132, 41);
            this.button_onePlayer.TabIndex = 1;
            this.button_onePlayer.Text = "1 игрок";
            this.button_onePlayer.UseVisualStyleBackColor = true;
            this.button_onePlayer.Click += new System.EventHandler(this.button_onePlayer_Click);
            // 
            // button_twoPlayer
            // 
            this.button_twoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_twoPlayer.Location = new System.Drawing.Point(141, 214);
            this.button_twoPlayer.Name = "button_twoPlayer";
            this.button_twoPlayer.Size = new System.Drawing.Size(132, 41);
            this.button_twoPlayer.TabIndex = 2;
            this.button_twoPlayer.Text = "2 игрока";
            this.button_twoPlayer.UseVisualStyleBackColor = true;
            this.button_twoPlayer.Click += new System.EventHandler(this.button_twoPlayer_Click);
            // 
            // button_description
            // 
            this.button_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_description.Location = new System.Drawing.Point(141, 261);
            this.button_description.Name = "button_description";
            this.button_description.Size = new System.Drawing.Size(132, 41);
            this.button_description.TabIndex = 3;
            this.button_description.Text = "Описание";
            this.button_description.UseVisualStyleBackColor = true;
            this.button_description.Click += new System.EventHandler(this.button_description_Click);
            // 
            // startGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 315);
            this.Controls.Add(this.button_description);
            this.Controls.Add(this.button_twoPlayer);
            this.Controls.Add(this.button_onePlayer);
            this.Controls.Add(this.label1);
            this.Name = "startGame";
            this.Text = "Виселица";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_onePlayer;
        private System.Windows.Forms.Button button_twoPlayer;
        private System.Windows.Forms.Button button_description;
    }
}