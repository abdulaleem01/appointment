using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApi
{
    public interface IRepo<T>
    {
        T Add(T t);
        List<T> GetAll();
        List<T> GetByAcceptance(int t);

        List<T> GetByPatientId(int t);
        T Update(T t);
        List<T> GetByDoctorMailAcceptance(int i, string email);
    }
}
