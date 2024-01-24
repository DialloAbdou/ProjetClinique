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
    public class MedecinServiceTestUnitaires
    {
        private IMedecinService _medecinService;
        private static Medecin medecin = new Medecin
        {
            Id= 1,
            Nom = "NomMedecin",
            Prenom= "PreMedecin",
            Adresse = "AdresseMedecin",
            Age = 36
        };

    public MedecinServiceTestUnitaires()
        {
            _medecinService = new MedecinService();
        }

        [Fact]
        public void IsExistedMedecin_Should_Be_True_When_Found_In_Collection()
        {
            _medecinService.isNotExistedMedecin(medecin).Should().BeTrue();
        }

        public void IsExistedMedecin_Should_Be_False_When_Found_In_Collection()
        {
            _medecinService.isNotExistedMedecin(medecin).Should().BeTrue();
        }
        [Fact]
        public void GetAllMedecin_Should_Be_Empty_At_Beginin()
        {
            // Arrange
            // Act
            var results = _medecinService.GetAllMedecin();
            //Assertion
            results.Should().BeEmpty();
        }

        [Fact]
        public void GetAllMedecin_Should_NotBeEmpty_In_Collection()
        {
            _medecinService.AddMedecin(medecin);
            var results = _medecinService.GetAllMedecin();
           var mymedecin = results.FirstOrDefault();
            mymedecin.Should().NotBeNull();
            mymedecin!.Nom.Should().Be(mymedecin.Nom);
            mymedecin!.Prenom.Should().Be(mymedecin.Prenom);
            mymedecin!.Adresse.Should().Be(mymedecin.Adresse);
            mymedecin!.Age.Should().Be(mymedecin.Age);

        }
    }
}
