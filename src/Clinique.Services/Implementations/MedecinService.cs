using Clinique.Data.Abstractions;
using Clinique.Services.Abstracts;
using CLinique.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinique.Services.Implementations
{
    public class MedecinService : IMedecinService
    {
        IMedecinRepository _medecinRepository;
        public MedecinService(IMedecinRepository medecinRepository)
        {
            _medecinRepository = medecinRepository;
        }
        public async Task<Medecin> AddMedecinAsync(Medecin medecin)
        {
            await _medecinRepository.AddAsync(medecin);
            return medecin;
        }
    }
}
