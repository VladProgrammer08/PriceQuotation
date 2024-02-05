using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuote
    {
        /// <summary>
        /// The original price, as entered
        /// by the user
        /// </summary>
        [Range(0, double.MaxValue, ErrorMessage = "Value must be 0 or greater")]
        public double Subtotal { get; set; }

        /// <summary>
        /// The discount percentage, as entered
        /// by the user
        /// </summary>
        [Range(0, 100, ErrorMessage = "Value must be between 0 and 100")]
        [Display(Name = "Discount Percent")]
        public double Discount { get; set; }

        /// <summary>
        /// Calculates how much is taken off the total
        /// when the discount is applied
        /// </summary>
        [Display(Name = "Discount Amount")]
        [DataType(DataType.Currency)]
        public double DiscountAmount 
        { 
            get
            {
                return Subtotal * Discount / 100;
            }

        }

        /// <summary>
        /// The total amount due
        /// </summary>
        [DataType(DataType.Currency)]
        public double Total 
        {
            get
            {
                return Subtotal - DiscountAmount;
            }
        }


    }
}
