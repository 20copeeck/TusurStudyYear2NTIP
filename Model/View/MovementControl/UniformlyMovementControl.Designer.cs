namespace View.MovementControl
{
    partial class UniformlyMovementControl
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
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLabel = new System.Windows.Forms.Label();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialCoordinateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialCoordinateLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialCoordinateNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.timeNumericUpDown);
            this.groupBox1.Controls.Add(this.timeLabel);
            this.groupBox1.Controls.Add(this.speedNumericUpDown);
            this.groupBox1.Controls.Add(this.initialCoordinateNumericUpDown);
            this.groupBox1.Controls.Add(this.initialCoordinateLabel);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 136);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
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
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedNumericUpDown.DecimalPlaces = 2;
            this.speedNumericUpDown.Location = new System.Drawing.Point(199, 77);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.speedNumericUpDown.TabIndex = 1;
            // 
            // initialCoordinateNumericUpDown
            // 
            this.initialCoordinateNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.initialCoordinateNumericUpDown.DecimalPlaces = 2;
            this.initialCoordinateNumericUpDown.Location = new System.Drawing.Point(199, 49);
            this.initialCoordinateNumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.initialCoordinateNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.initialCoordinateNumericUpDown.Name = "initialCoordinateNumericUpDown";
            this.initialCoordinateNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.initialCoordinateNumericUpDown.TabIndex = 0;
            // 
            // initialCoordinateLabel
            // 
            this.initialCoordinateLabel.AutoSize = true;
            this.initialCoordinateLabel.Location = new System.Drawing.Point(6, 51);
            this.initialCoordinateLabel.Name = "initialCoordinateLabel";
            this.initialCoordinateLabel.Size = new System.Drawing.Size(163, 17);
            this.initialCoordinateLabel.TabIndex = 4;
            this.initialCoordinateLabel.Text = "Начальная координата";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 79);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(103, 17);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Скорость (м/с)";
            // 
            // UniformlyMovementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UniformlyMovementControl";
            this.Size = new System.Drawing.Size(329, 148);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialCoordinateNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.NumericUpDown initialCoordinateNumericUpDown;
        private System.Windows.Forms.Label initialCoordinateLabel;
        private System.Windows.Forms.Label speedLabel;
    }
}
