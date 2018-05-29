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
            this.Ok = new System.Windows.Forms.Button();
            this.initialCoordinateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.initialCoordinateMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.speedMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.accelerationLabel = new System.Windows.Forms.Label();
            this.accelerationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.amplitudeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.initialPhaseLabel = new System.Windows.Forms.Label();
            this.frequencyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.initialPhaseMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.SelectMovementBox.Location = new System.Drawing.Point(193, 16);
            this.SelectMovementBox.Name = "SelectMovementBox";
            this.SelectMovementBox.Size = new System.Drawing.Size(153, 24);
            this.SelectMovementBox.TabIndex = 0;
            this.SelectMovementBox.SelectedIndexChanged += new System.EventHandler(this.SelectMovementBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите движение";
            // 
            // Cansel
            // 
            this.Cansel.Location = new System.Drawing.Point(473, 194);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(91, 28);
            this.Cansel.TabIndex = 2;
            this.Cansel.Text = "Отмена";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(362, 194);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(91, 28);
            this.Ok.TabIndex = 3;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // initialCoordinateLabel
            // 
            this.initialCoordinateLabel.AutoSize = true;
            this.initialCoordinateLabel.Location = new System.Drawing.Point(13, 87);
            this.initialCoordinateLabel.Name = "initialCoordinateLabel";
            this.initialCoordinateLabel.Size = new System.Drawing.Size(163, 17);
            this.initialCoordinateLabel.TabIndex = 4;
            this.initialCoordinateLabel.Text = "Начальная координата";
            this.initialCoordinateLabel.Visible = false;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 52);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(90, 17);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "Время (сек.)";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(12, 122);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(103, 17);
            this.speedLabel.TabIndex = 6;
            this.speedLabel.Text = "Скорость (м/с)";
            this.speedLabel.Visible = false;
            // 
            // initialCoordinateMaskedTextBox
            // 
            this.initialCoordinateMaskedTextBox.Location = new System.Drawing.Point(194, 87);
            this.initialCoordinateMaskedTextBox.Mask = "000.00";
            this.initialCoordinateMaskedTextBox.Name = "initialCoordinateMaskedTextBox";
            this.initialCoordinateMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.initialCoordinateMaskedTextBox.TabIndex = 7;
            this.initialCoordinateMaskedTextBox.Text = "00000";
            this.initialCoordinateMaskedTextBox.Visible = false;
            // 
            // timeMaskedTextBox
            // 
            this.timeMaskedTextBox.Location = new System.Drawing.Point(193, 52);
            this.timeMaskedTextBox.Mask = "000.00";
            this.timeMaskedTextBox.Name = "timeMaskedTextBox";
            this.timeMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.timeMaskedTextBox.TabIndex = 8;
            this.timeMaskedTextBox.Text = "00000";
            this.timeMaskedTextBox.ValidatingType = typeof(int);
            // 
            // speedMaskedTextBox
            // 
            this.speedMaskedTextBox.Location = new System.Drawing.Point(193, 122);
            this.speedMaskedTextBox.Mask = "000.00";
            this.speedMaskedTextBox.Name = "speedMaskedTextBox";
            this.speedMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.speedMaskedTextBox.TabIndex = 9;
            this.speedMaskedTextBox.Text = "00000";
            this.speedMaskedTextBox.ValidatingType = typeof(int);
            this.speedMaskedTextBox.Visible = false;
            // 
            // accelerationLabel
            // 
            this.accelerationLabel.AutoSize = true;
            this.accelerationLabel.Location = new System.Drawing.Point(13, 159);
            this.accelerationLabel.Name = "accelerationLabel";
            this.accelerationLabel.Size = new System.Drawing.Size(79, 17);
            this.accelerationLabel.TabIndex = 10;
            this.accelerationLabel.Text = "Ускорение";
            this.accelerationLabel.Visible = false;
            // 
            // accelerationMaskedTextBox
            // 
            this.accelerationMaskedTextBox.Location = new System.Drawing.Point(193, 159);
            this.accelerationMaskedTextBox.Mask = "000.00";
            this.accelerationMaskedTextBox.Name = "accelerationMaskedTextBox";
            this.accelerationMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.accelerationMaskedTextBox.TabIndex = 11;
            this.accelerationMaskedTextBox.Text = "00000";
            this.accelerationMaskedTextBox.Visible = false;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(339, 57);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(80, 17);
            this.amplitudeLabel.TabIndex = 12;
            this.amplitudeLabel.Text = "Амплитуда";
            this.amplitudeLabel.Visible = false;
            // 
            // amplitudeMaskedTextBox
            // 
            this.amplitudeMaskedTextBox.Location = new System.Drawing.Point(464, 54);
            this.amplitudeMaskedTextBox.Mask = "000.00";
            this.amplitudeMaskedTextBox.Name = "amplitudeMaskedTextBox";
            this.amplitudeMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.amplitudeMaskedTextBox.TabIndex = 13;
            this.amplitudeMaskedTextBox.Text = "00000";
            this.amplitudeMaskedTextBox.ValidatingType = typeof(int);
            this.amplitudeMaskedTextBox.Visible = false;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(339, 92);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(63, 17);
            this.frequencyLabel.TabIndex = 14;
            this.frequencyLabel.Text = "Частота";
            this.frequencyLabel.Visible = false;
            // 
            // initialPhaseLabel
            // 
            this.initialPhaseLabel.AutoSize = true;
            this.initialPhaseLabel.Location = new System.Drawing.Point(339, 127);
            this.initialPhaseLabel.Name = "initialPhaseLabel";
            this.initialPhaseLabel.Size = new System.Drawing.Size(119, 17);
            this.initialPhaseLabel.TabIndex = 15;
            this.initialPhaseLabel.Text = "Начальная фаза";
            this.initialPhaseLabel.Visible = false;
            // 
            // frequencyMaskedTextBox
            // 
            this.frequencyMaskedTextBox.Location = new System.Drawing.Point(464, 87);
            this.frequencyMaskedTextBox.Mask = "000.00";
            this.frequencyMaskedTextBox.Name = "frequencyMaskedTextBox";
            this.frequencyMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.frequencyMaskedTextBox.TabIndex = 16;
            this.frequencyMaskedTextBox.Text = "00000";
            this.frequencyMaskedTextBox.ValidatingType = typeof(int);
            this.frequencyMaskedTextBox.Visible = false;
            // 
            // initialPhaseMaskedTextBox
            // 
            this.initialPhaseMaskedTextBox.Location = new System.Drawing.Point(464, 124);
            this.initialPhaseMaskedTextBox.Mask = "000.00";
            this.initialPhaseMaskedTextBox.Name = "initialPhaseMaskedTextBox";
            this.initialPhaseMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.initialPhaseMaskedTextBox.TabIndex = 17;
            this.initialPhaseMaskedTextBox.Text = "00000";
            this.initialPhaseMaskedTextBox.ValidatingType = typeof(int);
            this.initialPhaseMaskedTextBox.Visible = false;
            // 
            // AddObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 234);
            this.Controls.Add(this.initialPhaseMaskedTextBox);
            this.Controls.Add(this.frequencyMaskedTextBox);
            this.Controls.Add(this.initialPhaseLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.amplitudeMaskedTextBox);
            this.Controls.Add(this.amplitudeLabel);
            this.Controls.Add(this.accelerationMaskedTextBox);
            this.Controls.Add(this.accelerationLabel);
            this.Controls.Add(this.speedMaskedTextBox);
            this.Controls.Add(this.timeMaskedTextBox);
            this.Controls.Add(this.initialCoordinateMaskedTextBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.initialCoordinateLabel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMovementBox);
            this.Name = "AddObjectForm";
            this.Text = "Добавление нового объекта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMovementBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label initialCoordinateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.MaskedTextBox initialCoordinateMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox timeMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox speedMaskedTextBox;
        private System.Windows.Forms.Label accelerationLabel;
        private System.Windows.Forms.MaskedTextBox accelerationMaskedTextBox;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.MaskedTextBox amplitudeMaskedTextBox;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label initialPhaseLabel;
        private System.Windows.Forms.MaskedTextBox frequencyMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox initialPhaseMaskedTextBox;
    }
}