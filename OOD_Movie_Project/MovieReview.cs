using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Movie_Project
{
    public class MovieReview
    {
        public int ReviewID { get; set; }

        public string ReviewerName { get; set; }

        public string ReviewDesc {  get; set; }

        public int MoviesID {  get; set; }

        public virtual Movies Movie { get; set; }

        public virtual List<Movies> Movies {  get; set; }

        public MovieReview()
        {
            Movies = new List<Movies>();
        }
    }

    public class Movies
    {
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public int Date { get; set; }

        public string descriptions { get; set; }

        public string MovieImg { get; set; }
    }

    public class MovieData : DbContext
    {
        public MovieData(string databaseName) :base(databaseName) { }

        public DbSet<MovieReview> movieReviews { get; set;}

        public DbSet<Movies> movies { get; set;}
    }
}
