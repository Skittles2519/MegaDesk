namespace MegaDesk
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DrawerComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderTimeComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.WarningText = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(9, 32);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(125, 26);
            this.NameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width of desk";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(180, 32);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(125, 26);
            this.WidthBox.TabIndex = 3;
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth of Desk";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(9, 94);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(125, 26);
            this.DepthBox.TabIndex = 5;
            this.DepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Drawers";
            // 
            // DrawerComboBox
            // 
            this.DrawerComboBox.FormattingEnabled = true;
            this.DrawerComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawerComboBox.Location = new System.Drawing.Point(180, 92);
            this.DrawerComboBox.Name = "DrawerComboBox";
            this.DrawerComboBox.Size = new System.Drawing.Size(125, 28);
            this.DrawerComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Type of Material";
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.MaterialComboBox.Location = new System.Drawing.Point(9, 156);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(125, 28);
            this.MaterialComboBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Order Processing Time";
            // 
            // OrderTimeComboBox
            // 
            this.OrderTimeComboBox.FormattingEnabled = true;
            this.OrderTimeComboBox.Items.AddRange(new object[] {
            "Default (14 Days)",
            "7 Days",
            "5 Days",
            "3 Days"});
            this.OrderTimeComboBox.Location = new System.Drawing.Point(180, 156);
            this.OrderTimeComboBox.Name = "OrderTimeComboBox";
            this.OrderTimeComboBox.Size = new System.Drawing.Size(125, 28);
            this.OrderTimeComboBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(180, 202);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(150, 30);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit Quote";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // WarningText
            // 
            this.WarningText.AutoSize = true;
            this.WarningText.ForeColor = System.Drawing.Color.Red;
            this.WarningText.Location = new System.Drawing.Point(322, 9);
            this.WarningText.MaximumSize = new System.Drawing.Size(150, 0);
            this.WarningText.Name = "WarningText";
            this.WarningText.Size = new System.Drawing.Size(0, 20);
            this.WarningText.TabIndex = 13;
            this.WarningText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(13, 202);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(51, 20);
            this.Date.TabIndex = 14;
            this.Date.Text = "label7";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 244);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.WarningText);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.OrderTimeComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DrawerComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddQuote_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DrawerComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox OrderTimeComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label WarningText;
        private System.Windows.Forms.Label Date;
    }
}