using Clinique.Services.Abstracts;
using Clinique.Services.Implementations;
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
    }
}
