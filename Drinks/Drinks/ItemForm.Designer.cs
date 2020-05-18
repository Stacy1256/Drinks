namespace Drinks
{
    partial class ItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemForm));
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFruit = new System.Windows.Forms.TextBox();
            this.textBoxSortOfCoffee = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonCoffeine = new System.Windows.Forms.RadioButton();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedBoxCoffeine = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelName.Location = new System.Drawing.Point(42, 130);
            this.labelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(70, 33);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(42, 203);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(42, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fruit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(42, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sort of coffee";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(196, 125);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(618, 39);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxFruit
            // 
            this.textBoxFruit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFruit.Location = new System.Drawing.Point(199, 284);
            this.textBoxFruit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxFruit.Name = "textBoxFruit";
            this.textBoxFruit.Size = new System.Drawing.Size(615, 39);
            this.textBoxFruit.TabIndex = 7;
            this.textBoxFruit.TextChanged += new System.EventHandler(this.textBoxFruit_TextChanged);
            this.textBoxFruit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFruit_KeyPress);
            // 
            // textBoxSortOfCoffee
            // 
            this.textBoxSortOfCoffee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSortOfCoffee.Location = new System.Drawing.Point(199, 359);
            this.textBoxSortOfCoffee.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.textBoxSortOfCoffee.Name = "textBoxSortOfCoffee";
            this.textBoxSortOfCoffee.Size = new System.Drawing.Size(615, 39);
            this.textBoxSortOfCoffee.TabIndex = 8;
            this.textBoxSortOfCoffee.TextChanged += new System.EventHandler(this.textBoxSortOfCoffee_TextChanged);
            this.textBoxSortOfCoffee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFruit_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(455, 586);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(161, 58);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(653, 586);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(161, 58);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // radioButtonCoffeine
            // 
            this.radioButtonCoffeine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonCoffeine.AutoSize = true;
            this.radioButtonCoffeine.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonCoffeine.Location = new System.Drawing.Point(269, 414);
            this.radioButtonCoffeine.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.radioButtonCoffeine.Name = "radioButtonCoffeine";
            this.radioButtonCoffeine.Size = new System.Drawing.Size(112, 37);
            this.radioButtonCoffeine.TabIndex = 11;
            this.radioButtonCoffeine.TabStop = true;
            this.radioButtonCoffeine.Text = "Coffeine";
            this.radioButtonCoffeine.UseVisualStyleBackColor = false;
            this.radioButtonCoffeine.Visible = false;
            this.radioButtonCoffeine.CheckedChanged += new System.EventHandler(this.radioButtonCoffeine_CheckedChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.comboBoxSize.Location = new System.Drawing.Point(196, 202);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(618, 39);
            this.comboBoxSize.TabIndex = 12;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Drink",
            "Fresh",
            "Coffee"});
            this.comboBoxType.Location = new System.Drawing.Point(196, 44);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(618, 39);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 513);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 145);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(42, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 33);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type";
            // 
            // checkedBoxCoffeine
            // 
            this.checkedBoxCoffeine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedBoxCoffeine.AutoSize = true;
            this.checkedBoxCoffeine.BackColor = System.Drawing.Color.Transparent;
            this.checkedBoxCoffeine.Location = new System.Drawing.Point(268, 414);
            this.checkedBoxCoffeine.Name = "checkedBoxCoffeine";
            this.checkedBoxCoffeine.Size = new System.Drawing.Size(113, 37);
            this.checkedBoxCoffeine.TabIndex = 16;
            this.checkedBoxCoffeine.Text = "Coffeine";
            this.checkedBoxCoffeine.UseVisualStyleBackColor = false;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 661);
            this.Controls.Add(this.checkedBoxCoffeine);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.radioButtonCoffeine);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSortOfCoffee);
            this.Controls.Add(this.textBoxFruit);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximumSize = new System.Drawing.Size(874, 708);
            this.MinimumSize = new System.Drawing.Size(570, 596);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New order";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        protected internal System.Windows.Forms.TextBox textBoxName;
        protected internal System.Windows.Forms.TextBox textBoxFruit;
        protected internal System.Windows.Forms.TextBox textBoxSortOfCoffee;
        protected internal System.Windows.Forms.RadioButton radioButtonCoffeine;
        protected internal System.Windows.Forms.ComboBox comboBoxSize;
        protected internal System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.CheckBox checkedBoxCoffeine;
    }
}