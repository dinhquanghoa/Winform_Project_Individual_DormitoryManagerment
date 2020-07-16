using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Room
    {
        public string idRoom, nameRoom, currentPeople, capacity, typeRoom, idEmployee;

        public Room(){}
        public Room(string idRoom, string nameRoom, string currentPeople, string capacity, string typeRoom, string idEmployee )
        {
            this.idRoom = idRoom;
            this.nameRoom = nameRoom;
            this.currentPeople = currentPeople ;
            this.capacity = capacity;
            this.typeRoom = typeRoom;
            this.idEmployee = idEmployee;
        }
        public string IdRoom
        {
            get { return this.idRoom; }
            set { this.idRoom = value; }
        }

        public string NameRoom
        {
            get { return this.nameRoom; }
            set { this.nameRoom = value; }
        }

        public string CurrentPeople
        {
            get { return this.currentPeople; }
            set { this.currentPeople = value; }
        }

        public string Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public string IdEmployee
        {
            get { return this.idEmployee; }
            set { this.idEmployee = value; }
        }
        public string TypeRoom
        {
            get { return this.typeRoom; }
            set { this.typeRoom = value; }
        }
    }
}
