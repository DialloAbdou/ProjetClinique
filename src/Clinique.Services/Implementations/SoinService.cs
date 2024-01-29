using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class SoinService : ISoinService
    {
        List<Soin> listSoin = new List<Soin>();
        public IEnumerable<Soin> GetAllSoins()
        {
             return listSoin.AsEnumerable();
        }
        public void AddSoin(Soin soin)
        {
            listSoin.Add(soin);
        }

      
    }
}
