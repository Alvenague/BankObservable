namespace Jalasoft.Bootcamp.Observer.Bank
{
    public class Cellphone
    {
        public int CellphoneNumber { get; set; }
        public bool Subcribe { get; set; }
        public Cellphone(int cellphone)
        {
            this.CellphoneNumber = cellphone;
            this.Subcribe = true;
        }
    }
}