namespace SaberSongSpeed {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mapTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.multiplierInput = new System.Windows.Forms.TextBox();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mapTextBox
            // 
            this.mapTextBox.Location = new System.Drawing.Point(12, 59);
            this.mapTextBox.Multiline = true;
            this.mapTextBox.Name = "mapTextBox";
            this.mapTextBox.Size = new System.Drawing.Size(776, 379);
            this.mapTextBox.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(628, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(160, 41);
            this.convertButton.TabIndex = 1;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // multiplierInput
            // 
            this.multiplierInput.Location = new System.Drawing.Point(12, 33);
            this.multiplierInput.Name = "multiplierInput";
            this.multiplierInput.Size = new System.Drawing.Size(160, 20);
            this.multiplierInput.TabIndex = 2;
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.multiplierLabel.Location = new System.Drawing.Point(13, 12);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(160, 18);
            this.multiplierLabel.TabIndex = 3;
            this.multiplierLabel.Text = "Multiplier";
            this.multiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(180, 13);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(442, 40);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.multiplierLabel);
            this.Controls.Add(this.multiplierInput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.mapTextBox);
            this.Name = "Form1";
            this.Text = "Saber Song Speed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mapTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox multiplierInput;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.Label infoLabel;
    }
}

