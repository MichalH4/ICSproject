using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_filmManagmet
{
    class Program
    {
        /// <summary>
        /// This is the Main method of this program, starting point of program
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Creating a new film called Film_1
            Film Film_1 = new Film();

            // Adding specification of the film
            Film_1.CountryOfOrigin = "Hungary";
            Film_1.CzechName = "Dva Kone a Pes";
            Film_1.OriginalName = "Two Horses and Dog";
            Film_1.GenreOfFilm = Genre.comedyFilm;
            Film_1.LengthInMinutes = 95;
            Film_1.Description = "Uzasny film plny konov a psov";
            Film_1.Director = "Alfonz Hlina";

            // Adding actors to Film_1
            Film_1.Actors = "Actor_1";
            Film_1.Actors = "Actor_2";
            Film_1.Actors = "Actor_3";

            // Adding rating of the film
            Ratings Film_1_rating = new Ratings();
            Film_1.Rating = Film_1_rating;
            Film_1_rating.RatingInPercents = 80;
            Film_1_rating.TextRating = "It was really amazing film";

            // Creating new object for director "Alfonz Hlina"
            Person Director_AlfonzHlina = new Person();
            Director_AlfonzHlina.FirstName = "Alfonz";
            Director_AlfonzHlina.SecondName = "Hlina";
            Director_AlfonzHlina.Age = 40;
            Director_AlfonzHlina.MoviesAsActor = "Nejaky nazov filmu";
            Director_AlfonzHlina.MoviesAsDirector = Film_1.CzechName;

            // Testing printout of actors, which played in Film_1:
            Film_1.ReadActersOfFilm();
            Console.ReadKey();
        }
    }
}
