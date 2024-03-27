using EfSample.Models.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfSample.Forms;
public partial class FrmAddBook : Form
{
    public FrmAddBook()
    {
        InitializeComponent();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        AkademiLibraryContext db = new AkademiLibraryContext();

        // instance of Book class
        Book book = new Book();
        book.Name = txtName.Text;
        book.Writer = txtWriter.Text;

        db.Books.Add(book);
        db.SaveChanges();

        MessageBox.Show("Book added successfully");
    }

    private void FrmAddBook_Load(object sender, EventArgs e)
    {

    }
}
