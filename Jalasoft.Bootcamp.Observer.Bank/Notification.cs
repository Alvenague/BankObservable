namespace Jalasoft.Bootcamp.Observer.Bank
{
    public abstract class Notification
    {
        //Observer
        protected Bank bank;
        public Notification(Bank bank)
        {
            this.bank = bank;
            this.bank.Attach(this);
        }
        public abstract void Update(int cellphoneNumber);
    }
}
