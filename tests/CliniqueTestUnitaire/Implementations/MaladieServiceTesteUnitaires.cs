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
    public class MaladieServiceTesteUnitaires
    {
        private IMaladieService _maladieService;
        private static Maladie maladie = new Maladie
        {
            Id = 1,
            NomPahtologi = "Scarlatine"  
        };
        private static Maladie maladie1 = new Maladie
        {
            Id = 2,
            NomPahtologi = "Varicelle"
        };
        public MaladieServiceTesteUnitaires()
        {
            _maladieService = new MaladieService();
        }
        [Fact]
        public void GellAllMaladie_Should_Be_Return_Empty_At_Begining()
        {
            var results = _maladieService.GetAllMaladie();
            results.Should().BeEmpty();
        }

        [Fact]
        public void IsExistedMaladie_Should_Be_Return_True_When_Found_In_Collection()
        {
        
            _maladieService.IsNotExistedMaladie(maladie).Should().BeTrue();
        }
        [Fact]
        public void GellAllMaladie_Should_Be_Return_Not_Be_Empty_In_Collection()
        {
            //Arrange
            _maladieService.AddMaladie(maladie);
            var results = _maladieService.GetAllMaladie();
            results.Should().NotBeEmpty();
            var resmaladie = results.First();
            resmaladie.Id.Should().Be(maladie.Id);
            resmaladie.NomPahtologi.Should().Be(maladie.NomPahtologi);
        }
    }
}
