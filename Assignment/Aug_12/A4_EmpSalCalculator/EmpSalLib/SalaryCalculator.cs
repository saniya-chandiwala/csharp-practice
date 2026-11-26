namespace EmpSalLib
{
    public static class SalaryCalculator
    {
        // Calculate salary using only basic salary.
        public static double CalculateSalary(double sal)
        {
            return sal;
        }

        //Calculate salary using basic salary + allowance.
        public static double CalculateSalary(double sal, double allowance)
        {
            return sal + allowance;
        }

        //Calculate salary using basic salary + allowance + bonus.
        public static double CalculateSalary(double sal, double allowance, double bonus)
        {
            return sal + allowance + bonus;
        }

        //Calculate salary using basic salary + allowance + bonus + deduction.
        public static double CalculateSalary(double sal, double allowance, double bonus, double deduction)
        {
            return sal + allowance + bonus - deduction;
        }

    }
}
