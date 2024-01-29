using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
using CLinique.Models.Models;
using FluentAssertions;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CliniqueTestUnitaire.Implementations
{
    public class SoinServicesTestUnitaires
    {
        private ISoinService _SoinService;
        private Soin soin = new Soin
        {
            Id = 1,
            Tysoin = "Soin1",
            Cout = 50,
            NbJour  =1

        };
        public SoinServicesTestUnitaires()
        {
            _SoinService = new SoinService();
        }

        [Fact]
        public void GetAllSoins_Should_be_Empty_At_Beginin()
        {
            //Arrange
            //Action
            var results = _SoinService.GetAllSoins();
            results.Should().BeEmpty();
        }

        [Fact]
        public void GetAllSoins_Should_be_Collection_Not_be_Empty()
        {
            _SoinService.AddSoin(soin);
            var results = _SoinService.GetAllSoins();
            results.Should().NotBeEmpty();
            var resulSoin = results.First();
            resulSoin.Id.Should().Be(resulSoin.Id);
            resulSoin.Tysoin.Should().Be(resulSoin.Tysoin);
            resulSoin.Cout.Should().Be(resulSoin.Cout);
            resulSoin.NbJour.Should().Be(resulSoin.NbJour);

        }
    }
}
