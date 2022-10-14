using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public Machine()
    {
      this.JoinEntities = new HashSet<EngineerMachine>();
    }

    public int MachineId { get; set; }
    public string Name { get; set; }

    [DataType(DataType.Date)]
    public DateTime WorkingSince { get; set; }
    public virtual ICollection<EngineerMachine> JoinEntities { get;}
  }
}