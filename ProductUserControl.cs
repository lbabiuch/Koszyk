using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class ProductUserControl : UserControl
    {
        public ProductUserControl()
        {
            InitializeComponent();
        }

        public void Update(Product product)
        {
            lblName.Text = product.Name;
            lblDescription.Text = product.Description;
            pbxImage.Load(product.ImageUrl);
            lblcena.Text = product.Price.ToString() + "€";
            lblkategoria.Text = product.Category.ToString();
        }
    }
}
