using System;
using System.Collections.Generic;
using VoicebotBillingMIS.Data.Models;

namespace VoicebotBillingMIS.Models;

public sealed class MonthlyHistoryRowViewModel
{
    public DateTime? FromDate { get; set; }
    public DateTime? ToDate { get; set; }
    public string Vendor { get; set; } = string.Empty;
    public decimal Rate { get; set; }
    public string BillCampaign { get; set; } = string.Empty;
    public decimal BillMou { get; set; }
    public decimal? TrackedMou { get; set; }
    public decimal BillCost => BillMou * Rate * 1.18m;
    public decimal? TrackedCost => TrackedMou.HasValue ? TrackedMou.Value * Rate * 1.18m : (decimal?)null;
    public decimal? Difference => TrackedCost.HasValue ? BillCost - TrackedCost.Value : (decimal?)null;
}

public sealed class MonthlyHistoryViewModel
{
    public int Year { get; set; }
    public int Month { get; set; }
    public IReadOnlyList<int> Years { get; set; } = Array.Empty<int>();
    public IReadOnlyList<DateTime> Periods { get; set; } = Array.Empty<DateTime>();
    public string FromPeriod { get; set; } = string.Empty;
    public string ToPeriod { get; set; } = string.Empty;
    public IReadOnlyList<MonthlyHistoryRowViewModel> Rows { get; set; } = Array.Empty<MonthlyHistoryRowViewModel>();
    public decimal TotalBillCost { get; set; }
    public decimal TotalTrackedCost { get; set; }
    public string Message { get; set; } = string.Empty;
}
