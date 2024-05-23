﻿namespace BusinessObjects.DTO;
public class PromotionDTO
{
    public string? Type { get; set; }

    public string? ApproveManager { get; set; }

    public string? Description { get; set; }

    public double? DiscountRate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}