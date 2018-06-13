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
using View.MovementControl;

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
                    return uniformlyMovementControl1.UniformlyMovement;
                }
                else if (SelectMovementBox.Text == "Равноускоренное")
                {
                    return uniformlyAcceleratedMovementControl1.UniformlyAcceleratedMovement;
                }
                else if (SelectMovementBox.Text == "Колебательное")
                {
                    return oscillatoryMovementControl1.OscillatoryMovement;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (value is UniformlyMovement uniformlyMovement)
                {
                    uniformlyMovementControl1.UniformlyMovement = uniformlyMovement;
                }
                else if (value is UniformlyAcceleratedMovement uniformlyAcceleratedMovement)
                {
                    uniformlyAcceleratedMovementControl1.UniformlyAcceleratedMovement = uniformlyAcceleratedMovement;
                }
                else if (value is OscillatoryMovement oscillatoryMovement)
                {
                    oscillatoryMovementControl1.OscillatoryMovement = oscillatoryMovement;
                }
            }
        }

        public bool ReadOnly
        {
            set
            {
                uniformlyMovementControl1.ReadOnly = value;
                uniformlyAcceleratedMovementControl1.ReadOnly = value;
                oscillatoryMovementControl1.ReadOnly = value;
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
            uniformlyMovementControl1.Visible = false;
            uniformlyAcceleratedMovementControl1.Visible = false;
            oscillatoryMovementControl1.Visible = false;
            
            SelectMovementBox.SelectedIndex = -1;

            Close();
        }

        private void SelectMovementBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMovementBox.Text == "Равномерное")
            {
                uniformlyMovementControl1.Visible = true;
                uniformlyAcceleratedMovementControl1.Visible = false;
                oscillatoryMovementControl1.Visible = false;
            }
            else if (SelectMovementBox.Text == "Равноускоренное")
            {
                uniformlyMovementControl1.Visible = false;
                uniformlyAcceleratedMovementControl1.Visible = true;
                oscillatoryMovementControl1.Visible = false;
            }
            else
            {
                uniformlyMovementControl1.Visible = false;
                uniformlyAcceleratedMovementControl1.Visible = false;
                oscillatoryMovementControl1.Visible = true;
            }
        }
        
        private void AddObjectForm_Load(object sender, EventArgs e)
        {
            uniformlyMovementControl1.Visible = false;
            uniformlyAcceleratedMovementControl1.Visible = false;
            oscillatoryMovementControl1.Visible = false;

            this.Width = 353;
            this.Height = 309;
            uniformlyAcceleratedMovementControl1.Location = new System.Drawing.Point(-4, 45);
            oscillatoryMovementControl1.Location = new System.Drawing.Point(-4, 45);

            SelectMovementBox.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
            uniformlyMovementControl1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            uniformlyAcceleratedMovementControl1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            oscillatoryMovementControl1.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom);
            okButton.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
            Cansel.Anchor = (AnchorStyles.Right | AnchorStyles.Bottom);
        }
    }
}
