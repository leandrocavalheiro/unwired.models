namespace Unwired.Models.Types;

public struct USort
{
    public string Field { get; set; }
    public bool Descending { get; set; }
    public USort()
    {
        Field = "created_at";
        Descending = true;
    }
}
