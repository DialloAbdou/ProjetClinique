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
    public class TraitementServiceTestUnitaires
    {
        private ITraitementService _TraitementService;

        private Patient patient = new Patient
        {
            Id = 1,
            Nom = "Patient1",
            Adresse = "Adresse Patient1",
            Age = 35,
            Maladie = new Maladie { Id = 1, NomPahtologi = "Scarlatine" },
            MaladieId = 1

        };

        private Traitement traitement = new Traitement
        {
            Id = 1,
            Soins = new List<Soin> { new Soin { Id = 1, Tysoin = "soin1", Cout = 50, NbJour = 1 }, new Soin { Id = 2, Tysoin = "Soin2", Cout = 100, NbJour = 2 } },
            MaladieId = 1

        };
        public TraitementServiceTestUnitaires()
        {
            _TraitementService = new TraitementService();

        }

        [Fact]
        public void GetAllTraitement_Should_Be_Empty_At_Beginin()
        {
            var results = _TraitementService.GetAllTraitements();
            results.Should().BeEmpty();
        }

        [Fact]
        public void IsTraiementExists_Should_Be_Return_true_When_found_traitement_In_COllection()
        {
            _TraitementService.AddTraitement(traitement);
            _TraitementService.IsExistedTraitement(traitement).Should().BeTrue();
        }
        [Fact]
        public void GetAllTraitement_Shoul_Be_Return_In_Collection_When_Collection_Not_Be_Empty()
        {
            _TraitementService.AddTraitement(traitement);
            var results = _TraitementService.GetAllTraitements();
            results.Should().NotBeEmpty();
        }

        [Fact]
        public void IsTrouveTraitementPatient_Shoul_Be_ReturnTrue__When_Found_Traiement_In_Collection()
        {
            _TraitementService.IsTrouveTraitementPatient(patient).Should().BeTrue();
        }

        [Fact]
        public void CoutTraitement_Shoul_Be_Return_Totat_Cost_Traitement_By_Patient()
        {
            _TraitementService.IsTrouveTraitementPatient(patient).Should().BeTrue();
            var result = _TraitementService.CoutTraitement(patient);
            result.Should().Be(150);
        }

        [Fact]
        public void GetTraitementByPatient_Shoul_Be_Return_Traitement_When_Found_In_Collection()
        {
            _TraitementService.AddTraitement(traitement);
            var result = _TraitementService.GetTraitementByPatient(patient);
            result.Should().NotBeNull();
            result.Id.Should().Be(traitement.Id);
            result.Soins.Should().NotBeNull();
        }



    }
}
