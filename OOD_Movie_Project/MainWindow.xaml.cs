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

namespace OOD_Movie_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MovieData db = new MovieData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from m in db.Movies
                        select m.MovieImg;

            List<string> results = query.ToList();

            string image = results.Where(movie1 => movie1.Contains("Casa")).FirstOrDefault();
            imgCasablanca.Source = new BitmapImage(new Uri($"/MovieImags/{image}", UriKind.Relative));

            string image2 = results.Where(movie2 => movie2.Contains("Dune")).FirstOrDefault();
            imgDune_2.Source = new BitmapImage(new Uri($"/MovieImags/{image}", UriKind.Relative));



        }

    }
}
