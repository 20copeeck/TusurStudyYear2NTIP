namespace View
{
    partial class SearchForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(121, 83);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 40);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(32, 83);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 40);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchNumericUpDown
            // 
            this.searchNumericUpDown.DecimalPlaces = 2;
            this.searchNumericUpDown.Location = new System.Drawing.Point(98, 25);
            this.searchNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.searchNumericUpDown.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.searchNumericUpDown.Name = "searchNumericUpDown";
            this.searchNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.searchNumericUpDown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Найти";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 133);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchNumericUpDown);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.closeButton);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            ((System.ComponentModel.ISupportInitialize)(this.searchNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.NumericUpDown searchNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}