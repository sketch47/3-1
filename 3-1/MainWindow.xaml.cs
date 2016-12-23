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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
                int j=0;
              double[] mas = new double[10];
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

              for (int i = 1; i < 9; i++)
                  if (mas[i] > mas[i - 1] && mas[i] > mas[i + 1]) j++;

              out1.Text = "Элементов  больше своих «соседей» =" + Convert.ToString(j);
        }
    }
}
