using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAssigment.Models;

namespace WebAssigment.Controllers
{
    public class Setting
    {
        DBEntities db = new DBEntities();

        public int GenerateId(Object o)
        {
            Random r = new Random();
            int id=0;
            if (o is User)
            {
                
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Users.Find(id) != null);
            }else if(o is Account)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Accounts.Find(id) != null);
            }else if(o is Security)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Securities.Find(id) != null);
            }else if(o is Address)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Addresses.Find(id) != null);
            }else if(o is PaymentMethod)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.PaymentMethods.Find(id) != null);
            }else if(o is Order)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Orders.Find(id) != null);
            }else if(o is Promo)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Promoes.Find(id) != null);
            }else if(o is Variant)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Variants.Find(id) != null);
            }else if(o is Product)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Products.Find(id) != null);
            }else if(o is Brand)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Brands.Find(id) != null);
            }else if(o is Category)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Categories.Find(id) != null);
            }else if(o is ProductImage)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.ProductImages.Find(id) != null);
            }else if(o is Wishlist)
            {
                do
                {
                    id = r.Next(0, 2147483647);
                } while (db.Wishlists.Find(id) != null);
            }
            return id;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}