using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View.MovementControl
{
    public partial class OscillatoryMovementControl : UserControl
    {
        public OscillatoryMovementControl()
        {
            InitializeComponent();
        }

        public OscillatoryMovement OscillatoryMovement
        {
            get
            {
                double time = Convert.ToDouble(timeNumericUpDown.Text);
                double amplitude = Convert.ToDouble(amplitudeNumericUpDown.Text);
                double frequency = Convert.ToDouble(frequencyNumericUpDown.Text);
                double initialPhase = Convert.ToDouble(initialPhaseNumericUpDown.Text);
                return new OscillatoryMovement(amplitude, frequency, initialPhase, time);
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                timeNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Time);
                amplitudeNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Amplitude);
                frequencyNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Frequency);
                initialPhaseNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).InitialPhase);
            }
        }

        public bool ReadOnly { get; set; } = true;
    }
}
