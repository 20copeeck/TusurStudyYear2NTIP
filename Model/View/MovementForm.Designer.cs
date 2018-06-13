namespace View
{
    partial class MovementForm
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
            Model.UniformlyMovement uniformlyMovement1 = new Model.UniformlyMovement();
            this.SelectMovementBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cansel = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.oscillatoryMovementControl1 = new View.MovementControl.OscillatoryMovementControl();
            this.uniformlyAcceleratedMovementControl1 = new View.UniformlyAcceleratedMovementControl();
            this.uniformlyMovementControl1 = new View.UniformlyMovementControl();
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
            this.SelectMovementBox.Location = new System.Drawing.Point(153, 15);
            this.SelectMovementBox.Name = "SelectMovementBox";
            this.SelectMovementBox.Size = new System.Drawing.Size(163, 24);
            this.SelectMovementBox.TabIndex = 1;
            this.SelectMovementBox.SelectedIndexChanged += new System.EventHandler(this.SelectMovementBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид движения";
            // 
            // Cansel
            // 
            this.Cansel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cansel.Location = new System.Drawing.Point(234, 228);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(91, 28);
            this.Cansel.TabIndex = 4;
            this.Cansel.Text = "Закрыть";
            this.Cansel.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(137, 228);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(91, 28);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // oscillatoryMovementControl1
            // 
            this.oscillatoryMovementControl1.Location = new System.Drawing.Point(12, 262);
            this.oscillatoryMovementControl1.Name = "oscillatoryMovementControl1";
            this.oscillatoryMovementControl1.ReadOnly = true;
            this.oscillatoryMovementControl1.Size = new System.Drawing.Size(329, 148);
            this.oscillatoryMovementControl1.TabIndex = 22;
            // 
            // uniformlyAcceleratedMovementControl1
            // 
            this.uniformlyAcceleratedMovementControl1.Location = new System.Drawing.Point(347, 45);
            this.uniformlyAcceleratedMovementControl1.Name = "uniformlyAcceleratedMovementControl1";
            this.uniformlyAcceleratedMovementControl1.ReadOnly = true;
            this.uniformlyAcceleratedMovementControl1.Size = new System.Drawing.Size(329, 148);
            this.uniformlyAcceleratedMovementControl1.TabIndex = 21;
            // 
            // uniformlyMovementControl1
            // 
            this.uniformlyMovementControl1.Location = new System.Drawing.Point(-4, 45);
            this.uniformlyMovementControl1.Name = "uniformlyMovementControl1";
            this.uniformlyMovementControl1.ReadOnly = true;
            this.uniformlyMovementControl1.Size = new System.Drawing.Size(329, 118);
            this.uniformlyMovementControl1.TabIndex = 20;
            uniformlyMovement1.InitialCoordinate = 0D;
            uniformlyMovement1.Speed = 0D;
            uniformlyMovement1.Time = 0.01D;
            this.uniformlyMovementControl1.UniformlyMovement = uniformlyMovement1;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 425);
            this.Controls.Add(this.oscillatoryMovementControl1);
            this.Controls.Add(this.uniformlyAcceleratedMovementControl1);
            this.Controls.Add(this.uniformlyMovementControl1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMovementBox);
            this.MinimumSize = new System.Drawing.Size(353, 309);
            this.Name = "MovementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление нового объекта";
            this.Load += new System.EventHandler(this.AddObjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMovementBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button okButton;
        private UniformlyMovementControl uniformlyMovementControl1;
        private UniformlyAcceleratedMovementControl uniformlyAcceleratedMovementControl1;
        private MovementControl.OscillatoryMovementControl oscillatoryMovementControl1;
    }
}