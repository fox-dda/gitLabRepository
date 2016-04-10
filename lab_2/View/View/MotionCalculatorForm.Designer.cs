namespace View
{
    partial class MotionCalculatorForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotionCalculatorForm));
            this.MotionListGroupBox = new System.Windows.Forms.GroupBox();
            this.MotionDataGridView = new System.Windows.Forms.DataGridView();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveMotionButton = new System.Windows.Forms.Button();
            this.AddMotionButton = new System.Windows.Forms.Button();
            this.CreateRandomDataButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.MotionMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MotionListGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MotionDataGridView)).BeginInit();
            this.MotionMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotionListGroupBox
            // 
            this.MotionListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotionListGroupBox.Controls.Add(this.MotionDataGridView);
            this.MotionListGroupBox.Location = new System.Drawing.Point(12, 35);
            this.MotionListGroupBox.Name = "MotionListGroupBox";
            this.MotionListGroupBox.Size = new System.Drawing.Size(548, 310);
            this.MotionListGroupBox.TabIndex = 0;
            this.MotionListGroupBox.TabStop = false;
            this.MotionListGroupBox.Text = "Motion list";
            // 
            // MotionDataGridView
            // 
            this.MotionDataGridView.AllowUserToAddRows = false;
            this.MotionDataGridView.AllowUserToDeleteRows = false;
            this.MotionDataGridView.AllowUserToResizeColumns = false;
            this.MotionDataGridView.AllowUserToResizeRows = false;
            this.MotionDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MotionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Style,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.MotionDataGridView.Location = new System.Drawing.Point(6, 13);
            this.MotionDataGridView.Name = "MotionDataGridView";
            this.MotionDataGridView.RowHeadersVisible = false;
            this.MotionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MotionDataGridView.ShowEditingIcon = false;
            this.MotionDataGridView.Size = new System.Drawing.Size(537, 291);
            this.MotionDataGridView.TabIndex = 0;
            this.MotionDataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MotionDataGridView_RowEnter);
            // 
            // Style
            // 
            this.Style.HeaderText = "Style";
            this.Style.Name = "Style";
            this.Style.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Start coordinate";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start speed";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Motion time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Finish coordinate";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // RemoveMotionButton
            // 
            this.RemoveMotionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveMotionButton.Location = new System.Drawing.Point(524, 361);
            this.RemoveMotionButton.MaximumSize = new System.Drawing.Size(500, 500);
            this.RemoveMotionButton.Name = "RemoveMotionButton";
            this.RemoveMotionButton.Size = new System.Drawing.Size(169, 23);
            this.RemoveMotionButton.TabIndex = 3;
            this.RemoveMotionButton.Text = "Remove";
            this.RemoveMotionButton.UseVisualStyleBackColor = true;
            this.RemoveMotionButton.Click += new System.EventHandler(this.RemoveMotionButton_Click);
            // 
            // AddMotionButton
            // 
            this.AddMotionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddMotionButton.Location = new System.Drawing.Point(145, 361);
            this.AddMotionButton.MaximumSize = new System.Drawing.Size(500, 500);
            this.AddMotionButton.Name = "AddMotionButton";
            this.AddMotionButton.Size = new System.Drawing.Size(172, 23);
            this.AddMotionButton.TabIndex = 1;
            this.AddMotionButton.Text = "Add";
            this.AddMotionButton.UseVisualStyleBackColor = true;
            this.AddMotionButton.Click += new System.EventHandler(this.AddMotionButton_Click);
            // 
            // CreateRandomDataButton
            // 
            this.CreateRandomDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateRandomDataButton.Location = new System.Drawing.Point(145, 390);
            this.CreateRandomDataButton.MaximumSize = new System.Drawing.Size(500, 500);
            this.CreateRandomDataButton.Name = "CreateRandomDataButton";
            this.CreateRandomDataButton.Size = new System.Drawing.Size(172, 23);
            this.CreateRandomDataButton.TabIndex = 4;
            this.CreateRandomDataButton.Text = "Create random data";
            this.CreateRandomDataButton.UseVisualStyleBackColor = true;
            this.CreateRandomDataButton.Click += new System.EventHandler(this.CreateRandomDataButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ModifyButton.Location = new System.Drawing.Point(336, 361);
            this.ModifyButton.MaximumSize = new System.Drawing.Size(500, 500);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(171, 23);
            this.ModifyButton.TabIndex = 2;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // MotionMenuStrip
            // 
            this.MotionMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MotionMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MotionMenuStrip.Name = "MotionMenuStrip";
            this.MotionMenuStrip.Size = new System.Drawing.Size(828, 24);
            this.MotionMenuStrip.TabIndex = 5;
            this.MotionMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NewToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.LoadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.SaveAsToolStripMenuItem.Text = "Save As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // LoadToolStripMenuItem
            // 
            this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            this.LoadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LoadToolStripMenuItem.Text = "Load";
            this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchButton.Location = new System.Drawing.Point(336, 390);
            this.SearchButton.MaximumSize = new System.Drawing.Size(500, 500);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(171, 23);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MotionCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 426);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.CreateRandomDataButton);
            this.Controls.Add(this.RemoveMotionButton);
            this.Controls.Add(this.MotionListGroupBox);
            this.Controls.Add(this.AddMotionButton);
            this.Controls.Add(this.MotionMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MotionMenuStrip;
            this.MinimizeBox = false;
            this.Name = "MotionCalculatorForm";
            this.Text = "Motion Calculator";
            this.Activated += new System.EventHandler(this.MotionCalculator_Activated);
            this.MotionListGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MotionDataGridView)).EndInit();
            this.MotionMenuStrip.ResumeLayout(false);
            this.MotionMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MotionListGroupBox;
        private System.Windows.Forms.Button RemoveMotionButton;
        private System.Windows.Forms.Button AddMotionButton;
        private System.Windows.Forms.DataGridView MotionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button CreateRandomDataButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.MenuStrip MotionMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
        private System.Windows.Forms.Button SearchButton;
    }
}

