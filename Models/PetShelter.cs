﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    internal class PetShelter
    {
        public List<Pets> availablePets;

        public PetShelter()
        {
            availablePets = new List<Pets>();
        }
    }
}
