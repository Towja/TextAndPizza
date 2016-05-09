namespace TextAndPizza
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DialogueBox = new System.Windows.Forms.TextBox();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.CompassBox = new System.Windows.Forms.PictureBox();
            this.CompassLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CompassBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DialogueBox
            // 
            this.DialogueBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DialogueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DialogueBox.Location = new System.Drawing.Point(12, 12);
            this.DialogueBox.Multiline = true;
            this.DialogueBox.Name = "DialogueBox";
            this.DialogueBox.ReadOnly = true;
            this.DialogueBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DialogueBox.Size = new System.Drawing.Size(499, 374);
            this.DialogueBox.TabIndex = 0;
            this.DialogueBox.TextChanged += new System.EventHandler(this.DialogueBox_TextChanged);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.Location = new System.Drawing.Point(12, 393);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(415, 20);
            this.InputBox.TabIndex = 1;
            this.InputBox.TextChanged += new System.EventHandler(this.PlaceHolderCompass_Click);
            this.InputBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Location = new System.Drawing.Point(433, 392);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(78, 23);
            this.InputButton.TabIndex = 2;
            this.InputButton.Text = "Send";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            this.InputButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputBox_KeyDown);
            // 
            // CompassBox
            // 
            this.CompassBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompassBox.Image = ((System.Drawing.Image)(resources.GetObject("CompassBox.Image")));
            this.CompassBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("CompassBox.InitialImage")));
            this.CompassBox.Location = new System.Drawing.Point(517, 107);
            this.CompassBox.Name = "CompassBox";
            this.CompassBox.Size = new System.Drawing.Size(185, 185);
            this.CompassBox.TabIndex = 3;
            this.CompassBox.TabStop = false;
            this.CompassBox.Click += new System.EventHandler(this.CompassBox_Click);
            // 
            // CompassLabel
            // 
            this.CompassLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CompassLabel.AutoSize = true;
            this.CompassLabel.Location = new System.Drawing.Point(584, 91);
            this.CompassLabel.Name = "CompassLabel";
            this.CompassLabel.Size = new System.Drawing.Size(50, 13);
            this.CompassLabel.TabIndex = 4;
            this.CompassLabel.Text = "Compass";
            this.CompassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 424);
            this.Controls.Add(this.CompassLabel);
            this.Controls.Add(this.CompassBox);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.DialogueBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text & Pizza";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.CompassBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DialogueBox;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.PictureBox CompassBox;
        private System.Windows.Forms.Label CompassLabel;
    }
}

