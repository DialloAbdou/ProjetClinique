using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Abstracts
{
    public interface ITraitementService
    {
        IEnumerable<Traitement> GetAllTraitements();
        bool  IsExistedTraitement(Traitement tradement);
        bool IsTrouveTraitementPatient(Patient patient);
        void AddTraitement(Traitement tritement);
        int NbJourTraitement(Patient patient);
        decimal CoutTraitement( Patient patient);
        Traitement GetTraitementByPatient(Patient patient);
    }
}
