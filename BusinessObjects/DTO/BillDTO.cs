﻿namespace BusinessObjects.DTO
{
    public class BillDTO
    {
        public int? CustomerId { get; set; }

        public int? UserId { get; set; }
        public DateTime? SaleDate { get; set; }
        public IEnumerable<int>? JewelryIds { get; set; }
    }
    
}