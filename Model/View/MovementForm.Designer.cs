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
            Model.UniformlyMovement uniformlyMovement5 = new Model.UniformlyMovement();
            this.SelectMovementBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.oscillatoryMovementControl = new View.MovementControl.OscillatoryMovementControl();
            this.uniformlyAcceleratedMovementControl = new View.MovementControl.UniformlyAcceleratedMovementControl();
            this.uniformlyMovementControl = new View.MovementControl.UniformlyMovementControl();
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
            this.SelectMovementBox.Location = new System.Drawing.Point(144, 6);
            this.SelectMovementBox.Name = "SelectMovementBox";
            this.SelectMovementBox.Size = new System.Drawing.Size(174, 24);
            this.SelectMovementBox.TabIndex = 0;
            this.SelectMovementBox.SelectedIndexChanged += new System.EventHandler(this.SelectMovementBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вид движения";
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(144, 189);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(84, 29);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Принять";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(234, 189);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 29);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Отмена";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // oscillatoryMovementControl
            // 
            this.oscillatoryMovementControl.Location = new System.Drawing.Point(334, 163);
            this.oscillatoryMovementControl.Name = "oscillatoryMovementControl";
            this.oscillatoryMovementControl.ReadOnly = true;
            this.oscillatoryMovementControl.Size = new System.Drawing.Size(329, 148);
            this.oscillatoryMovementControl.TabIndex = 6;
            this.oscillatoryMovementControl.Visible = false;
            // 
            // uniformlyAcceleratedMovementControl
            // 
            this.uniformlyAcceleratedMovementControl.Location = new System.Drawing.Point(334, 6);
            this.uniformlyAcceleratedMovementControl.Name = "uniformlyAcceleratedMovementControl";
            this.uniformlyAcceleratedMovementControl.ReadOnly = true;
            this.uniformlyAcceleratedMovementControl.Size = new System.Drawing.Size(329, 148);
            this.uniformlyAcceleratedMovementControl.TabIndex = 5;
            this.uniformlyAcceleratedMovementControl.Visible = false;
            // 
            // uniformlyMovementControl
            // 
            this.uniformlyMovementControl.Location = new System.Drawing.Point(-1, 36);
            this.uniformlyMovementControl.Name = "uniformlyMovementControl";
            this.uniformlyMovementControl.ReadOnly = true;
            this.uniformlyMovementControl.Size = new System.Drawing.Size(329, 121);
            this.uniformlyMovementControl.TabIndex = 4;
            uniformlyMovement5.InitialCoordinate = 0D;
            uniformlyMovement5.Speed = 0D;
            uniformlyMovement5.Time = 0.01D;
            this.uniformlyMovementControl.UniformlyMovement = uniformlyMovement5;
            this.uniformlyMovementControl.Visible = false;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 311);
            this.Controls.Add(this.oscillatoryMovementControl);
            this.Controls.Add(this.uniformlyAcceleratedMovementControl);
            this.Controls.Add(this.uniformlyMovementControl);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectMovementBox);
            this.MinimumSize = new System.Drawing.Size(343, 273);
            this.Name = "MovementForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры тела";
            this.Load += new System.EventHandler(this.MovementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMovementBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button closeButton;
        private MovementControl.UniformlyMovementControl uniformlyMovementControl;
        private MovementControl.UniformlyAcceleratedMovementControl uniformlyAcceleratedMovementControl;
        private MovementControl.OscillatoryMovementControl oscillatoryMovementControl;
    }
}