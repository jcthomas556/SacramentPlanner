using SacramentPlanner.Models;
using System;
using System.Linq;

namespace SacramentPlanner.Data
{
   public static class DbInitializer
   {
      public static void Initialize(PlannerContext context)
      {
         context.Database.EnsureCreated();

         // Look for any students.
         if (context.Planners.Any())
         {
            return;   // DB has been seeded
         }

         var planners = new Planner[]
         {
            new Planner{SacramentDate=DateTime.Parse("July 04, 2018"),Ward = "Rexburg 4th", Conducting = "Vitali Karmanov", Presiding = "Jacob Thomas", Invocation = "Brett Smith", Benediction = "Janice Hall"},
           
            
         };
         foreach (Planner p in planners)
         {
            context.Planners.Add(p);
         }
         context.SaveChanges();

         
      }
   }
}