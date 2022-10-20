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
using Complex;
namespace ComplexTestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
       

        private void ButPlusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(FirstA.Text);
                double b1 = Convert.ToDouble(FirstB.Text);


                double a2 = Convert.ToDouble(SecondA.Text);
                double b2 = Convert.ToDouble(SecondB.Text);
                Complex.Complex comp1 = new Complex.Complex(a1, b1);
                Complex.Complex comp2 = new Complex.Complex(a2, b2);


                Complex.Complex res = comp1+comp2;

                MessageBox.Show($"Первое комплексное число: {comp1}\n" +
                    $"Второе комплексное число: {comp2}\n" +
                    res);

            }
            catch
            {
                MessageBox.Show("Некоторые поля пусты или имеют неверный формат!");
            }
        }

        private void ButMinusClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(FirstA.Text);
                double b1 = Convert.ToDouble(FirstB.Text);


                double a2 = Convert.ToDouble(SecondA.Text);
                double b2 = Convert.ToDouble(SecondB.Text);
                Complex.Complex comp1 = new Complex.Complex(a1, b1);
                Complex.Complex comp2 = new Complex.Complex(a2, b2);


                Complex.Complex res = comp1 - comp2;
                MessageBox.Show($"Первое комплексное число: {comp1}\n" +
                    $"Второе комплексное число: {comp2}\n" +
                    res);

            }
            catch
            {
                MessageBox.Show("Некоторые поля пусты или имеют неверный формат!");
            }
        }

        private void ButDellClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(FirstA.Text);
                double b1 = Convert.ToDouble(FirstB.Text);


                double a2 = Convert.ToDouble(SecondA.Text);
                double b2 = Convert.ToDouble(SecondB.Text);
                Complex.Complex comp1 = new Complex.Complex(a1, b1);
                Complex.Complex comp2 = new Complex.Complex(a2, b2);


                Complex.Complex res = comp1 / comp2;
                MessageBox.Show($"Первое комплексное число: {comp1}\n" +
                   $"Второе комплексное число: {comp2}\n" +
                   res);

            }
            catch
            {
                MessageBox.Show("Некоторые поля пусты или имеют неверный формат!");
            }
        }

        private void ButMultiClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double a1 = Convert.ToDouble(FirstA.Text);
                double b1 = Convert.ToDouble(FirstB.Text);


                double a2 = Convert.ToDouble(SecondA.Text);
                double b2 = Convert.ToDouble(SecondB.Text);
                Complex.Complex comp1 = new Complex.Complex(a1, b1);
                Complex.Complex comp2 = new Complex.Complex(a2, b2);


                Complex.Complex res = comp1 * comp2;
                MessageBox.Show($"Первое комплексное число: {comp1}\n" +
                   $"Второе комплексное число: {comp2}\n" +
                   res);

            }
            catch
            {
                MessageBox.Show("Некоторые поля пусты или имеют неверный формат!");
            }
        }
    }
}
