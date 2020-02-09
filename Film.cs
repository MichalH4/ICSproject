using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_filmManagmet
{
    // TODO: where to place this enum variable ???
    /// <summary>
    /// Enum type for genres
    /// </summary>
    enum Genre
    {
        undefined,
        actionFilm,
        adventureFilm,
        comedyFilm,
        horrorFilm,
        historicalFilm,
        documentaryFilm,
        dramaFilm,
        scienceFilm,
        warFilm
    }

    /// <summary>
    /// This class contains all informations about film
    /// For every new film, new object from this class need to be created
    /// </summary>
    class Film
    {
        // Private fields of the class ( they are private by default )
        string orignalName;
        string czechName;
        Genre genreOfFilm;
        int lengthInMinutes;
        string countryOfOrigin;
        string description;
        object rating;                  // This reference variable will point at description which belongs to the film

        string[] actors;                // In this array will be stored all actors, which played in the film       
        int actors_index;               // Keep track of index in array actors

        string director;                // TODO: could be there more than one director ???

        // Default constructor
        public Film()
        {
            orignalName = string.Empty;
            czechName = string.Empty;
            genreOfFilm = Genre.undefined;
            lengthInMinutes = 0;
            countryOfOrigin = string.Empty;
            description = string.Empty;
            rating = null;
            actors = new string[10];                // Default length is 10 because of simplicity of code
            actors_index = 0;
            director = string.Empty;
        }

        #region Properties

        // Methods for getting and setting the content of orignalName
        public string OriginalName
        {
            get { return orignalName; }
            set { orignalName = value; }
        }

        // Methods for getting and setting the content of czechName
        public string CzechName
        {
            get { return czechName; }
            set { czechName = value; }
        }

        // Methods for getting and setting the content of genreOfFilm
        public Genre GenreOfFilm
        {
            get { return genreOfFilm; }
            set { genreOfFilm = value; }
        }

        // Methods for getting and setting the value of lengthInMinutes
        public int LengthInMinutes
        {
            get { return lengthInMinutes; }
            set { lengthInMinutes = value; }
        }

        // Methods for getting and setting the content of countryOfOrigin
        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }

        // Methods for getting and setting the content of description
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // Method for getting and setting the content of rating
        // If rating to film is added, new object from class Ratings is created and reference to this object is saved
        public object Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        // Method for setting the content of array actors
        public string Actors
        {
            set
            { 
                if (actors_index >= 0 && actors_index < actors.Length)
                    actors[actors_index] = value;
                ++actors_index;          
            }
        }

        // Methods for getting and setting the content of director
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        #endregion

        // Method for printing out names of actors in film
        public void ReadActersOfFilm()
        {
            for (int i = 0; i < 3; ++i)
                Console.WriteLine($"{i+1}. actor: {actors[i]}");
        }

        // TODO: write a method for reading from array actors according to index
        // TODO: write a method for removing actors from the array actors

    }
}
