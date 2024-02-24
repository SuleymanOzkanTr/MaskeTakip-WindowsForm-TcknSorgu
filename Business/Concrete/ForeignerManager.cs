using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantServices
    {
        public void ApplyMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetAllPersons()
        {
            throw new NotImplementedException();
        }
    }
}
