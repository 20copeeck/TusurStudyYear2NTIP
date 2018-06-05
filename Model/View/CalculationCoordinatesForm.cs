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
using System.Runtime.Serialization.Json;

namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class CalculationCoordinatesForm : Form
    {
        /// <summary>
        /// Список типов движений
        /// </summary>
        List<IMovement> _moverment;

        /// <summary>
        /// Форма добавления нового объекта
        /// </summary>
        MovementForm _addObjectForm;

        /// <summary>
        /// Класс для записи объектов в json-файл
        /// </summary>
        DataContractJsonSerializer _serializer;

        /// <summary>
        /// Конструктор
        /// </summary>
        public CalculationCoordinatesForm()
        {
            InitializeComponent();
            _moverment = new List<IMovement>();
            _addObjectForm = new MovementForm();

            bindingSource.DataSource = _moverment;
            dataGridView1.DataSource = bindingSource;

            List<Type> knownTypeList = new List<Type>();
            knownTypeList.Add(typeof(UniformlyMovement));
            knownTypeList.Add(typeof(UniformlyAcceleratedMovement));
            knownTypeList.Add(typeof(OscillatoryMovement));

            _serializer = new DataContractJsonSerializer(typeof(List<IMovement>), knownTypeList);
        }

        /// <summary>
        /// Метод генерирующий случайные значения
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private int Random(int minValue, int maxValue)
        {
            Random random = new Random();
            int value = random.Next(minValue, maxValue);
            return value;
        }

        private void AddSolid_Click(object sender, EventArgs e)
        {
            _addObjectForm.ShowDialog();
            if (_addObjectForm.movement != null)
            {
                bindingSource.Add(_addObjectForm.movement);
            }
        }

        private void RemoveSolid_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int index = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Sanches files|*.Sanches";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                List<IMovement> deserializeFigures = (List<IMovement>)_serializer.ReadObject(fileStream);
                fileStream.Dispose();

                bindingSource.Clear();

                foreach (IMovement movement in deserializeFigures)
                {
                    bindingSource.Add(movement);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Sanches Files|*.Sanches";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _moverment);
                fileStream.Dispose();
            }
                
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            for(int index = 0; index < dataGridView1.RowCount; index++)
            {
                dataGridView1.Rows[index].Visible = true;
            }

            if(searchNumericUpDown.Text != String.Empty)
            {
                List<int> indexes = new List<int>();
                for(int count = 0; count < dataGridView1.RowCount; count++)
                {
                    double volume = Convert.ToDouble(dataGridView1.Rows[count].Cells["Column2"].Value);
                    if(volume < Convert.ToDouble(searchNumericUpDown.Text))
                    {
                        indexes.Add(count);
                    }
                }

                dataGridView1.CurrentCell = null;
                foreach (int index in indexes)
                {
                    dataGridView1.Rows[index].Visible = false;
                }
            }
        }
        
        private void CalculationCoordinatesForm_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F6:
                    if (e.Control)
                    {
                        Random random = new Random();
                        int value;
                        value = random.Next(0, 3);
                        IMovement movement;
                            
                        if (value == 0)
                        {
                            movement = new UniformlyMovement(Random(-300, 400), Random(0, 400), Random(0, 400));
                        }
                        else if(value == 1)
                        {
                            movement = new UniformlyAcceleratedMovement(Random(-300, 400), Random(0, 400), Random(0, 400), Random(0, 400));
                        }
                        else
                        {
                            movement = new OscillatoryMovement(Random(0, 400), Random(0, 400), Random(-300, 400), Random(0, 400));
                        }
                        bindingSource.Add(movement);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
