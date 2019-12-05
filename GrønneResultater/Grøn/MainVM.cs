using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    class MainVM
    {
        private NavigationService navigationService;
        private xSingleton x;
        private Product selectedProduct = null;
        private Product newProduct = null;
        private Dictionary<Order, int> completedOrders = new Dictionary<Order, int>();
        private Dictionary<Product, int> productList = new Dictionary<Product, int>();

        public MainVM()
        {
            x = xSingleton.Instance;
            navigationService = new NavigationService();
        }
        public xSingleton X
        {
            get { return x; }
        }
    }
}
