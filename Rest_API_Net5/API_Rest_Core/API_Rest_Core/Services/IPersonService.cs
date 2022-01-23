using System.Collections.Generic;
using API_Rest_Core.Model;

namespace API_Rest_Core.Services
{
    public interface IPersonService
    {
        Person Create(Person person);

        Person FindById(long id);

        Person Update(Person person);

        void Delete(long id);

        List<Person> FindAll();
    }
}
