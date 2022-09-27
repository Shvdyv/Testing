using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ApplicationToLearnTest;
using System.Linq;

namespace MyTests
{
    class CompanyTests
    {
        [Test]
        public void CheckCreateWorker()
        {
            var worker = new Worker(1, "Jan");
            Assert.IsInstanceOf(typeof(Worker), worker);
            Assert.IsTrue(worker.Id == 1 && worker.Name == "Jan");
        }

        [Test]
        public void CheckCreateProduct()
        {
            var product = new Product(1, "Komputer");
            Assert.IsInstanceOf(typeof(Product), product);
            Assert.IsTrue(product.Id == 1 && product.Name == "Komputer");
        }

        [Test]
        public void CheckCreateInvoice()
        {
            var invoice = new Invoice(1, 9757);
            Assert.IsInstanceOf(typeof(Invoice), invoice);
            Assert.IsTrue(invoice.Id == 1 && invoice.Number == 9757);
        }

        [Test]
        public void CheckCreateCompany()
        {
            var worker1 = new Worker(1, "Jan");
            var worker2 = new Worker(2, "Aga");

            var workers = new List<Worker>();
            workers.Add(worker1);
            workers.Add(worker2);

            var product1 = new Product(1, "Komputer");
            var product2 = new Product(2, "Laptop");

            var products = new List<Product>();
            products.Add(product1);
            products.Add(product2);

            var invoice1 = new Invoice(1, 9757);
            var invoice2 = new Invoice(2, 1111);

            var invoices = new List<Invoice>();
            invoices.Add(invoice1);
            invoices.Add(invoice2);

            var company = new Company(1, "Firma", workers, products, invoices);
            Assert.IsInstanceOf(typeof(Company), company);
            Assert.IsTrue(company.Id == 1 && company.Name == "Firma" &&
                company.Workers.Any(w => w.Id == 1 && w.Name == "Jan") &&
                company.Workers.Any(w => w.Id == 2 && w.Name == "Aga") &&
                company.Products.Any(p => p.Id == 1 && p.Name == "Komputer") &&
                company.Products.Any(p => p.Id == 2 && p.Name == "Laptop") &&
                company.Invoices.Any(i => i.Id == 1 && i.Number == 9757) &&
                company.Invoices.Any(i => i.Id == 2 && i.Number == 1111));
        }


    }
}
