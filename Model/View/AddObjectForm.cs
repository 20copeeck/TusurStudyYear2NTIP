using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class AddObjectForm : Form
    {
        public AddObjectForm()
        {
            InitializeComponent();
        }

        private void SelectMovementBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMovementBox.Text == "Равномерное")
            {
                initialCoordinateLabel.Visible = true;
                initialCoordinateMaskedTextBox.Visible = true;
                speedLabel.Visible = true;
                speedMaskedTextBox.Visible = true;
                accelerationLabel.Visible = false;
                accelerationMaskedTextBox.Visible = false;
                amplitudeLabel.Visible = false;
                amplitudeMaskedTextBox.Visible = false;
                frequencyLabel.Visible = false;
                frequencyMaskedTextBox.Visible = false;
                initialPhaseLabel.Visible = false;
                initialPhaseMaskedTextBox.Visible = false;
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                initialCoordinateLabel.Visible = true;
                initialCoordinateMaskedTextBox.Visible = true;
                speedLabel.Visible = true;
                speedMaskedTextBox.Visible = true;
                accelerationLabel.Visible = true;
                accelerationMaskedTextBox.Visible = true;
                amplitudeLabel.Visible = false;
                amplitudeMaskedTextBox.Visible = false;
                frequencyLabel.Visible = false;
                frequencyMaskedTextBox.Visible = false;
                initialPhaseLabel.Visible = false;
                initialPhaseMaskedTextBox.Visible = false;
            }
            else
            {
                initialCoordinateLabel.Visible = false;
                initialCoordinateMaskedTextBox.Visible = false;
                speedLabel.Visible = false;
                speedMaskedTextBox.Visible = false;
                accelerationLabel.Visible = false;
                accelerationMaskedTextBox.Visible = false;
                amplitudeLabel.Visible = true;
                amplitudeMaskedTextBox.Visible = true;
                frequencyLabel.Visible = true;
                frequencyMaskedTextBox.Visible = true;
                initialPhaseLabel.Visible = true;
                initialPhaseMaskedTextBox.Visible = true;
            }
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
