using System;

public partial class FormEleven : System.Web.UI.Page
{
    double sum;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        double n1 = Convert.ToDouble(txtNum1.Text);
        double n2 = Convert.ToDouble(txtNum2.Text);
        double n3 = Convert.ToDouble(txtNum3.Text);
        double n4 = Convert.ToDouble(txtNum4.Text);
        double n5 = Convert.ToDouble(txtNum5.Text);
        double n6 = Convert.ToDouble(txtNum6.Text);
        double n7 = Convert.ToDouble(txtNum7.Text);
        double n8 = Convert.ToDouble(txtNum8.Text);
        double n9 = Convert.ToDouble(txtNum9.Text);
        double n10 = Convert.ToDouble(txtNum10.Text);

        double sum = n1 + n2 + n3 + n4 + n5 +
                     n6 + n7 + n8 + n9 + n10;

        double average = sum / 10;

        lblSumOutput.Text = sum.ToString();
        lblAverageOutput.Text = average.ToString();

    }
}
