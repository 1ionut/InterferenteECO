namespace Inteferente_ECO
{
    partial class Root
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
            this.components = new System.ComponentModel.Container();
            this.MainPictureBox = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.PlasticLabel = new System.Windows.Forms.Label();
            this.PaperLabel = new System.Windows.Forms.Label();
            this.BottleLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.RotateDeflectorButton = new System.Windows.Forms.Button();
            this.DeflectorPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadmapButton = new System.Windows.Forms.Button();
            this.GridCheckbox = new System.Windows.Forms.CheckBox();
            this.Updater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).BeginInit();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPictureBox
            // 
            this.MainPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPictureBox.Image = global::Inteferente_ECO.Properties.Resources.Back4;
            this.MainPictureBox.Location = new System.Drawing.Point(13, 13);
            this.MainPictureBox.Name = "MainPictureBox";
            this.MainPictureBox.Size = new System.Drawing.Size(400, 800);
            this.MainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainPictureBox.TabIndex = 0;
            this.MainPictureBox.TabStop = false;
            this.MainPictureBox.Click += new System.EventHandler(this.MainPictureBox_Click);
            this.MainPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPictureBox_Paint);
            this.MainPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPictureBox_MouseMove);
            // 
            // SidePanel
            // 
            this.SidePanel.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Wood2;
            this.SidePanel.Controls.Add(this.PlasticLabel);
            this.SidePanel.Controls.Add(this.PaperLabel);
            this.SidePanel.Controls.Add(this.BottleLabel);
            this.SidePanel.Controls.Add(this.ClearButton);
            this.SidePanel.Controls.Add(this.RotateDeflectorButton);
            this.SidePanel.Controls.Add(this.DeflectorPanel);
            this.SidePanel.Controls.Add(this.StartButton);
            this.SidePanel.Controls.Add(this.LoadmapButton);
            this.SidePanel.Controls.Add(this.GridCheckbox);
            this.SidePanel.Location = new System.Drawing.Point(425, 13);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(250, 800);
            this.SidePanel.TabIndex = 1;
            // 
            // PlasticLabel
            // 
            this.PlasticLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlasticLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.PlasticLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PlasticLabel.Location = new System.Drawing.Point(8, 389);
            this.PlasticLabel.Name = "PlasticLabel";
            this.PlasticLabel.Size = new System.Drawing.Size(234, 23);
            this.PlasticLabel.TabIndex = 8;
            this.PlasticLabel.Text = "Plastic - 0";
            this.PlasticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaperLabel
            // 
            this.PaperLabel.BackColor = System.Drawing.Color.Transparent;
            this.PaperLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.PaperLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.PaperLabel.Location = new System.Drawing.Point(8, 356);
            this.PaperLabel.Name = "PaperLabel";
            this.PaperLabel.Size = new System.Drawing.Size(234, 23);
            this.PaperLabel.TabIndex = 7;
            this.PaperLabel.Text = "Hartie - 0";
            this.PaperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BottleLabel
            // 
            this.BottleLabel.BackColor = System.Drawing.Color.Transparent;
            this.BottleLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.BottleLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.BottleLabel.Location = new System.Drawing.Point(9, 323);
            this.BottleLabel.Name = "BottleLabel";
            this.BottleLabel.Size = new System.Drawing.Size(234, 23);
            this.BottleLabel.TabIndex = 6;
            this.BottleLabel.Text = "Sticla - 0";
            this.BottleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.ClearButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Coral;
            this.ClearButton.Location = new System.Drawing.Point(8, 271);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(235, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Curata Tot";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // RotateDeflectorButton
            // 
            this.RotateDeflectorButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.RotateDeflectorButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateDeflectorButton.ForeColor = System.Drawing.Color.Coral;
            this.RotateDeflectorButton.Location = new System.Drawing.Point(8, 234);
            this.RotateDeflectorButton.Name = "RotateDeflectorButton";
            this.RotateDeflectorButton.Size = new System.Drawing.Size(235, 30);
            this.RotateDeflectorButton.TabIndex = 4;
            this.RotateDeflectorButton.Text = "Roteste Deflector";
            this.RotateDeflectorButton.UseVisualStyleBackColor = true;
            this.RotateDeflectorButton.Click += new System.EventHandler(this.RotateDeflectorButton_Click);
            // 
            // DeflectorPanel
            // 
            this.DeflectorPanel.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back1;
            this.DeflectorPanel.Location = new System.Drawing.Point(70, 95);
            this.DeflectorPanel.Name = "DeflectorPanel";
            this.DeflectorPanel.Size = new System.Drawing.Size(120, 120);
            this.DeflectorPanel.TabIndex = 3;
            this.DeflectorPanel.Click += new System.EventHandler(this.DeflectorPanel_Click);
            this.DeflectorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DeflectorPanel_Paint);
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.StartButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Coral;
            this.StartButton.Location = new System.Drawing.Point(8, 433);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(235, 30);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LoadmapButton
            // 
            this.LoadmapButton.BackgroundImage = global::Inteferente_ECO.Properties.Resources.Back3;
            this.LoadmapButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadmapButton.ForeColor = System.Drawing.Color.Coral;
            this.LoadmapButton.Location = new System.Drawing.Point(9, 53);
            this.LoadmapButton.Name = "LoadmapButton";
            this.LoadmapButton.Size = new System.Drawing.Size(235, 30);
            this.LoadmapButton.TabIndex = 1;
            this.LoadmapButton.Text = "Incarca Harta";
            this.LoadmapButton.UseVisualStyleBackColor = true;
            this.LoadmapButton.Click += new System.EventHandler(this.LoadmapButton_Click);
            // 
            // GridCheckbox
            // 
            this.GridCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.GridCheckbox.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridCheckbox.ForeColor = System.Drawing.Color.Coral;
            this.GridCheckbox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GridCheckbox.Location = new System.Drawing.Point(9, 11);
            this.GridCheckbox.Name = "GridCheckbox";
            this.GridCheckbox.Size = new System.Drawing.Size(235, 24);
            this.GridCheckbox.TabIndex = 0;
            this.GridCheckbox.Text = "Hide/Show Grid";
            this.GridCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GridCheckbox.UseVisualStyleBackColor = false;
            // 
            // Updater
            // 
            this.Updater.Enabled = true;
            this.Updater.Interval = 250;
            this.Updater.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Root
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 828);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.MainPictureBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Root";
            this.Text = "InterferenteECO - Ionut";
            this.Load += new System.EventHandler(this.Root_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainPictureBox)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPictureBox;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.CheckBox GridCheckbox;
        private System.Windows.Forms.Timer Updater;
        private System.Windows.Forms.Button LoadmapButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button RotateDeflectorButton;
        private System.Windows.Forms.Panel DeflectorPanel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label PlasticLabel;
        private System.Windows.Forms.Label PaperLabel;
        private System.Windows.Forms.Label BottleLabel;
    }
}

