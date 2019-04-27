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

namespace WpfDataBoundApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string ApplyText { get; set; }
        public string ResizeText { get; set; }
        public string ResetText { get; set; }

        DataBindClass _data = new DataBindClass()
        {
            Button1Text = "Button 1",
            Button2Text = "Button 2",
            Button3Text = "Button 3",
            TextBlock1Text = "TB 1",
            TextBlock2Text = "TB 2",
            TextBlock3Text = "TB 3"
        };


        public MainWindow()
        {
            InitializeComponent();

            ApplyText = "One";
            ResizeText = "Two";
            ResetText = "Three";

            // all controls will inherit this context
            this.DataContext = _data; // this;
            // btnResize.DataContext = this;
            // btnReset.DataContext = this;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            int value = 0;

            // value = 3 * int.Parse(firstNameText.Text);

            Console.WriteLine("{0}", value);

            MyWindow win = new MyWindow();

            win.ShowDialog();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Apply");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyWindow win = new MyWindow();

            win.ShowDialog();

            int total = 0;

            if (win.chkOne.IsChecked == true) total += 1;

            if (win.chkTwo.IsChecked == true) total += 2;

            if (win.chkThree.IsChecked == true) total += 3;

            if (win.chkFour.IsChecked == true) total += 4;

            if (win.chkFive.IsChecked == true) total += 5;

            if (win.chkSix.IsChecked == true) total += 6;

            MessageBox.Show(string.Format("Total = {0}", total), "Total", MessageBoxButton.OK);
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Reset");
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {
            _data.Button1Text = "Apply";
            _data.Button2Text = "Resize";
            _data.Button3Text = "Reset";
            _data.TextBlock1Text = "Height";
            _data.TextBlock2Text = "Width";
            _data.TextBlock3Text = "Depth";

        }
    }
}
