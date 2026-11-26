namespace SalMngmntLib
{
    // class for all salary based calculations
    public class SalCalculator
    {
        // calculating allowance data based on salary
        public void CalculateAllowance(Employee emp, out double housing, out double transportation, out double special)
        {
            if (emp.BasicSalary < 6000)
            {
                housing = emp.BasicSalary * 0.12;
                transportation = emp.BasicSalary * 0.08;
                special = emp.BasicSalary * 0.10;
            }
            else if (emp.BasicSalary < 12000)
            {
                housing = emp.BasicSalary * 0.18;
                transportation = emp.BasicSalary * 0.12;
                special = emp.BasicSalary * 0.15;
            }
            else if (emp.BasicSalary < 18000)
            {
                housing = emp.BasicSalary * 0.25;
                transportation = emp.BasicSalary * 0.15;
                special = emp.BasicSalary * 0.20;
            }
            else
            {
                housing = emp.BasicSalary * 0.30;
                transportation = emp.BasicSalary * 0.20;
                special = emp.BasicSalary * 0.25;
            }
        }

        // total salary including allowance
        public double CalculateTotal(Employee emp)
        {
            double housing;
            double transportation;
            double special;

            CalculateAllowance(emp, out housing, out transportation, out special);

            return emp.BasicSalary + housing + transportation + special;
        }

        // adding 10% tax to total salary
        public double CalculateTax(Employee emp)
        {
            double total = CalculateTotal(emp);

            return total * 0.10;
        }

        // final salary
        public double CalculateNetSalary(Employee emp)
        {
            double total = CalculateTotal(emp);
            double tax = CalculateTax(emp);

            return total - tax;
        }
    }
}
