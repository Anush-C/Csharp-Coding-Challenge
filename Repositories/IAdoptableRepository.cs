using CodingChallenge.Models;
using CodingChallenge.Utility;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Repositories
{
    internal class IAdoptableRepository
    {
        SqlConnection connect = null;
        SqlCommand cmd = null;


        public IAdoptableRepository()
        {
            connect = new SqlConnection(DBConnectUtil.GetConnectionString());
            cmd = new SqlCommand();
        }
 

        public List<AdoptionEvent> GetAvailableParticpants(String adoption_status)
        {
            List<AdoptionEvent> availableParticipants = new List<AdoptionEvent>();
            cmd.CommandText = "Select * from AdoptionEvent where adoption_status = @status";
            cmd.Parameters.AddWithValue("@status", adoption_status);
            connect.Open();
            cmd.Connection = connect;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                AdoptionEvent participant = new AdoptionEvent();
                participant.ParticipantID = (int)sqlDataReader["participant_id"];
                participant.ParticipantName = (string)sqlDataReader["participant_name"];
                participant.ParticipantType = (string)sqlDataReader["participant_type"];
                participant.ContactEmail = (string)sqlDataReader["contact_email"];
                participant.ContactPhone = (string)sqlDataReader["contact_phone"];
                participant.ParticipantAddress = (string)sqlDataReader["participant_address"];
                participant.AdoptedPetID = sqlDataReader["adopted_pet_id"] == DBNull.Value ? (int?)null : (int)sqlDataReader["adopted_pet_id"];
                participant.AdoptionStatus = (string)sqlDataReader["adoption_status"];
                participant.RegistrationDate = (DateTime)sqlDataReader["registration_date"];
                participant.Notes = (string)sqlDataReader["notes"];
                availableParticipants.Add(participant);

            }
            connect.Close();
            return availableParticipants;
        }

        public void RegisterParticipant(AdoptionEvent participant)
        {
            cmd.CommandText = "Insert into AdoptionEvent values(@participant_id, @participant_name, @participant_type, @contact_email, @contact_phone, @participant_address, @adopted_pet_id, @adoption_status, @registration_date, @notes)";
            cmd.Parameters.AddWithValue("@participant_id", participant.ParticipantID);
            cmd.Parameters.AddWithValue("@participant_name", participant.ParticipantName);
            cmd.Parameters.AddWithValue("@participant_type", participant.ParticipantType);
            cmd.Parameters.AddWithValue("@contact_email", participant.ContactEmail);
            cmd.Parameters.AddWithValue("@contact_phone", participant.ContactPhone);
            cmd.Parameters.AddWithValue("@participant_address", participant.ParticipantAddress);
            cmd.Parameters.AddWithValue("@adopted_pet_id", participant.AdoptedPetID);
            cmd.Parameters.AddWithValue("@adoption_status", participant.AdoptionStatus);
            cmd.Parameters.AddWithValue("@registration_date", participant.RegistrationDate);
            cmd.Parameters.AddWithValue("@notes", participant.Notes);

            connect.Open();
            cmd.Connection = connect;
            cmd.ExecuteNonQuery();
            connect.Close();
        }
    }
}
