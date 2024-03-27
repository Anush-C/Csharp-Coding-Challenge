using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Models
{
    internal class AdoptionEvent
    {
        public int ParticipantID { get; set; }
        public string ParticipantName { get; set; }
        public string ParticipantType { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string ParticipantAddress { get; set; }
        public int? AdoptedPetID { get; set; }
        public string AdoptionStatus { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Notes { get; set; }

        public AdoptionEvent() { }  

        // Constructor
        public AdoptionEvent(int participantID, string participantName, string participantType, string contactEmail, string contactPhone, string participantAddress, int? adoptedPetID, string adoptionStatus, DateTime registrationDate, string notes)
        {
            ParticipantID = participantID;
            ParticipantName = participantName;
            ParticipantType = participantType;
            ContactEmail = contactEmail;
            ContactPhone = contactPhone;
            ParticipantAddress = participantAddress;
            AdoptedPetID = adoptedPetID;
            AdoptionStatus = adoptionStatus;
            RegistrationDate = registrationDate;
            Notes = notes;
        }
    }
}
