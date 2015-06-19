using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    /// <summary>
    /// Represents a Question row from the Questions table in the
    /// BrainFart database for the Brain Fart application.
    /// </summary>
    public class Questions
    {
       private int questionID;
       private string questionDescrip;
       private int pointValue;
       private int categoryID;
       private int difficultyID;

        /// <summary>
        /// Constructor for a new Questions object
        /// </summary>

       public Questions() { }

       // the following are generic get and set methods, automatically generated
       public int QuestionID { get; set; }

       public string QuestionDescrip { get; set; }

       public int CatergoryID { get; set; }

       public int DifficultyID { get; set; }

    }
}
