namespace DnDCreator
{
    partial class charScreen1
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
            this.components = new System.ComponentModel.Container();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.backBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.boxTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // raceBox
            // 
            this.raceBox.BackColor = System.Drawing.Color.Silver;
            this.raceBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raceBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Items.AddRange(new object[] {
            "Forest Gnome",
            "Rock Gnome",
            "High Elf",
            "Wood Elf",
            "Dark Elf",
            "Human",
            "Tiefling",
            "Half-Orc",
            "Half-Elf",
            "Dragonborn",
            "Hill Dwarf",
            "Mountain Dwarf",
            "Lightfoot Halfling",
            "Stout Halfling"});
            this.raceBox.Location = new System.Drawing.Point(311, 70);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(194, 38);
            this.raceBox.TabIndex = 0;
            this.raceBox.Text = "RACE";
            // 
            // typeBox
            // 
            this.typeBox.BackColor = System.Drawing.Color.Silver;
            this.typeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            "Rogue",
            "Fighter",
            "Ranger",
            "Barbarian",
            "Warlock",
            "Paladin",
            "Monk",
            "Bard",
            "Wizard",
            "Sorcerer",
            "Druid",
            "Cleric"});
            this.typeBox.Location = new System.Drawing.Point(311, 197);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(194, 38);
            this.typeBox.TabIndex = 1;
            this.typeBox.Text = "CLASS";
            // 
            // backBox
            // 
            this.backBox.BackColor = System.Drawing.Color.Silver;
            this.backBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBox.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBox.FormattingEnabled = true;
            this.backBox.Items.AddRange(new object[] {
            "Acolyte",
            "Charlatan",
            "Criminal",
            "Entertainer",
            "Folk Hero",
            "Guild Merchant",
            "Hermit",
            "Noble",
            "Outlander",
            "Sailor",
            "Soldier",
            "Urchin"});
            this.backBox.Location = new System.Drawing.Point(311, 328);
            this.backBox.Name = "backBox";
            this.backBox.Size = new System.Drawing.Size(215, 38);
            this.backBox.TabIndex = 2;
            this.backBox.Text = "BACKGROUND";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Papyrus", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(490, 481);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // boxTimer
            // 
            this.boxTimer.Enabled = true;
            this.boxTimer.Interval = 16;
            this.boxTimer.Tick += new System.EventHandler(this.boxTimer_Tick);
            // 
            // charScreen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DnDCreator.Properties.Resources.map;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.raceBox);
            this.Name = "charScreen1";
            this.Size = new System.Drawing.Size(836, 617);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ComboBox backBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer boxTimer;
    }
}
