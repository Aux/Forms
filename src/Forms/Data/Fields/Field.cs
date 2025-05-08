namespace Forms.Data;

public class Field
{
    public string Id { get; set; }
    public string FormId { get; set; }
    public string Title { get; set; }
    public FieldValueType ValueType { get; set; }
    public FieldEntryType EntryType { get; set; }
}
