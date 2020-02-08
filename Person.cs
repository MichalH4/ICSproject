using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_filmManagmet
{
    /// <summary>
    /// This class contains all informations about actors and directors
    /// Actors and directors are separated into two different classes
    /// Actors will be objects from class Actor, Directors will be objects from class Director
    /// </summary>
    class Person
    {
        class Actor
        {
            // Properties of the class
            string firstName;
            string secondName;
            int age;
            string[] moviesWithThisActor;
            // TODO: Photography ????
            // TODO: link to his profil on wiki ???

            // Default constructor
            public Actor()
            {
                firstName = null;           // TODO: use null or string.Empty -> if string.Empty than it need to be changed everywhere
                secondName = null;
                age = 0;
                moviesWithThisActor = null;
            }

            // CONTINUE

        }

        class Director
        {
            // Properties of the class
            string firstName;
            string secondName;
            int age;
            string[] filmsHeDirected;
            // TODO: Photography ????
            // TODO: link to his profil on wiki ???

            // Default constructor
            public Director()
            {
                firstName = null;
                secondName = null;
                age = 0;
                filmsHeDirected = null;
            }

            // CONTINUE

        }
    }
}
