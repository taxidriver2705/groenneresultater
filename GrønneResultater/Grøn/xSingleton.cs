using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    class xSingleton
    {
        private static xSingleton _instance = new xSingleton();
        private Basket _basket = new Basket();

        private xSingleton()
        {
        }

        public static xSingleton Instance
        {
            get { return _instance; }
        }
        public Basket CurrentBasket
        {
            get { return _basket; }
            set { _basket = value; }
        }
    }
}
