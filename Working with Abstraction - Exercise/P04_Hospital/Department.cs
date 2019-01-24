using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Patients = new List<List<Patient>>(20);
            Patients.Add(new List<Patient>(3));
        }
        public string Name { get; }
        public List<List<Patient>> Patients { get; }
        public void AddPatient(string patient, string doctor)
        {
            int currentRoomIndex = this.Patients.Count - 1;
            int currentBedIndex = this.Patients[currentRoomIndex].Count;
            if (currentBedIndex > 2)
            {
                currentRoomIndex++;
                Patients.Add( new List<Patient>(3));
            }

            if (currentRoomIndex > 19)
            {
                return;
            }

            this.Patients[currentRoomIndex].Add(new Patient(patient, doctor));
        }
        public static void Print(List<Department> departments, string[] tokens)
        {
            List<string> resultPatientNames = new List<string>();
            int roomNumber = -1;
            if (tokens.Length == 1)
            {
                var res = departments.FirstOrDefault(x => x.Name == tokens[0]).Patients;
                foreach (var room in res)
                {
                    foreach (var patient in room)
                    {
                        resultPatientNames.Add(patient.Name);
                    }
                }
            }
            if (tokens.Length == 2)
            {
                if (int.TryParse(tokens[1], out roomNumber))
                {
                    var res = departments.FirstOrDefault(x => x.Name == tokens[0]).Patients[roomNumber - 1];
                    foreach (var patient in res.OrderBy(x => x.Name))
                    {
                        resultPatientNames.Add(patient.Name);
                    }
                }
                else
                {
                    string doctorName = tokens[0] + ' ' + tokens[1];
                    foreach (Department department in departments.Where(x => x.Patients.Any(y => y.Any(z => z.Doctor == doctorName))))
                    {
                        foreach (List<Patient> room in department.Patients.Where(x => x.Any(z => z.Doctor == doctorName)))
                        {
                            foreach (Patient patient in room.Where(x => x.Doctor == doctorName))
                            {
                                resultPatientNames.Add(patient.Name);
                            }
                        }
                    }
                    resultPatientNames = resultPatientNames.OrderBy(x => x).ToList();
                }
            }
            System.Console.WriteLine(string.Join("\n", resultPatientNames));
        }
    }
}