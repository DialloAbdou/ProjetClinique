using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Abstracts
{
    public interface IAdmissionService
    {
        IEnumerable<Admission> GetAllAdmission();
        void AjoutAdmission(Patient patient, string nomPathologie);
        bool isAddmissionPossible();
    }
}
