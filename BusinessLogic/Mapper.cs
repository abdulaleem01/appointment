using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fe = FluentApi.Entities;
namespace BusinessLogic
{
    public class Mapper
    {
        public static Models.Appointment Map(fe.Appointment ap)
        {
            return new Models.Appointment()
            {
                Id = ap.Id,
                Reason = ap.Reason,
                Date = ap.Date,
                Acceptance = ap.Acceptance,
                PatientId = ap.PatientId,
                PhysicianEmail = ap.PhysicianEmail,
                SubmissionDate = ap.SubmissionDate
            };
        }

        public static fe.Appointment Map(Models.Appointment ap)
        {
            return new fe.Appointment()
            {
                     Id = ap.Id,
                     Reason= ap.Reason,
                     Date= ap.Date,
                     Acceptance = ap.Acceptance,
                     PatientId= ap.PatientId,
                     PhysicianEmail  = ap.PhysicianEmail,
                     SubmissionDate   =ap.SubmissionDate
            };
        }
        public static IEnumerable<Models.Appointment> Map(IEnumerable<fe.Appointment> ap)
        {
            return ap.Select(Map);
        }
    }
}
