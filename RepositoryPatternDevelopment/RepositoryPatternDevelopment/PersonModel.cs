using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPatternDevelopment
{
    public interface ICompanyLogic
    {
        PersonModel GetPersonByName(string name);
    }

    public class IPersonDataContext { }


    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }

    public class CompanyLogic: ICompanyLogic
    {
        private IPersonDataContext _personDataContext;
        public PersonService(IPersonDataContext personDataContext,
                ICompanyDataCOnte)
        {
            _personDataContext = personDataContext;
        }

        public PersonModel GetPersonByName(string name)
        {
            using (var ctx = _personDataContext.NewContext())
            {
                var person = ctx.People.First(p => p.Name.Equals(Name));
                return person;
            }
        }

        public 

        public class CompanyModel
        {
            public string Name { get; set; }
            public int Size { get; set; }
            public bool Public { get; set; }
        }
    }
}
