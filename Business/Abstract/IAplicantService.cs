using Entities.Concrete;

namespace Business.Abstract;

public interface IAplicantService
{
    void ApplyForMask(Person person);


    List<Person> GetList();


    bool CheckPerspn(Person person);


}