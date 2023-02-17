namespace Unwired.Models.ViewModels;

public struct PaginatedViewModel<T>
{
    public ICollection<T> Items { get; set; }
    public int Page { get; }
    public int PageSize { get; }
    public int TotalRecords { get; set; }
    public int TotalPages { get; set; }

    public PaginatedViewModel(ICollection<T> items, int page, int pageSize, int totalRecords, int totalPages)
    {
        Items = items ?? new List<T>();
        Page = page;
        PageSize = pageSize;
        TotalRecords = totalRecords;
        TotalPages = totalPages;
    }
}