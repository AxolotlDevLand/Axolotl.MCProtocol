namespace Axolotl;

/// <summary>
///     Old transactions
/// </summary>
public abstract class Transaction
    {
        public bool HasNetworkIds { get; set; } = false;

        public int RequestId { get; set; }
        public List<RequestRecord> RequestRecords { get; set; } = new();
        public List<TransactionRecord> TransactionRecords { get; set; } = new();
    }