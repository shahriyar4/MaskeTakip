using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {



        public void ApplyForMask()
        {
            throw new NotImplementedException();
        }

        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool IsCheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);


            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                new TCKimlikNoDogrulaRequestBody(
                person.NationalIdentity,
                person.FirstName,
                person.LastName,
                person.DateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }

}
