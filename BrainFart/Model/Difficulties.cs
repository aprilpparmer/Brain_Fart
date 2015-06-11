using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    /// <summary>
    /// Represents a Difficulty row from the Difficulties table in the
    /// BrainFart database for the Brain Fart application.
    /// </summary>
    public class Difficulties
    {
       private int difficultyID;
       private string difficultyDescrip;

        /// <summary>
        /// Constructor for a new Catergories object
        /// </summary>

       public Difficulties() { }

       // the following are generic get and set methods, automatically generated
       public int DifficultyID { get; set; }

       public string DifficultyDescrip { get; set; }

    }
}
