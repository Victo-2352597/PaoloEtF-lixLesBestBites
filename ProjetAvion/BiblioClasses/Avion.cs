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
        private int _nbRange;
        private int _nbSiege;

        public Avion(int nbRange, int nbSiege)
        {
            _nbSiege = nbSiege;
            _nbRange = nbRange;

            CreationAvion(nbRange, nbSiege);
        }

        public void CreationAvion(int nbRange, int nbSiege)
        {
            for (int i = 1; i <= nbRange; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Siege nomSiege = new Siege("Pauvre", $"{i}|{j}");
                }
            }
        }
    }
}
