using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
   public class Hymn
   {

      public int HymnID { get; set; }

      [Range(0, 300)]
      public int Page { get; set; }

      [StringLength(50)]
      public string Title { get; set; }

      [StringLength(50)]
      public string Type { get; set; }


   }
}
