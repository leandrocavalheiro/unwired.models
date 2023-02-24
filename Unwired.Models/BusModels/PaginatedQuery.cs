using Unwired.Models.Interfaces;
using Unwired.Models.Types;

namespace Unwired.Models.BusModels;

public class PaginatedQuery<T> : IQuery<T>
{
    private string _filter;
    public string Filter { get => _filter; set => _filter = (value ?? string.Empty).Trim(); }
    public int Page { get; set; }
    public int PageSize { get; set; }
    public ICollection<USort> SortBy { get; set; }    
    public PaginatedQuery(string filter, int page, int pageSize, ICollection<USort> sortBy = null)
    {

        Filter = filter;
        Page = page;
        PageSize = pageSize;
        sortBy ??= new List<USort>() { new USort() { Field = "created_at", Descending = true} };
        SortBy = sortBy;
    }       
}