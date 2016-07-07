using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourSquare.SharpSquare.Entities;

namespace SharpSquare.Entities
{
    public class MiniVenue : FourSquareEntity
    {
        /// <summary>
        /// A unique string identifier for this venue.
        /// </summary>
        public string id
        {
            get;
            set;
        }

        /// <summary>
        /// The best known name for this venue.
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        ///  An object containing none, some, or all of address (street address), crossStreet, city, state, postalCode, country, lat, lng, and distance. All fields are strings, except for lat, lng, and distance. Distance is measured in meters. 
        ///  Some venues have their locations intentionally hidden for privacy reasons (such as private residences). If this is the case, the parameter isFuzzed will be set to true, and the lat/lng parameters will have reduced precision. 
        /// </summary>
        public Location location
        {
            get;
            set;
        }

        /// <summary>
        /// An array, possibly empty, of categories that have been applied to this venue. One of the categories will have a field primary indicating that it is the primary category for the venue. For the complete set of categories, see venues/categories. 
        /// </summary>
        public List<Category> categories
        {
            get;
            set;
        }

    }
}
