using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
    {
        public Engineer()
        {
          this.JoinEntities = new HashSet<EngineerMachine>();
        }

        public int EngineerId { get; set; }
        public string Name { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime WorkingSince { get; set; }
        public virtual ICollection<EngineerMachine> JoinEntities { get; set; }
    }
}