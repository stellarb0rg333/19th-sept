using System;
using System.Collections.Generic;
using VoicebotBillingMIS.Data.Models;

namespace VoicebotBillingMIS.Models;

public static class PageStateKeys
{
    public const string UsagePageState = "UsagePageState";
    public const string CampaignBudgetPageState = "CampaignBudgetPageState";
    public const string VendorRatesPageState = "VendorRatesPageState";
    public const string InvoiceUploadPageState = "InvoiceUploadPageState";
    public const string InvoiceHistoryPageState = "InvoiceHistoryPageState";
    public const string MonthlyHistoryPageState = "MonthlyHistoryPageState";
}

public sealed class UsagePageState
{
    public UsageFilterInputModel Filter { get; set; } = new();
}

public sealed class CampaignBudgetPageState
{
    public CampaignBudgetInputModel Input { get; set; } = new();
}

public sealed class VendorRatesPageState
{
    public VendorRateInputModel Input { get; set; } = new();
}

public sealed class InvoiceUploadPageState
{
    public InvoiceUploadInputModel Input { get; set; } = new();

    public List<InvoiceUploadRow> Rows { get; set; } = [];

    public bool SaveCompleted { get; set; }
}

public sealed class InvoiceHistoryPageState
{
    public string? SearchTerm { get; set; }

    public Guid? SelectedRecordId { get; set; }
}

public sealed class MonthlyHistoryPageState
{
    public int Year { get; set; }
    public int Month { get; set; }
    public string? FromPeriod { get; set; }
    public string? ToPeriod { get; set; }
}
