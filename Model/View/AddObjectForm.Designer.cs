namespace View
{
    partial class AddObjectForm
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
            this.SelectMovementBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cansel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.initialCoordinateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.initialPhaseLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.initialCoordinateNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.accelerationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amplitudeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.frequencyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.initialPhaseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.createRandomDataButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialCoordinateNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectMovementBox
            // 
            this.SelectMovementBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectMovementBox.FormattingEnabled = true;
            this.SelectMovementBox.Items.AddRange(new object[] {
            "Равномерное",
            "Равноускоренное",
            "Колебательное"});
            this.SelectMovementBox.Location = new System.Drawing.Point(159, 15);
            this.SelectMovementBox.Name = "SelectMovementBox";
            this.SelectMovementBox.Size = new System.Drawing.Size(153, 24);
            this.SelectMovementBox.TabIndex = 0;
            this.SelectMovementBox.SelectedIndexChanged += new System.EventHandler(this.SelectMovementBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид движения";
            // 
            // Cansel
            // 
            this.Cansel.Location = new System.Drawing.Point(224, 266);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(91, 28);
            this.Cansel.TabIndex = 2;
            this.Cansel.Text = "Закрыть";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(15, 266);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 28);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // initialCoordinateLabel
            // 
            this.initialCoordinateLabel.AutoSize = true;
            this.initialCoordinateLabel.Location = new System.Drawing.Point(6, 31);
            this.initialCoordinateLabel.Name = "initialCoordinateLabel";
            this.initialCoordinateLabel.Size = new System.Drawing.Size(163, 17);
            this.initialCoordinateLabel.TabIndex = 4;
            this.initialCoordinateLabel.Text = "Начальная координата";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(18, 53);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Время (сек.)";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(6, 66);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(103, 17);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Скорость (м/с)";
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Location = new System.Drawing.Point(6, 102);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(79, 17);
            this.accelerationLabel.TabIndex = 10;
            this.accelerationLabel.Text = "Ускорение";
            this.accelerationLabel.Visible = false;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(6, 34);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(80, 17);
            this.amplitudeLabel.TabIndex = 12;
            this.amplitudeLabel.Text = "Амплитуда";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 68);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(63, 17);
            this.frequencyLabel.TabIndex = 14;
            this.frequencyLabel.Text = "Частота";
            // 
            // initialPhaseLabel
            // 
            this.initialPhaseLabel.AutoSize = true;
            this.initialPhaseLabel.Location = new System.Drawing.Point(6, 103);
            this.initialPhaseLabel.Name = "initialPhaseLabel";
            this.initialPhaseLabel.Size = new System.Drawing.Size(119, 17);
            this.initialPhaseLabel.TabIndex = 15;
            this.initialPhaseLabel.Text = "Начальная фаза";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.accelerationNumericUpDown);
            this.groupBox1.Controls.Add(this.speedNumericUpDown);
            this.groupBox1.Controls.Add(this.initialCoordinateNumericUpDown);
            this.groupBox1.Controls.Add(this.initialCoordinateLabel);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.accelerationLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 133);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.initialPhaseNumericUpDown);
            this.groupBox2.Controls.Add(this.frequencyNumericUpDown);
            this.groupBox2.Controls.Add(this.amplitudeNumericUpDown);
            this.groupBox2.Controls.Add(this.amplitudeLabel);
            this.groupBox2.Controls.Add(this.frequencyLabel);
            this.groupBox2.Controls.Add(this.initialPhaseLabel);
            this.groupBox2.Location = new System.Drawing.Point(358, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 133);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристики";
            this.groupBox2.Visible = false;
            // 
            // initialCoordinateNumericUpDown
            // 
            this.initialCoordinateNumericUpDown.DecimalPlaces = 2;
            this.initialCoordinateNumericUpDown.Location = new System.Drawing.Point(186, 29);
            this.initialCoordinateNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.initialCoordinateNumericUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.initialCoordinateNumericUpDown.Name = "initialCoordinateNumericUpDown";
            this.initialCoordinateNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.initialCoordinateNumericUpDown.TabIndex = 20;
            // 
            // timeNumericUpDown
            // 
            this.timeNumericUpDown.DecimalPlaces = 2;
            this.timeNumericUpDown.Location = new System.Drawing.Point(198, 54);
            this.timeNumericUpDown.Maximum = new decimal(new int[] {
            9999,
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
            this.timeNumericUpDown.TabIndex = 21;
            this.timeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.DecimalPlaces = 2;
            this.speedNumericUpDown.Location = new System.Drawing.Point(185, 66);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.speedNumericUpDown.TabIndex = 22;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // accelerationNumericUpDown
            // 
            this.accelerationNumericUpDown.DecimalPlaces = 2;
            this.accelerationNumericUpDown.Location = new System.Drawing.Point(185, 100);
            this.accelerationNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.accelerationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.accelerationNumericUpDown.Name = "accelerationNumericUpDown";
            this.accelerationNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.accelerationNumericUpDown.TabIndex = 23;
            this.accelerationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // amplitudeNumericUpDown
            // 
            this.amplitudeNumericUpDown.DecimalPlaces = 2;
            this.amplitudeNumericUpDown.Location = new System.Drawing.Point(185, 32);
            this.amplitudeNumericUpDown.Maximum = new decimal(new int[] {
            9999,
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
            this.amplitudeNumericUpDown.TabIndex = 24;
            this.amplitudeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // frequencyNumericUpDown
            // 
            this.frequencyNumericUpDown.DecimalPlaces = 2;
            this.frequencyNumericUpDown.Location = new System.Drawing.Point(185, 66);
            this.frequencyNumericUpDown.Maximum = new decimal(new int[] {
            9999,
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
            this.frequencyNumericUpDown.TabIndex = 25;
            this.frequencyNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // initialPhaseNumericUpDown
            // 
            this.initialPhaseNumericUpDown.DecimalPlaces = 2;
            this.initialPhaseNumericUpDown.Location = new System.Drawing.Point(185, 101);
            this.initialPhaseNumericUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.initialPhaseNumericUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.initialPhaseNumericUpDown.Name = "initialPhaseNumericUpDown";
            this.initialPhaseNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.initialPhaseNumericUpDown.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 24;
            // 
            // createRandomDataButton
            // 
            this.createRandomDataButton.Location = new System.Drawing.Point(15, 228);
            this.createRandomDataButton.Name = "createRandomDataButton";
            this.createRandomDataButton.Size = new System.Drawing.Size(300, 28);
            this.createRandomDataButton.TabIndex = 20;
            this.createRandomDataButton.Text = "Сгенерировать случайные данные";
            this.createRandomDataButton.UseVisualStyleBackColor = true;
            this.createRandomDataButton.Visible = false;
            this.createRandomDataButton.Click += new System.EventHandler(this.createRandomDataButton_Click);
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 306);
            this.Controls.Add(this.createRandomDataButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.timeNumericUpDown);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMovementBox);
            this.Name = "AddObjectForm";
            this.Text = "Добавление нового объекта";
            this.Load += new System.EventHandler(this.AddObjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialCoordinateNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialPhaseNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMovementBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label initialCoordinateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Label accelerationLabel;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label initialPhaseLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown initialCoordinateNumericUpDown;
        private System.Windows.Forms.NumericUpDown accelerationNumericUpDown;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.NumericUpDown timeNumericUpDown;
        private System.Windows.Forms.NumericUpDown initialPhaseNumericUpDown;
        private System.Windows.Forms.NumericUpDown frequencyNumericUpDown;
        private System.Windows.Forms.NumericUpDown amplitudeNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createRandomDataButton;
    }
}