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
using static System.Reflection.Metadata.BlobBuilder;

namespace EfSample.Forms;
public partial class FrmBooks : Form
{
    public FrmBooks()
    {
        InitializeComponent();
    }

    private void FrmBooks_Load(object sender, EventArgs e)
    {
        AkademiLibraryContext db = new AkademiLibraryContext();

        List<Book> books = db.Books.ToList();
        dataGridView1.DataSource = books;

        //kitapları ada göre sırala
        //List<Book> books = db.Books.OrderBy(x => x.Name).ToList();
        //dataGridView1.DataSource = books;

        //kitapları ada göre tersten sırala
        //List<Book> books = db.Books.OrderByDescending(x => x.Name).ToList();
        //dataGridView1.DataSource = books;

        //List<Book> books = db.Books.Where(x => x.Name.Contains('a')).ToList();

        //kitap fiyatı 100 den büyük olan kitapları getir
        //List<Book> books2 = db.Books.Where(x => x.UnitPrice > 100).ToList();

        //kitap fiyatı 50 den büyük, 100 den küçük olan kitapları getir
        //List<Book> books3 = db.Books.Where(x => x.UnitPrice > 50 && x.UnitPrice < 100).ToList();
    }


    private void btnOrderByName_Click(object sender, EventArgs e)
    {
        AkademiLibraryContext db = new AkademiLibraryContext();
        List<Book> books = db.Books.OrderBy(x => x.Name).ToList();
        dataGridView1.DataSource = books;



    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string search = txtSearch.Text.Trim();
        AkademiLibraryContext db = new AkademiLibraryContext();
        //List<Book> books = db.Books.Where(x => x.Name.Contains(search)).ToList();
        List<Book> books = db.Books.Where(x => x.Name.StartsWith(search)).ToList();

        dataGridView1.DataSource = books;
    }

    private void btnSearchByPrice_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(txtMinPrice.Text) || string.IsNullOrEmpty(txtMaxPrice.Text))
        {
            MessageBox.Show("Please enter min and max price");
            return;
        }

        decimal minPrice = Convert.ToDecimal(txtMinPrice.Text);
        decimal maxPrice = Convert.ToDecimal(txtMaxPrice.Text);

        AkademiLibraryContext db = new AkademiLibraryContext();

        List<Book> books = db.Books.Where(x => x.UnitPrice >= minPrice && x.UnitPrice <= maxPrice).ToList();

        dataGridView1.DataSource = books;
    }
}
