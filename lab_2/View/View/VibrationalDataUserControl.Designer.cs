namespace View
{
    partial class VibrationalDataUserControl
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
            this.amplitudeTextBox = new System.Windows.Forms.TextBox();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amplitudeTextBox
            // 
            this.amplitudeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amplitudeTextBox.Location = new System.Drawing.Point(92, 4);
            this.amplitudeTextBox.Name = "amplitudeTextBox";
            this.amplitudeTextBox.Size = new System.Drawing.Size(84, 20);
            this.amplitudeTextBox.TabIndex = 50;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(7, 7);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(53, 13);
            this.amplitudeLabel.TabIndex = 49;
            this.amplitudeLabel.Text = "Amplitude";
            // 
            // VibrationalDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amplitudeTextBox);
            this.Controls.Add(this.amplitudeLabel);
            this.Name = "VibrationalDataUserControl";
            this.Size = new System.Drawing.Size(182, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amplitudeTextBox;
        private System.Windows.Forms.Label amplitudeLabel;


    }
}
