namespace EmiCalc;

public class HomeLoan:Loan
{
    public override float GetRate()
    {
        float rate =0;
        rate = (Principle>2000000)? 0.10f : 0.11f;
        return rate;
    }

}
