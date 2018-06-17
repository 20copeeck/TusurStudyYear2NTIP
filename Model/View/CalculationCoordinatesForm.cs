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
        List<IMovement> _movement;
        
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
            _movement = new List<IMovement>();
            
            bindingSource.DataSource = _movement;
            dataGridView1.DataSource = bindingSource;

            List<Type> knownTypeList = new List<Type>
            {
                typeof(UniformlyMovement),
                typeof(UniformlyAcceleratedMovement),
                typeof(OscillatoryMovement)
            };
            
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
            MovementForm movementObjectForm = new MovementForm()
            {
                ReadOnly = false
            };

            movementObjectForm.ShowDialog();

            if (movementObjectForm.DialogResult != DialogResult.OK) return;
            if (movementObjectForm.Movement != null)
            {
                bindingSource.Add(movementObjectForm.Movement);
            }
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                MovementForm modifyObjectForm = new MovementForm()
                {
                    Movement = _movement[dataGridView1.CurrentRow.Index],
                    ReadOnly = false
                };

                modifyObjectForm.ShowDialog();

                if (modifyObjectForm.DialogResult != DialogResult.OK) return;
                if (modifyObjectForm.Movement != null)
                {
                    _movement[dataGridView1.CurrentRow.Index] = modifyObjectForm.Movement;
                    bindingSource.ResetCurrentItem();
                }
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

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "Movement files|*.Movement";
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

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Movement Files|*.Movement";
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);
                _serializer.WriteObject(fileStream, _movement);
                fileStream.Dispose();
            }
                
        }

        private void SearchButton_Click(object sender, EventArgs e)
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
#if DEBUG
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
#endif
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var movement = _movement[dataGridView1.CurrentRow.Index];
            //if (movement is UniformlyMovement uniformlyMovement)
            //{
            //    uniformlyMovementControl1.Visible = true;
            //    uniformlyAcceleratedMovementControl1.Visible = false;
            //    oscillatoryMovementControl1.Visible = false;
            //    uniformlyMovementControl1.ReadOnly = true;
            //    uniformlyMovementControl1.UniformlyMovement = uniformlyMovement;
            //}
            //else if (movement is UniformlyAcceleratedMovement uniformlyAcceleratedMovement)
            //{
            //    uniformlyMovementControl1.Visible = false;
            //    uniformlyAcceleratedMovementControl1.Visible = true;
            //    oscillatoryMovementControl1.Visible = false;
            //    uniformlyAcceleratedMovementControl1.ReadOnly = true;
            //    uniformlyAcceleratedMovementControl1.UniformlyAcceleratedMovement = uniformlyAcceleratedMovement;
            //}
            //else if (movement is OscillatoryMovement oscillatoryMovement)
            //{
            //    uniformlyMovementControl1.Visible = false;
            //    uniformlyAcceleratedMovementControl1.Visible = false;
            //    oscillatoryMovementControl1.Visible = true;
            //    oscillatoryMovementControl1.ReadOnly = true;
            //    oscillatoryMovementControl1.OscillatoryMovement = oscillatoryMovement;
            //}
        }

        private void CalculationCoordinatesForm_Load(object sender, EventArgs e)
        {
            this.Width = 789; 
            this.Height = 418;

            uniformlyAcceleratedMovementControl1.Location = new System.Drawing.Point(4, 31);
            oscillatoryMovementControl1.Location = new System.Drawing.Point(4, 31);
            dataGridView1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
        }
    }
}
