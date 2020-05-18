namespace Drinks
{
    partial class SampleForm
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
            this.RangeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RangeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RangeDataGridView
            // 
            this.RangeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RangeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RangeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.RangeDataGridView.Name = "RangeDataGridView";
            this.RangeDataGridView.RowTemplate.Height = 24;
            this.RangeDataGridView.Size = new System.Drawing.Size(800, 450);
            this.RangeDataGridView.TabIndex = 0;
            this.RangeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RangeDataGridView_CellContentClick_1);
            // 
            // SampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RangeDataGridView);
            this.Name = "SampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SampleForm";
            this.Load += new System.EventHandler(this.SampleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RangeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RangeDataGridView;
    }
}