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
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.LavenderBlush;
            this.labelName.Location = new System.Drawing.Point(51, 68);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Location = new System.Drawing.Point(51, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LavenderBlush;
            this.label2.Location = new System.Drawing.Point(51, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fruit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LavenderBlush;
            this.label3.Location = new System.Drawing.Point(51, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sort of coffee";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(200, 64);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(284, 22);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxFruit
            // 
            this.textBoxFruit.Location = new System.Drawing.Point(200, 146);
            this.textBoxFruit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFruit.Name = "textBoxFruit";
            this.textBoxFruit.Size = new System.Drawing.Size(284, 22);
            this.textBoxFruit.TabIndex = 7;
            this.textBoxFruit.TextChanged += new System.EventHandler(this.textBoxFruit_TextChanged);
            this.textBoxFruit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFruit_KeyPress);
            // 
            // textBoxSortOfCoffee
            // 
            this.textBoxSortOfCoffee.Location = new System.Drawing.Point(200, 185);
            this.textBoxSortOfCoffee.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSortOfCoffee.Name = "textBoxSortOfCoffee";
            this.textBoxSortOfCoffee.Size = new System.Drawing.Size(284, 22);
            this.textBoxSortOfCoffee.TabIndex = 8;
            this.textBoxSortOfCoffee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFruit_KeyPress);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(109, 273);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 48);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonCancel.Location = new System.Drawing.Point(307, 273);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(137, 48);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // radioButtonCoffeine
            // 
            this.radioButtonCoffeine.AutoSize = true;
            this.radioButtonCoffeine.Location = new System.Drawing.Point(200, 228);
            this.radioButtonCoffeine.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonCoffeine.Name = "radioButtonCoffeine";
            this.radioButtonCoffeine.Size = new System.Drawing.Size(81, 21);
            this.radioButtonCoffeine.TabIndex = 11;
            this.radioButtonCoffeine.TabStop = true;
            this.radioButtonCoffeine.Text = "Coffeine";
            this.radioButtonCoffeine.UseVisualStyleBackColor = true;
            this.radioButtonCoffeine.CheckedChanged += new System.EventHandler(this.radioButtonCoffeine_CheckedChanged);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(200, 98);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(284, 24);
            this.comboBoxSize.TabIndex = 12;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Drink",
            "Fresh",
            "Coffee"});
            this.comboBoxType.Location = new System.Drawing.Point(156, 16);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(259, 24);
            this.comboBoxType.TabIndex = 13;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(579, 346);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFruit;
        private System.Windows.Forms.TextBox textBoxSortOfCoffee;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonCoffeine;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxType;
    }
}