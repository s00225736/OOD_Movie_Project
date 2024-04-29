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

            Movies m1 = new Movies() { MovieID = 1, MovieName = "Casablanca", Director = "Michael Curtiz", Date = 23 / 01 / 1943, Descriptions = "During WWII, Rick, a nightclub owner in Casablanca, agrees to help his former lover Ilsa and her husband. Soon, Ilsa's feelings for Rick resurface and she finds herself renewing her love for him.", MovieImg = "/images/Casablanca.jpg" };
            Movies m2 = new Movies() { MovieID = 2, MovieName = "Blade Runner", Director = "Ridley Scott", Date = 25 / 06 / 1982, Descriptions = "Rick Deckard, an ex-policeman, becomes a special agent with a mission to exterminate a group of violent androids. As he starts getting deeper into his mission, he questions his own identity.", MovieImg = "/images/bladeRunner.jpg" };

            AllMovies.Add(m1);
            AllMovies.Add(m2);


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
            string tag = selectedImage.Tag.ToString();

            Movies selectedMovie = AllMovies.FirstOrDefault(m => m.MovieID.ToString() == tag);

            MovieDetailsPage movieDetailsPage = new MovieDetailsPage(selectedMovie.MovieID);
            movieDetailsPage.ShowDialog();
        }
    }
}
