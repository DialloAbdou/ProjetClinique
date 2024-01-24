using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueTestUnitaire.Implementations
{
    public class AffectationServiceTestUnitaire
    {
        private IAffectationService _affectaionService;
        private Medecin medecin = new Medecin()
        {
             Id = 1,
             Nom = "NomMedecin",
             Prenom = "PreMedecin",
             Adresse = "AdresseMedecin",
             Age= 15

        };

        private Patient patient = new Patient()
        {
            Id = 1,
            Nom = "NomPatient",
            Prenom = "PrePatient",
            Adresse = "AdressePatient",
            Age = 25

        };
        public AffectationServiceTestUnitaire()
        {
            _affectaionService = new AffectationService();
        }

        [Fact]
        public void GetAllAffection_Should_Be_Return_Empty_At_Beginin()
        {
            var results = _affectaionService.GetAllAffectations();
            results.Should().BeEmpty();
        }

        [Fact]
        public void IsMedecinExisted_Should_Be_Return_True_When_Medecin_found_In_Collection()
        {
            _affectaionService.IsMedecinExisted(medecin).Should().BeTrue();
        }

        [Fact]
        public void GetAllAffection_Should_Be_Return_Current_Collection()
        {
            //Arrange
            _affectaionService.AddAffectation(medecin, patient);
            var results = _affectaionService.GetAllAffectations();
            results.Should().NotBeEmpty();
            var affectation = results.First();
            affectation.Should().NotBeNull();
       
        }
    }
}
