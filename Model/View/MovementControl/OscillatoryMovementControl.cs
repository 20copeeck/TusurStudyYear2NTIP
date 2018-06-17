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
                double initialPhase = Convert.ToDouble(initialPhaseNumericUpDown.Text);
                double amplitude = Convert.ToDouble(amplitudeNumericUpDown.Text);
                double frequency = Convert.ToDouble(frequencyNumericUpDown.Text);
                return new OscillatoryMovement(amplitude, frequency, initialPhase, time);
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                timeNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Time);
                initialPhaseNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).InitialPhase);
                amplitudeNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Amplitude);
                frequencyNumericUpDown.Text = Convert.ToString((value as OscillatoryMovement).Frequency);
            }
        }

        public bool ReadOnly { get; set; } = true;
    }
}
