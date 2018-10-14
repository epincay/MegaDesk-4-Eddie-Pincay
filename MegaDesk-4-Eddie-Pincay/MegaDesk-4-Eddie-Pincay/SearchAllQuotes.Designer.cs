namespace MegaDesk_4_Eddie_Pincay
{
    partial class SearchAllQuotes
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
            this.label2 = new System.Windows.Forms.Label();
            this.Criteria = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.Results = new System.Windows.Forms.RichTextBox();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Criteria";
            // 
            // Criteria
            // 
            this.Criteria.Location = new System.Drawing.Point(501, 33);
            this.Criteria.Name = "Criteria";
            this.Criteria.Size = new System.Drawing.Size(182, 20);
            this.Criteria.TabIndex = 16;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(530, 337);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(127, 50);
            this.Search.TabIndex = 15;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(123, 79);
            this.Results.Name = "Results";
            this.Results.Size = new System.Drawing.Size(560, 236);
            this.Results.TabIndex = 14;
            this.Results.Text = "";
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Location = new System.Drawing.Point(160, 337);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(127, 50);
            this.MainMenuButton.TabIndex = 12;
            this.MainMenuButton.Text = "Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Search";
            // 
            // SearchComboBox
            // 
            this.SearchComboBox.FormattingEnabled = true;
            this.SearchComboBox.Items.AddRange(new object[] {
            "Client",
            "Material"});
            this.SearchComboBox.Location = new System.Drawing.Point(185, 33);
            this.SearchComboBox.Name = "SearchComboBox";
            this.SearchComboBox.Size = new System.Drawing.Size(203, 21);
            this.SearchComboBox.TabIndex = 13;
            // 
            // SearchAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Criteria);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchComboBox);
            this.Name = "SearchAllQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Criteria;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RichTextBox Results;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SearchComboBox;
    }
}