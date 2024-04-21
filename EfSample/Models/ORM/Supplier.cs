using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class Supplier : BaseModel
{
    public string CompanyName { get; set; }
    public string Address { get; set; }

    public int CityId { get; set; }
    [ForeignKey("CityId")]
    public City City { get; set; }
}
