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
        private string _id;

        public MovieDetailsPage(string tag)
        {
            InitializeComponent();
            _id = tag;
            this.Title = tag;
        }
    }
}
