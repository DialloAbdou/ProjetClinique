using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class TraitementService : ITraitementService
    {
        List<Traitement> _Listtraitements = new List<Traitement>();
        public IEnumerable<Traitement> GetAllTraitements()
        {
             return _Listtraitements.AsEnumerable();
        }
        public bool IsExistedTraitement(Traitement tradement)
        {
           return _Listtraitements.Any(t=>t.Id == tradement.Id);
        }
        public void AddTraitement(Traitement tritement)
        {
            _Listtraitements.Add(tritement);
        }

        /// <summary>
        ///  cette fonction permet de 
        ///  Calculer le cout de traitement d'un patient
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public decimal CoutTraitement(Patient patient)
        {
            decimal coutTraitement = 0;
            if(IsTrouveTraitementPatient(patient))
            {
                //
            }
            return  150;
           
        }


        public int NbJourTraitement(Patient patient)
        {
            throw new NotImplementedException();
        }

        public bool IsTrouveTraitementPatient(Patient patient)
        {
            return   _Listtraitements.All(t => t.Maladie.Id == patient.MaladieId);
        }

        public Traitement GetTraitementByPatient(Patient patient)
        {
            return _Listtraitements.Find(t => t.MaladieId == patient.MaladieId);
            
        }
    }
}
