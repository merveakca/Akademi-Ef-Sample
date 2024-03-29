using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class City : BaseModel
{
    public string Name { get; set; }

    public ICollection<Supplier> Suppliers { get; set; }

}
