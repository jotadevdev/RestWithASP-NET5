using System.Collections.Generic;
using API_Rest_Core.Model;

namespace API_Rest_Core.Services.Implementations
{
    public interface IPersonServices
    {
        Person Create(Person person);

        Person FindById(long id);

        Person Update(Person person);

        void Delete(long id);

        List<Person> FindAll();
    }
}
