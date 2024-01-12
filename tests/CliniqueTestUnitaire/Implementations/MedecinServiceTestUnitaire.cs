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

        private IEnumerable<Medecin> _ListeMedecins = new List<Medecin>();
        public MedecinServiceTestUnitaire()
        {
            _medecinService = new MedecinService();
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
            Medecin medecin = new Medecin()
            {
                Id =1,
                Nom = "medecin1",
                Prenom = "medecinPre",
                Adresse = "AdresseMed",
                Age = 25
            };
            // Act 
            _medecinService.AddMedecin(medecin);

            var result = _medecinService.GetAllMedecin();

            result.Should().NotBeNullOrEmpty();
        }
    }
}
