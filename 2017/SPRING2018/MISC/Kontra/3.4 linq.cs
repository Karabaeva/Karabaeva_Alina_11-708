using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqKR1
{   class C {
        public int Discount { get; set; }
        public string StoreName { get; set; } 
        public int ConsumerCode { get; set; }
    }
    class D { public string ItemNumber { get; set; }
            public string StoreName { get; set; }
           public int Price { get; set; }
    }
    class E {
        public string ItemNumber { get; set; }
          public string StoreName { get; set; }
          public int ConsumerCode { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            List<C> list1 = new List<C>
            { new C {Discount = 45 , ConsumerCode = 202 , StoreName ="L" },
              new C {Discount = 3 , ConsumerCode = 202 , StoreName ="K"},
              new C {Discount = 5 , ConsumerCode = 85 , StoreName ="MAC" },
              new C {Discount = 10 , ConsumerCode = 202 , StoreName ="L" },
              new C {Discount = 15 , ConsumerCode = 12 , StoreName ="L" }
            };
            List<D> list2 = new List<D> {
                new D { ItemNumber = "AS3445-6678", Price = 28520, StoreName = "L" },
                 new D { ItemNumber = "AS3445-6678", Price = 27840, StoreName = "K" } ,
                new D { ItemNumber = "AS3445-4568", Price = 29860, StoreName = "MAC" },
                new D { ItemNumber = "AS3445-6678", Price = 24500, StoreName = "L" },
                new D { ItemNumber = "AS3445-1237", Price = 2540, StoreName = "L" }

            };
            List<E> list3 = new List<E>
            {
                new E { ItemNumber = "AS3445-6678", ConsumerCode = 202, StoreName = "L" },
                new E { ItemNumber = "AS3445-6677", ConsumerCode = 12, StoreName = "K" },
                new E { ItemNumber = "AS3445-4568", ConsumerCode = 752, StoreName = "MAC" },
                new E { ItemNumber = "AS3445-4568", ConsumerCode = 752, StoreName = "Nak" },
                new E { ItemNumber = "AS3445-1237", ConsumerCode = 85, StoreName = "L" },
                new E { ItemNumber = "AS3445-4568", ConsumerCode = 85, StoreName = "L" },
            };
            var list23 = list2.Join(list3,
              p => p.ItemNumber,
              t => t.ItemNumber,
              (p, t) => new { ItemNum = p.ItemNumber, Price = p.Price, Store = t.StoreName });  // Объединям 2 и 3 коллекции и ищем по Арктиклу товара одинаковые товары в магазине

            var list123 = list23.Join(list1,  // Объединяeм получившуюся колекцию с 3 и ищем по названию магазина сопадающие  товары со скидкой  
               k => k.Store,
               y => y.StoreName,
               (k, y) => new { Item = k.ItemNum , pricewithDiscount = y.Discount , Stoore = k.Store , price = k.Price});

            foreach (var l in list123)
            {
                var puf = (l.price * l.pricewithDiscount)/100; // Цена с учетом скидки
                Console.WriteLine("{0} - {1} - {2}" , puf, l.Stoore, l.Item); // Программа что-то выводит, но вроде не так как надо :С
            }
           







        }
    }
}
