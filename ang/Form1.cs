using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.Timers;
//using System.Threading;

//using System.Threading.Tasks;

namespace ang
{
    public partial class Form1 : Form
    {
        Point b1 = new Point(55, 35);
        Point b2 = new Point(160, 35);
        Point b3 = new Point(55, 75);
        Point b4 = new Point(160, 75);
        Point b5 = new Point(55, 120);
        Point b6 = new Point(160, 120);
        Point b7 = new Point(55, 160);
        Point b8 = new Point(160, 160);

        Dictionary<int, Point> points = new Dictionary<int, Point>();

        Random numberRandom = new Random();
        int number = 1;

        List<int> numbers = new List<int>();

        string[] TabPol = new string[] { "dom",     "szkola",   "pomoc",    "imie" };
        string[] TabEng = new string[] { "home",    "school",   "help",     "name" };

        Diction dict0;
        Diction dict1;
        Diction dict2;
        Diction dict3;

        public Form1()
        {
            InitializeComponent();

            while (numbers.Count < 8)
            {
                number = numberRandom.Next(1, 9);
                if (!(numbers.Contains(number)))
                {
                    numbers.Add(number);
                }
            }
            
            points.Add(numbers[0], b1);
            points.Add(numbers[1], b2);
            points.Add(numbers[2], b3);
            points.Add(numbers[3], b4);
            points.Add(numbers[4], b5);
            points.Add(numbers[5], b6);
            points.Add(numbers[6], b7);
            points.Add(numbers[7], b8);

            numbers.Clear();

            while (numbers.Count < TabPol.Count())
            {
                number = numberRandom.Next(0, TabPol.Count());
                if (!(numbers.Contains(number)))
                {
                    numbers.Add(number);
                }
            }

            dict0 = new Diction(TabPol[numbers[0]], TabEng[numbers[0]]);
            dict1 = new Diction(TabPol[numbers[1]], TabEng[numbers[1]]);
            dict2 = new Diction(TabPol[numbers[2]], TabEng[numbers[2]]);
            dict3 = new Diction(TabPol[numbers[3]], TabEng[numbers[3]]);

            button1.Location = new System.Drawing.Point(points[1].X, points[1].Y);
            button2.Location = new System.Drawing.Point(points[2].X, points[2].Y);
            button3.Location = new System.Drawing.Point(points[3].X, points[3].Y);
            button4.Location = new System.Drawing.Point(points[4].X, points[4].Y);
            button5.Location = new System.Drawing.Point(points[5].X, points[5].Y);
            button6.Location = new System.Drawing.Point(points[6].X, points[6].Y);
            button7.Location = new System.Drawing.Point(points[7].X, points[7].Y);
            button8.Location = new System.Drawing.Point(points[8].X, points[8].Y);

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";

            //button1.Text = null;
            //button2.Text = null;
            //button3.Text = null;
            //button4.Text = null;
            //button5.Text = null;
            //button6.Text = null;
            //button7.Text = null;
            //button8.Text = null;
        }       

        Diction shot = new Diction();

        //Diction dict0 = new Diction("dom", "house");
        //Diction dict1 = new Diction("szkola", "school");
        //Diction dict2 = new Diction("pomoc", "help");
        //Diction dict3 = new Diction("imie", "name");

        Checker check = new Checker();

        private void button1_Click(object sender, EventArgs e)
        {
            check.checker1(button1, timer1, dict0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check.checker2(button2, timer1, dict0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check.checker1(button3, timer1, dict1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check.checker2(button4, timer1, dict1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check.checker1(button5, timer1, dict2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check.checker2(button6, timer1, dict2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check.checker1(button7, timer1, dict3);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check.checker2(button8, timer1, dict3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);
            timer1.Stop();

            //clrear all
            check.Btn1.Text = null;
            check.Btn1 = null;
            check.Btn2.Text = null;
            check.Btn2 = null;

            check.Pol = check.Eng = null;
        }

    }// public partial class Form1 : Form
}
