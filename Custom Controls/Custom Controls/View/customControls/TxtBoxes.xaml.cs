using OxyPlot.Series;
using OxyPlot;
using System.Windows;
using System.Windows.Controls;

namespace Custom_Controls.View.customControls
{
    /// <summary>
    /// Interaction logic for TxtBoxes.xaml
    /// </summary>
    public partial class TxtBoxes : UserControl
    {
        public TxtBoxes()
        {
            InitializeComponent();
            var model = new PlotModel { Title = "Example Chart" };
            var series = new LineSeries
            {
                Title = "Line Series",
                MarkerType = MarkerType.Circle
            };

            series.Points.Add(new DataPoint(0, 0));
            series.Points.Add(new DataPoint(10, 18));
            series.Points.Add(new DataPoint(20, 12));
            series.Points.Add(new DataPoint(30, 8));
            series.Points.Add(new DataPoint(40, 15));

            model.Series.Add(series);

            DataContext = new { MyModel = model };
        }

        //public void btn_Clear(object sender, RoutedEventArgs s)
        //{
        //    txt_Box.Clear();
        //    txt_Box.Focus();
        //}
        //public void VisiblityChecker(object sender, RoutedEventArgs s)
        //{
        //    if (string.IsNullOrEmpty(txt_Box.Text))
        //    {
        //        txt_placeholder.Visibility = Visibility.Visible;

        //    }
        //    else
        //    {
        //        txt_placeholder.Visibility = Visibility.Hidden;
        //    }
        //}
    }
}
