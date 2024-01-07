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
        private IMedecinService _medecinService;
        private Mock<IMedecinRepository> _medecinRepositoryMock = new Mock<IMedecinRepository>();
        Fixture _fixture = new Fixture();
        public MedecinServiceTestUnitaire()
        {
            _medecinService = new MedecinService(_medecinRepositoryMock.Object);
        }

        [Fact]
        public async Task AddMedecinAsync_Syhould_Be_Return_new_Medecin_In_Db()
        {
            //Arrange

            Medecin med = null;
            _medecinRepositoryMock.Setup(m => m.AddAsync(It.IsAny<Medecin>()))
                .Callback((Medecin medecin) => med = medecin);
            var randomMedecin = _fixture.Create<Medecin>();
            //Action
            var result = await _medecinService.AddMedecinAsync(randomMedecin);
            result.Should().NotBeNull();
            result.Nom.Should().Be(randomMedecin.Nom);
            result.Prenom.Should().Be(randomMedecin.Prenom);
            result.Adresse.Should().Be(randomMedecin.Adresse);
            result.Age.Should().Be(randomMedecin.Age);

        }

    }
}
