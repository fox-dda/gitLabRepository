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
            this.vibrationalDataUserControl1 = new View.VibrationalDataUserControl();
            this.accelerationDataUserControl1 = new View.AccelerationDataUserControl();
            this.defaultDataUserControl1 = new View.DefaultDataUserControl();
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
            // vibrationalDataUserControl1
            // 
            this.vibrationalDataUserControl1.Location = new System.Drawing.Point(8, 231);
            this.vibrationalDataUserControl1.Name = "vibrationalDataUserControl1";
            this.vibrationalDataUserControl1.ReadOnly = true;
            this.vibrationalDataUserControl1.Size = new System.Drawing.Size(182, 27);
            this.vibrationalDataUserControl1.TabIndex = 46;
            this.vibrationalDataUserControl1.Visible = false;
            // 
            // accelerationDataUserControl1
            // 
            this.accelerationDataUserControl1.Location = new System.Drawing.Point(8, 205);
            this.accelerationDataUserControl1.Name = "accelerationDataUserControl1";
            this.accelerationDataUserControl1.ReadOnly = true;
            this.accelerationDataUserControl1.Size = new System.Drawing.Size(182, 27);
            this.accelerationDataUserControl1.TabIndex = 45;
            this.accelerationDataUserControl1.Visible = false;
            // 
            // defaultDataUserControl1
            // 
            this.defaultDataUserControl1.Location = new System.Drawing.Point(8, 127);
            this.defaultDataUserControl1.Name = "defaultDataUserControl1";
            this.defaultDataUserControl1.ReadOnly = true;
            this.defaultDataUserControl1.Size = new System.Drawing.Size(182, 81);
            this.defaultDataUserControl1.StartCoordinate = "";
            this.defaultDataUserControl1.StartSpeed = "";
            this.defaultDataUserControl1.TabIndex = 44;
            this.defaultDataUserControl1.Time = "";
            // 
            // motionInfoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.vibrationalDataUserControl1);
            this.Controls.Add(this.accelerationDataUserControl1);
            this.Controls.Add(this.defaultDataUserControl1);
            this.Controls.Add(this.MotionStyleGroupBox);
            this.Name = "motionInfoUserControl";
            this.Size = new System.Drawing.Size(206, 265);
            this.MotionStyleGroupBox.ResumeLayout(false);
            this.MotionStyleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MotionStyleGroupBox;
        private System.Windows.Forms.RadioButton uniformRadioButton;
        private System.Windows.Forms.RadioButton accelerationRadioButton;
        private System.Windows.Forms.RadioButton vibrationalRadioButton;
        private DefaultDataUserControl defaultDataUserControl1;
        private AccelerationDataUserControl accelerationDataUserControl1;
        private VibrationalDataUserControl vibrationalDataUserControl1;



    }
}
