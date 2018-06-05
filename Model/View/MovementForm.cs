using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    /// <summary>
    /// Форма добавления объектов движения
    /// </summary>
    public partial class MovementForm : Form
    {
        /// <summary>
        /// Движение
        /// </summary>
        public IMovement movement { get; private set; }
                
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bindingSource">Источник данных</param>
        public MovementForm()
        {  
            InitializeComponent();
        }

        /// <summary>
        /// Метод очищающий все элементы на форме и закрывающий ее
        /// </summary>
        private void Cleaner()
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            timeNumericUpDown.Value = 0.01m;
            initialCoordinateNumericUpDown.Value = 0;
            speedNumericUpDown.Value = 0.01m;
            accelerationNumericUpDown.Value = 0.01m;
            amplitudeNumericUpDown.Value = 0.01m;
            frequencyNumericUpDown.Value = 0.01m;
            initialPhaseNumericUpDown.Value = 0;
            SelectMovementBox.SelectedIndex = -1;

            Close();
        }

        private void SelectMovementBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMovementBox.Text == "Равномерное")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                accelerationLabel.Visible = false;
                accelerationNumericUpDown.Visible = false;
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = false;
                accelerationLabel.Visible = true;
                accelerationNumericUpDown.Visible = true;
            }
            else
            {
                groupBox2.Visible = true;
                groupBox1.Visible = false;
            }
        }
                
        private void Cansel_Click(object sender, EventArgs e)
        {
            Cleaner();
        }
        
        private void AddObjectForm_Load(object sender, EventArgs e)
        {
            this.Width = 353;
            this.Height = 309;
            groupBox2.Location = new System.Drawing.Point(12, 89);

            SelectMovementBox.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            timeNumericUpDown.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            groupBox1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            groupBox2.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            okButton.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            Cansel.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
        }
                
        private void okButton_Click(object sender, EventArgs e)
        {
            if (SelectMovementBox.Text == "Равномерное")
            {
                double result;
                if (Double.TryParse(initialCoordinateNumericUpDown.Text, out result) == false)
                {

                }
                movement = new UniformlyMovement(Convert.ToDouble(initialCoordinateNumericUpDown.Text), Convert.ToDouble(speedNumericUpDown.Text), Convert.ToDouble(timeNumericUpDown.Text));
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                movement = new UniformlyAcceleratedMovement(Convert.ToDouble(initialCoordinateNumericUpDown.Text), Convert.ToDouble(speedNumericUpDown.Text), Convert.ToDouble(accelerationNumericUpDown.Text), Convert.ToDouble(timeNumericUpDown.Text));
            }
            else
            {
                movement = new OscillatoryMovement(Convert.ToDouble(amplitudeNumericUpDown.Text), Convert.ToDouble(frequencyNumericUpDown.Text), Convert.ToDouble(initialPhaseNumericUpDown.Text), Convert.ToDouble(timeNumericUpDown.Text));
            }
            Cleaner();
        }

        private void SelectMovementBox_VisibleChanged(object sender, EventArgs e)
        {
            movement = null;
        }

        private void MovementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cleaner();
        }
    }
}
