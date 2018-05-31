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
               
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void searchButton_Click(object sender, EventArgs e)
        {
            var selectedItem = from m in _movement
                               where m.NewCoordinate > (double)searchNumericUpDown.Value
                               select m;
            string info = String.Empty;

            foreach ( IMovement movement in selectedItem)
            {
                info += movement.Type + " " + movement.NewCoordinate + "\r\n";
            }

            MessageBox.Show(info);
        }
    }
}
