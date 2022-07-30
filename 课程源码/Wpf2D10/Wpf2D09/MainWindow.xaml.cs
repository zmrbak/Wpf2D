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

namespace Wpf2D09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double xMin = 0;
        double xMax = 0;
        double yMin = 0;
        double yMax = 0;
        Line line = new Line() { Stroke = Brushes.Red, StrokeThickness = 1 };

        public MainWindow()
        {
            InitializeComponent();
            canvas.Children.Add(line);
        }

        private void ModifyGraphics()
        {           
            line.X1 = NormalizeX(0);
            line.Y1 = NormalizeY(0);
            line.X2 = NormalizeX(100);
            line.Y2 = NormalizeY(200);
        }

        private double NormalizeY(double y)
        {
            if (yMax == yMin) return 0;
            return this.canvas.ActualHeight - (y - yMin) * this.canvas.ActualHeight / (yMax - yMin);
        }

        private double NormalizeX(double x)
        {
            if (xMax == xMin) return 0;

            return  (x - xMin) * this.canvas.ActualWidth / (xMax - xMin);
        }

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ModifyGraphics();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            xMin = Convert.ToDouble(tb_xMin.Text);
            xMax = Convert.ToDouble(tb_xMax.Text);
            yMin = Convert.ToDouble(tb_yMin.Text);
            yMax = Convert.ToDouble(tb_yMax.Text);

            ModifyGraphics();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
