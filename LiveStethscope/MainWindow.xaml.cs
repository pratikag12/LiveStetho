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
using LiveCharts;
using LiveCharts.Wpf;

namespace LiveStethscope
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DataClass Dataset;
        public MainWindow()
        {
           InitializeComponent();
            Dataset = new DataClass()
            {
            SeriesCllection = new SeriesCollection()
            {
                new LineSeries()
                {
                    Values = new ChartValues<double> { 3, 5, 7, 4 , 3, 5, 7, 4 , 3, 5, 7, 4 , 3, 5, 7, 4 , 3, 5, 7, 4 , 3, 5, 7, 4 }
                },
            }
        };

           this.DataContext = Dataset;
        }

        private void btnStream_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Plotting Data");
            Dataset.SeriesCllection.Add(new ColumnSeries() { Values = new ChartValues<int> { 3, 12, 2, 3, 4, 1, 1, 2 } });

            //SoundGraph.Series = SeriesCllection;
            //CartesianChart chart = new CartesianChart();
            //chart.Series = SeriesCllection;
            //chart.AddToView(this);

            // CartesianChart.VisualElementsProperty = SeriesCollection;
        }




        private void btnStream_MouseEnter(object sender, MouseEventArgs e)
        {
            btnStream.Content = "Clickme";
        }

        private void btnStream_MouseLeave(object sender, MouseEventArgs e)
        {
            btnStream.Content = "Stream";
        }
    }
}
