using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentPlanner.Models
{
   public class Planner
   {

      public int PlannerID { get; set; }

      [DataType(DataType.Date)]
      [DisplayFormat(DataFormatString = "{0:MMMM dd, YYYY}", ApplyFormatInEditMode = true)]
      [Display(Name = "Sacrament Date")]
      public DateTime SacramentDate { get; set; }
      
      [StringLength(50)]
      public string Ward { get; set; }
   
      [StringLength(50)]
      public string Presiding { get; set; }

      
      [StringLength(50)]
      public string Conducting { get; set; }

  
      [StringLength(50)]
      public string Invocation { get; set; }

      public ICollection<Speaker> Speakers { get; set; }

      public ICollection<Hymn> Hymns { get; set; }

   }
}
