namespace View
{
    partial class CalculationCoordinatesForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Model.UniformlyMovement uniformlyMovement1 = new Model.UniformlyMovement();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.searchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RemoveSolid = new System.Windows.Forms.Button();
            this.AddSolid = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.oscillatoryMovementControl1 = new View.MovementControl.OscillatoryMovementControl();
            this.uniformlyAcceleratedMovementControl1 = new View.MovementControl.UniformlyAcceleratedMovementControl();
            this.uniformlyMovementControl1 = new View.MovementControl.UniformlyMovementControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(15, 93);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(130, 33);
            this.ModifyButton.TabIndex = 6;
            this.ModifyButton.Text = "Изменить";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // searchNumericUpDown
            // 
            this.searchNumericUpDown.DecimalPlaces = 2;
            this.searchNumericUpDown.Location = new System.Drawing.Point(207, 42);
            this.searchNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.searchNumericUpDown.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.searchNumericUpDown.Name = "searchNumericUpDown";
            this.searchNumericUpDown.Size = new System.Drawing.Size(101, 22);
            this.searchNumericUpDown.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Найти координату более";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(178, 93);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(130, 33);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RemoveSolid
            // 
            this.RemoveSolid.Location = new System.Drawing.Point(178, 155);
            this.RemoveSolid.Name = "RemoveSolid";
            this.RemoveSolid.Size = new System.Drawing.Size(130, 33);
            this.RemoveSolid.TabIndex = 2;
            this.RemoveSolid.Text = "Удалить";
            this.RemoveSolid.UseVisualStyleBackColor = true;
            this.RemoveSolid.Click += new System.EventHandler(this.RemoveSolid_Click);
            // 
            // AddSolid
            // 
            this.AddSolid.Location = new System.Drawing.Point(15, 155);
            this.AddSolid.Name = "AddSolid";
            this.AddSolid.Size = new System.Drawing.Size(130, 33);
            this.AddSolid.TabIndex = 1;
            this.AddSolid.Text = "Добавить";
            this.AddSolid.UseVisualStyleBackColor = true;
            this.AddSolid.Click += new System.EventHandler(this.AddSolid_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(335, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 319);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Type";
            this.Column1.HeaderText = "Тип движения";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NewCoordinate";
            this.Column2.HeaderText = "Координата";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 133;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1098, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // oscillatoryMovementControl1
            // 
            this.oscillatoryMovementControl1.Location = new System.Drawing.Point(765, 211);
            this.oscillatoryMovementControl1.Name = "oscillatoryMovementControl1";
            this.oscillatoryMovementControl1.ReadOnly = true;
            this.oscillatoryMovementControl1.Size = new System.Drawing.Size(329, 148);
            this.oscillatoryMovementControl1.TabIndex = 4;
            this.oscillatoryMovementControl1.Visible = false;
            // 
            // uniformlyAcceleratedMovementControl1
            // 
            this.uniformlyAcceleratedMovementControl1.Location = new System.Drawing.Point(765, 40);
            this.uniformlyAcceleratedMovementControl1.Name = "uniformlyAcceleratedMovementControl1";
            this.uniformlyAcceleratedMovementControl1.ReadOnly = true;
            this.uniformlyAcceleratedMovementControl1.Size = new System.Drawing.Size(329, 148);
            this.uniformlyAcceleratedMovementControl1.TabIndex = 3;
            this.uniformlyAcceleratedMovementControl1.Visible = false;
            // 
            // uniformlyMovementControl1
            // 
            this.uniformlyMovementControl1.Location = new System.Drawing.Point(0, 222);
            this.uniformlyMovementControl1.Name = "uniformlyMovementControl1";
            this.uniformlyMovementControl1.ReadOnly = true;
            this.uniformlyMovementControl1.Size = new System.Drawing.Size(329, 148);
            this.uniformlyMovementControl1.TabIndex = 2;
            uniformlyMovement1.InitialCoordinate = 0D;
            uniformlyMovement1.Speed = 0D;
            uniformlyMovement1.Time = 0.01D;
            this.uniformlyMovementControl1.UniformlyMovement = uniformlyMovement1;
            this.uniformlyMovementControl1.Visible = false;
            // 
            // CalculationCoordinatesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.oscillatoryMovementControl1);
            this.Controls.Add(this.AddSolid);
            this.Controls.Add(this.RemoveSolid);
            this.Controls.Add(this.searchNumericUpDown);
            this.Controls.Add(this.uniformlyAcceleratedMovementControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uniformlyMovementControl1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(789, 418);
            this.Name = "CalculationCoordinatesForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рассчет координаты";
            this.Load += new System.EventHandler(this.CalculationCoordinatesForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CalculationCoordinatesForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RemoveSolid;
        private System.Windows.Forms.Button AddSolid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.NumericUpDown searchNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button ModifyButton;
        private MovementControl.UniformlyMovementControl uniformlyMovementControl1;
        private MovementControl.UniformlyAcceleratedMovementControl uniformlyAcceleratedMovementControl1;
        private MovementControl.OscillatoryMovementControl oscillatoryMovementControl1;
    }
}

