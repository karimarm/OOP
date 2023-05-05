using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace L4_OOP
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            penCircleMake();
        }


        static Pen penCircleSelect = new Pen(Brushes.Green);
        static Pen penCircleNotSelect = new Pen(Brushes.Red);
        void penCircleMake()
        {
            penCircleSelect.Width = 5;
            penCircleNotSelect.Width = 5;
        }


        static int radius = 20;
        bool isCtrl = false;

        class CCircle // Класс кругов
        {
            public Rectangle rect;
            private bool isSelect;
            public CCircle(int x, int y) // Конструктор
            {
                rect = new Rectangle(x, y, radius * 2, radius * 2);
                isSelect = true;
            }
            public void draw(PaintEventArgs e) // Отрисовка кругов
            {
                Graphics graphic = e.Graphics;
                graphic.DrawEllipse((isSelect ? penCircleSelect : penCircleNotSelect), rect);
            }
            public bool isClicked(int x, int y) // Проверка нажатия на круг
            {
                if (Math.Abs(rect.X - x) <= radius && Math.Abs(rect.Y - y) <= radius)
                    return true;
                else
                    return false;
            }
            public void setSelect(bool select) // Установка флага выбранности
            {
                isSelect = select;
            }
            public void changeSelect() // Изменение флага выбранности
            {
                isSelect = !isSelect;
            }
            public bool getSelect()
            {
                return isSelect;
            }
        }
        List<CCircle> Circles = new List<CCircle>(); // Список кругов


        private void pbCircles_MouseClick(object sender, MouseEventArgs e)
        {
            bool flCircleClick = false;
            if (!isCtrl || !cbIsCtrl.Checked)
                foreach (var j in Circles)
                    j.setSelect(false);

            foreach (var i in Circles) // Проверка кругов на нажатие
            {
                if (i.isClicked(e.X - radius, e.Y - radius))
                {
                    i.changeSelect();
                    flCircleClick = true;
                    if(!cbSelectionCircles.Checked)
                        break;
                }
            }

            if (!flCircleClick) // Создание нового круга
            {
                if (!isCtrl || !cbIsCtrl.Checked)
                    foreach (var j in Circles)
                        j.setSelect(false);
                Circles.Add(new CCircle(e.X - radius, e.Y - radius));                
                
            }
            pbCircles.Invalidate();
        }
        private void pbCircles_Paint(object sender, PaintEventArgs e) // Событие отрисовки
        {
            foreach (var i in Circles)
                i.draw(e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) // Удаление кругов
            {
                for (int i = 0; i<Circles.Count(); ++i)
                {
                    if (Circles[i].getSelect())
                    {
                        Circles.RemoveAt(i--);
                    }
                }
                if(Circles.Count != 0)
                    Circles.Last().setSelect(true);

                pbCircles.Invalidate();
            }
            else if (e.Control) // Нажатие CTRL
            {
                isCtrl = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey) // Отпускание CTRL
            {
                isCtrl = false;
            }
        }
    }
}
