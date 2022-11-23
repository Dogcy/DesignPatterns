using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationFactory
{
    internal static class Factory
    {
        public static Product OperationFactoryProduct(string operate)
        {
            // switch 新版寫法
            Product product = operate switch
            {
                "A" => new ProductA(),
                "B" => new ProductB(),
                _ => new Product() // 同等default _=>
            };
            return product;


            // switch舊版寫法
            //Product product = null;
            //switch (operate)
            //{
            //    case "A":
            //        product = new ProductA();
            //        break;
            //    case "B":
            //        product = new ProductA();
            //        break;
            //    default:
            //        product = new Product();
            //        break;
            //};
            //return product;

        }
    }
}
