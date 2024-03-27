using CodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Repositories
{
    public abstract class DonationRepository
    {
        protected List<CashDonation> donations;

        public DonationRepository()
        {
            donations = new List<CashDonation>();
        }

        public abstract void RecordDonation(CashDonation donation);
    }
}
