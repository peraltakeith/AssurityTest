using System.Collections.Generic;

namespace AssurityTest.Models.Category
{
    public class Fee
    {
        public Fee()
        {
            ListingFeeTiers = new List<ListingFeeTier>();
        }

        public int Bundle { get; set; }
        public decimal EndDate { get; set; }
        public int Feature { get; set; }
        public int Gallery { get; set; }
        public int Listing { get; set; }
        public decimal Reserve { get; set; }
        public decimal Subtitle { get; set; }
        public decimal TenDays { get; set; }
        public List<ListingFeeTier> ListingFeeTiers { get; set; }
        public decimal SecondCategory { get; set; }
    }

    public class ListingFeeTier
    {
        public int MinimumTierPrice { get; set; }
        public int FixedFee { get; set; }
    }
}
