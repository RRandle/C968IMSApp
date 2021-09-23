using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968IMSApp.model
{
   class Product
    {
        public int prodID { get; set; }
        public string prodName { get; set; }
        public int prodInvntry { get; set; }
        public double prodPrice { get; set; }
        public int prodMin { get; set; }
        public int prodMax  { get; set; }

        public static int prodCount;

        public BindingList<Part> AssocPart = new BindingList<Part>();

        public Product( int aProdID, string aProdName, int aProdInvntry, double aProdPrice, int aProdMin, int aProdMax)
        {
            prodID = aProdID;
            prodName = aProdName;
            prodInvntry = aProdInvntry;
            prodPrice = aProdPrice;
            prodMin = aProdMin;
            prodMax = aProdMax;
        }

        public Product(string aProdName, int aProdInvntry, double aProdPrice, int aProdMin, int aProdMax)
        {
            prodID = prodCount++;
            prodName = aProdName;
            prodInvntry = aProdInvntry;
            prodPrice = aProdPrice;
            prodMin = aProdMin;
            prodMax = aProdMax;

        }

        public void AddAssocPart (Part newPart)
        {
            AssocPart.Add(newPart);
        }
    }
}
