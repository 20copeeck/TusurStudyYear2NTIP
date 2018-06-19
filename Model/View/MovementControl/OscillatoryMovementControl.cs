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
    /// Контроллер колебательного движения
    /// </summary>
    public partial class OscillatoryMovementControl : UserControl
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public OscillatoryMovementControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Получает или задает параметры колебательного движения тела
        /// </summary>
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
                initialPhaseNumericUpDown.ReadOnly = value;
                amplitudeNumericUpDown.ReadOnly = value;
                frequencyNumericUpDown.ReadOnly = value;

                if (timeNumericUpDown.ReadOnly == true)
                {
                    timeNumericUpDown.Controls[0].Hide();
                    initialPhaseNumericUpDown.Controls[0].Hide();
                    amplitudeNumericUpDown.Controls[0].Hide();
                    frequencyNumericUpDown.Controls[0].Hide();
                }
                else
                {
                    timeNumericUpDown.Controls[0].Show();
                    initialPhaseNumericUpDown.Controls[0].Show();
                    amplitudeNumericUpDown.Controls[0].Show();
                    frequencyNumericUpDown.Controls[0].Show();
                }
            }
        } 
    }
}
