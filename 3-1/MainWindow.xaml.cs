using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double[] mas = new double[10];
        int i;
        int j = 0;
        double sum=0;
        string str_out;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)//ex1
        {
                
             
              mas[0]  = Convert.ToInt32(textBox1.Text);
              mas[1] = Convert.ToInt32(textBox2.Text);
              mas[2]= Convert.ToInt32(textBox3.Text);
              mas[3]= Convert.ToInt32(textBox4.Text);
              mas[4] = Convert.ToInt32(textBox5.Text);
              mas[5]= Convert.ToInt32(textBox6.Text);
              mas[6]= Convert.ToInt32(textBox7.Text);
              mas[7]= Convert.ToInt32(textBox8.Text);
              mas[8]= Convert.ToInt32(textBox9.Text);
              mas[9] = Convert.ToInt32(textBox10.Text);

              for (i = 1; i < 9; i++)
                  if (mas[i] > mas[i - 1] && mas[i] > mas[i + 1]) j++;

              out1.Text = "Элементов  больше своих «соседей» =" + Convert.ToString(j);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);

            for (i = 0; i <= 9; i++)
                if (mas[i] > 25) { j++; break; }

            if(j==0)
                out1.Text = "Все элименты <25";
            if(j==1)
            out1.Text = "Первый элимент >25 =" + (i+1);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);
            sum = mas[0];
            for (i = 2; i <= 9; i++)
            {
                sum += mas[i];
                if (sum > mas[1]) break;
                
            }
            out1.Text = Convert.ToString(sum);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);
            for (i = 0; i < 10; i++)
                if (mas[i] > mas[3]) j++;

            out1.Text ="Элементов больше чем 4-ый элемент ="+ Convert.ToString(j);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            sum = 0; i = 0;
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);
            while (sum < 21) {
                sum += mas[i];
                
                
                if (sum >= 21) break;
                i++;
                str_out += i + " ";
               
            }
            
            out1.Text ="Сумма элиментов меньше 21 = " + Convert.ToString(str_out);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            sum = 0; i = 0;
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);
            for (i = 0; i < 10; i++)
            {
                if (mas[i] % 5 == 0) mas[i] += 1;
                str_out += mas[i] + " ";
            }
            out1.Text =  Convert.ToString(str_out);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            sum = 0; i = 0;
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);

            for (i = 0; i < 10; i++) {
                if (mas[i] % 3 != 0)
                    sum += mas[i];
            }
            out1.Text ="Сумма не кратных 3 = "+ Convert.ToString(sum);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            sum = 0; i = 0;
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);

            for (i = 0; i < 10; i++)
            {
                if (mas[i] < mas[0] && mas[i] > mas[9])
                    sum++;
            }
            out1.Text = "Сумма меньше первого и больше последнего = " + Convert.ToString(sum);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);
            double min = Math.Abs(mas[1]-mas[0]);
            double element=0 ;
            for (i = 2; i < 10; i++)
                if (Math.Abs(mas[1] - mas[i]) < min)
                {
                    min = Math.Abs(mas[1] - mas[i]);
                    element = mas[i];
                }
            for (i = 0; i < 10; i++)
                if (mas[i] == element) str_out += " " + (i+1);

            out1.Text = " " + str_out;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            j = 0;
            mas[0] = Convert.ToInt32(textBox1.Text);
            mas[1] = Convert.ToInt32(textBox2.Text);
            mas[2] = Convert.ToInt32(textBox3.Text);
            mas[3] = Convert.ToInt32(textBox4.Text);
            mas[4] = Convert.ToInt32(textBox5.Text);
            mas[5] = Convert.ToInt32(textBox6.Text);
            mas[6] = Convert.ToInt32(textBox7.Text);
            mas[7] = Convert.ToInt32(textBox8.Text);
            mas[8] = Convert.ToInt32(textBox9.Text);
            mas[9] = Convert.ToInt32(textBox10.Text);

            for (i = 0; i < 10; i++)
                if (mas[i] % 3 == 0) j++;
            out1.Text = "Колличество элементов кратных 3" + str_out;
        }
    }
}