using CodingChallenge.Models;
using CodingChallenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Service
{
    internal class IAdoptableService
    {
        private readonly IAdoptableRepository _repository;

        public IAdoptableService()
        {
            _repository = new IAdoptableRepository(); 
        }

        public void Addparticipant(AdoptionEvent participant)
        {
            _repository.RegisterParticipant(participant);
        }

        public void EventHost(string adop_status)
        {
            _repository.GetAvailableParticpants(adop_status);
        }
    }
}
