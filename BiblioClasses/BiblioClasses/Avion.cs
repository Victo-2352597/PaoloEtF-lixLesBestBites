using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioClasses
{
    public class Avion
    {
        // Attributs Passagers
        private string _pilote;
        private Passagers _copilote;
        private Passagers[] _agentsBords;

        // 
        private int _nbSiege;

        public Avion(int nbSiege)
        {
            _nbSiege = nbSiege;
        }

        public void AjouterPassager(string nomPassager, DateTime dateNaissance, bool passeport)
        {
            Passagers nouveauPassager = new Passagers(nomPassager, dateNaissance, passeport);
        }
    }
}
