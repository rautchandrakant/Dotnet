using EmiCalc;

class Program
{
    static void Main(string[] args)
    {
        PersonalLoan p1 = new PersonalLoan();
        p1.Principle=(600000);
        p1.period=(5);
        Console.WriteLine("EMI of Personal Loan :{0:0.00}" , p1.GetEMI());

        HomeLoan h1 = new HomeLoan();
        h1.Principle=(300000);
        h1.period=(1);
        Console.WriteLine("Home Lone EMI is :{0:0.00}", h1.GetEMI());
    }
}