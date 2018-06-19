using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Model;

namespace View.MovementControl
{
    /// <summary>
    /// Контроллер равноускоренного движения
    /// </summary>
    public partial class UniformlyAcceleratedMovementControl : UserControl
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public UniformlyAcceleratedMovementControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получает или задает параметры равноускоренного движения тела
        /// </summary>
        public UniformlyAcceleratedMovement UniformlyAcceleratedMovement
        {
            get
            {
                double time = Convert.ToDouble(timeNumericUpDown.Text);
                double initialCoordinate = Convert.ToDouble(initialCoordinateNumericUpDown.Text);
                double speed = Convert.ToDouble(speedNumericUpDown.Text);
                double acceleration = Convert.ToDouble(accelerationNumericUpDown.Text);
                return new UniformlyAcceleratedMovement(initialCoordinate, speed, acceleration, time);
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                timeNumericUpDown.Text = Convert.ToString((value as UniformlyAcceleratedMovement).Time);
                initialCoordinateNumericUpDown.Text = Convert.ToString((value as UniformlyAcceleratedMovement).InitialCoordinate);
                speedNumericUpDown.Text = Convert.ToString((value as UniformlyAcceleratedMovement).Speed);
                accelerationNumericUpDown.Text = Convert.ToString((value as UniformlyAcceleratedMovement).Acceleration);
            }
        }

        /// <summary>
        /// Получает или задает значение ReadOnly
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return timeNumericUpDown.ReadOnly;
            }
            set
            {
                timeNumericUpDown.ReadOnly = value;
                initialCoordinateNumericUpDown.ReadOnly = value;
                speedNumericUpDown.ReadOnly = value;
                accelerationNumericUpDown.ReadOnly = value;

                if (timeNumericUpDown.ReadOnly == true)
                {
                    timeNumericUpDown.Controls[0].Hide();
                    initialCoordinateNumericUpDown.Controls[0].Hide();
                    speedNumericUpDown.Controls[0].Hide();
                    accelerationNumericUpDown.Controls[0].Hide();
                }
                else
                {
                    timeNumericUpDown.Controls[0].Show();
                    initialCoordinateNumericUpDown.Controls[0].Show();
                    speedNumericUpDown.Controls[0].Show();
                    accelerationNumericUpDown.Controls[0].Show();
                }
            }
        }
    }
}
