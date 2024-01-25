using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class AffectationService : IAffectationService
    {

        private List<Medecin> ListMedecins = new List<Medecin> { new Medecin { Id = 1, Nom = "NomMedecin", Prenom = "PreMedecin", Adresse = "AdresseMedecin", Age = 25 } };
        private List<Affectation> Affectations = new List<Affectation>();
        public IEnumerable<Affectation> GetAllAffectations()
        {
            return Affectations.AsEnumerable();
        }

        public void AddAffectation(Medecin medecin, Patient patient)
        {
           if(IsMedecinExisted(medecin))
           {
               if(MedecinIsAffected(medecin))
                {
                    Affectation affection = new Affectation
                    {
                        DateAffection = DateTime.Today,
                         Patient = patient,
                         medecin = medecin
                    };
                    Affectations.Add(affection);
                }
           }
        }

        public bool IsMedecinExisted(Medecin medecin)
        => ListMedecins.Any(m => m.Id == medecin.Id);

        public bool MedecinIsAffected(Medecin medecin)
        {
            var medecin1 = ListMedecins.FirstOrDefault(m => m.Id == medecin.Id);
            if (medecin1 != null)
            {
                if (medecin.Patients.Count <= 6)
                {
                    return true;
                }else
                {
                    return false;
                }
            }
            else
            {

                return false;
            }

        }
    }
}
