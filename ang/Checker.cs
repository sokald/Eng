using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ang
{
    class Checker
    {
        private bool status = false;
        private string eng, pol = null;
        private Button btn1, btn2 = null; 

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        public string Eng
        {
            get { return eng; }
            set { eng = value; }
        }

        public string Pol
        {
            get { return pol; }
            set { pol = value; }
        }

        public Button Btn1
        {
            get { return btn1; }
            set { btn1 = value; }
        }

        public Button Btn2
        {
            get { return btn2; }
            set { btn2 = value; }
        }

        //check if two button is pressed
        public bool checkButtons(){
            if (btn1 != null && btn2 != null)
                return true;
            else
                return false;
        }

        //checker for even
        public void checker1(Button btn, Timer timer, Diction d)
        {
            //if are pressed two buttons
            if (timer.Enabled)
            {
                Task.Delay(TimeSpan.FromSeconds(1));
                //Thread.Sleep(1000);
            }
            else
            {
                //button1.Text = dict0.Pol;
                btn.Text = d.Pol;

                //if press the same language in other button
                //if (check.Btn1 != null)
                if (Btn1 != null)
                {
                    //button1.Text = check.Btn1.Text = null;

                    Btn2 = btn;
                    //timer
                    timer.Start();
                    //check.Btn1 = button1;
                }
                else
                {
                    Btn1 = btn;
                    Pol = d.Pol;

                    //if 2 buttons pressed
                    if (checkButtons())
                    {
                        //shot hit
                        if (Eng == d.Eng && Pol == d.Pol)
                        {
                            btn.Text = d.Pol;
                            Btn1.Enabled = Btn2.Enabled = false;
                            Btn1 = Btn2 = null;
                            Pol = Eng = null;
                        }
                        else
                        {
                            //shot miss, clear all
                            //timer
                            timer.Start();
                        }
                    }
                    else
                    {
                        //one button press
                        btn.Text = Pol = d.Pol;
                        Btn1 = btn;
                    }
                }
            }
        }

        //checker for odd
        public void checker2(Button btn, Timer timer, Diction d)
        {
            //if are pressed two buttons
            if (timer.Enabled)
            {
                Task.Delay(TimeSpan.FromSeconds(1));
                //Thread.Sleep(1000);
            }
            else
            {
                //button1.Text = dict0.Pol;
                btn.Text = d.Eng;

                //if press the same language in other button
                //if (check.Btn1 != null)
                if (Btn2 != null)
                {
                    //button1.Text = check.Btn1.Text = null;

                    Btn1 = btn;
                    //timer
                    timer.Start();
                    //check.Btn1 = button1;
                }
                else
                {
                    Btn2 = btn;
                    Eng = d.Eng;

                    //if 2 buttons pressed
                    if (checkButtons())
                    {
                        //shot hit
                        if (Eng == d.Eng && Pol == d.Pol)
                        {
                            btn.Text = d.Eng;
                            Btn1.Enabled = Btn2.Enabled = false;
                            Btn1 = Btn2 = null;
                            Pol = Eng = null;
                        }
                        else
                        {
                            //shot miss, clear all
                            //timer
                            timer.Start();
                        }
                    }
                    else
                    {
                        //one button press
                        btn.Text = Eng = d.Eng;
                        Btn2 = btn;
                    }
                }
            }
        }
    }
}
