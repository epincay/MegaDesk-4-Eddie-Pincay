namespace MegaDesk_4_Eddie_Pincay
{
    partial class MainMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewAllQuotes = new System.Windows.Forms.Button();
            this.searchAllQuotes = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openAddQuoteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllQuotes
            // 
            this.viewAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllQuotes.Location = new System.Drawing.Point(95, 158);
            this.viewAllQuotes.Name = "viewAllQuotes";
            this.viewAllQuotes.Size = new System.Drawing.Size(175, 49);
            this.viewAllQuotes.TabIndex = 2;
            this.viewAllQuotes.Text = "View Quote";
            this.viewAllQuotes.UseVisualStyleBackColor = true;
            this.viewAllQuotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchAllQuotes
            // 
            this.searchAllQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchAllQuotes.Location = new System.Drawing.Point(95, 226);
            this.searchAllQuotes.Name = "searchAllQuotes";
            this.searchAllQuotes.Size = new System.Drawing.Size(175, 49);
            this.searchAllQuotes.TabIndex = 3;
            this.searchAllQuotes.Text = "Search Quote";
            this.searchAllQuotes.UseVisualStyleBackColor = true;
            this.searchAllQuotes.Click += new System.EventHandler(this.searchAllQuotes_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(95, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 49);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.cancelQuoteButton);
            // 
            // openAddQuoteButton
            // 
            this.openAddQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAddQuoteButton.Location = new System.Drawing.Point(95, 91);
            this.openAddQuoteButton.Name = "openAddQuoteButton";
            this.openAddQuoteButton.Size = new System.Drawing.Size(175, 49);
            this.openAddQuoteButton.TabIndex = 1;
            this.openAddQuoteButton.Text = "Add New Quote";
            this.openAddQuoteButton.UseVisualStyleBackColor = true;
            this.openAddQuoteButton.Click += new System.EventHandler(this.openAddQuoteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MegaDesk_4_Eddie_Pincay.Properties.Resources.desk_161474_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(356, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openAddQuoteButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.searchAllQuotes);
            this.Controls.Add(this.viewAllQuotes);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button viewAllQuotes;
        private System.Windows.Forms.Button searchAllQuotes;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button openAddQuoteButton;
    }
}

