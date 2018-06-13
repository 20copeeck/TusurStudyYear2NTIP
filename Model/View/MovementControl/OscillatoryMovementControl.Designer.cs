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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.initialPhaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amplitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.initialPhaseLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.timeNumericUpDown);
            this.groupBox2.Controls.Add(this.timeLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.initialPhaseNumericUpDown);
            this.groupBox2.Controls.Add(this.frequencyNumericUpDown);
            this.groupBox2.Controls.Add(this.amplitudeNumericUpDown);
            this.groupBox2.Controls.Add(this.amplitudeLabel);
            this.groupBox2.Controls.Add(this.frequencyLabel);
            this.groupBox2.Controls.Add(this.initialPhaseLabel);
            this.groupBox2.Location = new System.Drawing.Point(7, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 136);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики";
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
            this.timeNumericUpDown.TabIndex = 23;
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
            this.timeLabel.TabIndex = 24;
            this.timeLabel.Text = "Время (сек.)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 24;
            // 
            // initialPhaseNumericUpDown
            // 
            this.initialPhaseNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initialPhaseNumericUpDown.DecimalPlaces = 2;
            this.initialPhaseNumericUpDown.Location = new System.Drawing.Point(199, 105);
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
            this.initialPhaseNumericUpDown.TabIndex = 2;
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.frequencyNumericUpDown.DecimalPlaces = 2;
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(199, 77);
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
            this.frequencyNumericUpDown.TabIndex = 1;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // amplitudeNumericUpDown
            // 
            this.amplitudeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amplitudeNumericUpDown.DecimalPlaces = 2;
            this.amplitudeNumericUpDown.Location = new System.Drawing.Point(199, 49);
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
            this.amplitudeNumericUpDown.TabIndex = 0;
            this.amplitudeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(6, 51);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(80, 17);
            this.amplitudeLabel.TabIndex = 12;
            this.amplitudeLabel.Text = "Амплитуда";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 79);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(63, 17);
            this.frequencyLabel.TabIndex = 14;
            this.frequencyLabel.Text = "Частота";
            // 
            // initialPhaseLabel
            // 
            this.initialPhaseLabel.AutoSize = true;
            this.initialPhaseLabel.Location = new System.Drawing.Point(6, 107);
            this.initialPhaseLabel.Name = "initialPhaseLabel";
            this.initialPhaseLabel.Size = new System.Drawing.Size(119, 17);
            this.initialPhaseLabel.TabIndex = 15;
            this.initialPhaseLabel.Text = "Начальная фаза";
            // 
            // OscillatoryMovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "OscillatoryMovementControl";
            this.Size = new System.Drawing.Size(329, 148);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown initialPhaseNumericUpDown;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.NumericUpDown amplitudeNumericUpDown;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label initialPhaseLabel;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label timeLabel;
    }
}
