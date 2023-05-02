using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank3
{
    internal class CustomerData
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        private string _phoneNumber;
        public string PhoneNumber
        {
            //метод get возвращает значение поля _phoneNumber, которое хранит номер телефона объекта класса
            get { return _phoneNumber; }
            //метод set принимает значение типа string, которое передается в свойство, и проверяет, является ли значение пустым или null
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _phoneNumber = value;
                    RecordChanges("PhoneNumber", value);
                }
            }
        }
        private string _passportSeriesNumber;
        public string PassportSeriesNumber
        {
            //метод get возвращает строку, представляющую серию и номер паспорта, скрывая серийный номер символами
            //если поле _passportSeriesNumber не является пустым или null или если оно пустое, то вернет пустую строку.
            get
            {
                if (!string.IsNullOrEmpty(_passportSeriesNumber))
                {
                    return "******************";
                }
                else
                {
                    return _passportSeriesNumber;
                }
            }
            //если значение не пустое, оно присваивается в поле _passportSeriesNumber
            //вызывается метод RecordChanges, который смотрит изменения свойств объекта
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _passportSeriesNumber = value;
                    RecordChanges("PassportSeriesNumber", value);
                }
            }
        }
        //определение 4 свойств для объекта класса
        public DateTime? LastModificationDate { get; set; }
        public string ModifiedData { get; set; }
        public string ModificationType { get; set; }
        public string ModifiedBy { get; set; }
        //конструктор, который принимает параметры и использует свойства класса
        public CustomerData(string surname, string firstName, string patronymic, string phoneNumber, string passportSeriesNumber)
        {
            Surname = surname;
            FirstName = firstName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            PassportSeriesNumber = passportSeriesNumber;
        }
        //позволяет обновлять значения св-тв при каждом изменении данных
        private void RecordChanges(string fieldName, string value, string modificationType = "Update")
        {
            LastModificationDate = DateTime.Now; //св-во устанавливается равным текущей дате и времени
            ModifiedData = fieldName + ":" + value; //св-во устанавливается в строку, содержащую имя поля и его новое значение, и их разделяет двоеточие
            ModificationType = modificationType; //устанавливается в переданный тип модификации
        }
    }
}

