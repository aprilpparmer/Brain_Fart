using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainFart.Model
{
    /// <summary>
    /// Represents a Category row from the Catergories table in the
    /// BrainFart database for the Brain Fart application.
    /// </summary>
   public class Categories
    {
       private int categoryID;
       private string categoryDescrip;

        /// <summary>
        /// Constructor for a new Catergories object
        /// </summary>

       public Categories() { }

       // the following are generic get and set methods, automatically generated
       public int CategoryID { get; set; }

       public string CategoryDescrip { get; set; }

    }
}
