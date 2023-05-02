using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank3
{
    internal class @interface
    {
        // определяет интерфейс с методом
        public interface IConsultantData
        {
            void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber);
        }
        //определение класса для реализации интерфейса
        public class ConsultantData : IConsultantData
        {
            public void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber)
            {
                customer.PhoneNumber = newPhoneNumber;
                customer.ModifiedBy = "Consultant";
            }
        }
        //объявление интерфейса с наследием из другого и имеет два метода
        public interface IManagerData : IConsultantData
        {
            void AddNewCustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber);
            void UpdateCustomerData(CustomerData customer, string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber);
        }
    }
}
