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
    public partial class UniformlyMovementControl : UserControl
    {
        public UniformlyMovementControl()
        {
            InitializeComponent();
        }

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

        public bool ReadOnly { get; set; } = true;
    }
}
