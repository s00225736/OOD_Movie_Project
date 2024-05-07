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
    /// Interaction logic for MainWindow.xamlz
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Movies> AllMovies { get; set; }
        public List<MovieReview> AllReviews { get; set; }


        MovieData db = new MovieData();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            AllMovies = new List<Movies>();
            AllReviews = new List<MovieReview>();

            DataContext = this;

            #region movies
            Movies m1 = new Movies() { MovieID = 1, MovieName = "Casablanca", Director = "Michael Curtiz", MovieImg = "/images/Casablanca.jpg", DateTime = 23 / 01 / 1943, Descriptions = "During WWII, Rick, a nightclub owner in Casablanca, agrees to help his former lover Ilsa and her husband. Soon, Ilsa's feelings for Rick resurface and she finds herself renewing her love for him." };
            Movies m2 = new Movies() {MovieID = 2, MovieName = "Blade Runner", Director = "Ridley Scott", MovieImg = "/images/BladeRunner.jpg", DateTime = 25 / 06 / 1982, Descriptions = "Rick Deckard, an ex-policeman, becomes a special agent with a mission to exterminate a group of violent androids. As he starts getting deeper into his mission, he questions his own identity." };
            Movies m3 = new Movies() { MovieID = 3, MovieName = "Dune 2", Director = "Denis Villeneuve", MovieImg = "/images/Dune_2.jpg", DateTime = 01 / 03 / 2024, Descriptions = "Paul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family. Facing a choice between the love of his life and the fate of the universe, he must prevent a terrible future only he can foresee." };
            Movies m4 = new Movies() { MovieID = 4, MovieName = "Godfather 1", Director = "Francis Ford Coppola", MovieImg = "/images/godfather.png", DateTime = 25 / 08 / 1972, Descriptions = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son, Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger." };
            Movies m5 = new Movies() { MovieID = 5, MovieName = "Indiana Jones And The Raider Of The Lost Ark", Director = "Steven Spielberg", MovieImg = "/images/Raiders_of_the_lost_ark.jpg", DateTime = 07 / 08 / 1981, Descriptions = "Upon his arrival in India, Indiana Jones, an American adventurer, is asked by the villagers of a remote hamlet to retrieve a mystical stone and rescue young boys kidnapped from the village." };
            Movies m6 = new Movies() { MovieID = 6, MovieName = "Killers Of The Flower Moon", Director = "Martin Scorsese", MovieImg = "/images/killers_of_the_flower_moon_poster.jpg", DateTime = 20 / 10 / 2023, Descriptions = "Real love crosses paths with unspeakable betrayal as Mollie Burkhart, a member of the Osage Nation, tries to save her community from a spree of murders fueled by oil and greed." };
            Movies m7 = new Movies() { MovieID = 7, MovieName = "Monty Python And The Holy Grail ", Director = "Terry Gilliam and Terry Jones", MovieImg = "/images/monty_python_and_the_holy_grail.jpg", DateTime = 25 / 05 / 1975, Descriptions = "King Arthur and his knights are tasked by God to find the legendary Holy Grail. During their journey, they encounter various people and obstacles that hinder them on their quest." };
            Movies m8 = new Movies() { MovieID = 8, MovieName = "Oppenheimer", MovieImg = "/images/oppenheimer-movie-poster.jpg", DateTime = 21 / 07 / 2023, Director = "Christopher Nolan", Descriptions = "During World War II, Lt. Gen. Leslie Groves Jr. appoints physicist J. Robert Oppenheimer to work on the top-secret Manhattan Project. Oppenheimer and a team of scientists spend years developing and designing the atomic bomb. Their work comes to fruition on July 16, 1945, as they witness the world's first nuclear explosion, forever changing the course of history." };
            Movies m9 = new Movies() { MovieID = 9, MovieName = "Ran", MovieImg = "/images/Ran_1985.jpg", DateTime = 01 / 06 / 1985, Director = "Akira Kurosawa", Descriptions = "An ageing warlord retires and entrusts his empire to his three sons. However, he soon realises that power has corrupted them and made them uncontrollable." };
            Movies m10 = new Movies() { MovieID = 10, MovieName = "Star Wars The Revenge Of The Sith", Director = "George Lucas", MovieImg = "/images/star_wars_Revenge_Of_The_Sith_jpg.jpg", DateTime = 19 / 05 / 2005, Descriptions = "Anakin joins forces with Obi-Wan and sets Palpatine free from the evil clutches of Count Doku. However, he falls prey to Palpatine and the Jedis' mind games and gives into temptation." };

            #endregion

            #region reviews                
            //casablanca
            MovieReview r1 = new MovieReview() {MovieID = 1, ReviewerName = "BrenerTT", ReviewDesc = "We'll always have Paris" };
            MovieReview r2 = new MovieReview() { MovieID = 1, ReviewerName = "Karst", ReviewDesc = "Three times. Three separate times I have tried to watch this, falling asleep each time and never being able to finish it. Not sure if I should blame the movie or my horrible sleep schedule, but it took way longer to watch this than it should’ve. Anyways, yeah it’s fine but not my type of thing." };
            MovieReview r3 = new MovieReview() {MovieID = 1, ReviewerName = "Reece", ReviewDesc = "I'm straight up crying on a plane right now because of this movie" };

            //blade runner
            MovieReview r4 = new MovieReview() { MovieID = 2, ReviewerName = "BlinkerSolidman", ReviewDesc = "Final cut, looked amazing " };
            MovieReview r5 = new MovieReview() {MovieID = 2, ReviewerName = "Reyach", ReviewDesc = "Eerie and uncanny. Script is great. Visuals are beautiful" };
            MovieReview r6 = new MovieReview() {MovieID = 2, ReviewerName = "Karst", ReviewDesc = "Perfect film. Made me want to make movies." };

            //dune 2
            MovieReview r7 = new MovieReview() {MovieID = 3, ReviewerName = "Karst", ReviewDesc = "one of those moviegoing experiences i’ll cherish for the rest of my life" };
            MovieReview r8 = new MovieReview() { MovieID = 3, ReviewerName = "TheFilmPope", ReviewDesc = "Denis Villeneuve has done something truly unique here." };
            MovieReview r9 = new MovieReview() {MovieID = 3, ReviewerName = "Cam Walsh", ReviewDesc = "This is truly the cinematic event of our generation… don’t take it for granted 100/100" };

            //godfather
            MovieReview r10 = new MovieReview() {MovieID = 4, ReviewerName = "Karst", ReviewDesc = "I was sooooo ready to say this was overhyped but nope, it’s as good as everyone says it is. On to part 2." };
            MovieReview r11 = new MovieReview() {MovieID = 4, ReviewerName = "Tentin Quarantno", ReviewDesc = "I don't trust anyone who dislikes this movie." };
            MovieReview r12 = new MovieReview() { MovieID = 4, ReviewerName = "Trex888", ReviewDesc = "this is the greatest movie ever made" };

            //indiana jones
            MovieReview r13 = new MovieReview() {MovieID = 5, ReviewerName = "Bravosky", ReviewDesc = "This film belongs in a museum." };
            MovieReview r14 = new MovieReview() { MovieID = 5, ReviewerName = "CarolineCain", ReviewDesc = "the fact that i had to watch this for an archaeology class is appalling" };
            MovieReview r15 = new MovieReview() {MovieID = 5, ReviewerName = "Tmason00", ReviewDesc = "A masterpiece! I love it gets better with every watch." };

            //killers of the flower moom
            MovieReview r16 = new MovieReview() { MovieID = 6, ReviewerName = "OppenheimerFan", ReviewDesc = "“There was no mention of the murders.”Incredible final line by the director himself, Martin Scorsese." };
            MovieReview r17 = new MovieReview() {MovieID = 6, ReviewerName = "Luigi", ReviewDesc = "Lily Gladstone has to win the oscar" };
            MovieReview r18 = new MovieReview() {MovieID = 6, ReviewerName = "Martin", ReviewDesc = "lily gladstone left me speechless and wow i really dont like leonardo dicaprio" };

            //monty python
            MovieReview r19 = new MovieReview() {MovieID = 7, ReviewerName = "Amaya", ReviewDesc = "sometimes i think i am a mature person and sometimes i cry of laughter because a french man said i fart in your general direction" };
            MovieReview r20 = new MovieReview() { MovieID = 7,ReviewerName = "Mattie Gazzard", ReviewDesc = "Never gets old" };
            MovieReview r21 = new MovieReview() { MovieID = 7, ReviewerName = "KeerinLoocis", ReviewDesc = "I did not stop quoting it the whole time" };

            //oppenheimer
            MovieReview r22 = new MovieReview() { MovieID = 8, ReviewerName = "Patrick Willems", ReviewDesc = "It’s so funny that this is a big summer blockbuster" };
            MovieReview r23 = new MovieReview() { MovieID = 8, ReviewerName = "Flynn", ReviewDesc = "I thought this would be a Christopher Nolan film I could actually understand but I was wrong" };
            MovieReview r24 = new MovieReview() { MovieID = 8, ReviewerName = "SuspirLiam", ReviewDesc = "can’t shake the image of the raindrop ripples and the sound of stamping feet….. nolan is a GENIUS"};

            //ran
            MovieReview r25 = new MovieReview() { MovieID = 9, ReviewerName = "Karst", ReviewDesc = "I feel like I just witnessed color in film for the first time.There is a lot to love about Ran. It's way of finding heart and beauty in a story fueled by hatred and tension is one of my favorite aspects, I suppose. But then there's the color. And the editing. And everything else." };
            MovieReview r26 = new MovieReview() { MovieID = 9, ReviewerName = "Emily Housel", ReviewDesc = "if Kurosawa made a 3 hour film of just clouds and grass I’d probably watch it every day" };
            MovieReview r27 = new MovieReview() { MovieID = 9, ReviewerName = "Zegan", ReviewDesc = "Akira Kurosawa is god or what?" };

            //star wars
            MovieReview r28 = new MovieReview() { MovieID = 10, ReviewerName = "houston Coley", ReviewDesc = "it’s crazy how this movie was bad for a decade, and then it just like....became good" };
            MovieReview r29 = new MovieReview() { MovieID = 10, ReviewerName = "Mario", ReviewDesc = "This is where the fun begins." };
            MovieReview r30 = new MovieReview() { MovieID = 10, ReviewerName = "Wes", ReviewDesc = "there is a very small but loud part of me that feels this is the best one" };
            #endregion

            #region moviesAdd
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
            #endregion

            #region reviewsAdd
            AllReviews.Add(r1);
            AllReviews.Add(r2);
            AllReviews.Add(r3);
            AllReviews.Add(r4);
            AllReviews.Add(r5);
            AllReviews.Add(r6);
            AllReviews.Add(r7);
            AllReviews.Add(r8);
            AllReviews.Add(r9);
            AllReviews.Add(r10);
            AllReviews.Add(r11);
            AllReviews.Add(r12);
            AllReviews.Add(r13);
            AllReviews.Add(r14);
            AllReviews.Add(r15);
            AllReviews.Add(r16);
            AllReviews.Add(r17);
            AllReviews.Add(r18);
            AllReviews.Add(r19);
            AllReviews.Add(r20);
            AllReviews.Add(r21);
            AllReviews.Add(r22);
            AllReviews.Add(r23);
            AllReviews.Add(r24);
            AllReviews.Add(r25);
            AllReviews.Add(r26);
            AllReviews.Add(r27);
            AllReviews.Add(r28);
            AllReviews.Add(r29);
            AllReviews.Add(r30);
            #endregion
        }

        private void DisplayMovieDetails(object sender, MouseButtonEventArgs e)
        {
            Image selectedImage = (Image)sender;

            if (selectedImage != null && selectedImage.Tag != null)
            {
                string tag = selectedImage.Tag.ToString();

                Movies selectedMovie = AllMovies.FirstOrDefault(m => m.MovieID.ToString() == tag);

                if (selectedMovie != null)
                {
                    StringBuilder movieDetails = new StringBuilder();
                    movieDetails.AppendLine($"Name: {selectedMovie.MovieName}");
                    movieDetails.AppendLine($"Director: {selectedMovie.Director}");
                    movieDetails.AppendLine($"Date: {selectedMovie.DateTime}");
                    movieDetails.AppendLine($"Description: {selectedMovie.Descriptions}");

                    var movieReviews = AllReviews.Where(r => r.MovieID.ToString() == tag);

                    movieDetails.AppendLine("\nReviews:");
                    foreach (var review in movieReviews)
                    {
                        movieDetails.AppendLine($"- {review.ReviewerName}: {review.ReviewDesc}");
                    }

                    MessageBox.Show(movieDetails.ToString(), "Movie Details", MessageBoxButton.OK);
                }
            }
        }

    }
}
