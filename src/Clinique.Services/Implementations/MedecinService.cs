using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class MedecinService : IMedecinService
    {
        List<Medecin> medecinLists = new List<Medecin>();
        public IEnumerable<Medecin> GetAllMedecin()
        {
            return medecinLists.AsEnumerable();
        }

        public void AddMedecin(Medecin medecin)
        {
            if (isNotExistedMedecin(medecin))
            {
                medecinLists.Add(medecin);

            }
        }

        public bool isNotExistedMedecin(Medecin medecin)
        {
            return medecinLists.All(m => m.Id != medecin.Id);
        }

        public void Affecter(Medecin medecin, Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
