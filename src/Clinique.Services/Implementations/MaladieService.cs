using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class MaladieService : IMaladieService
    {
        private List<Maladie> ListeMaladies = new List<Maladie>();
        public IEnumerable<Maladie> GetAllMaladie()
        {
             return ListeMaladies.AsEnumerable();
        }
        public void AddMaladie(Maladie maladie)
        {
            if (!IsNotExistedMaladie(maladie)) return;
            ListeMaladies.Add(maladie);
        }

        public bool IsNotExistedMaladie(Maladie maladie)
        {
            return ListeMaladies.All(m=>m.Id!= maladie.Id);   
        }
    }
}
