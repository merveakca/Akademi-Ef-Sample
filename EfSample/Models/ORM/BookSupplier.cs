using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class BookSupplier : BaseModel
{
    public int BookId { get; set; }
    [ForeignKey("BookId")]
    public Book Book { get; set; }

    public int SupplierId { get; set; }
    [ForeignKey("SupplierId")]
    public Supplier Supplier { get; set; }
}
