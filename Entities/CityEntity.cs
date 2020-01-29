using System;
using Cities;

namespace Entities
{
    public class CityEntity : CityModel
    {
        [Key]
        public int CityID { get; set; }

        public virtual Cities.CountryEntity Country { get; set; }
    }
}
