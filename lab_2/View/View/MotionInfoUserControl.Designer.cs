namespace View
{
    partial class motionInfoUserControl
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
            this.MotionStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.uniformRadioButton = new System.Windows.Forms.RadioButton();
            this.accelerationRadioButton = new System.Windows.Forms.RadioButton();
            this.vibrationalRadioButton = new System.Windows.Forms.RadioButton();
            this.accelerationAmplitudeLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startSpeedLabel = new System.Windows.Forms.Label();
            this.startCoordinateLabel = new System.Windows.Forms.Label();
            this.startCoordinateTextBox = new System.Windows.Forms.TextBox();
            this.startSpeedTextBox = new System.Windows.Forms.TextBox();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.accelerationAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.MotionStyleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MotionStyleGroupBox
            // 
            this.MotionStyleGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MotionStyleGroupBox.Controls.Add(this.uniformRadioButton);
            this.MotionStyleGroupBox.Controls.Add(this.accelerationRadioButton);
            this.MotionStyleGroupBox.Controls.Add(this.vibrationalRadioButton);
            this.MotionStyleGroupBox.Location = new System.Drawing.Point(19, 21);
            this.MotionStyleGroupBox.Name = "MotionStyleGroupBox";
            this.MotionStyleGroupBox.Size = new System.Drawing.Size(171, 100);
            this.MotionStyleGroupBox.TabIndex = 36;
            this.MotionStyleGroupBox.TabStop = false;
            this.MotionStyleGroupBox.Text = "Motion style";
            // 
            // uniformRadioButton
            // 
            this.uniformRadioButton.AutoSize = true;
            this.uniformRadioButton.Location = new System.Drawing.Point(16, 25);
            this.uniformRadioButton.Name = "uniformRadioButton";
            this.uniformRadioButton.Size = new System.Drawing.Size(61, 17);
            this.uniformRadioButton.TabIndex = 6;
            this.uniformRadioButton.Text = "Uniform";
            this.uniformRadioButton.UseVisualStyleBackColor = true;
            this.uniformRadioButton.CheckedChanged += new System.EventHandler(this.uniformRadioButton_CheckedChanged);
            // 
            // accelerationRadioButton
            // 
            this.accelerationRadioButton.AutoSize = true;
            this.accelerationRadioButton.Location = new System.Drawing.Point(16, 48);
            this.accelerationRadioButton.Name = "accelerationRadioButton";
            this.accelerationRadioButton.Size = new System.Drawing.Size(82, 17);
            this.accelerationRadioButton.TabIndex = 4;
            this.accelerationRadioButton.Text = "Accelerated";
            this.accelerationRadioButton.UseVisualStyleBackColor = true;
            this.accelerationRadioButton.CheckedChanged += new System.EventHandler(this.accelerationRadioButton_CheckedChanged);
            // 
            // vibrationalRadioButton
            // 
            this.vibrationalRadioButton.AutoSize = true;
            this.vibrationalRadioButton.Location = new System.Drawing.Point(16, 71);
            this.vibrationalRadioButton.Name = "vibrationalRadioButton";
            this.vibrationalRadioButton.Size = new System.Drawing.Size(74, 17);
            this.vibrationalRadioButton.TabIndex = 5;
            this.vibrationalRadioButton.Text = "Vibrational";
            this.vibrationalRadioButton.UseVisualStyleBackColor = true;
            this.vibrationalRadioButton.CheckedChanged += new System.EventHandler(this.vibrationalRadioButton_CheckedChanged);
            // 
            // accelerationAmplitudeLabel
            // 
            this.accelerationAmplitudeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accelerationAmplitudeLabel.AutoSize = true;
            this.accelerationAmplitudeLabel.Location = new System.Drawing.Point(18, 225);
            this.accelerationAmplitudeLabel.Name = "accelerationAmplitudeLabel";
            this.accelerationAmplitudeLabel.Size = new System.Drawing.Size(66, 13);
            this.accelerationAmplitudeLabel.TabIndex = 32;
            this.accelerationAmplitudeLabel.Text = "Acceleration";
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(18, 199);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(30, 13);
            this.timeLabel.TabIndex = 31;
            this.timeLabel.Text = "Time";
            // 
            // startSpeedLabel
            // 
            this.startSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSpeedLabel.AutoSize = true;
            this.startSpeedLabel.Location = new System.Drawing.Point(18, 173);
            this.startSpeedLabel.Name = "startSpeedLabel";
            this.startSpeedLabel.Size = new System.Drawing.Size(61, 13);
            this.startSpeedLabel.TabIndex = 30;
            this.startSpeedLabel.Text = "Start speed";
            // 
            // startCoordinateLabel
            // 
            this.startCoordinateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startCoordinateLabel.AutoSize = true;
            this.startCoordinateLabel.Location = new System.Drawing.Point(18, 147);
            this.startCoordinateLabel.Name = "startCoordinateLabel";
            this.startCoordinateLabel.Size = new System.Drawing.Size(82, 13);
            this.startCoordinateLabel.TabIndex = 29;
            this.startCoordinateLabel.Text = "Start coordinate";
            // 
            // startCoordinateTextBox
            // 
            this.startCoordinateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startCoordinateTextBox.Location = new System.Drawing.Point(106, 144);
            this.startCoordinateTextBox.Name = "startCoordinateTextBox";
            this.startCoordinateTextBox.Size = new System.Drawing.Size(84, 20);
            this.startCoordinateTextBox.TabIndex = 37;
            this.startCoordinateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startCoordinateTextBox_KeyPress);
            // 
            // startSpeedTextBox
            // 
            this.startSpeedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startSpeedTextBox.Location = new System.Drawing.Point(106, 170);
            this.startSpeedTextBox.Name = "startSpeedTextBox";
            this.startSpeedTextBox.Size = new System.Drawing.Size(84, 20);
            this.startSpeedTextBox.TabIndex = 38;
            this.startSpeedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startSpeedTextBox_KeyPress);
            // 
            // timeTextBox
            // 
            this.timeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeTextBox.Location = new System.Drawing.Point(106, 196);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(84, 20);
            this.timeTextBox.TabIndex = 39;
            this.timeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeTextBox_KeyPress);
            // 
            // accelerationAmplitudeTextBox
            // 
            this.accelerationAmplitudeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accelerationAmplitudeTextBox.Location = new System.Drawing.Point(106, 222);
            this.accelerationAmplitudeTextBox.Name = "accelerationAmplitudeTextBox";
            this.accelerationAmplitudeTextBox.Size = new System.Drawing.Size(84, 20);
            this.accelerationAmplitudeTextBox.TabIndex = 40;
            this.accelerationAmplitudeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accelerationAmplitudeTextBox_KeyPress);
            // 
            // motionInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.accelerationAmplitudeTextBox);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.startSpeedTextBox);
            this.Controls.Add(this.startCoordinateTextBox);
            this.Controls.Add(this.MotionStyleGroupBox);
            this.Controls.Add(this.accelerationAmplitudeLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.startSpeedLabel);
            this.Controls.Add(this.startCoordinateLabel);
            this.Name = "motionInfoUserControl";
            this.Size = new System.Drawing.Size(206, 265);
            this.MotionStyleGroupBox.ResumeLayout(false);
            this.MotionStyleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MotionStyleGroupBox;
        private System.Windows.Forms.RadioButton uniformRadioButton;
        private System.Windows.Forms.RadioButton accelerationRadioButton;
        private System.Windows.Forms.RadioButton vibrationalRadioButton;
        private System.Windows.Forms.Label accelerationAmplitudeLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label startSpeedLabel;
        private System.Windows.Forms.Label startCoordinateLabel;
        private System.Windows.Forms.TextBox startCoordinateTextBox;
        private System.Windows.Forms.TextBox startSpeedTextBox;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox accelerationAmplitudeTextBox;



    }
}
