using System;
using SQLite;

namespace CougBites.Models
{
    [Table("FoodItems")]
    public class FoodItem
    {
        [PrimaryKey]
        public string Name { get; set; }
        public int LocationID { get; set; }
        public double[] Rating { get; set; }
        public double AvgRating { get; set; }
        public string Description   { get; set; }
        public Boolean[] DaysAvailable { get; set; }
        public Boolean[] TimesAvailable { get; set; }
        // Picture
        public void calcAvgRating()
        {
            double sum = 0.0;
            for (int i = 0; i < Rating.Length; i++)
            {
                sum += Rating[i];
            }
            AvgRating = sum / Rating.Length;
        }

        public void rateItem(double rating)
        {
            /*signedinprofile.rateItem(this, rating)
            Rating.append(rating)
            calcAvgRating()*/
        }

    }
}