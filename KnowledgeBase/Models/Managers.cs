using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ballerz.KnowledgeBase.Models
{
    public class Managers
    {
        public int Id { get; set; }
        public string ManagerName { get; set; }
        
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string ManagerImageUrl { get; set; }
         public int CountryId { get; set; }
        
        public Countries Countries { get; set; }
        public string BirthPlace { get; set; }
        public int TeamId { get; set; }
       
        public Teams Teams { get; set; }
      

        
       
        
        

    }
}