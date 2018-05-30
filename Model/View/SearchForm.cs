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

namespace View
{
    /// <summary>
    /// Форма поиска по объектам
    /// </summary>
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Список движений
        /// </summary>
        private List<IMovement> _movement;
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="movement">Список движений</param>
        public SearchForm(List<IMovement> movement)
        {
            InitializeComponent();
            _movement = movement;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки закрыть
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку поиска
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы события</param>
        private void searchButton_Click(object sender, EventArgs e)
        {
            double coordinate;
            string info = string.Empty;


            if (!String.IsNullOrWhiteSpace(info))
            {
                MessageBox.Show(info, "Найдено", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Ничего не найдено", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
