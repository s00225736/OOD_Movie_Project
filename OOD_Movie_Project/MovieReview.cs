using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Movie_Project
{
    public class MovieReview
    {
        [Key]
        public int ReviewID { get; set; }

        public string ReviewerName { get; set; }

        public string ReviewDesc {  get; set; }

        public int MovieID {  get; set; }

        public virtual Movies Movie { get; set; }

        public virtual List<Movies> Movies {  get; set; }

        public MovieReview()
        {
            Movies = new List<Movies>();
        }
    }

    public class Movies
    {
        [Key]
        public int MovieID { get; set; }

        public string MovieName { get; set; }

        public string Director { get; set; }

        public int DateTime { get; set; }

        public string Descriptions { get; set; }

        public string MovieImg { get; set; }
    }

    public class MovieData : DbContext
    {
        public MovieData() :base("MovieProject") { }

        public DbSet<MovieReview> MovieReviews { get; set;}

        public DbSet<Movies> Movies { get; set;}
    }
}
