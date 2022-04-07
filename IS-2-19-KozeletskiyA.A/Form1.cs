using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_KozeletskiyA.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Создание абстракного класса от которого будут наследоваться родительские
        abstract class Комплектующие<art>
        {
            // переменные
            protected int цена;
            protected string год;
            protected art арт;
            // Конструктор
            public Комплектующие(int цена1, string год1, art арт1)
            {
                цена = цена1;
                год = год1;
                арт = арт1;
            }
            // создание метода для вывода пользователей в лист бокс
            public abstract void Display(ListBox lb);
        }
        // создание дочернего класса ЦП
        class ЦП<art> : Комплектующие<art>
        {
            // переменные класса
            double частота1;
            int ядра1;
            int потоки1;
            // наследование от родительского класса Комплектующие
            public ЦП(int цена1, string год1, art арт1, double поле1, int поле2, int поле3)
                : base(цена1, год1, арт1)
            {
                частота = поле1;
                ядра = поле2;
                потоки = поле3;
            }
            // свойства для создания дополнительной логики полям
            public double частота { get { return частота1; } set { частота1 = value; } }
            public int ядра { get { return ядра1; } set { ядра1 = value; } }
            public int потоки { get { return потоки1; } set { потоки1 = value; } }

            // метод для вывода информации в лист бокс
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена: {цена}, год Выпуска: {год}, арктикул: {арт}, частота: {частота}, количество ядер: {ядра}, количество потоков: {потоки}");
            }
        }
        // создание дочернего класса Видеокарты
        class Видеокарты<art> : Комплектующие<art>
        {
            double частота1;
            string производитель1;
            int память1;
            // наследование от родительского класса Комплектующие
            public Видеокарты(int цена1, string год1, art арт1, double поле1, string поле2, int поле3)
                : base(цена1, год1, арт1)
            {
                частота = поле1;
                производитель = поле2;
                память = поле3;
            }
            // свойства для создания дополнительной логики полям
            public double частота { get { return частота1; } set { частота1 = value; } }
            public string производитель { get { return производитель1; } set { производитель1 = value; } }
            public int память { get { return память1; } set { память1 = value; } }

            // метод для вывода информации в лист бокс
            public override void Display(ListBox listBox1)
            {
                listBox1.Items.Add($"Цена: {цена}, год Выпуска: {год}, арктикул: {арт}, частота GPU: {частота}, производитель: {производитель}, объём Памяти {память}");

            }
        }
        // объявление экземпляра класса глобально
        ЦП<string> цп;
        Видеокарты<string> вк;

        void button1_Click(object sender, EventArgs e)
        {
            // присвоение переменным введенных данных в текст боксы
            int цена1 = Convert.ToInt32(textBox1.Text);
            string год1 = textBox2.Text;
            double поле1 = Convert.ToDouble(textBox3.Text);
            int поле2 = Convert.ToInt32(textBox4.Text);
            int поле3 = Convert.ToInt32(textBox5.Text);
            string арт1 = textBox9.Text;
            // инициализания экземпляра класса и вызов ее конструктора
            цп = new ЦП<string>(цена1, год1, арт1, поле1, поле2, поле3);
            // вывод переменных в лист бокс с помощью метода
            цп.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // присвоение переменным введенных данных в текст боксы
            int цена1 = Convert.ToInt32(textBox1.Text);
            string год1 = textBox2.Text;
            double поле1 = Convert.ToDouble(textBox6.Text);
            string поле2 = textBox7.Text;
            int поле3 = Convert.ToInt32(textBox8.Text);
            string арт1 = textBox9.Text;
            // инициализания экземпляра класса и вызов ее конструктора
            вк = new Видеокарты<string>(цена1, год1, арт1, поле1, поле2, поле3);
            // вывод переменных в лист бокс с мощью метода
            вк.Display(listBox1);
        }
    }
}
