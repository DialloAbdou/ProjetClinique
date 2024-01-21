using AutoFixture;
using Clinique.Data.Abstractions;
using Clinique.Data.Implementations;
using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueTestUnitaire.Implementations
{
    public class MedecinServiceTestUnitaire
    {
        private MedecinService _medecinService;
        private PatientService _patientService;
        private IEnumerable<Medecin> _ListeMedecins = new List<Medecin>();
        private Medecin medecin = new()
        {
            Id = 1,
            Nom = "medecin1",
            Prenom = "medecinPre",
            Adresse = "AdresseMed",
            Age = 25

        };

        private Patient patient = new()
        {
            Id = 1,
            Nom = "Nompatient",
            Prenom = "PrePatient",
            Adresse = "Adresse1",
            Age = 35

        };
        public MedecinServiceTestUnitaire()
        {
            _medecinService = new MedecinService();
            _patientService = new PatientService();
        }

        [Fact]
        public void GetAllMedecin_should_Be_Return_Empty_At_Beginin()
        {
            // Arrange
            // Action
            var result = _medecinService.GetAllMedecin();
            result.Should().BeEmpty();
        }


        [Fact]
        public void GetAllMedecin_should_Be_Return_At_Beginin()
        {
            // Arrange
            // Act 
            _medecinService.AddMedecin(medecin);
            var result = _medecinService.GetAllMedecin();

            result.Should().NotBeNullOrEmpty();
        }

        [Fact]
        public void IsMedecin_should_Be_Return_True_When_Medecin_Existed_In_Collection()
        {
            _medecinService.AddMedecin(medecin);
            var result = _medecinService.isExistMedecin(medecin);
            // Verifer si le medecin existe dans notre base de données 
            result.Should().BeTrue();
        }


        [Fact]
        public void AffectationApatient_should_Be_AAdd__In_Collection_when_Medecin_IsExisted()
        {
            // Arrange
            //-- verifier si le médecin exist
            _medecinService.AddMedecin(medecin);
            _medecinService.isExistMedecin(medecin).Should().BeTrue();
          ///  _patientService.AddMissionPatient(patient, "NomPathologie");
            //// Act
            //_medecinService.Affecter(medecin, patient);
   
            //asser
         
        }

    
    }
}