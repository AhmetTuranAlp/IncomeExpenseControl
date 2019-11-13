using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeExpenseControl.Data.Entity
{
    public class DailyCastingEntry_TotalRevenue : Base
    {
        public DailyCastingEntry_TotalRevenue()
        {
            Catering_TotalPrice = 0;
            Personal_TotalPrice = 0;
            RestaurantBank_TotalPrice = 0;
            RestaurantCash_TotalPrice = 0;
            RestaurantFood_TotalPrice = 0;
            RevenueTotalPrice = 0;
            Catering_ReelPrice = 0;
            Personal_ReelPrice = 0;
            RestaurantBank_ReelPrice = 0;
            RestaurantCash_ReelPrice = 0;
            RestaurantFood_ReelPrice = 0;
            RevenueReelPrice = 0;

        }
        public DateTime CastingDate { get; set; }  //Döküm Tarihi

        #region Personal Revenue
        private decimal _personalTotalPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Personal_TotalPrice
        {
            get { return _personalTotalPrice; }
            set { _personalTotalPrice = Math.Round(value, 2); }
        } //Total Price

        private decimal _personalReelPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Personal_ReelPrice
        {
            get { return _personalReelPrice; }
            set { _personalReelPrice = Math.Round(value, 2); }
        } //Reel Price 
        #endregion

        #region Catering Revenue
        public int Catering_NumberOfPeople { get; set; }

        private decimal _cateringTotalPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Catering_TotalPrice
        {
            get { return _cateringTotalPrice; }
            set { _cateringTotalPrice = Math.Round(value, 2); }
        } //Total Price

        private decimal _cateringReelPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal Catering_ReelPrice
        {
            get { return _cateringReelPrice; }
            set { _cateringReelPrice = Math.Round(value, 2); }
        } //Reel Price 
        #endregion



        #region RestaurantCash Revenue
        public int RestaurantCash_NumberOfPeople { get; set; }

        private decimal _restaurantCashTotalPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantCash_TotalPrice
        {
            get { return _restaurantCashTotalPrice; }
            set { _restaurantCashTotalPrice = Math.Round(value, 2); }
        } //Total Price 

        private decimal _restaurantCashReelPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantCash_ReelPrice
        {
            get { return _restaurantCashReelPrice; }
            set { _restaurantCashReelPrice = Math.Round(value, 2); }
        } //Reel Price 
        #endregion

        #region RestaurantBank Revenue
        public int RestaurantBank_NumberOfPeople { get; set; }

        private decimal _restaurantBankTotalPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantBank_TotalPrice
        {
            get { return _restaurantBankTotalPrice; }
            set { _restaurantBankTotalPrice = Math.Round(value, 2); }
        } //Total Price 

        private decimal _restaurantBankReelPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantBank_ReelPrice
        {
            get { return _restaurantBankReelPrice; }
            set { _restaurantBankReelPrice = Math.Round(value, 2); }
        } //Reel Price 
        #endregion

        #region RestaurantFood Revenue
        public int RestaurantFood_NumberOfPeople { get; set; }

        private decimal _restaurantFoodTotalPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantFood_TotalPrice
        {
            get { return _restaurantFoodTotalPrice; }
            set { _restaurantFoodTotalPrice = Math.Round(value, 2); }
        } //Total Price 

        private decimal _restaurantFoodReelPrice = 0;
        [Required(ErrorMessage = "Zorunlu Alan")]
        public decimal RestaurantFood_ReelPrice
        {
            get { return _restaurantFoodReelPrice; }
            set { _restaurantFoodReelPrice = Math.Round(value, 2); }
        } //Reel Price 
        #endregion



        private decimal _revenueTotalPrice = 0;
        public decimal RevenueTotalPrice
        {
            get
            {
                _revenueTotalPrice = Catering_TotalPrice + Personal_TotalPrice + RestaurantCash_TotalPrice + RestaurantBank_TotalPrice + RestaurantFood_TotalPrice;
                return _revenueTotalPrice;
            }
            set
            {
                _revenueTotalPrice = Math.Round(value, 2);
            }

        } //Toplam Gelir

        private decimal _revenueReelPrice = 0;
        public decimal RevenueReelPrice
        {
            get
            {
                _revenueReelPrice = Catering_ReelPrice + Personal_ReelPrice + RestaurantCash_ReelPrice + RestaurantBank_ReelPrice + RestaurantFood_ReelPrice;
                return _revenueReelPrice;
            }
            set
            {
                _revenueReelPrice = Math.Round(value, 2);
            }
        } //Gerçek Gelir


    }
}
