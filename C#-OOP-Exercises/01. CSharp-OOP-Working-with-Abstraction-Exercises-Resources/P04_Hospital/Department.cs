using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;

            this.Rooms = new List<Room>();

            CreateRooms();
        }

        public string Name { get; set; }

        public List<Room> Rooms { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var room in this.Rooms)
            {
                foreach (var patient in room.Patients)
                {
                    sb.AppendLine(patient.Name);
                }
            }

            return sb.ToString().TrimEnd();
        }

        public bool AddPatientToRoom(Patient patient)
        {
            var currentRoom = this.Rooms.FirstOrDefault(r => !r.IsFull);

            if(currentRoom != null)
            {
                currentRoom.Patients.Add(patient);
                return true;
            }

            return false;
        }
        
        private void CreateRooms()
        {
            for (int room = 0; room < 20; room++)
            {
                this.Rooms.Add(new Room());
            }
        }
    }
}
