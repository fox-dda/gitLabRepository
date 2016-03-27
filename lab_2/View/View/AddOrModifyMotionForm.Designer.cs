namespace View
{
    partial class AddOrModifyMotionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrModifyMotionForm));
            this.StartCoordinateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartSpeedMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MotionTimeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AcceleratedRadioButton = new System.Windows.Forms.RadioButton();
            this.VibrationalRadioButton = new System.Windows.Forms.RadioButton();
            this.StartCooddinateLabel = new System.Windows.Forms.Label();
            this.StartSpeedLabel = new System.Windows.Forms.Label();
            this.MotionTimeLabel = new System.Windows.Forms.Label();
            this.MotionStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.UniformRadioButton = new System.Windows.Forms.RadioButton();
            this.AddButton = new System.Windows.Forms.Button();
            this.AccelerationLabel = new System.Windows.Forms.Label();
            this.AmplitudeLabel = new System.Windows.Forms.Label();
            this.AccelerationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AmplitudeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MotionStyleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartCoordinateMaskedTextBox
            // 
            this.StartCoordinateMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCoordinateMaskedTextBox.Location = new System.Drawing.Point(101, 135);
            this.StartCoordinateMaskedTextBox.Mask = "00000";
            this.StartCoordinateMaskedTextBox.Name = "StartCoordinateMaskedTextBox";
            this.StartCoordinateMaskedTextBox.PromptChar = ' ';
            this.StartCoordinateMaskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.StartCoordinateMaskedTextBox.TabIndex = 0;
            this.StartCoordinateMaskedTextBox.ValidatingType = typeof(int);
            this.StartCoordinateMaskedTextBox.TextChanged += new System.EventHandler(this.StartCoordinateMaskedTextBox_TextChanged);
            // 
            // StartSpeedMaskedTextBox
            // 
            this.StartSpeedMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSpeedMaskedTextBox.Location = new System.Drawing.Point(101, 161);
            this.StartSpeedMaskedTextBox.Mask = "00000";
            this.StartSpeedMaskedTextBox.Name = "StartSpeedMaskedTextBox";
            this.StartSpeedMaskedTextBox.PromptChar = ' ';
            this.StartSpeedMaskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.StartSpeedMaskedTextBox.TabIndex = 1;
            this.StartSpeedMaskedTextBox.ValidatingType = typeof(int);
            this.StartSpeedMaskedTextBox.TextChanged += new System.EventHandler(this.StartSpeedMaskedTextBox_TextChanged);
            // 
            // MotionTimeMaskedTextBox
            // 
            this.MotionTimeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MotionTimeMaskedTextBox.Location = new System.Drawing.Point(101, 187);
            this.MotionTimeMaskedTextBox.Mask = "00000";
            this.MotionTimeMaskedTextBox.Name = "MotionTimeMaskedTextBox";
            this.MotionTimeMaskedTextBox.PromptChar = ' ';
            this.MotionTimeMaskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.MotionTimeMaskedTextBox.TabIndex = 2;
            this.MotionTimeMaskedTextBox.ValidatingType = typeof(int);
            this.MotionTimeMaskedTextBox.TextChanged += new System.EventHandler(this.MotionTimeMaskedTextBox_TextChanged);
            // 
            // AcceleratedRadioButton
            // 
            this.AcceleratedRadioButton.AutoSize = true;
            this.AcceleratedRadioButton.Location = new System.Drawing.Point(16, 48);
            this.AcceleratedRadioButton.Name = "AcceleratedRadioButton";
            this.AcceleratedRadioButton.Size = new System.Drawing.Size(82, 17);
            this.AcceleratedRadioButton.TabIndex = 4;
            this.AcceleratedRadioButton.Text = "Accelerated";
            this.AcceleratedRadioButton.UseVisualStyleBackColor = true;
            this.AcceleratedRadioButton.CheckedChanged += new System.EventHandler(this.AcceleratedRadioButton_CheckedChanged);
            // 
            // VibrationalRadioButton
            // 
            this.VibrationalRadioButton.AutoSize = true;
            this.VibrationalRadioButton.Location = new System.Drawing.Point(16, 71);
            this.VibrationalRadioButton.Name = "VibrationalRadioButton";
            this.VibrationalRadioButton.Size = new System.Drawing.Size(74, 17);
            this.VibrationalRadioButton.TabIndex = 5;
            this.VibrationalRadioButton.Text = "Vibrational";
            this.VibrationalRadioButton.UseVisualStyleBackColor = true;
            this.VibrationalRadioButton.CheckedChanged += new System.EventHandler(this.VabrationalRadioButton_CheckedChanged);
            // 
            // StartCooddinateLabel
            // 
            this.StartCooddinateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCooddinateLabel.AutoSize = true;
            this.StartCooddinateLabel.Location = new System.Drawing.Point(13, 138);
            this.StartCooddinateLabel.Name = "StartCooddinateLabel";
            this.StartCooddinateLabel.Size = new System.Drawing.Size(82, 13);
            this.StartCooddinateLabel.TabIndex = 6;
            this.StartCooddinateLabel.Text = "Start coordinate";
            // 
            // StartSpeedLabel
            // 
            this.StartSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StartSpeedLabel.AutoSize = true;
            this.StartSpeedLabel.Location = new System.Drawing.Point(13, 164);
            this.StartSpeedLabel.Name = "StartSpeedLabel";
            this.StartSpeedLabel.Size = new System.Drawing.Size(61, 13);
            this.StartSpeedLabel.TabIndex = 7;
            this.StartSpeedLabel.Text = "Start speed";
            // 
            // MotionTimeLabel
            // 
            this.MotionTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MotionTimeLabel.AutoSize = true;
            this.MotionTimeLabel.Location = new System.Drawing.Point(13, 190);
            this.MotionTimeLabel.Name = "MotionTimeLabel";
            this.MotionTimeLabel.Size = new System.Drawing.Size(61, 13);
            this.MotionTimeLabel.TabIndex = 8;
            this.MotionTimeLabel.Text = "Motion time";
            // 
            // MotionStyleGroupBox
            // 
            this.MotionStyleGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MotionStyleGroupBox.Controls.Add(this.UniformRadioButton);
            this.MotionStyleGroupBox.Controls.Add(this.AcceleratedRadioButton);
            this.MotionStyleGroupBox.Controls.Add(this.VibrationalRadioButton);
            this.MotionStyleGroupBox.Location = new System.Drawing.Point(17, 12);
            this.MotionStyleGroupBox.Name = "MotionStyleGroupBox";
            this.MotionStyleGroupBox.Size = new System.Drawing.Size(171, 100);
            this.MotionStyleGroupBox.TabIndex = 9;
            this.MotionStyleGroupBox.TabStop = false;
            this.MotionStyleGroupBox.Text = "Motion style";
            // 
            // UniformRadioButton
            // 
            this.UniformRadioButton.AutoSize = true;
            this.UniformRadioButton.Location = new System.Drawing.Point(16, 25);
            this.UniformRadioButton.Name = "UniformRadioButton";
            this.UniformRadioButton.Size = new System.Drawing.Size(61, 17);
            this.UniformRadioButton.TabIndex = 6;
            this.UniformRadioButton.Text = "Uniform";
            this.UniformRadioButton.UseVisualStyleBackColor = true;
            this.UniformRadioButton.CheckedChanged += new System.EventHandler(this.UniformCheckBox_CheckedChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(143, 300);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 10;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AccelerationLabel
            // 
            this.AccelerationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AccelerationLabel.AutoSize = true;
            this.AccelerationLabel.Location = new System.Drawing.Point(13, 216);
            this.AccelerationLabel.Name = "AccelerationLabel";
            this.AccelerationLabel.Size = new System.Drawing.Size(66, 13);
            this.AccelerationLabel.TabIndex = 11;
            this.AccelerationLabel.Text = "Acceleration";
            // 
            // AmplitudeLabel
            // 
            this.AmplitudeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AmplitudeLabel.AutoSize = true;
            this.AmplitudeLabel.Location = new System.Drawing.Point(13, 242);
            this.AmplitudeLabel.Name = "AmplitudeLabel";
            this.AmplitudeLabel.Size = new System.Drawing.Size(53, 13);
            this.AmplitudeLabel.TabIndex = 12;
            this.AmplitudeLabel.Text = "Amplitude";
            // 
            // AccelerationMaskedTextBox
            // 
            this.AccelerationMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AccelerationMaskedTextBox.Location = new System.Drawing.Point(101, 213);
            this.AccelerationMaskedTextBox.Name = "AccelerationMaskedTextBox";
            this.AccelerationMaskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.AccelerationMaskedTextBox.TabIndex = 13;
            this.AccelerationMaskedTextBox.TextChanged += new System.EventHandler(this.AccelerationMaskedTextBox_TextChanged);
            // 
            // AmplitudeMaskedTextBox
            // 
            this.AmplitudeMaskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AmplitudeMaskedTextBox.Location = new System.Drawing.Point(101, 239);
            this.AmplitudeMaskedTextBox.Name = "AmplitudeMaskedTextBox";
            this.AmplitudeMaskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.AmplitudeMaskedTextBox.TabIndex = 14;
            this.AmplitudeMaskedTextBox.TextChanged += new System.EventHandler(this.AmplitudeMaskedTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CancelButton.Location = new System.Drawing.Point(33, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 15;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AddOrModifyMotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 353);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AmplitudeMaskedTextBox);
            this.Controls.Add(this.AccelerationMaskedTextBox);
            this.Controls.Add(this.AmplitudeLabel);
            this.Controls.Add(this.AccelerationLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MotionStyleGroupBox);
            this.Controls.Add(this.MotionTimeLabel);
            this.Controls.Add(this.StartSpeedLabel);
            this.Controls.Add(this.StartCooddinateLabel);
            this.Controls.Add(this.MotionTimeMaskedTextBox);
            this.Controls.Add(this.StartSpeedMaskedTextBox);
            this.Controls.Add(this.StartCoordinateMaskedTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddOrModifyMotionForm";
            this.ShowInTaskbar = false;
            this.Text = "Add motion";
            this.Load += new System.EventHandler(this.addMotion_Load);
            this.MotionStyleGroupBox.ResumeLayout(false);
            this.MotionStyleGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox StartCoordinateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox StartSpeedMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MotionTimeMaskedTextBox;
        private System.Windows.Forms.RadioButton AcceleratedRadioButton;
        private System.Windows.Forms.RadioButton VibrationalRadioButton;
        private System.Windows.Forms.Label StartCooddinateLabel;
        private System.Windows.Forms.Label StartSpeedLabel;
        private System.Windows.Forms.Label MotionTimeLabel;
        private System.Windows.Forms.GroupBox MotionStyleGroupBox;
        private System.Windows.Forms.RadioButton UniformRadioButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AccelerationLabel;
        private System.Windows.Forms.Label AmplitudeLabel;
        private System.Windows.Forms.MaskedTextBox AccelerationMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox AmplitudeMaskedTextBox;
        private System.Windows.Forms.Button CancelButton;
    }
}