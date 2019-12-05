using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Grøn
{
    class RelayCommand : ICommand
    {
        private Predicate<object> _predicate;
        private Action _metode;

        public event EventHandler CanExecuteChanged;

        public RelayCommand(Action metode, Predicate<object> pred)
        {
            _metode = metode; //trigger             opret et produkt
            _predicate = pred; //can trigger?       er felterne udfyldt?
        }

        public bool CanExecute(object parameter)
        {
            return _predicate(parameter);
        }

        public void Execute(object parameter)
        {
            _metode();
        }
    }
}
