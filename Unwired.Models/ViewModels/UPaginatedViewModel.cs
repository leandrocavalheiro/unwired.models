namespace Unwired.Models.ViewModels;

public struct UPaginatedViewModel<TResult>
{
    public ICollection<TResult> Items { get; set; }
    public int Page { get; }
    public int PageSize { get; }
    public int TotalRecords { get; set; }
    public int TotalPages { get; set; }

    public UPaginatedViewModel(ICollection<TResult> items, int page, int pageSize, int totalRecords, int totalPages)
    {
        Items = items ?? new List<TResult>();
        Page = page;
        PageSize = pageSize;
        TotalRecords = totalRecords;
        TotalPages = totalPages;
    }
}