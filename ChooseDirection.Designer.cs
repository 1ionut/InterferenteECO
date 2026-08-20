namespace Inteferente_ECO
{
    partial class ChooseDirection
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
            this.Background = new System.Windows.Forms.PictureBox();
            this.RightButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back4;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Background.Location = new System.Drawing.Point(12, 12);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(460, 436);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Background.TabIndex = 11;
            this.Background.TabStop = false;
            // 
            // RightButton
            // 
            this.RightButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.RightButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RightButton.ForeColor = System.Drawing.Color.Coral;
            this.RightButton.Location = new System.Drawing.Point(297, 210);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(156, 30);
            this.RightButton.TabIndex = 15;
            this.RightButton.Text = "Dreapta";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click_1);
            // 
            // LeftButton
            // 
            this.LeftButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.LeftButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeftButton.ForeColor = System.Drawing.Color.Coral;
            this.LeftButton.Location = new System.Drawing.Point(30, 210);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(159, 30);
            this.LeftButton.TabIndex = 14;
            this.LeftButton.Text = "Stanga";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click_1);
            // 
            // DownButton
            // 
            this.DownButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.DownButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownButton.ForeColor = System.Drawing.Color.Coral;
            this.DownButton.Location = new System.Drawing.Point(117, 280);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(235, 30);
            this.DownButton.TabIndex = 13;
            this.DownButton.Text = "Jos";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click_1);
            // 
            // UpButton
            // 
            this.UpButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.UpButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpButton.ForeColor = System.Drawing.Color.Coral;
            this.UpButton.Location = new System.Drawing.Point(117, 139);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(235, 30);
            this.UpButton.TabIndex = 12;
            this.UpButton.Text = "Sus";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click_1);
            // 
            // ChooseDirection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.Background);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseDirection";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ChooseDirection";
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Button UpButton;
    }
}