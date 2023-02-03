using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage= "Flavor cannot be blank")]
    public string FlavorType { get; set; }
    public List<TreatFlavor> JoinEntities { get;  }
    public ApplicationUser User { get; set; }
  }
}