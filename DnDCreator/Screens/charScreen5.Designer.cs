namespace DnDCreator.Screens
{
    partial class charScreen5
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameNextButton = new System.Windows.Forms.Button();
            this.nameBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.Color.Silver;
            this.nameBox.Font = new System.Drawing.Font("Papyrus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(286, 197);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(248, 63);
            this.nameBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(533, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Name Your Character";
            // 
            // nameNextButton
            // 
            this.nameNextButton.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameNextButton.Location = new System.Drawing.Point(493, 374);
            this.nameNextButton.Name = "nameNextButton";
            this.nameNextButton.Size = new System.Drawing.Size(91, 38);
            this.nameNextButton.TabIndex = 7;
            this.nameNextButton.Text = "Next";
            this.nameNextButton.UseVisualStyleBackColor = true;
            this.nameNextButton.Click += new System.EventHandler(this.nameNextButton_Click);
            // 
            // nameBackButton
            // 
            this.nameBackButton.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBackButton.Location = new System.Drawing.Point(259, 374);
            this.nameBackButton.Name = "nameBackButton";
            this.nameBackButton.Size = new System.Drawing.Size(91, 38);
            this.nameBackButton.TabIndex = 6;
            this.nameBackButton.Text = "Back";
            this.nameBackButton.UseVisualStyleBackColor = true;
            this.nameBackButton.Click += new System.EventHandler(this.nameBackButton_Click);
            // 
            // charScreen5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnDCreator.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.nameNextButton);
            this.Controls.Add(this.nameBackButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameBox);
            this.Name = "charScreen5";
            this.Size = new System.Drawing.Size(836, 617);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nameNextButton;
        private System.Windows.Forms.Button nameBackButton;
    }
}
