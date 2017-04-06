namespace SOLID.OCP
{
    public class DiscountCalculator
    {
        double _discountValue;

        public double CalculateDiscount(int amount, string rule)
        {
            if (rule.Equals("Summer"))
            {
                _discountValue = amount * 0.15;
            }
            else if (rule.Equals("Winter"))
            {
                _discountValue = amount * 0.10;
            }
            else if (rule.Equals("Christmas"))
            {
                _discountValue = amount * 0.30;
            }
            else if (rule.Equals("Iday"))
            {
                _discountValue = amount * 0.05;
                //Adding this new rule would be a violation of the OCP as we are modifying the class
            }

            return _discountValue;

            //The class is set out to calculate discounts against 3 rules, if another rule 
            //was to be added this would be a modification and count as a violation
            //Of the OCP.
        }
    }
}
