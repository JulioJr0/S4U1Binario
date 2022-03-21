using System;
using System.Windows.Input;

namespace S4U1Binario
{
    internal class RelayCommand<T> : ICommand
    {
        private Action<bool> sumarRestar;

        public RelayCommand(Action<bool> sumarRestar)
        {
            this.sumarRestar = sumarRestar;
        }
    }
}