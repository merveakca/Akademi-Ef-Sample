using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSample.Models.ORM;
public class Book
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string? Name { get; set; }
    public DateTime PublishDate { get; set; }
    public string? Writer { get; set; }
}
