namespace EmiCalc;

public class PersonalLoan:Loan
{
    public override float GetRate()
    {
        float rate =0;
        rate = (Principle<500000)? 0.15f : 0.16f;
        return rate;
    }

}
