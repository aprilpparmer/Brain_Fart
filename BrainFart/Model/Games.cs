using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    /// <summary>
    /// Represents a Game row from the Games table in the
    /// BrainFart database for the Brain Fart application.
    /// </summary>
    public class Games
    {
       private int gamesID;
       private int userID;
       private int difficultyID;
       private int score;

        /// <summary>
        /// Constructor for a new Games object
        /// </summary>

       public Games() { }

       // the following are generic get and set methods, automatically generated
       public int GamesID { get; set; }

       public int UserID { get; set; }

       public int DifficultyID { get; set; }

       public int Score { get; set; }

    }
}
