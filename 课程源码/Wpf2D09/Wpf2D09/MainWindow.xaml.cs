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
        Line line = new Line() { Stroke = Brushes.Red, StrokeThickness = 1 };

        public MainWindow()
        {
            InitializeComponent();
            canvas.Children.Add(line);
        }

        private void ModifyGraphics()
        {           
            line.X1 = 0;
            line.Y1 = NormalizeY(0);
            line.X2 =100;
            line.Y2 = NormalizeY(200);
        }

        private double NormalizeY(double y)
        {
            return this.canvas.ActualHeight - y;
        }

        private void canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ModifyGraphics();
        }
    }
}
