using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fe = FluentApi.Entities;
namespace BusinessLogic
{
    public interface ILogic
    {
        public fe.Appointment AddAppointment(Models.Appointment ap);
        IEnumerable<Models.Appointment> GetAppointment();

        IEnumerable<Models.Appointment> GetMedicalHistory(int patientid);
        IEnumerable<Models.Appointment> GetAppointmentByAcceptance(int acceptVal);

        public fe.Appointment UpdateAppointment(int PatientId, Models.Appointment ap);

        IEnumerable<Models.Appointment> GetAppointmentsbyEmailandAcceptance(int i, string email);


    }
}
