using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grøn
{
    class Product
    {
        #region instance field
        public enum Stand { A, B, C, D, E };

        private int _productID;
        private string _brand;
        private string _model;
        private double _price;
        private string _stand;
        #endregion

        public Product(string brand, string model, int id, double price, Stand stand)
        {
            _brand = brand;
            _model = model;
            _productID = id;
            _price = price;
            _stand = stand.ToString();
        }

        public string Model
        {
            get { return _model; }
        }
        public string Brand
        {
            get { return _brand; }
        }
        public int ID
        {
            get { return _productID; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        //returnerer stand som enum-type
        public string GetStand
        {
            get { return _stand; }
        }
        //Override ToString med al relevant info
        public override string ToString()
        {
            return $"{_brand} {_model} Pris: {_price.ToString("#,##0.00")} \nSerienummer: {_productID} Stand: {_stand}";
        }
        //returnerer stand som beskrivelse
        //valgfri stand-beskrivelse - ikke med i planen
        public string StandBeskrivelse()
        {
            string beskrivelse = null;
            char stand = Char.Parse(_stand);

            switch (stand)
            {
                case 'A': beskrivelse = "Beskrivelse af A"; break;
                case 'B': beskrivelse = "Beskrivelse af B"; break;
                case 'C': beskrivelse = "Beskrivelse af C"; break;
                case 'D': beskrivelse = "Beskrivelse af D"; break;
                case 'E': beskrivelse = "Beskrivelse af E"; break;
            }
            return beskrivelse;
        }
    }
}
