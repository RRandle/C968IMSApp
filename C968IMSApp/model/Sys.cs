using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968IMSApp.model
{
    static class Sys
    {
        //Binding Lists
        private static BindingList<Part> parts = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return parts; } set { parts = value; } }

        private static BindingList<Product> products = new BindingList<Product>();

        public static BindingList<Product> Products { get { return products; } set { products = value; } }

        private static BindingList<Part> associateParts = new BindingList<Part>();

        public static BindingList<Part> AssociateParts { get { return associateParts; } set { associateParts = value; } }

        //Selectors
        public static Part SelectedPart { get; set; }
        public static int SelectPartID { get; set; }

        public static Product SelectedProd { get; set; }
        public static int SelectedProdID { get; set; }

        public static int SelectedPartIndex { get; set; }
        public static int SelectedProdIndex { get; set; }
        //Part Modifications
        internal static void Change(Part itm)
        {
            Parts.Insert(SelectPartID, itm);
            Parts.RemoveAt(SelectPartID + 1);
        }
        //Product Modifications
        internal static void ChangeProd(Product itm)
        {
            Products.Insert(SelectedProdID, itm);
            Products.RemoveAt(SelectedProdID + 1);
        }
        //Part Look Up
        public static Part lookupPart(int i)
        {
            for(int j = 0; j < Parts.Count; j++)
            {
                if (Parts[j].partID.Equals(i))
                {
                    SelectPartID = j;
                    return Parts[j];
                }
                
            }
            SelectedPartIndex = -1;
            return null;
        }
        //Product Look Up
        public static Product lookupProd(int i)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j].prodID.Equals(i))
                {
                    SelectedProdID = j;
                    return Products[j];
                }

            }
            SelectedProdIndex = -1;
            return null;
        }
    }

}
