namespace EmiCalc;

public abstract class Loan
{
    public double Principle{get; set;}
    public float period{get; set;}

    public abstract float GetRate();

    public double GetEMI()
    {
        double rate = GetRate()/100;
        return Principle * (1+rate*period)/(12*period);
    }
}
