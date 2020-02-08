using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_filmManagmet
{
    /// <summary>
    /// This class contains user's rating of one film.
    /// For every new film, new object from this class need to be created
    /// </summary>
    class Ratings
    {
        // Properties of the class
        int ratingInPercents;
        StringBuilder textRating;

        // Default constructor which sets the values to properties when new object is created
        public Ratings()                // TODO: is constructor useless here ???
        {
            ratingInPercents = 0;
            textRating = null;
        }

        // After clicking on "Add rating" button, new object "rating to film xx" is created and init. via constructor
        // Than user will approach exact properties via getters and setters ( can also leave some properties empty )

        #region Getters and Setters

        // Methods for getting and setting the value of ratingInPercents
        public int RatingInPercents
        {
            get { return ratingInPercents; }
            set { ratingInPercents = value; }
        }

        // Methods for getting and setting the content of textRating
        public StringBuilder TextRating
        {
            get { return textRating; }
            set { textRating = value; }
        }

        #endregion

    }
}
