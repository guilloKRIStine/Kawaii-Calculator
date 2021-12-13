using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Info_Box.Text = "Привет ♥ Перед тобой kawaii calculator. Чтобы что-то посчитать в 1 и 3 боксе напиши числа, а во втором специалным знаком операцию. Чтобы увидеть список операций нажми на вопросик! ";
        }

        // ОСНОВА //

        private void Result_button_Click(object sender, EventArgs e)
        {
            Info_Box.Clear();
            Result_box.Clear();

            String Number_First_Box = First_box.Text; // 1 
            String Solution_Second_Box = Second_box.Text; // 2
            String Number_Third_Box = Third_box.Text; // 3

            int i = 0;
            
            if (Number_First_Box == "" || Solution_Second_Box == "" || Number_Third_Box == "") // проверка что не пустые
            {
                Info_Box.Text ="Ой, вы что-то упустили :( Проверьте, чтобы все было введено ♥";
                i++;
            }

            // кол-во знаков в первом боксе
            int NumberPlus1 = Number_First_Box.Where(c => c == '+').Count();
            int NumberMinus1 = Number_First_Box.Where(c => c == '-').Count();
            int NumberDots1 = Number_First_Box.Where(c => c == '.').Count();
            // кол-во знаков во втором боксе
            int NumberPlus3 = Number_Third_Box.Where(c => c == '+').Count();
            int NumberMinus3 = Number_Third_Box.Where(c => c == '-').Count();
            int NumberDots3 = Number_First_Box.Where(c => c == '.').Count();

            if ((NumberPlus1 >= 2) || (NumberMinus1 >= 2) || (NumberDots1 >= 2)  || (NumberPlus3 >= 2) || (NumberMinus3 >= 2) || (NumberDots3 >= 2)) //два раза ++ или -- или ..
            {
                Info_Box.Text = "Ой, вы написали лишний знак :( Проверьте, чтобы все было введено правильно ♥";
                i++;
            }

            if ((Number_First_Box.Contains("-") && Number_First_Box.Contains("+")) || (Number_Third_Box.Contains("-") && Number_Third_Box.Contains("+"))) // и + и -
            {
                Info_Box.Text = "Ой, вы написали лишний знак :( Проверьте, чтобы все было введено правильно ♥";
                i++;
            }

            if (Number_First_Box.EndsWith("-") || Number_First_Box.EndsWith("+") || Number_First_Box.EndsWith(".") || Number_Third_Box.EndsWith("-") || Number_Third_Box.EndsWith("+") || Number_Third_Box.EndsWith(".")) // конец на + - .
            {
                Info_Box.Text = "Ой, вы написали лишний знак :( Проверьте, чтобы все было введено правильно ♥";
                i++;
            }

            if ((Number_First_Box.Length == 1 && (Number_First_Box.Contains("-") || Number_First_Box.Contains("+") || Number_First_Box.Contains("."))) || (Number_Third_Box.Length == 1 && (Number_Third_Box.Contains("-") || Number_Third_Box.Contains("+") || Number_Third_Box.Contains(".")))) // только + и - и .
            {
                Info_Box.Text = "Ой, вы написали только знак :( Проверьте, чтобы все было введено правильно ♥";
                i++;
            }


            // так ну если все ок то погнали считать
            if (i == 0)
            {
                double First = Convert.ToDouble(Number_First_Box);
                double Third = Convert.ToDouble(Number_Third_Box);

                if (Solution_Second_Box == "+") // сложение
                {
                    Result_box.Text = (First + Third).ToString();
                    Info_Box.Text = "UwU ♥";
                }

                if (Solution_Second_Box == "-") // вычитание
                {
                    Result_box.Text = (First - Third).ToString();
                    Info_Box.Text = "UwU ♥";
                }

                if (Solution_Second_Box == "*") // умножение
                {
                    Result_box.Text = (First * Third).ToString();
                    Info_Box.Text = "UwU ♥";
                }

                if (Solution_Second_Box == "/") // деление
                {
                    if (Third != 0)
                    {
                        Result_box.Text = (First / Third).ToString();
                        Info_Box.Text = "UwU ♥";
                    }
                    else
                    {
                        Info_Box.Text = "Ай ай ай ~ На ноль делить нельзя! Поменяй, пожалуйста ♥";
                    }
                }
            }

        }

        // ПРОВЕРКИ НА ВВОД//

        private void First_Box_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод букв
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 45 && number != 43 && number != 46) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Third_Box_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод букв
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number!= 45 && number != 43 && number != 46) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Second_Box_KeyPress(object sender, KeyPressEventArgs e) //запрет на ввод букв
        {
            char number = e.KeyChar;

            if (number != 8 && number != 45 && number != 43 && number != 47 && number != 42) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        // ДОП ФУНКЦИИ //
        private void What_Button_Click(object sender, EventArgs e) // вопросик
        {
            MessageBox.Show(" Привет ♥ Перед тобой kawaii calculator. Чтобы что-то посчитать в 1 и 3 боксе напиши числа, а во втором специалным знаком операцию. + сложить, - вычесть, * умножить, / поделить, десятичные записывать с точкой", "Информация ♥");
        }
    }
}
