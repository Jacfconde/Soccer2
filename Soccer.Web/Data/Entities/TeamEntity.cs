using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Soccer.Web.Data.Entities
{
    public class TeamEntity
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "the  field {0} can not have more than {1} characters.")]
        [Required  (ErrorMessage = " the field {0} is mandatory") ] 
        public string Name { get; set; }
        public string LogoPath { get; set; }
    }
}
