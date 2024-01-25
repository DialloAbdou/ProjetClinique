using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Abstracts
{
    public interface IAffectationService
    {
        IEnumerable<Affectation> GetAllAffectations();
        void AddAffectation(Medecin medecin, Patient patient);
        bool IsMedecinExisted(Medecin medecin);
        bool MedecinIsAffected(Medecin medecin); 


    }
}
