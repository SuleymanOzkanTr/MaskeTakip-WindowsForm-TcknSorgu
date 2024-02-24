using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IApplicantServices
    {
        void ApplyMask(Person person);
        bool CheckPerson(Person person);
        List<Person> GetAllPersons();
    }
}
