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
using System.IO;

namespace View
{
    public partial class CalculationCoordinatesForm : Form
    {
        List<IMovement> _moverment;
        AddObjectForm _addObjectForm;

        public CalculationCoordinatesForm()
        {
            InitializeComponent();
            _moverment = new List<IMovement>();
            _addObjectForm = new AddObjectForm(bindingSource);

            bindingSource.DataSource = _moverment;
            dataGridView1.DataSource = bindingSource;
        }

        private void AddSolid_Click(object sender, EventArgs e)
        {
            _addObjectForm.ShowDialog();
        }

        private void RemoveSolid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.Y >= 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
