namespace Form_PasswordGeneratorProject {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passwordLength_textBox = new System.Windows.Forms.TextBox();
            this.passwordLength_label = new System.Windows.Forms.Label();
            this.passwordLength_trackBar = new System.Windows.Forms.TrackBar();
            this.generatePassword_button = new System.Windows.Forms.Button();
            this.includeSymbols_checkBox = new System.Windows.Forms.CheckBox();
            this.includeNumbers_checkBox = new System.Windows.Forms.CheckBox();
            this.includeLowercase_checkBox = new System.Windows.Forms.CheckBox();
            this.includeUppercase_checkBox = new System.Windows.Forms.CheckBox();
            this.excludeSimilar_checkBox = new System.Windows.Forms.CheckBox();
            this.excludeAmbiguous_checkBox = new System.Windows.Forms.CheckBox();
            this.includeSymbols_label = new System.Windows.Forms.Label();
            this.includeNumbers_label = new System.Windows.Forms.Label();
            this.includeLowercase_label = new System.Windows.Forms.Label();
            this.includeUppercase_label = new System.Windows.Forms.Label();
            this.excludeSimilar_label = new System.Windows.Forms.Label();
            this.excludeAmbiguous_label = new System.Windows.Forms.Label();
            this.generatedPassword_textBox = new System.Windows.Forms.TextBox();
            this.copyPassword_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordLength_textBox
            // 
            this.passwordLength_textBox.Location = new System.Drawing.Point(263, 14);
            this.passwordLength_textBox.Name = "passwordLength_textBox";
            this.passwordLength_textBox.ReadOnly = true;
            this.passwordLength_textBox.Size = new System.Drawing.Size(62, 18);
            this.passwordLength_textBox.TabIndex = 3;
            // 
            // passwordLength_label
            // 
            this.passwordLength_label.Location = new System.Drawing.Point(12, 11);
            this.passwordLength_label.Name = "passwordLength_label";
            this.passwordLength_label.Size = new System.Drawing.Size(103, 21);
            this.passwordLength_label.TabIndex = 2;
            this.passwordLength_label.Text = "Password Length:";
            this.passwordLength_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passwordLength_trackBar
            // 
            this.passwordLength_trackBar.Location = new System.Drawing.Point(138, 8);
            this.passwordLength_trackBar.Maximum = 24;
            this.passwordLength_trackBar.Minimum = 1;
            this.passwordLength_trackBar.Name = "passwordLength_trackBar";
            this.passwordLength_trackBar.Size = new System.Drawing.Size(120, 45);
            this.passwordLength_trackBar.TabIndex = 1;
            this.passwordLength_trackBar.Value = 1;
            // 
            // generatePassword_button
            // 
            this.generatePassword_button.Location = new System.Drawing.Point(12, 230);
            this.generatePassword_button.Name = "generatePassword_button";
            this.generatePassword_button.Size = new System.Drawing.Size(158, 36);
            this.generatePassword_button.TabIndex = 4;
            this.generatePassword_button.Text = "Generate Password";
            this.generatePassword_button.UseVisualStyleBackColor = true;
            this.generatePassword_button.Click += new System.EventHandler(this.generatePassword_button_Click);
            // 
            // includeSymbols_checkBox
            // 
            this.includeSymbols_checkBox.Location = new System.Drawing.Point(154, 56);
            this.includeSymbols_checkBox.Name = "includeSymbols_checkBox";
            this.includeSymbols_checkBox.Size = new System.Drawing.Size(104, 22);
            this.includeSymbols_checkBox.TabIndex = 5;
            this.includeSymbols_checkBox.Text = "(e.g. @#$% )";
            this.includeSymbols_checkBox.UseVisualStyleBackColor = true;
            // 
            // includeNumbers_checkBox
            // 
            this.includeNumbers_checkBox.Location = new System.Drawing.Point(154, 83);
            this.includeNumbers_checkBox.Name = "includeNumbers_checkBox";
            this.includeNumbers_checkBox.Size = new System.Drawing.Size(104, 22);
            this.includeNumbers_checkBox.TabIndex = 6;
            this.includeNumbers_checkBox.Text = "(e.g. 123456 )";
            this.includeNumbers_checkBox.UseVisualStyleBackColor = true;
            // 
            // includeLowercase_checkBox
            // 
            this.includeLowercase_checkBox.Location = new System.Drawing.Point(154, 111);
            this.includeLowercase_checkBox.Name = "includeLowercase_checkBox";
            this.includeLowercase_checkBox.Size = new System.Drawing.Size(104, 22);
            this.includeLowercase_checkBox.TabIndex = 7;
            this.includeLowercase_checkBox.Text = "(e.g. abcdefgh )";
            this.includeLowercase_checkBox.UseVisualStyleBackColor = true;
            // 
            // includeUppercase_checkBox
            // 
            this.includeUppercase_checkBox.Location = new System.Drawing.Point(154, 139);
            this.includeUppercase_checkBox.Name = "includeUppercase_checkBox";
            this.includeUppercase_checkBox.Size = new System.Drawing.Size(104, 22);
            this.includeUppercase_checkBox.TabIndex = 8;
            this.includeUppercase_checkBox.Text = "(e.g. ABCDEF )";
            this.includeUppercase_checkBox.UseVisualStyleBackColor = true;
            // 
            // excludeSimilar_checkBox
            // 
            this.excludeSimilar_checkBox.Location = new System.Drawing.Point(154, 166);
            this.excludeSimilar_checkBox.Name = "excludeSimilar_checkBox";
            this.excludeSimilar_checkBox.Size = new System.Drawing.Size(135, 22);
            this.excludeSimilar_checkBox.TabIndex = 9;
            this.excludeSimilar_checkBox.Text = "(e.g. i, l, 1, L, o, 0, O )";
            this.excludeSimilar_checkBox.UseVisualStyleBackColor = true;
            // 
            // excludeAmbiguous_checkBox
            // 
            this.excludeAmbiguous_checkBox.Location = new System.Drawing.Point(154, 194);
            this.excludeAmbiguous_checkBox.Name = "excludeAmbiguous_checkBox";
            this.excludeAmbiguous_checkBox.Size = new System.Drawing.Size(167, 22);
            this.excludeAmbiguous_checkBox.TabIndex = 10;
            this.excludeAmbiguous_checkBox.Text = "( { } [ ] ( ) / \\ \' \" ` ~ , ; : _ < > )";
            this.excludeAmbiguous_checkBox.UseVisualStyleBackColor = true;
            // 
            // includeSymbols_label
            // 
            this.includeSymbols_label.Location = new System.Drawing.Point(12, 56);
            this.includeSymbols_label.Name = "includeSymbols_label";
            this.includeSymbols_label.Size = new System.Drawing.Size(120, 21);
            this.includeSymbols_label.TabIndex = 11;
            this.includeSymbols_label.Text = "Include Symbols:";
            this.includeSymbols_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // includeNumbers_label
            // 
            this.includeNumbers_label.Location = new System.Drawing.Point(12, 83);
            this.includeNumbers_label.Name = "includeNumbers_label";
            this.includeNumbers_label.Size = new System.Drawing.Size(120, 21);
            this.includeNumbers_label.TabIndex = 12;
            this.includeNumbers_label.Text = "Include Numbers:";
            this.includeNumbers_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // includeLowercase_label
            // 
            this.includeLowercase_label.Location = new System.Drawing.Point(12, 111);
            this.includeLowercase_label.Name = "includeLowercase_label";
            this.includeLowercase_label.Size = new System.Drawing.Size(120, 21);
            this.includeLowercase_label.TabIndex = 13;
            this.includeLowercase_label.Text = "Include Lowercase:";
            this.includeLowercase_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // includeUppercase_label
            // 
            this.includeUppercase_label.Location = new System.Drawing.Point(12, 139);
            this.includeUppercase_label.Name = "includeUppercase_label";
            this.includeUppercase_label.Size = new System.Drawing.Size(120, 21);
            this.includeUppercase_label.TabIndex = 14;
            this.includeUppercase_label.Text = "Include Uppercase:";
            this.includeUppercase_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // excludeSimilar_label
            // 
            this.excludeSimilar_label.Location = new System.Drawing.Point(12, 166);
            this.excludeSimilar_label.Name = "excludeSimilar_label";
            this.excludeSimilar_label.Size = new System.Drawing.Size(120, 21);
            this.excludeSimilar_label.TabIndex = 15;
            this.excludeSimilar_label.Text = "Exclude Similar:";
            this.excludeSimilar_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // excludeAmbiguous_label
            // 
            this.excludeAmbiguous_label.Location = new System.Drawing.Point(12, 194);
            this.excludeAmbiguous_label.Name = "excludeAmbiguous_label";
            this.excludeAmbiguous_label.Size = new System.Drawing.Size(120, 21);
            this.excludeAmbiguous_label.TabIndex = 16;
            this.excludeAmbiguous_label.Text = "Exclude Ambiguous:";
            this.excludeAmbiguous_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // generatedPassword_textBox
            // 
            this.generatedPassword_textBox.Location = new System.Drawing.Point(12, 272);
            this.generatedPassword_textBox.Name = "generatedPassword_textBox";
            this.generatedPassword_textBox.Size = new System.Drawing.Size(313, 18);
            this.generatedPassword_textBox.TabIndex = 17;
            // 
            // copyPassword_button
            // 
            this.copyPassword_button.Location = new System.Drawing.Point(176, 230);
            this.copyPassword_button.Name = "copyPassword_button";
            this.copyPassword_button.Size = new System.Drawing.Size(149, 36);
            this.copyPassword_button.TabIndex = 18;
            this.copyPassword_button.Text = "COPY";
            this.copyPassword_button.UseVisualStyleBackColor = true;
            this.copyPassword_button.Click += new System.EventHandler(this.copyPassword_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 307);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 307);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(96, 307);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(96, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Subliminal PassGen";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(169, 307);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(337, 391);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.copyPassword_button);
            this.Controls.Add(this.generatedPassword_textBox);
            this.Controls.Add(this.excludeAmbiguous_label);
            this.Controls.Add(this.excludeSimilar_label);
            this.Controls.Add(this.includeUppercase_label);
            this.Controls.Add(this.includeLowercase_label);
            this.Controls.Add(this.includeNumbers_label);
            this.Controls.Add(this.includeSymbols_label);
            this.Controls.Add(this.excludeAmbiguous_checkBox);
            this.Controls.Add(this.excludeSimilar_checkBox);
            this.Controls.Add(this.includeUppercase_checkBox);
            this.Controls.Add(this.includeLowercase_checkBox);
            this.Controls.Add(this.includeNumbers_checkBox);
            this.Controls.Add(this.includeSymbols_checkBox);
            this.Controls.Add(this.generatePassword_button);
            this.Controls.Add(this.passwordLength_textBox);
            this.Controls.Add(this.passwordLength_label);
            this.Controls.Add(this.passwordLength_trackBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subliminal PassGen";
            ((System.ComponentModel.ISupportInitialize)(this.passwordLength_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button copyPassword_button;

        private System.Windows.Forms.TextBox generatedPassword_textBox;

        private System.Windows.Forms.CheckBox includeSymbols_checkBox;
        private System.Windows.Forms.CheckBox includeNumbers_checkBox;
        private System.Windows.Forms.CheckBox includeLowercase_checkBox;
        private System.Windows.Forms.CheckBox includeUppercase_checkBox;
        private System.Windows.Forms.CheckBox excludeSimilar_checkBox;
        private System.Windows.Forms.CheckBox excludeAmbiguous_checkBox;
        private System.Windows.Forms.Label includeSymbols_label;
        private System.Windows.Forms.Label includeNumbers_label;
        private System.Windows.Forms.Label includeLowercase_label;
        private System.Windows.Forms.Label includeUppercase_label;
        private System.Windows.Forms.Label excludeSimilar_label;
        private System.Windows.Forms.Label excludeAmbiguous_label;

        private System.Windows.Forms.Button generatePassword_button;

        private System.Windows.Forms.TrackBar passwordLength_trackBar;
        private System.Windows.Forms.Label passwordLength_label;
        private System.Windows.Forms.TextBox passwordLength_textBox;

        #endregion
    }
}