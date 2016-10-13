namespace COMP1004_F2016_Lesson6
{
    partial class AbilityForm
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
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.ConstitutionTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.WisdomTextBox = new System.Windows.Forms.TextBox();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.CharismaTextBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.RollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Location = new System.Drawing.Point(24, 17);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(99, 24);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Location = new System.Drawing.Point(24, 55);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(107, 24);
            this.DexterityLabel.TabIndex = 1;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Location = new System.Drawing.Point(24, 93);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(139, 24);
            this.ConstitutionLabel.TabIndex = 2;
            this.ConstitutionLabel.Text = "Constitution";
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.Location = new System.Drawing.Point(169, 14);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.Size = new System.Drawing.Size(100, 32);
            this.StrengthTextBox.TabIndex = 3;
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.Location = new System.Drawing.Point(169, 52);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.Size = new System.Drawing.Size(100, 32);
            this.DexterityTextBox.TabIndex = 4;
            // 
            // ConstitutionTextBox
            // 
            this.ConstitutionTextBox.Location = new System.Drawing.Point(169, 90);
            this.ConstitutionTextBox.Name = "ConstitutionTextBox";
            this.ConstitutionTextBox.Size = new System.Drawing.Size(100, 32);
            this.ConstitutionTextBox.TabIndex = 5;
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.Location = new System.Drawing.Point(169, 128);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.Size = new System.Drawing.Size(100, 32);
            this.IntelligenceTextBox.TabIndex = 7;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Location = new System.Drawing.Point(24, 131);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(129, 24);
            this.IntelligenceLabel.TabIndex = 6;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // WisdomTextBox
            // 
            this.WisdomTextBox.Location = new System.Drawing.Point(169, 166);
            this.WisdomTextBox.Name = "WisdomTextBox";
            this.WisdomTextBox.Size = new System.Drawing.Size(100, 32);
            this.WisdomTextBox.TabIndex = 9;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Location = new System.Drawing.Point(24, 169);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(91, 24);
            this.WisdomLabel.TabIndex = 8;
            this.WisdomLabel.Text = "Wisdom";
            // 
            // CharismaTextBox
            // 
            this.CharismaTextBox.Location = new System.Drawing.Point(169, 204);
            this.CharismaTextBox.Name = "CharismaTextBox";
            this.CharismaTextBox.Size = new System.Drawing.Size(100, 32);
            this.CharismaTextBox.TabIndex = 11;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Location = new System.Drawing.Point(24, 207);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(107, 24);
            this.CharismaLabel.TabIndex = 10;
            this.CharismaLabel.Text = "Charisma";
            // 
            // RollButton
            // 
            this.RollButton.Location = new System.Drawing.Point(36, 260);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(224, 36);
            this.RollButton.TabIndex = 12;
            this.RollButton.Text = "Roll Abilities";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // AbilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 314);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.CharismaTextBox);
            this.Controls.Add(this.CharismaLabel);
            this.Controls.Add(this.WisdomTextBox);
            this.Controls.Add(this.WisdomLabel);
            this.Controls.Add(this.IntelligenceTextBox);
            this.Controls.Add(this.IntelligenceLabel);
            this.Controls.Add(this.ConstitutionTextBox);
            this.Controls.Add(this.DexterityTextBox);
            this.Controls.Add(this.StrengthTextBox);
            this.Controls.Add(this.ConstitutionLabel);
            this.Controls.Add(this.DexterityLabel);
            this.Controls.Add(this.StrengthLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AbilityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ability Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.TextBox StrengthTextBox;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.TextBox ConstitutionTextBox;
        private System.Windows.Forms.TextBox IntelligenceTextBox;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.TextBox WisdomTextBox;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.TextBox CharismaTextBox;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.Button RollButton;
    }
}

