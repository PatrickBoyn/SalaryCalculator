using System;
using System.Windows;

namespace SalaryCalculator
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //hourly rate * 2000 = yearly salary
            //yearly salary / 2000 = hourly rate
            double yearlySalary = Double.Parse(txtWages.Text) * 2000;
            double hourlyWage = Double.Parse(txtWages.Text) / 2000;

            if (cmbWages.Text == "Yearly Salary")
            {
                lblCalculate.Content = yearlySalary.ToString();
            }
            else
            {
                lblCalculate.Content = hourlyWage.ToString();
            }
        }
    }
}
