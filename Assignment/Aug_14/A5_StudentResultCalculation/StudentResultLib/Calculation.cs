namespace StudentResultLib
{
    public class Calculation
    {
        public void CalculateResult(Student s)
        {
            s.Total = s.English + s.Science + s.Maths;
            s.Percentage = s.Total / 3;
        }

        public string Display(Student s)
        {
            return "Student Name: " + s.Name + "<br>English: " + s.English + "<br>Maths: " + s.Maths + "<br>Science: " + s.Science + "<br>Total: " + s.Total + "<br>Percentage: " + s.Percentage;
        }
    }
}
