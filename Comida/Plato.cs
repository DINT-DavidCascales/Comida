using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class Plato : INotifyPropertyChanged
    {
        public string nombre;
        public string Nombre
        {

            get { return this.nombre; }

            set
            {
                if (this.nombre != value)
                {
                    this.nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }
        public string imagen;
        public string Imagen
        {

            get { return this.imagen; }

            set
            {
                if (this.imagen != value)
                {
                    this.imagen = value;
                    this.NotifyPropertyChanged("Imagen");
                }
            }
        }
        public string tipo;
        public string Tipo
        {

            get { return this.tipo; }

            set
            {
                if (this.tipo != value)
                {
                    this.tipo = value;
                    this.NotifyPropertyChanged("Tipo");
                }
            }
        }
        public bool gluten;
        public bool Gluten {

            get { return this.gluten; }

            set
            {
                if (this.gluten != value)
                {
                    this.gluten = value;
                    this.NotifyPropertyChanged("Gluten");
                }
            }
        
        }
        public bool soja;
        public bool Soja {

            get { return this.soja; }

            set
            {
                if (this.soja != value)
                {
                    this.soja = value;
                    this.NotifyPropertyChanged("Soja");
                }
            }
        }
        public bool leche;
        public bool Leche {

            get { return this.leche; }

            set
            {
                if (this.leche != value)
                {
                    this.leche = value;
                    this.NotifyPropertyChanged("Leche");
                }
            }
        }
        public bool sulfitos;
        public bool Sulfitos {

            get { return this.sulfitos; }

            set
            {
                if (this.sulfitos != value)
                {
                    this.sulfitos = value;
                    this.NotifyPropertyChanged("Sulfitos");
                }
            }
        }

        public Plato(string nombre, string imagen, string tipo, bool gluten, bool soja, bool leche, bool sulfitos)
        {
            Nombre = nombre;
            Imagen = imagen;
            Tipo = tipo;
            Gluten = gluten;
            Soja = soja;
            Leche = leche;
            Sulfitos = sulfitos;
        }

        public Plato()
        {
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {

            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static ObservableCollection<Plato> GetSamples(string rutaImagenes)
        {
            ObservableCollection<Plato> lista = new ObservableCollection<Plato>();

            lista.Add(new Plato("Hamburguesa", Path.Combine(rutaImagenes, @"burguer.jpg"), "Americana", true, false, true, true));
            lista.Add(new Plato("Dumplings", Path.Combine(rutaImagenes, @"dumplings.jpg"), "China", true, true, false, false));
            lista.Add(new Plato("Tacos", Path.Combine(rutaImagenes, @"tacos.jpg"), "Mexicana", true, false, false, true));
            lista.Add(new Plato("Cerdo agridulce", Path.Combine(rutaImagenes, @"cerdoagridulce.jpg"), "China", true, true, false, true));
            lista.Add(new Plato("Hot dogs", Path.Combine(rutaImagenes, @"hotdog.jpg"), "Americana", true, true, true, true));
            lista.Add(new Plato("Fajitas", Path.Combine(rutaImagenes, @"fajitas.jpg"), "Mexicana", true, false, false, true));

            return lista;
        }
    }
}
