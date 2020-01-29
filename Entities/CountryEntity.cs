using System;
using System.Collections.Generic;
using System.Text;
using Cities;

namespace Entities
{
    class CountryEntity : CountryModel
    {
        [Key]
        public int CountryID { get; set; }

        public virtual List<CityEntity> Cities { get; set; }
    }
}
