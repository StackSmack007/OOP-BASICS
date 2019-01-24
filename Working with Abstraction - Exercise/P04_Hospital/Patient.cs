namespace P04_Hospital
{
    public class Patient
    {
        public Patient(string name,string doctor)
        {
            this.Name = name;
            this.Doctor = doctor;
        }
        public string Name { get;}
        public string Doctor { get;}
    }
}