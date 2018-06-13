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

namespace View
{
    public partial class UniformlyAcceleratedMovementControl : UserControl
    {
        public UniformlyAcceleratedMovementControl()
        {
            InitializeComponent();
        }

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

        public bool ReadOnly { get; set; } = true;
    }
}
