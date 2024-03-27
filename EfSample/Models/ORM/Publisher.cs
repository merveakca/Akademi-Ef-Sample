using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class Publisher : BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
}
