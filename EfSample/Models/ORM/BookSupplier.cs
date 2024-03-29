using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class BookSupplier : BaseModel
{
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int SupplierId { get; set; }
    public Supplier Supplier { get; set; }
}
