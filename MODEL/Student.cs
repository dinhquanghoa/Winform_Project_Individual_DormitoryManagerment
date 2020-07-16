using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Student
    {
        public string idStudent, idRoom, nameStudent, dateOfBirthStudent, addressStudent, phoneNumberStudent;
        public Student() { }
        public Student(string idStudent, string idRoom, string nameStudent, string dateOfBirthStudent, string addressStudent, string phoneNumberStudent)
        {
            this.idStudent = idStudent;
            this.idRoom = idRoom;
            this.nameStudent = nameStudent;
            this.dateOfBirthStudent = dateOfBirthStudent;
            this.addressStudent = addressStudent;
            this.phoneNumberStudent = phoneNumberStudent;
        }
        public string IdStudent
        {
            get { return this.idStudent; }
            set { this.idStudent = value; }
        }

        public string IdRoom
        {
            get { return this.idRoom; }
            set { this.idRoom = value; }
        }

        public string NameStudent
        {
            get { return this.nameStudent; }
            set { this.nameStudent = value; }
        }

        public string DateOfBirthStudent
        {
            get { return this.dateOfBirthStudent; }
            set { this.dateOfBirthStudent = value; }
        }

        public string AddressStudent
        {
            get { return this.addressStudent; }
            set { this.addressStudent = value; }
        }

        public string PhoneNumberStudent
        {
            get { return this.phoneNumberStudent ; }
            set { this.phoneNumberStudent = value; }
        }
    }
}
