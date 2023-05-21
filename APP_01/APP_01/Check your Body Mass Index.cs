using System;
using System.Windows.Forms;

namespace APP_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string weight_value = weight.Text; // the weigth value of the user
            string tall_value = tall.Text; // the value os the user

            // convert the values into floats numbers
            double weight_float_value = double.Parse(weight_value) + .0;
            double tall_float_value = double.Parse(tall_value) + .0;

            //formula: IMC = Peso (kg) / (Altura (m))^2
            double body_mass_index_formula = weight_float_value / (double)Math.Pow(tall_float_value, 2);

            //float or double into int
            int bmi_01 = Convert.ToInt32(body_mass_index_formula); //this way do a round out of the final value
            int bmi_02 = (int)body_mass_index_formula; //this one dont do the round out

            if (bmi_02 < 18.5)
            {
                // updating the final string text
                result.Text = "Body Mass Index: " + bmi_02 + " IMC";

                // how you are
                imc_result.Text = "Your IMC or BMI is Low, Because " + bmi_02 +
                    "\nis less than 18.5, and that is considered Low." +
                    "\nThis is no Oficial, This is just an approximate vale, " +
                    "\nalways Go to the Doctor for somethings like this.";
            }
            else
            {
                if (25.0 <= bmi_02 && bmi_02 < 30)
                {
                    // updating the final string text
                    result.Text = "Body Mass Index: " + bmi_02 + " IMC";

                    // how you are
                    imc_result.Text = "Your IMC or BMI is Overweight, Because " + bmi_02 +
                        "\nis too much than 25.0 and less than 30.0, and that is considered Overweight." +
                        "\nThis is no Oficial, This is just an approximate vale, " +
                        "\nalways Go to the Doctor for somethings like this.";
                }
                else
                {
                    if (bmi_02 <= 25.0)
                    {
                        // updating the final string text
                        result.Text = "Body Mass Index: " + bmi_02 + " IMC";

                        // how you are
                        imc_result.Text = "Your IMC or BMI is Normal, Because " + bmi_02 +
                            "\nis less than 25.0, and that is considered Normal." +
                            "\nThis is no Oficial, This is just an approximate vale, " +
                            "\nalways Go to the Doctor for somethings like this.";
                    }
                    if (bmi_02 >= 30.0)
                    {
                        // updating the final string text
                        result.Text = "Body Mass Index: " + bmi_02 + " IMC";

                        // how you are
                        imc_result.Text = "Your IMC or BMI is Obesity, Because " + bmi_02 +
                            "\nis bad for your health, its more than 30.0, and that is considered Obesity." +
                            "\nThis is no Oficial, This is just an approximate vale, " +
                            "\nalways Go to the Doctor for somethings like this.";
                    }
                }
            }
        }
    }
}
