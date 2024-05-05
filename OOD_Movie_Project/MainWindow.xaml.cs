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
        public List<string> ImageUrls { get; set; }
        public List<Movies> AllMovies { get; set; }

        //MovieData db = new MovieData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AllMovies = new List<Movies>();

            DataContext = this;

            Movies m1 = new Movies() {MovieImg = "/images/Casablanca.jpg" };
            Movies m2 = new Movies() { MovieImg = "/images/BladeRunner.jpg" };
            Movies m3 = new Movies() { MovieImg = "/images/Dune_2.jpg" };
            Movies m4 = new Movies() { MovieImg = "/images/Raiders_of_the_lost_ark.jpg" };
            Movies m5 = new Movies() { MovieImg = "/images/Ran_1985.jpg" };
            Movies m6 = new Movies() { MovieImg = "/images/star_wars_Revenge_Of_The_Sith_jpg.jpg" };
            Movies m7 = new Movies() { MovieImg = "/images/oppenheimer-movie-poster.jpg" };
            Movies m8 = new Movies() { MovieImg = "/images/monty_python_and_the_holy_grail.jpg" };
            Movies m9 = new Movies() { MovieImg = "/images/killers_of_the_flower_moon_poster.jpg" };
            Movies m10 = new Movies() { MovieImg = "/images/godfather.png" };

            AllMovies.Add(m1);
            AllMovies.Add(m2);
            AllMovies.Add(m3);
            AllMovies.Add(m4);
            AllMovies.Add(m5);
            AllMovies.Add(m6);
            AllMovies.Add(m7);
            AllMovies.Add(m8);
            AllMovies.Add(m9);
            AllMovies.Add(m10);

            // Simulated database query result
            //    List<string> imageUrls = new List<string>
            //{
            //    "/images/bladeRunner.jpg",
            //    "/images/Casablanca.jpg",
            //    "/images/Dune_2.jpg",
            //    "/images/godfather.png",
            //    "/images/killers_of_the_flower_moon_poster.jpg",
            //    "/images/monty_python_and_the_holy_grail.jpg",
            //    "/images/oppenheimer-movie-poster.jpg",
            //    "/images/Raiders_of_the_lost_ark.jpg",
            //    "/images/Ran_1985.jpg",
            //    "/images/star_wars_Revenge_Of_The_Sith_jpg.jpg"
            //    // Add more URLs as needed
            //};

            //    ImageUrls = imageUrls;
        }

        private void DisplayMovieDetails(object sender, MouseButtonEventArgs e)
        {
            Image selectedImage = sender as Image;

            if(selectedImage != null && selectedImage.Tag != null)
            {
                string tag = selectedImage.Tag.ToString();

                Movies selectedMovie = AllMovies.FirstOrDefault(m => m.MovieID.ToString() == tag);
                if(selectedMovie  != null)
                {
                    try
                    {
                        MovieDetailsPage movieDetailsPage = new MovieDetailsPage(selectedMovie.MovieID);
                        movieDetailsPage.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}","Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selected movie not found.", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
                }

                
            }
            
        }
    }
}
