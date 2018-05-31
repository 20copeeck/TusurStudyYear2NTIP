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
using System.Runtime.Serialization.Formatters.Binary;

namespace View
{
    /// <summary>
    /// Главная форма
    /// </summary>
    public partial class CalculationCoordinatesForm : Form
    {
        /// <summary>
        /// Сериализует/Десериализует объекты.
        /// </summary>
        private BinaryFormatter _formatter;

        /// <summary>
        /// Список типов движений
        /// </summary>
        List<IMovement> _moverment;

        /// <summary>
        /// Форма добавления нового объекта
        /// </summary>
        AddObjectForm _addObjectForm;

        /// <summary>
        /// Форма для поиска по объектам
        /// </summary>
        SearchForm _searchForm;

        /// <summary>
        /// Конструктор
        /// </summary>
        public CalculationCoordinatesForm()
        {
            InitializeComponent();
            _moverment = new List<IMovement>();
            _addObjectForm = new AddObjectForm(bindingSource);
            _searchForm = new SearchForm(_moverment);

            bindingSource.DataSource = _moverment;
            dataGridView1.DataSource = bindingSource;

            InitializeFileDialogs();
            _formatter = new BinaryFormatter();
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

        /// <summary>
        /// Инициализация файл диалогов
        /// </summary>
        private void InitializeFileDialogs()
        {
            void InitializeFileDialog(FileDialog fileDialog)
            {
                fileDialog.AddExtension = true;
                fileDialog.Filter = "Sanches Files|*.Sanches";
            }
            InitializeFileDialog(saveFileDialog);
            InitializeFileDialog(openFileDialog);
        }
               
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);

                    List<IMovement> deserilizeSalarys = (List<IMovement>)_formatter.Deserialize(fileStream);

                    bindingSource.Clear();

                    foreach (IMovement salary in deserilizeSalarys)
                    {
                        bindingSource.Add(salary);
                    }
                    fileStream.Dispose();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
                
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                try
                {
                    FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate);

                    _formatter.Serialize(fileStream, _moverment);
                    fileStream.Dispose();

                    MessageBox.Show("Файл сохранен. \r\nПуть:" + saveFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
       
        private void searchButton_Click(object sender, EventArgs e)
        {
            _searchForm.ShowDialog();
        }
    }
}
