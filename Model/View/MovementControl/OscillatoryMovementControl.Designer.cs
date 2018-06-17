namespace View.MovementControl
{
    partial class OscillatoryMovementControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.initialPhaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialPhaseLabel = new System.Windows.Forms.Label();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.amplitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.frequencyNumericUpDown);
            this.groupBox1.Controls.Add(this.amplitudeNumericUpDown);
            this.groupBox1.Controls.Add(this.frequencyLabel);
            this.groupBox1.Controls.Add(this.timeNumericUpDown);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.initialPhaseNumericUpDown);
            this.groupBox1.Controls.Add(this.initialPhaseLabel);
            this.groupBox1.Controls.Add(this.amplitudeLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 136);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 107);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(63, 17);
            this.frequencyLabel.TabIndex = 26;
            this.frequencyLabel.Text = "Частота";
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeNumericUpDown.DecimalPlaces = 2;
            this.timeNumericUpDown.Location = new System.Drawing.Point(199, 21);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.timeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.timeNumericUpDown.Name = "timeNumericUpDown";
            this.timeNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.timeNumericUpDown.TabIndex = 24;
            this.timeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(6, 23);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 17);
            this.timeLabel.TabIndex = 25;
            this.timeLabel.Text = "Время (сек.)";
            // 
            // initialPhaseNumericUpDown
            // 
            this.initialPhaseNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initialPhaseNumericUpDown.DecimalPlaces = 2;
            this.initialPhaseNumericUpDown.Location = new System.Drawing.Point(199, 49);
            this.initialPhaseNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.initialPhaseNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.initialPhaseNumericUpDown.Name = "initialPhaseNumericUpDown";
            this.initialPhaseNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.initialPhaseNumericUpDown.TabIndex = 0;
            // 
            // initialPhaseLabel
            // 
            this.initialPhaseLabel.AutoSize = true;
            this.initialPhaseLabel.Location = new System.Drawing.Point(6, 51);
            this.initialPhaseLabel.Name = "initialPhaseLabel";
            this.initialPhaseLabel.Size = new System.Drawing.Size(119, 17);
            this.initialPhaseLabel.TabIndex = 4;
            this.initialPhaseLabel.Text = "Начальная фаза";
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(6, 79);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(80, 17);
            this.amplitudeLabel.TabIndex = 6;
            this.amplitudeLabel.Text = "Амплитуда";
            // 
            // amplitudeNumericUpDown
            // 
            this.amplitudeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amplitudeNumericUpDown.DecimalPlaces = 2;
            this.amplitudeNumericUpDown.Location = new System.Drawing.Point(199, 77);
            this.amplitudeNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.amplitudeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.amplitudeNumericUpDown.Name = "amplitudeNumericUpDown";
            this.amplitudeNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.amplitudeNumericUpDown.TabIndex = 27;
            this.amplitudeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNumericUpDown.DecimalPlaces = 2;
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(199, 105);
            this.frequencyNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.frequencyNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.frequencyNumericUpDown.Name = "frequencyNumericUpDown";
            this.frequencyNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.frequencyNumericUpDown.TabIndex = 28;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // OscillatoryMovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "OscillatoryMovementControl";
            this.Size = new System.Drawing.Size(329, 148);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown initialPhaseNumericUpDown;
        private System.Windows.Forms.Label initialPhaseLabel;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.NumericUpDown amplitudeNumericUpDown;
    }
}
