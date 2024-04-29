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
using System.Windows.Shapes;

namespace OOD_Movie_Project
{
    /// <summary>
    /// Interaction logic for MovieDetailsPage.xaml
    /// </summary>
    public partial class MovieDetailsPage : Window
    {
        private MovieData _db = new MovieData();
        private int _movieID;

        public MovieDetailsPage(int movieID)
        {
            InitializeComponent();

            _movieID = movieID;
            this.Title = "Movie Details";

            LoadMovieDetails();
        }

        public void LoadMovieDetails()
        {
            var movie = _db.Movies.FirstOrDefault(m => m.MovieID == _movieID);
            if(movie != null)
            {
                imgPoster.Source = new BitmapImage(new Uri(movie.MovieImg, UriKind.RelativeOrAbsolute));
                tblkName.Text = movie.MovieName;
                tblkDescription.Text = movie.Descriptions;

                var reviews = _db.MovieReviews.Where(r => r.MovieID == _movieID).ToList();
                StringBuilder sb = new StringBuilder();
                foreach(var review in reviews)
                {
                    sb.AppendLine($"{review.ReviewerName}: {review.ReviewDesc}");
                }
                tblkReviews.Text = sb.ToString();
            }
        }

        
    }
}
