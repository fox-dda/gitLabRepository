namespace View
{
    partial class DefaultDataUserControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.startSpeedTextBox = new System.Windows.Forms.TextBox();
            this.startCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startSpeedLabel = new System.Windows.Forms.Label();
            this.startCoordinateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTextBox.Location = new System.Drawing.Point(92, 56);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(84, 20);
            this.timeTextBox.TabIndex = 51;
            // 
            // startSpeedTextBox
            // 
            this.startSpeedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSpeedTextBox.Location = new System.Drawing.Point(92, 30);
            this.startSpeedTextBox.Name = "startSpeedTextBox";
            this.startSpeedTextBox.Size = new System.Drawing.Size(84, 20);
            this.startSpeedTextBox.TabIndex = 50;
            // 
            // startCoordinateTextBox
            // 
            this.startCoordinateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startCoordinateTextBox.Location = new System.Drawing.Point(92, 4);
            this.startCoordinateTextBox.Name = "startCoordinateTextBox";
            this.startCoordinateTextBox.Size = new System.Drawing.Size(84, 20);
            this.startCoordinateTextBox.TabIndex = 49;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(7, 59);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 48;
            this.timeLabel.Text = "Time";
            // 
            // startSpeedLabel
            // 
            this.startSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSpeedLabel.AutoSize = true;
            this.startSpeedLabel.Location = new System.Drawing.Point(7, 33);
            this.startSpeedLabel.Name = "startSpeedLabel";
            this.startSpeedLabel.Size = new System.Drawing.Size(61, 13);
            this.startSpeedLabel.TabIndex = 47;
            this.startSpeedLabel.Text = "Start speed";
            // 
            // startCoordinateLabel
            // 
            this.startCoordinateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startCoordinateLabel.AutoSize = true;
            this.startCoordinateLabel.Location = new System.Drawing.Point(7, 7);
            this.startCoordinateLabel.Name = "startCoordinateLabel";
            this.startCoordinateLabel.Size = new System.Drawing.Size(82, 13);
            this.startCoordinateLabel.TabIndex = 46;
            this.startCoordinateLabel.Text = "Start coordinate";
            // 
            // DefaultDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.startSpeedTextBox);
            this.Controls.Add(this.startCoordinateTextBox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startSpeedLabel);
            this.Controls.Add(this.startCoordinateLabel);
            this.Name = "DefaultDataUserControl";
            this.Size = new System.Drawing.Size(182, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox startSpeedTextBox;
        private System.Windows.Forms.TextBox startCoordinateTextBox;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label startSpeedLabel;
        private System.Windows.Forms.Label startCoordinateLabel;

    }
}
