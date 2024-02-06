using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager:ISupplierService
{
    private IAplicantService _aplicantService;

    public PttManager(IAplicantService aplicantService)
    {
        _aplicantService = aplicantService;
    }


    public void GiveMask(Person person)
    {
        if (_aplicantService.CheckPerspn(person))
        {
            Console.WriteLine(person.FirstName+"için maske verildi");
        }
    }
}