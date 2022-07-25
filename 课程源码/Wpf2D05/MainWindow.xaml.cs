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

namespace Wpf2D05
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

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            slider_x.Maximum = canvas.ActualWidth;
            slider_y.Maximum = canvas.ActualHeight;
        }

        private void slider_x_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //button.SetValue(Canvas.LeftProperty,slider_x.Value);
            Canvas.SetLeft(button, slider_x.Value);
        }

        private void slider_y_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            button.SetValue(Canvas.TopProperty, slider_y.Value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("hi");
        }
    }
}
