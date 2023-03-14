using ShopAdministration.Data;
using ShopAdministration.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Task - Create Shop Application with ability to see products and workers list
namespace ShopAdministration
{
    public partial class Form1 : Form
    {
        ShopDbContext db = new ShopDbContext();
        Shop shop = new Shop();
        public Form1()
        {
            InitializeComponent();
        }

		// show product info
        private void ProductInfoBtnClick(object sender, EventArgs e)
        {
			if (shop == null)
				return;

			shopListBox.DataSource = null;
			List<Product> products = new List<Product>();

			foreach (var product in shop.Products.ToList())
			{
				products.Add(new Product()
				{
					Id = product.Id,
					Name = product.Name,
					Price = product.Price,
					Discount = product.Discount,
					Category = product.Category,
					Quantity = product.Quantity,
					IsInStock = product.IsInStock
				});
			}

			shopListBox.DataSource = products;
		}

		// show worker info
        private void WorkerInfoBtnClick(object sender, EventArgs e)
        {
			if (shop == null)
				return;

			shopListBox.DataSource = null;
			List<Worker> workers = new List<Worker>();

			foreach (var worker in shop.Workers)
			{
				workers.Add(new Worker()
				{
					Id = worker.Id,
					Name = worker.Name,
					Surname = worker.Surname,
					Salary = worker.Salary,
					Email = worker.Email,
					PhoneNumber = worker.PhoneNumber,
					PositionId = worker.PositionId,
					ShopId = worker.ShopId
				});
			}

			shopListBox.DataSource = workers;
		}

		// configure shop 
        private void ShopListSelectedIndexChanged(object sender, EventArgs e)
        {
			if (shopList.SelectedItem == null)
				return;

			var newshop = shopList.SelectedItem as Shop;
			shop = new Shop()
			{
				Id = newshop.Id,
				Name = newshop.Name,
				Address = newshop.Address,
				CityId = newshop.CityId,
				ParkingArea = newshop.ParkingArea,
				Products = newshop.Products,
				Workers = newshop.Workers
			};
		}
    }
}
