using Business.Abstract;
using Entities.Concrete;
using System.Windows.Forms;

namespace Business.Concrete
{
    public class PttManager : ISupplierServices
    {
        private IApplicantServices _applicantServices;

        public PttManager(IApplicantServices applicantServices)
        {
            _applicantServices = applicantServices;
        }

        public void GiveMask(Person person)
        {
            if (_applicantServices.CheckPerson(person))
            {
                MessageBox.Show("TCKN Dogrulama Basarili", "BİLGİ", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("TCKN Dogrulama BASARISIZ", "BİLGİ", MessageBoxButtons.OK);
            }
        }
    }
}