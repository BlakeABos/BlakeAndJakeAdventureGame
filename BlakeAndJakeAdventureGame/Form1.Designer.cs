namespace BlakeAndJakeAdventureGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundBox = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.redButton = new System.Windows.Forms.PictureBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.blueButton = new System.Windows.Forms.PictureBox();
            this.blueLabel = new System.Windows.Forms.Label();
            this.yellowButton = new System.Windows.Forms.PictureBox();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.greenBox = new System.Windows.Forms.PictureBox();
            this.greenLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundBox
            // 
            this.backgroundBox.Image = ((System.Drawing.Image)(resources.GetObject("backgroundBox.Image")));
            this.backgroundBox.Location = new System.Drawing.Point(-1, -2);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(604, 442);
            this.backgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundBox.TabIndex = 0;
            this.backgroundBox.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("PT Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(13, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(559, 116);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Hello, Welcome to Blake and Jake\'s Adventure Game , Would you like to start?";
            // 
            // redButton
            // 
            this.redButton.Image = ((System.Drawing.Image)(resources.GetObject("redButton.Image")));
            this.redButton.Location = new System.Drawing.Point(19, 342);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(39, 40);
            this.redButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.redButton.TabIndex = 2;
            this.redButton.TabStop = false;
            // 
            // redLabel
            // 
            this.redLabel.Font = new System.Drawing.Font("PT Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redLabel.Location = new System.Drawing.Point(65, 342);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(95, 40);
            this.redLabel.TabIndex = 3;
            this.redLabel.Text = "Yes";
            // 
            // blueButton
            // 
            this.blueButton.Image = ((System.Drawing.Image)(resources.GetObject("blueButton.Image")));
            this.blueButton.Location = new System.Drawing.Point(19, 391);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(39, 40);
            this.blueButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.blueButton.TabIndex = 4;
            this.blueButton.TabStop = false;
            // 
            // blueLabel
            // 
            this.blueLabel.Font = new System.Drawing.Font("PT Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueLabel.Location = new System.Drawing.Point(64, 391);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(94, 40);
            this.blueLabel.TabIndex = 5;
            this.blueLabel.Text = "No? Why not :(";
            // 
            // yellowButton
            // 
            this.yellowButton.Image = ((System.Drawing.Image)(resources.GetObject("yellowButton.Image")));
            this.yellowButton.Location = new System.Drawing.Point(197, 342);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(39, 40);
            this.yellowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yellowButton.TabIndex = 6;
            this.yellowButton.TabStop = false;
            // 
            // yellowLabel
            // 
            this.yellowLabel.Location = new System.Drawing.Point(242, 342);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(95, 40);
            this.yellowLabel.TabIndex = 7;
            // 
            // greenBox
            // 
            this.greenBox.Image = ((System.Drawing.Image)(resources.GetObject("greenBox.Image")));
            this.greenBox.Location = new System.Drawing.Point(197, 391);
            this.greenBox.Name = "greenBox";
            this.greenBox.Size = new System.Drawing.Size(39, 39);
            this.greenBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.greenBox.TabIndex = 8;
            this.greenBox.TabStop = false;
            // 
            // greenLabel
            // 
            this.greenLabel.Font = new System.Drawing.Font("PT Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenLabel.Location = new System.Drawing.Point(242, 390);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(95, 40);
            this.greenLabel.TabIndex = 9;
            this.greenLabel.Text = "Restart";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 443);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.greenBox);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backgroundBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Blake And Jake\'s Adventure Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backgroundBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox redButton;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.PictureBox blueButton;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.PictureBox yellowButton;
        private System.Windows.Forms.Label yellowLabel;
        private System.Windows.Forms.PictureBox greenBox;
        private System.Windows.Forms.Label greenLabel;
    }
}

