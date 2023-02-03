using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierreTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    [Required(ErrorMessage= "Treat type cannot be blank")]
    public string TreatType { get; set; }
    [Required(ErrorMessage= "Treat name cannot be blank")]
    public string TreatName { get; set; }
    public List<TreatFlavor> JoinEntities { get;  }
    public ApplicationUser User { get; set; }
  }
}