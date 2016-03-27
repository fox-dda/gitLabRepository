namespace View
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.SearchDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.FinishCoordinateRadioButton = new System.Windows.Forms.RadioButton();
            this.MotionTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.StyleRadioButton = new System.Windows.Forms.RadioButton();
            this.StartSpeedRadioButton = new System.Windows.Forms.RadioButton();
            this.StartCoordinateRadioButton = new System.Windows.Forms.RadioButton();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TextForSearchigMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.TextForSearchingGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).BeginInit();
            this.SelectSearchGroupBox.SuspendLayout();
            this.TextForSearchingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchDataGridView
            // 
            this.SearchDataGridView.AllowUserToAddRows = false;
            this.SearchDataGridView.AllowUserToDeleteRows = false;
            this.SearchDataGridView.AllowUserToResizeColumns = false;
            this.SearchDataGridView.AllowUserToResizeRows = false;
            this.SearchDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.SearchDataGridView.Location = new System.Drawing.Point(0, 170);
            this.SearchDataGridView.Name = "SearchDataGridView";
            this.SearchDataGridView.RowHeadersVisible = false;
            this.SearchDataGridView.Size = new System.Drawing.Size(544, 219);
            this.SearchDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Style";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start coordinate";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Start speed";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Motion time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Finish coordinate";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // SelectSearchGroupBox
            // 
            this.SelectSearchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectSearchGroupBox.Controls.Add(this.FinishCoordinateRadioButton);
            this.SelectSearchGroupBox.Controls.Add(this.MotionTimeRadioButton);
            this.SelectSearchGroupBox.Controls.Add(this.StyleRadioButton);
            this.SelectSearchGroupBox.Controls.Add(this.StartSpeedRadioButton);
            this.SelectSearchGroupBox.Controls.Add(this.StartCoordinateRadioButton);
            this.SelectSearchGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SelectSearchGroupBox.Name = "SelectSearchGroupBox";
            this.SelectSearchGroupBox.Size = new System.Drawing.Size(200, 134);
            this.SelectSearchGroupBox.TabIndex = 4;
            this.SelectSearchGroupBox.TabStop = false;
            this.SelectSearchGroupBox.Text = "Selected column for search";
            // 
            // FinishCoordinateRadioButton
            // 
            this.FinishCoordinateRadioButton.AutoSize = true;
            this.FinishCoordinateRadioButton.Location = new System.Drawing.Point(58, 106);
            this.FinishCoordinateRadioButton.Name = "FinishCoordinateRadioButton";
            this.FinishCoordinateRadioButton.Size = new System.Drawing.Size(105, 17);
            this.FinishCoordinateRadioButton.TabIndex = 5;
            this.FinishCoordinateRadioButton.TabStop = true;
            this.FinishCoordinateRadioButton.Text = "Finish coordinate";
            this.FinishCoordinateRadioButton.UseVisualStyleBackColor = true;
            // 
            // MotionTimeRadioButton
            // 
            this.MotionTimeRadioButton.AutoSize = true;
            this.MotionTimeRadioButton.Location = new System.Drawing.Point(58, 83);
            this.MotionTimeRadioButton.Name = "MotionTimeRadioButton";
            this.MotionTimeRadioButton.Size = new System.Drawing.Size(79, 17);
            this.MotionTimeRadioButton.TabIndex = 3;
            this.MotionTimeRadioButton.TabStop = true;
            this.MotionTimeRadioButton.Text = "Motion time";
            this.MotionTimeRadioButton.UseVisualStyleBackColor = true;
            // 
            // StyleRadioButton
            // 
            this.StyleRadioButton.AutoSize = true;
            this.StyleRadioButton.Location = new System.Drawing.Point(58, 18);
            this.StyleRadioButton.Name = "StyleRadioButton";
            this.StyleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.StyleRadioButton.TabIndex = 0;
            this.StyleRadioButton.TabStop = true;
            this.StyleRadioButton.Text = "Style";
            this.StyleRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartSpeedRadioButton
            // 
            this.StartSpeedRadioButton.AutoSize = true;
            this.StartSpeedRadioButton.Location = new System.Drawing.Point(58, 60);
            this.StartSpeedRadioButton.Name = "StartSpeedRadioButton";
            this.StartSpeedRadioButton.Size = new System.Drawing.Size(79, 17);
            this.StartSpeedRadioButton.TabIndex = 2;
            this.StartSpeedRadioButton.TabStop = true;
            this.StartSpeedRadioButton.Text = "Start speed";
            this.StartSpeedRadioButton.UseVisualStyleBackColor = true;
            // 
            // StartCoordinateRadioButton
            // 
            this.StartCoordinateRadioButton.AutoSize = true;
            this.StartCoordinateRadioButton.Location = new System.Drawing.Point(58, 37);
            this.StartCoordinateRadioButton.Name = "StartCoordinateRadioButton";
            this.StartCoordinateRadioButton.Size = new System.Drawing.Size(100, 17);
            this.StartCoordinateRadioButton.TabIndex = 1;
            this.StartCoordinateRadioButton.TabStop = true;
            this.StartCoordinateRadioButton.Text = "Start coordinate";
            this.StartCoordinateRadioButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.Location = new System.Drawing.Point(237, 89);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TextForSearchigMaskedTextBox
            // 
            this.TextForSearchigMaskedTextBox.Location = new System.Drawing.Point(6, 19);
            this.TextForSearchigMaskedTextBox.Name = "TextForSearchigMaskedTextBox";
            this.TextForSearchigMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.TextForSearchigMaskedTextBox.TabIndex = 6;
            // 
            // TextForSearchingGroupBox
            // 
            this.TextForSearchingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextForSearchingGroupBox.Controls.Add(this.TextForSearchigMaskedTextBox);
            this.TextForSearchingGroupBox.Location = new System.Drawing.Point(218, 15);
            this.TextForSearchingGroupBox.Name = "TextForSearchingGroupBox";
            this.TextForSearchingGroupBox.Size = new System.Drawing.Size(116, 51);
            this.TextForSearchingGroupBox.TabIndex = 7;
            this.TextForSearchingGroupBox.TabStop = false;
            this.TextForSearchingGroupBox.Text = "Text for searching";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 390);
            this.Controls.Add(this.TextForSearchingGroupBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SelectSearchGroupBox);
            this.Controls.Add(this.SearchDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.SearchDataGridView)).EndInit();
            this.SelectSearchGroupBox.ResumeLayout(false);
            this.SelectSearchGroupBox.PerformLayout();
            this.TextForSearchingGroupBox.ResumeLayout(false);
            this.TextForSearchingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SearchDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox SelectSearchGroupBox;
        private System.Windows.Forms.RadioButton StyleRadioButton;
        private System.Windows.Forms.RadioButton StartCoordinateRadioButton;
        private System.Windows.Forms.RadioButton StartSpeedRadioButton;
        private System.Windows.Forms.RadioButton MotionTimeRadioButton;
        private System.Windows.Forms.RadioButton FinishCoordinateRadioButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.MaskedTextBox TextForSearchigMaskedTextBox;
        private System.Windows.Forms.GroupBox TextForSearchingGroupBox;
    }
}