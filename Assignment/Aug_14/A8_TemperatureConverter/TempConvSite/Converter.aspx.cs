using System;
using TempConvLib;

public partial class Converter : System.Web.UI.Page
{
    double temp;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnConvert_Click(object sender, EventArgs e)
    {
        try
        {
            temp = Convert.ToDouble(txtTemp.Text);

            if (rdoCel.Checked)
            {
                lblHeading.Text = "Celsius Temp: ";
                lblResult.Text = TemperatureConverter.FahrenheitToCelsius(temp).ToString();
            }
            else if (rdoFah.Checked)
            {
                lblHeading.Text = "Fahrenheit Temp: ";
                lblResult.Text = TemperatureConverter.CelsiusToFahrenheit(temp).ToString();
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}

    