namespace ChuckNorris
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
            this.GetJokeButton = new System.Windows.Forms.Button();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GetJokeButton
            // 
            this.GetJokeButton.Location = new System.Drawing.Point(111, 97);
            this.GetJokeButton.Name = "GetJokeButton";
            this.GetJokeButton.Size = new System.Drawing.Size(172, 70);
            this.GetJokeButton.TabIndex = 0;
            this.GetJokeButton.Text = "Get Joke";
            this.GetJokeButton.UseVisualStyleBackColor = true;
            this.GetJokeButton.Click += new System.EventHandler(this.GetJokeButton_ClickAsync);
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.FormattingEnabled = true;
            this.CategoriesComboBox.Location = new System.Drawing.Point(111, 31);
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(172, 21);
            this.CategoriesComboBox.TabIndex = 1;
            this.CategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesComboBox_SelectedIndexChangedAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 232);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.GetJokeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetJokeButton;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
    }
}

