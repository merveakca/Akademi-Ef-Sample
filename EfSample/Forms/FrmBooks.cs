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
public partial class FrmBooks : Form
{
    public FrmBooks()
    {
        InitializeComponent();
    }

    private void FrmBooks_Load(object sender, EventArgs e)
    {
        AkademiLibraryContext db = new AkademiLibraryContext();
        dataGridView1.DataSource = db.Books.ToList();
    }
}
