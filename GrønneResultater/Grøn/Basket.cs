using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    class Basket
    {
        private ObservableCollection<Product> _basketList;
        private double _totalPrice;

        public Basket()
        {
            _basketList = new ObservableCollection<Product>();
        }

        //Skal opdatere pris og view når product lægges i.
        public void AddProduct(Product P)
        {
            _basketList.Add(P);
        }

        public ObservableCollection<Product> BasketList
        {
            get { return _basketList; }
        }
        //Beregn samlet pris i kurv. Skal opdateres når flere varer lægges i
        public double GetTotalPrice()
        {
            double price = 0;
            for (int i = 0, j = _basketList.Count; i < j; i++)
                price += _basketList[i].Price;
            return price;
        }
    }
}
