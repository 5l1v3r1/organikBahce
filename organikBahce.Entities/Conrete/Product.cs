using organikBahce.Entities.Conrete.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace organikBahce.Entities.Conrete
{
    public class Product
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Price2 { get; set; }
        public decimal Price3 { get; set; }
        public decimal Price4 { get; set; }
        public decimal Price5 { get; set; }
        public bool isKdv { get; set; }
        public Currency  Currency { get; set; }
        public string StockCode { get; set; }
        public string BarcodeCode { get; set; }
        public int StockQuantity { get; set; }
        public QuantityType QuantityType { get; set; }
        public bool isActive { get; set; }
        public decimal PurchasePrice { get; set; }
        public int Vat { get; set; }
        public int Discount { get; set; }
        public int MoneyOrderDiscount { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string ShortDescription { get; set; }
        public string Tag { get; set; }
        public int WarrantyPeriod { get; set; }
        public bool isGift { get; set; }
        public string GiftDescription { get; set; }
        public bool isCountdown { get; set; }
        public DateTime? startedCountdown { get; set; }
        public DateTime? finishedCountdown { get; set; }
        public DateTime? BasketDate { get; set; }


        public Brand Brand { get; set; }
    }
}
