using System;
using System.Collections.Generic;
using System.Text;
using Cities;
using System.ComponentModel.DataAnnotations;
using Models;

namespace Entitys
{
    public class CountryEntity : CountryModel
    {
        [Key]
        public int CountryID { get; set; }

        public virtual List<CityEntity> Cities { get; set; }
    }
}
