using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.MovementControl
{
    /// <summary>
    /// Контроллер равномерного движения
    /// </summary>
    public partial class UniformlyMovementControl : UserControl
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public UniformlyMovementControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получает или задает параметры равномерного движения тела
        /// </summary>
        public UniformlyMovement UniformlyMovement
        {
            get
            {
                double time = Convert.ToDouble(timeNumericUpDown.Text);
                double initialCoordinate = Convert.ToDouble(initialCoordinateNumericUpDown.Text);
                double speed = Convert.ToDouble(speedNumericUpDown.Text);
                return new UniformlyMovement(initialCoordinate, speed, time);
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                timeNumericUpDown.Text = Convert.ToString((value as UniformlyMovement).Time);
                initialCoordinateNumericUpDown.Text = Convert.ToString((value as UniformlyMovement).InitialCoordinate);
                speedNumericUpDown.Text = Convert.ToString((value as UniformlyMovement).Speed);
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

                if (timeNumericUpDown.ReadOnly == true)
                {
                    timeNumericUpDown.Controls[0].Hide();
                    initialCoordinateNumericUpDown.Controls[0].Hide();
                    speedNumericUpDown.Controls[0].Hide();
                }
                else
                {
                    timeNumericUpDown.Controls[0].Show();
                    initialCoordinateNumericUpDown.Controls[0].Show();
                    speedNumericUpDown.Controls[0].Show();
                }
            }
        } 
    }
}
