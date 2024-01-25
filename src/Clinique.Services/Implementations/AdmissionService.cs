using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class AdmissionService : IAdmissionService
    {
        private const int MAX = 10;
        private List<Admission> Listadmissions = new List<Admission>();


        public IEnumerable<Admission> GetAllAdmission()
        {
            return Listadmissions.AsEnumerable();
        }
        public void AjoutAdmission(Patient patient, string nomPathologie)
        {
            if (isAddmissionPossible())
            {
                Listadmissions.Add(
                                    new Admission
                                    {
                                        Patient = new Patient
                                        {
                                            Id = patient.Id,
                                            Nom = patient.Nom,
                                            Prenom = patient.Prenom,
                                            Adresse = patient.Adresse,
                                            Age = patient.Age,
                                            NomPathologie = patient.NomPathologie,
                                        },
                                        DebutAdmission = DateTime.Now

                                    });
            }
        }

        public bool isAddmissionPossible()
        {
            return Listadmissions.Count <= MAX;
        }
    }
}
