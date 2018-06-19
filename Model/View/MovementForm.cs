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
    /// Форма добавления объектов движения
    /// </summary>
    public partial class MovementForm : Form
    {
        /// <summary>
        /// Движение
        /// </summary>
        public IMovement Movement
        {
            get
            {
                if (SelectMovementBox.Text == "Равномерное")
                {
                    return uniformlyMovementControl.UniformlyMovement;
                }
                else if (SelectMovementBox.Text == "Равноускоренное")
                {
                    return uniformlyAcceleratedMovementControl.UniformlyAcceleratedMovement;
                }
                else if (SelectMovementBox.Text == "Колебательное")
                {
                    return oscillatoryMovementControl.OscillatoryMovement;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value is UniformlyMovement _uniformlyMovement)
                {
                    uniformlyMovementControl.UniformlyMovement = _uniformlyMovement;
                    SelectMovementBox.SelectedIndex = 0;
                }
                else if (value is UniformlyAcceleratedMovement _uniformlyAcceleratedMovement)
                {
                    uniformlyAcceleratedMovementControl.UniformlyAcceleratedMovement = _uniformlyAcceleratedMovement;
                    SelectMovementBox.SelectedIndex = 1;
                }
                else if (value is OscillatoryMovement _oscillatoryMovement)
                {
                    oscillatoryMovementControl.OscillatoryMovement = _oscillatoryMovement;
                    SelectMovementBox.SelectedIndex = 2;
                }
            }
        }

        /// <summary>
        /// Задает значение ReadOnly
        /// </summary>
        public bool ReadOnly
        {
            set
            {
                uniformlyMovementControl.ReadOnly = value;
                uniformlyAcceleratedMovementControl.ReadOnly = value;
                oscillatoryMovementControl.ReadOnly = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bindingSource">Источник данных</param>
        public MovementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод очищающий все элементы на форме и закрывающий ее
        /// </summary>
        private void Cleaner()
        {
            uniformlyMovementControl.Visible = false;
            uniformlyAcceleratedMovementControl.Visible = false;
            oscillatoryMovementControl.Visible = false;

            SelectMovementBox.SelectedIndex = -1;
            Close();
        }


        private void SelectMovementBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMovementBox.Text == "Равномерное")
            {
                uniformlyMovementControl.Visible = true;
                uniformlyAcceleratedMovementControl.Visible = false;
                oscillatoryMovementControl.Visible = false;
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                uniformlyMovementControl.Visible = false;
                uniformlyAcceleratedMovementControl.Visible = true;
                oscillatoryMovementControl.Visible = false;
            }
            else
            {
                uniformlyMovementControl.Visible = false;
                uniformlyAcceleratedMovementControl.Visible = false;
                oscillatoryMovementControl.Visible = true;
            }
        }

        private void MovementForm_Load(object sender, EventArgs e)
        {
            this.Width = 343;
            this.Height = 273;
            uniformlyAcceleratedMovementControl.Location = new System.Drawing.Point(-1, 36);
            oscillatoryMovementControl.Location = new System.Drawing.Point(-1, 36);

            SelectMovementBox.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            uniformlyMovementControl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            uniformlyAcceleratedMovementControl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            oscillatoryMovementControl.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            okButton.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            closeButton.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
        }       
    }
}
