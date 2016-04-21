namespace View
{
    partial class AccelerationDataUserControl
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
            this.accelerationTextBox = new System.Windows.Forms.TextBox();
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accelerationTextBox
            // 
            this.accelerationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accelerationTextBox.Location = new System.Drawing.Point(92, 4);
            this.accelerationTextBox.Name = "accelerationTextBox";
            this.accelerationTextBox.Size = new System.Drawing.Size(84, 20);
            this.accelerationTextBox.TabIndex = 46;
            this.accelerationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accelerationAmplitudeTextBox_KeyPress);
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Location = new System.Drawing.Point(7, 7);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(66, 13);
            this.accelerationLabel.TabIndex = 45;
            this.accelerationLabel.Text = "Acceleration";
            // 
            // AccelerationDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accelerationTextBox);
            this.Controls.Add(this.accelerationLabel);
            this.Name = "AccelerationDataUserControl";
            this.Size = new System.Drawing.Size(182, 27);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox accelerationTextBox;
        private System.Windows.Forms.Label accelerationLabel;

    }
}
