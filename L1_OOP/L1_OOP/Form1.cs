using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace L1_OOP
{
    public partial class mainForm : System.Windows.Forms.Form
    {
        public mainForm()
        {
            InitializeComponent();
        }


        //                     ----------
        //                     ---ДАТА---
        //                     ----------
        private void datetpDate_ValueChanged(object sender, EventArgs e) // Выбор даты
        {
            lbDateDay.Text = "Day: " + datetpDate.Value.Day.ToString();
            lbDateMonth.Text = "Month: " + datetpDate.Value.Month.ToString();
            lbDateYear.Text = "Year: " + datetpDate.Value.Year.ToString();
        }


        //                     --------------
        //                     ---КАРТИНКИ---
        //                     --------------
        private void chbImage_CheckedChanged(object sender, EventArgs e) // Выбор картинок
        {
            if (sender == chbImage1)
                picbImage1.Visible = !picbImage1.Visible;
            if (sender == chbImage2)
                picbImage2.Visible = !picbImage2.Visible;
            if (sender == chbImage3)
                picbImage3.Visible = !picbImage3.Visible;
            if (sender == chbImage4)
                picbImage4.Visible = !picbImage4.Visible;
        }


        //                     ----------
        //                     ---МЕНЮ---
        //                     ----------
        private void toolStripMenuItem_Click(object sender, EventArgs e) // Вывод пункта меню
        {
            System.Windows.Forms.ToolStripMenuItem menuItemThis = (System.Windows.Forms.ToolStripMenuItem)sender;
            tbMenuChoice.Text = menuItemThis.Text;
        }


        //                     ----------------
        //                     ---АВТОРАЗМЕР---
        //                     ----------------
        private Rectangle btnAutosizeOrig;
        private Point formOrig;
        int fl = 0;

        private void getSizes() // Получение размеров формы и элементов
        {
            formOrig = new Point(this.Width, this.Height);
            btnAutosizeOrig = new Rectangle(btnAutosize.Location.X, btnAutosize.Location.Y,
                btnAutosize.Width, btnAutosize.Height);
        }

        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            switch (fl)
            {
                case 0:
                    fl++;
                    return;
                case 1:
                    getSizes();
                    fl++;
                    break;
            }

            float ratioX = (float)(this.Width) / (float)(formOrig.X);
            float ratioY = (float)(this.Height) / (float)(formOrig.Y);
                        
            btnAutosize.Location = new Point((int)(btnAutosizeOrig.X * ratioX), (int)(btnAutosizeOrig.Y * ratioY));
            btnAutosize.Size = new Size((int)(btnAutosizeOrig.Width * ratioX), (int)(btnAutosizeOrig.Height * ratioY));
        }


        //                     ----------------
        //                     ---КООРДИНАТЫ---
        //                     ----------------
        private void Form1_MouseMove(object sender, MouseEventArgs e) // Координаты курсора
        {
            lbX.Text = "X: " + e.X.ToString();
            lbY.Text = "Y: " + e.Y.ToString();
        }

        
        //                     -----------------
        //                     ---ПРОГРЕССБАР---
        //                     -----------------
        private int speedPb = 0; // Скорость увеличения прогрессбара (0-100)

        private void nudPbSpeed_ValueChanged(object sender, EventArgs e) // Задать интервал таймера для прогрессбара
        {
            speedPb = (int)nudPbSpeed.Value;
            tmPbTimer.Interval = 10 * (101 - speedPb);
            if (speedPb == 0)
                tmPbTimer.Interval = Int32.MaxValue;
        }

        private void rbPbOn_Off_CheckedChanged(object sender, EventArgs e) // ВКЛ/ВЫКЛ прогрессбар
        {
            if (sender == rbPbOn)
            {
                tmPbTimer.Start();
            }
            else if (sender == rbPbOff)
            {
                tmPbTimer.Stop();
            }
        }

        private void tmPbTimer_Tick(object sender, EventArgs e) // Таймер для прогрессбара
        {
            if (pbTimer.Value == pbTimer.Maximum)
            {
                tmPbTimer.Interval = 10 * (101 - speedPb);
                pbTimer.Value = 0;
            }
            pbTimer.PerformStep();
            if (pbTimer.Value == pbTimer.Maximum)
                tmPbTimer.Interval = 600;
        }


        //                     -------------
        //                     ---ЭЛЛИПСЫ---
        //                     -------------
        struct Ellipse // Стрруктура эллипса
        {
            public int coordX, coordY, sizeX, sizeY;
            public Ellipse(int coordX, int coordY, int sizeX, int sizeY)
            {
                this.coordX = coordX;
                this.coordY = coordY;
                this.sizeX = sizeX;
                this.sizeY = sizeY;
            }
        }
        List<Ellipse> Ellipses = new List<Ellipse>(); // Список структур эллипсов
        private int pnlDrawingCoordX1, pnlDrawingCoordY1, deltaX, deltaY;
        private bool flDown = false; // Флаг рисования эллипса

        private void pnlDrawing_MouseDown(object sender, MouseEventArgs e) // Начало рисования эллипса
        {
            pnlDrawingCoordX1 = e.X;
            pnlDrawingCoordY1 = e.Y;
            flDown = true;
        }

        private void pnlDrawing_MouseMove(object sender, MouseEventArgs e) // Рисование эллипса
        {
            if (flDown)
            {
                deltaX = e.X - pnlDrawingCoordX1;
                deltaY = e.Y - pnlDrawingCoordY1;
                pnlDrawing.Invalidate();
            }
        }        

        private void pnlDrawing_MouseUp(object sender, MouseEventArgs e) // Конец рисования эллипса
        {
            flDown = false;
            Ellipses.Add(new Ellipse(pnlDrawingCoordX1, pnlDrawingCoordY1, deltaX, deltaY));
        }

        private void pnlDrawing_Paint(object sender, PaintEventArgs e) // Отрисовка эллипсов
        {
            Graphics graphic = e.Graphics;
            graphic.Clear(Color.LightYellow);
            graphic.DrawEllipse(Pens.Red, pnlDrawingCoordX1, pnlDrawingCoordY1, deltaX, deltaY);

            foreach (var i in Ellipses)
            {
                graphic.DrawEllipse(Pens.Red, i.coordX, i.coordY, i.sizeX, i.sizeY);
            }
        }        

        private void btnDeleteEllipses_Click(object sender, EventArgs e) // Удаление эллипсов
        {
            Ellipses.Clear();
            deltaX = deltaY = 0;
            pnlDrawing.Invalidate();
        }


        //                     ------------
        //                     ---КНОПКИ---
        //                     ------------
        private int counBtAuto = 0;
        private void Form_Click(object sender, EventArgs e) //Динамическое создание кнопки
        {
            MouseEventArgs e_ = (MouseEventArgs)e;

            System.Windows.Forms.Button btnAuto = new System.Windows.Forms.Button();

            btnAuto.Location = new Point(e_.X, e_.Y);
            btnAuto.Name = "btnAuto" + counBtAuto.ToString();
            btnAuto.Size = new Size(40, 20);
            btnAuto.TabIndex = 6;
            btnAuto.TabStop = false;
            btnAuto.Text = "xXx";
            btnAuto.UseVisualStyleBackColor = true;
            btnAuto.Click += new EventHandler(btnAuto_Click);

            Controls.Add(btnAuto);
            counBtAuto++;
            if (counBtAuto == 30)
                counBtAuto = 0;
        }

        private void btnAuto_Click(object sender, EventArgs e) // Удаление кнопки
        {
            var button = (System.Windows.Forms.Button)sender;
            for (int i = 0; i < 20; i++)
            {
                string buttonNmae = "btnAuto" + i.ToString();
                if (button.Name == buttonNmae)
                {
                    button.Dispose();
                    break;
                }
            }
        }
    }
}
