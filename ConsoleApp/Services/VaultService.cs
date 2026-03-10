using System.Collections.Generic;

public class VaultService
{
    private List<VaultRecord> records = new List<VaultRecord>();

    public void AddRecord(VaultRecord record)
    {
        records.Add(record);
    }

    public List<VaultRecord> GetRecords()
    {
        return records;
    }
}