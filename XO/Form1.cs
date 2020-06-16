using System;
using System.Windows.Forms;

namespace XO
{
    public partial class Form1 : Form
    {
        int i; //счетчик ходов
        int num_game = 0; // номер игры
        int Ovin = 0; // количество побед О
        int Xvin = 0; // количество побед Х
        string[] arr = new string[10]; // массив, который хранит расположение Х и О на игровом поле
        string t = "X"; // переменная которая показывает чей ход происходит
        public Form1()
        {
            InitializeComponent();
        }
        public string Game(int j) // принимает номер клетки поля
        {
            string fakeT; // переменная следущего хода
            if (i % 2 == 1) // узнает чей ход сделан (Х - непарный ход)
            {
                t = "X";
                fakeT = "O";
            }
            else
            {
                t = "O";
                fakeT = "X";
            }
            fakeT = "Ходит " + fakeT;
            arr[j] = t;
            i += 1;

            label1.Text = fakeT;// пишет кто следущий ходит


            return t; // возвращает отметку на поле Х или О

        }


        public void who_vin()
        {

            if ((arr[1] == "X" & arr[2] == "X" & arr[3] == "X") | (arr[1] == "X" & arr[5] == "X" & arr[9] == "X") | (arr[1] == "X" & arr[4] == "X" & arr[7] == "X") | (arr[2] == "X" & arr[5] == "X" & arr[8] == "X") | (arr[3] == "X" & arr[6] == "X" & arr[9] == "X") | (arr[3] == "X" & arr[5] == "X" & arr[7] == "X") | (arr[4] == "X" & arr[5] == "X" & arr[6] == "X") | (arr[7] == "X" & arr[8] == "X" & arr[9] == "X"))
            { // за таких обстоятельств побеждает Х
                Xvin += 1; // начисляем ему победу

                label3.Text = "X : O\n" + Xvin.ToString() + " : " + Ovin.ToString(); // обновляем табло побед
                MessageBox.Show(" X ПОБЕДИЛ!"); // выводим окошечко, которое говорит нам о победе
                refresch();// чистим поле, начинаем новую игру
            }

            if ((arr[1] == "O" & arr[2] == "O" & arr[3] == "O") | (arr[1] == "O" & arr[5] == "O" & arr[9] == "O") | (arr[1] == "O" & arr[4] == "O" & arr[7] == "O") | (arr[2] == "O" & arr[5] == "O" & arr[8] == "O") | (arr[3] == "O" & arr[6] == "O" & arr[9] == "O") | (arr[3] == "O" & arr[5] == "O" & arr[7] == "O") | (arr[4] == "O" & arr[5] == "O" & arr[6] == "O") | (arr[7] == "O" & arr[8] == "O" & arr[9] == "O"))
            {// за таких обстоятельств побеждает О, следущие действия аналогичны
                Ovin += 1;

                label3.Text = "X : O\n" + Xvin.ToString() + " : " + Ovin.ToString();
                MessageBox.Show(" O ПОБЕДИЛ!");
                refresch();
            }
            if ((arr[1] != "") & (arr[2] != "") & (arr[3] != "") & (arr[4] != "") & (arr[5] != "") & (arr[7] != "") & (arr[8] != "") & (arr[9] != ""))
            {// Ничья, тоесть все поле заполнено, а победителя нет


                MessageBox.Show(" НИЧЬЯ!"); // объявляем ничью
                refresch();// чистим поле
            }
        }

        public void refresch()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";// почистили каждую клетку поля
            label1.Text = "";//табло следующего хода
            for (i = 0; i < 10; i += 1) // массив ходов
            {
                arr[i] = "";
            }
            i = 1; // номер хода
            num_game += 1; // добавляем к номеру игры
            label2.Text = num_game + " игра"; // обновляем табло с номером игры
        }

        private void button10_Click(object sender, EventArgs e)
        {
            refresch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "X" | button1.Text == "O") // если клетка уже заполненая
            {
                MessageBox.Show(" Нельзя!");// предупреждаем, что нельзя
            }
            else { button1.Text = Game(1); who_vin(); }// если все хорошо, запускаем 2 функции. задаем клетке отметку Х или О
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            refresch();// чистим поле перед игрой
            label3.Text = "X : O\n" + Xvin.ToString() + " : " + Ovin.ToString(); // задаем счетчик
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "X" | button2.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button2.Text = Game(2); who_vin(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "X" | button3.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button3.Text = Game(3); who_vin(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "X" | button4.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button4.Text = Game(4); who_vin(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "X" | button5.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button5.Text = Game(5); who_vin(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "X" | button6.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button6.Text = Game(6); who_vin(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "X" | button7.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button7.Text = Game(7); who_vin(); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "X" | button8.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button8.Text = Game(8); who_vin(); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "X" | button9.Text == "O")
            {
                MessageBox.Show(" Нельзя!");
            }
            else { button9.Text = Game(9); who_vin(); }
        }
    }
}
