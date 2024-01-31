using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class TraitementService : ITraitementService
    {
        public IEnumerable<Traitement> GetAllTraitements()
        {
            return Enumerable.Empty<Traitement>();
        }
        public void AddTraitement(Traitement tritement)
        {
            throw new NotImplementedException();
        }

        public decimal CoutTraitement(Patient patient)
        {
            throw new NotImplementedException();
        }


        public int NbJourTraitement(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
