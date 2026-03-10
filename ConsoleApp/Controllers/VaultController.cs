using System.Collections.Generic;

public class VaultController
{
    private VaultService vaultService = new VaultService();

    public void AddVaultRecord(string data, int ownerId)
    {
        VaultRecord record = new VaultRecord
        {
            Data = Sanitize(data),
            OwnerId = ownerId
        };

        vaultService.AddRecord(record);
    }

    public List<VaultRecord> GetRecords()
    {
        return vaultService.GetRecords();
    }

    private string Sanitize(string input)
    {
        return System.Net.WebUtility.HtmlEncode(input);
    }
}