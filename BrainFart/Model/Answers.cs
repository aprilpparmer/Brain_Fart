using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    /// <summary>
    /// Represents an Answer row from the Answers table in the
    /// BrainFart database for the Brain Fart application.
    /// </summary>
    public class Answers
    {
        private int answerID;
        private string answerDescrip;
        private int questionID;
        private int correct;

        /// <summary>
        /// Constructor for a new Answer object
        /// </summary>
        /// 
        public Answers() { }
        // the following are generic get and set methods, automatically generated
        public int AnswerID { get; set; }

        public string AnswerDescrip { get; set; }

        public int QuestionID { get; set; }

        public int Correct { get; set; }

    }
}
