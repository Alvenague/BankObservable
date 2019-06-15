namespace Jalasoft.Bootcamp.Observer.Bank
{
    using System;
    public class CellphoneNotification : Notification
    {
        //View
        public CellphoneNotification(Bank bank):base (bank)
        {

        }
        public override void Update(int cellphoneNumber)
        {
            Console.WriteLine("Print : "+cellphoneNumber + " Money credit added to your account");
        }
    }
}
