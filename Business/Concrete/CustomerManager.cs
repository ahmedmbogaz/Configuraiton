using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            Random rastgele = new Random();
            string harfler = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZabcçdefgğhıijklmnoöprsştuüvyz";
            string uret = "";
            for (int i = 0; i < 5; i++)
            {
                uret += harfler[rastgele.Next(harfler.Length)];
            }
            customer.Name = uret;




            string[] isimler = { "Ankara", "İstanbul", "İzmir", "Bursa", "Edirne", "Konya", "Antalya", "Diyarbakır", "Van", "Rize" };
            Random rastgelesayi = new Random();

            int no = rastgelesayi.Next(0, isimler.Length);

            customer.City = isimler[no];




            _customerDal.Add(customer);

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
        }

        public int Plus(int a, int b)
        {
            int topla = (a + b);

            return topla;
        }

        //public int TestVerisiOlustur(int musteriAdet, int sepetAdet)
        //{

        //}
    }
}
