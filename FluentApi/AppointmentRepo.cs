using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    public class AppointmentRepo : IRepo<Entities.Appointment>
    {

        Entities.AppointmentDbContext context;
        public AppointmentRepo(Entities.AppointmentDbContext context)
        {
            this.context = context;
        }
        public Entities.Appointment Add(Entities.Appointment ap)
        {
            context.Add(ap);
            context.SaveChanges();
            return ap;
        }
        public List<Entities.Appointment> GetAll()
        {
            return context.Appointments.ToList();
        }
        public List<Entities.Appointment> GetByAcceptance(int val)
        {
            return context.Appointments.Where(x => x.Acceptance == val).ToList();
        }

        public List<Entities.Appointment> GetByPatientId(int val)
        {
            return context.Appointments.Where(x=>x.PatientId==val).ToList();
        }
        public Entities.Appointment Update(Entities.Appointment ap)
        {
            context.Appointments.Update(ap);
            context.SaveChanges();
            return ap;
        }

        public List<Entities.Appointment> GetByDoctorMailAcceptance(int i, string email)
        {
            return context.Appointments.Where(x => x.Acceptance == i && x.PhysicianEmail == email).ToList();
        }

    }
}
