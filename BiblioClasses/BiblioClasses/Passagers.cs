using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasses
{
    public class Passagers
    {
        // Informations du passager
        private string _nomPassager;
        private DateTime _dateNaissance;
        private bool _passeport;

        // Informations du voyage
        private string _paysDepart;
        private string _paysDestination;

        // Informations du siège
        private string _nomSiege;
        private string _coSiege;

        public Passagers(string nomPassager, DateTime dateNaissance, bool passeport)
        {
            _nomPassager = nomPassager ?? throw new ArgumentNullException(nameof(nomPassager));
            _dateNaissance = dateNaissance;
            _passeport = passeport;
        }
    }
}
