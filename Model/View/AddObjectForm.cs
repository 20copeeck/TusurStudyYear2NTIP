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
    public partial class AddObjectForm : Form
    {
        /// <summary>
        /// Источник данных
        /// </summary>
        private BindingSource _bindingSource;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bindingSource">Источник данных</param>
        public AddObjectForm(BindingSource bindingSource)
        {  
            InitializeComponent();
            _bindingSource = bindingSource;

#if DEBUG
            createRandomDataButton.Visible = true;
#endif
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
            Close();
        }
        
        private void AddObjectForm_Load(object sender, EventArgs e)
        {
            this.Width = 344;
            this.Height = 353;

            groupBox2.Location = new System.Drawing.Point(12, 89);
        }
                
        private void okButton_Click(object sender, EventArgs e)
        {
            IMovement movement;

            if (SelectMovementBox.Text == "Равномерное")
            {
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

            _bindingSource.Add(movement);
        }
                
        private void createRandomDataButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string value;

            if (SelectMovementBox.Text == "Равномерное")
            {
                value = Convert.ToString(random.Next(-500, 700));
                initialCoordinateNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 600));
                timeNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 800));
                speedNumericUpDown.Text = value;
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                value = Convert.ToString(random.Next(-500, 700));
                initialCoordinateNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 600));
                timeNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 800));
                speedNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 901));
                accelerationNumericUpDown.Text = value;
            }
            else
            {
                value = Convert.ToString(random.Next(0, 250));
                amplitudeNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 255));
                timeNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 300));
                frequencyNumericUpDown.Text = value;
                value = Convert.ToString(random.Next(0, 354));
                initialPhaseNumericUpDown.Text = value;
            }
  
        }
    }
}
