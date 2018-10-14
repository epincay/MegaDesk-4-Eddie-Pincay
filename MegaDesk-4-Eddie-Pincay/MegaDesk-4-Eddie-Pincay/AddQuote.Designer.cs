namespace MegaDesk_4_Eddie_Pincay
{
    partial class AddQuote
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
            this.depth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.error1 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveQuote = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Price = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DeskDrawers = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rushDays = new System.Windows.Forms.ComboBox();
            this.Material = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(187, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 13;
            this.label2.Visible = false;
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(187, 194);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(155, 20);
            this.depth.TabIndex = 3;
            this.depth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Depth (in inches) :";
            // 
            // error1
            // 
            this.error1.AutoSize = true;
            this.error1.ForeColor = System.Drawing.Color.Red;
            this.error1.Location = new System.Drawing.Point(187, 158);
            this.error1.Name = "error1";
            this.error1.Size = new System.Drawing.Size(0, 13);
            this.error1.TabIndex = 10;
            this.error1.Visible = false;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(187, 131);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(155, 20);
            this.width.TabIndex = 2;
            this.width.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Width (in inches) :";
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Location = new System.Drawing.Point(467, 359);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(193, 52);
            this.cancelQuoteButton.TabIndex = 5;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButto);
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(187, 82);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(155, 20);
            this.clientName.TabIndex = 1;
            
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Client Name  :";
            // 
            // saveQuote
            // 
            this.saveQuote.Location = new System.Drawing.Point(168, 359);
            this.saveQuote.Name = "saveQuote";
            this.saveQuote.Size = new System.Drawing.Size(193, 52);
            this.saveQuote.TabIndex = 4;
            this.saveQuote.Text = "Save Quote";
            this.saveQuote.UseVisualStyleBackColor = true;
            this.saveQuote.Click += new System.EventHandler(this.saveQuote_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Current Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(549, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 31);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.Location = new System.Drawing.Point(580, 234);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(0, 20);
            this.Price.TabIndex = 33;
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label09.Location = new System.Drawing.Point(462, 234);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(44, 20);
            this.label09.TabIndex = 32;
            this.label09.Text = "Price";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(581, 203);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(0, 20);
            this.size.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "Surface";
            // 
            // DeskDrawers
            // 
            this.DeskDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeskDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDrawers.FormattingEnabled = true;
            this.DeskDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DeskDrawers.Location = new System.Drawing.Point(568, 161);
            this.DeskDrawers.Name = "DeskDrawers";
            this.DeskDrawers.Size = new System.Drawing.Size(137, 28);
            this.DeskDrawers.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(463, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Drawers";
            // 
            // rushDays
            // 
            this.rushDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rushDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDays.FormattingEnabled = true;
            this.rushDays.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.rushDays.Location = new System.Drawing.Point(568, 85);
            this.rushDays.Name = "rushDays";
            this.rushDays.Size = new System.Drawing.Size(137, 28);
            this.rushDays.TabIndex = 27;
            // 
            // Material
            // 
            this.Material.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Material.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Material.FormattingEnabled = true;
            this.Material.Location = new System.Drawing.Point(568, 123);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(137, 28);
            this.Material.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Material";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Rush Days";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label09);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DeskDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rushDays);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveQuote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.error1);
            this.Controls.Add(this.width);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelQuoteButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error1;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveQuote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox DeskDrawers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rushDays;
        private System.Windows.Forms.ComboBox Material;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
    }
}