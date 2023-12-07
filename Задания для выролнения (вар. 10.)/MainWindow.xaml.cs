using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Задания_для_выполнения_Вариант_10_
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double distance1, speed1, distance2, speed2, distance3, speed3;

            if (double.TryParse(distance_1.Text, out distance1) && double.TryParse(speed_1.Text, out speed1) &&
                double.TryParse(distance_2.Text, out distance2) && double.TryParse(speed_2.Text, out speed2) &&
                double.TryParse(distance_3.Text, out distance3) && double.TryParse(speed_3.Text, out speed3))
            {
                double totalDistance = distance1 + distance2 + distance3;
                double totalTime = distance1 / speed1 + distance2 / speed2 + distance3 / speed3;
                double averageSpeed = totalDistance / totalTime;
                result.Text = averageSpeed.ToString("0.##");
            }
            else
            {
                result.Text = "Неверный ввод. Введите действительные числа.";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == true)
            {
                string fileName = openFile.FileName;
                img1.Source = new BitmapImage(new Uri(fileName));
            }
        }
    }
}
