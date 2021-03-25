using System.Collections.Generic;

namespace AssurityTest.Models.Category
{
    public class Fee
    {
        public Fee()
        {
            ListingFeeTiers = new List<ListingFeeTier>();
        }

        public decimal Bundle { get; set; }
        public decimal EndDate { get; set; }
        public decimal Feature { get; set; }
        public decimal Gallery { get; set; }
        public decimal Listing { get; set; }
        public decimal Reserve { get; set; }
        public decimal Subtitle { get; set; }
        public decimal TenDays { get; set; }
        public List<ListingFeeTier> ListingFeeTiers { get; set; }
        public decimal SecondCategory { get; set; }
    }

    public class ListingFeeTier
    {
        public decimal MinimumTierPrice { get; set; }
        public decimal FixedFee { get; set; }
    }
}
