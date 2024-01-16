using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class MedecinService:IMedecinService
    {
        private  List<Medecin> medecinList = new List<Medecin>();
        public void AddMedecin(Medecin medecin)
        {
            medecinList.Add(medecin);
        }

        public void Affecter(Medecin medecin, Patient patient)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Medecin> GetAllMedecin()
        {
           return  medecinList.AsEnumerable();
        }

        public bool isExistMedecin(Medecin medecin)
        {
            return!medecinList.Any(m=>m.Id == medecin.Id);
        }
    }
}
