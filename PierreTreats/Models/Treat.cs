using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public List<TreatFlavor> JoinEntities { get;  }
    public ApplicationUser User { get; set; }
  }
}