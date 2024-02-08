using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;


    }

    public void GiveMask(Person person)
    {
        if (_applicantService.IsCheckPerson(person))
        {
            Console.WriteLine("Maske verildi: " + person.FirstName);
        }
        else
        {
            Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
        }
    }
}

