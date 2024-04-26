namespace IceTask3_ST10082949_CafeApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblItem = new Label();
            lblQuantity = new Label();
            btnAdd = new Button();
            btnDisplay = new Button();
            comboBoxItem = new ComboBox();
            numericUpDownQuantity = new NumericUpDown();
            listBoxDisplay = new ListBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Yu Gothic", 18F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(239, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(121, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Cafe App";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(100, 86);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(34, 15);
            lblItem.TabIndex = 1;
            lblItem.Text = "Item:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(338, 86);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(56, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(176, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Order";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(285, 144);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(75, 23);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // comboBoxItem
            // 
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(140, 86);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(121, 23);
            comboBoxItem.TabIndex = 5;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Location = new Point(400, 84);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 23);
            numericUpDownQuantity.TabIndex = 6;
            // 
            // listBoxDisplay
            // 
            listBoxDisplay.FormattingEnabled = true;
            listBoxDisplay.ItemHeight = 15;
            listBoxDisplay.Location = new Point(193, 207);
            listBoxDisplay.Name = "listBoxDisplay";
            listBoxDisplay.Size = new Size(254, 169);
            listBoxDisplay.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(400, 144);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(648, 399);
            Controls.Add(btnClear);
            Controls.Add(listBoxDisplay);
            Controls.Add(numericUpDownQuantity);
            Controls.Add(comboBoxItem);
            Controls.Add(btnDisplay);
            Controls.Add(btnAdd);
            Controls.Add(lblQuantity);
            Controls.Add(lblItem);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblItem;
        private Label lblQuantity;
        private Button btnAdd;
        private Button btnDisplay;
        private ComboBox comboBoxItem;
        private NumericUpDown numericUpDownQuantity;
        private ListBox listBoxDisplay;
        private Button btnClear;
    }
}
