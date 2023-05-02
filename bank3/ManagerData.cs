using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static bank3.@interface;

namespace bank3
{
    internal class ManagerData : IManagerData
    {        
        //метод, который принимает объект и новый номер телефона в кач-ве параметра и обновляет его
            public void UpdateCustomerPhoneNumber(CustomerData customer, string newPhoneNumber)
            {
                customer.PhoneNumber = newPhoneNumber;
                customer.ModifiedBy = "Manager";
            }
        //метод, который принимает данные в параемтры и создает новый объект с этими данными
            public void AddNewCustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
            {
                var newCustomer = new CustomerData(surname, firstName, patronymic, phoneNumber, passportSeriesNumber);
                newCustomer.ModifiedBy = "Manager";
            }
        // метод, который принимает объект и новые в качестве параметров, и обновляет соответствующие поля в этом объекте и устанавливает свойства
        public void UpdateCustomerData(CustomerData customer, string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
            {
                customer.Surname = surname;
                customer.FirstName = firstName;
                customer.Patronymic = patronymic;
                customer.PhoneNumber = phoneNumber;
                customer.PassportSeriesNumber = passportSeriesNumber;
                customer.ModifiedBy = "Manager";
            }
    }
}

