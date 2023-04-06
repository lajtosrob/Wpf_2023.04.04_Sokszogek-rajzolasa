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

namespace WpfApp1_2023._04._04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

 

            List<Point> pontok = new List<Point>();

            Line szakasz = new Line();
            szakasz.X1 = 50;
            szakasz.Y1 = 120;
            szakasz.X2 = 520;
            szakasz.Y2 = 220;
            szakasz.StrokeThickness = 2;
            szakasz.Stroke = Brushes.Red;

            rajzlap.Children.Add(szakasz);

            Ellipse vegPont = new Ellipse();
            vegPont.Width = 20;
            vegPont.Height = 20;
            vegPont.Stroke = Brushes.DarkRed;
            vegPont.StrokeThickness = 3;

            Canvas.SetLeft(vegPont, szakasz.X1 - 10);
            Canvas.SetTop(vegPont, szakasz.Y1 - 10);
            rajzlap.Children.Add(vegPont);

            vegPont = new Ellipse();
            vegPont.Width = 20;
            vegPont.Height = 20;
            vegPont.Stroke = Brushes.DarkRed;
            vegPont.StrokeThickness = 3;

            Canvas.SetLeft(vegPont, szakasz.X2 - 10);
            Canvas.SetTop(vegPont, szakasz.Y2 - 10);
            rajzlap.Children.Add(vegPont);

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            Point pont = new Point();
            pont.X = 0;
            pont.Y = 0;

            Line szakasz = new Line();
            szakasz.X1 = 50;
            szakasz.Y1 = 120;
            szakasz.X2 = 520;
            szakasz.Y2 = 220;
            szakasz.StrokeThickness = 2;
            szakasz.Stroke = Brushes.Red;

            rajzlap.Children.Add(szakasz);
        }

        private void btnBefejezes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void VegPontFelvetel(Point pont)
        {
            Ellipse vegPont = new Ellipse();
            vegPont.Width = 20;
            vegPont.Height = 20;
            vegPont.Stroke = Brushes.DarkRed;
            vegPont.StrokeThickness = 3;

            Canvas.SetLeft(vegPont, pont.X - 10);
            Canvas.SetTop(vegPont, pont.Y - 10);
            rajzlap.Children.Add(vegPont);
        }
    }
}
