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
        List<Traitement> _Listraitements = new List<Traitement>();
        public IEnumerable<Traitement> GetAllTraitements()
        {
            return _Listraitements.AsEnumerable();
        }
        public bool IsExistedTraitement(Traitement tradement)
        {
            return _Listraitements.Any(t => t.Id == tradement.Id);
        }
        public void AddTraitement(Traitement tritement)
        {
            _Listraitements.Add(tritement);
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
            var TraitemntPatients = _Listraitements.FirstOrDefault(t => t.MaladieId == patient.MaladieId);
            var soins = TraitemntPatients!.Soins.ToList();
            decimal result = 0;
            foreach (var s in soins)
            {
                result += s.Cout;
            }
            return result;

        }

        /// <summary>
        /// cette fonction permet de 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int NbJourTraitement(Patient patient)
        {

            var TraitemntPatients = _Listraitements.FirstOrDefault(t => t.MaladieId == patient.MaladieId);
            var soins = TraitemntPatients!.Soins.ToList();
            int result = 0;
            foreach (var s in soins)
            {
                result += s.NbJour;
            }
            return result;

        }
        /// <summary>
        /// elle renvoie vrai s'elle trouve le
        /// vrai traitement du patient correspondant
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool IsTrouveTraitementPatient(Patient patient)
        {
            var result = _Listraitements.All(t => t.MaladieId == patient.MaladieId);

            return result;
        }

        public Traitement GetTraitementByPatient(Patient patient)
        {
            return _Listraitements.Find(t => t.MaladieId == patient.MaladieId);

        }
    }
}
