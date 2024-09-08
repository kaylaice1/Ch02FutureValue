using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValuesModel
    {
        [Required(ErrorMessage = "Please enter a monthly investment.")]
        [Range(1, 500, ErrorMessage =
                        "Monthly investment amount must be between 1 and 500.")]
        public decimal? MonthlyInvestment { get; set; }


        [Required(ErrorMessage = "Please enter a Yearly Intrest Rate.")]
        [Range(0.1 , 10.0, ErrorMessage =
                        "Yearly interest rate mus be between 0.1 and 10.0.")]
        public decimal? YearlyInterestRate { get; set; }

        [Required(ErrorMessage = "Please enter a number  of years.")]
        [Range(1, 50, ErrorMessage =
                        "Number of years must be between1 and 50.")]
        public int? Years { get; set; }
        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? MonthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) *
                                (1 + MonthlyInterestRate);
            }
            return futureValue;
        }
    }
}
