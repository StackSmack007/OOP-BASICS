namespace BorderControl.Model
{
    public class Human : Robbot
    {
        private int age;
        public Human(string name,int age,string id):base(name,id)
        {
            this.age = age;
        }
    }
}