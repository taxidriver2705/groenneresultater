using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    class Order
    {
        #region instance field
        private string _date;
        private int _customerID;
        private ObservableCollection<Product> _orderList;
        private double _totalPrice;
        private string _name;
        #endregion

        public Order(ObservableCollection<Product> basket, string fornavn, string efternavn, int tlfnr, Dictionary<Product, int> productList)
        {
            _orderList = new ObservableCollection<Product>();
            BasketToOrder(basket);
            _date = DateTime.Now.ToString();
            _name = $"{fornavn} {efternavn}";
            _customerID = tlfnr;
            _totalPrice = GetTotalPrice();
        }
        /*public void DeleteProduct(Dictionary<Product, int> productList)
        {
            foreach (var P in _orderList)
            {
                if (productList.
            }
        }*/
        public void BasketToOrder(ObservableCollection<Product> basket)
        {
            foreach (var P in basket)
            {
                _orderList.Add(P);

            }
        }
        //Returnerer ordrelisten
        public ObservableCollection<Product> OrderList
        {
            get { return _orderList; }
        }
        public string Date
        {
            get { return _date; }
        }
        //Override ToString med al relevant info
        public override string ToString()
        {
            return $"Navn: {_name}\nKunde ID: {_customerID}\nTotal pris: Kr.{_totalPrice.ToString("#,##0.00")}\nDato: {_date}";
        }
        //Beregn samlede pris af ordren. Sker automatisk i konstruktøren
        private double GetTotalPrice()
        {
            double price = 0;

            for (int i = 0, j = _orderList.Count; i < j; i++)
                price += _orderList[i].Price;
            return price;
        }
    }
}
