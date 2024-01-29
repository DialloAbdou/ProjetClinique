using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Abstracts
{
   public interface ISoinService
    {
        IEnumerable<Soin> GetAllSoins();
        void AddSoin(Soin soin);
    }
}
