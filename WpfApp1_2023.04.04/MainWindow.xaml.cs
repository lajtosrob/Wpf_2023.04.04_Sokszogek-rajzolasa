using System;
using System.Collections.Generic;
using System.IO;
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
        List<Point> pontok = new List<Point>();
        int index = -1;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            Point pont = new Point();
            pont.X = int.Parse(txtX.Text);
            pont.Y = int.Parse(txtY.Text);
            pontok.Add(pont);
            index++;


            if (index == 0)
            {
                VegPontFelvetel(pont);
            }
            else
            {
                SzakasztRajzol(pont);
            }

        }

        private void btnBefejezes_Click(object sender, RoutedEventArgs e)
        {
            Point pont = new Point();
            pont.X = int.Parse(txtX.Text);
            pont.Y = int.Parse(txtY.Text);
            pontok.Add(pont);
            index++;

            Line szakasz = new Line();
            szakasz.X1 = pontok[0].X;
            szakasz.Y1 = pontok[0].Y;
            szakasz.X2 = pontok[pontok.Count-1].X;
            szakasz.Y2 = pontok[pontok.Count-1].Y;
            szakasz.StrokeThickness = 2;
            szakasz.Stroke = Brushes.Red;

            rajzlap.Children.Add(szakasz);
        }

        private void btnMentes_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sr = new StreamWriter("mentes.txt", append: true);
            foreach (var item in pontok)
            {
                sr.Write($"{item} \n");
            }
            sr.Close();
            MessageBox.Show("A pontok lista mentése megtörtént!");
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

        private void SzakasztRajzol(Point pont)
        {
            Line szakasz = new Line();
            szakasz.X1 = pontok[index - 1].X;
            szakasz.Y1 = pontok[index - 1].Y;
            szakasz.X2 = pontok[index].X;
            szakasz.Y2 = pontok[index].Y;
            szakasz.StrokeThickness = 2;
            szakasz.Stroke = Brushes.Red;
            rajzlap.Children.Add(szakasz);
        }
    }
}
