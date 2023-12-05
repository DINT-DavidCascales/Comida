using Comida.Properties;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaPlatos;
        public ObservableCollection<Plato> ListaPlatos
        {
            get { return listaPlatos; }

            set
            {
                listaPlatos = value;
                NotifyPropertyChanged("ListaPlatos");
            }
        }

        private ObservableCollection<string> tipoComida;
        public ObservableCollection<string> TipoComida
        {
            get { return tipoComida; }
            set
            {
                tipoComida = value;
                NotifyPropertyChanged("TipoComida");
            }
        }

        private Plato platoSeleccionado;
        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public void QuitarPlato()
        {
            PlatoSeleccionado = null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowVM()
        {
            ListaPlatos = Plato.GetSamples(@"\Resources");

            TipoComida = new ObservableCollection<string>();
            TipoComida.Add("Americana");
            TipoComida.Add("Mexicana");
            TipoComida.Add("China");



        }

        public void NotifyPropertyChanged(string propertyName)
        {

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}