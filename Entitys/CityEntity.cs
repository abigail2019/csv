using System;
using System.Collections.Generic;
using System.Text;
using Cities;
using System.ComponentModel.DataAnnotations;
using Models;

namespace Entitys
{
   public class CityEntity : CityModel
    {
        [Key]
        public int CityID { get; set; }

        public virtual CountryEntity Country { get; set; }
    }
}
