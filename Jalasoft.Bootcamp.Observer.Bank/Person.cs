namespace Jalasoft.Bootcamp.Observer.Bank
{
    public class Person
    {
        public string Name { get; set; }
        public Cellphone Cellphone { get; set; }
        public Person(string name, Cellphone cellphone)
        {
            this.Name = name;
            this.Cellphone = cellphone;
        }
        public void UnsuscribeNotification()
        {
            Cellphone.Subcribe = false;
        }

    }
}