using Business.Abstract;
using Business.KPSPublic;
using Entities.Concrete;

namespace Business.Concrete;

public class PersonManager:IAplicantService
{
    public void ApplyForMask(Person person)
    {
        
    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerspn(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(123123,"Yasin Eren","Kovalık",1999))).Result.Body.TCKimlikNoDogrulaResult;
    }
}