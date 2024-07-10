using ExamenP3_JDS.Models;
using ExamenP3_JDS.Servicios;
using Java.Lang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP3_JDS.ViewModels
{
    public class PersonajeViewModelJDS : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private readonly PersonajeServiceJDS _service;
        private  List<PersonajesJDS> _jds;


        public List<PersonajesJDS> PersonajesJDS
        {
            get => _jds;
            set
            {
                _jds = value;
                OnPropertyChanged(nameof(PersonajesJDS));
            }
        }

        public PersonajeViewModelJDS()
        {
            _service = new PersonajeServiceJDS();
            LoadCharacters();
        }

        private async void LoadCharacters()
        {
            PersonajesJDS = await _service.ObtenerPersonaje();
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
