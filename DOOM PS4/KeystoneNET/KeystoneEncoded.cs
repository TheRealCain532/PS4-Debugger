// KeystoneEncoded
public class KeystoneEncoded
{
	public ulong Address
	{
		get;
		private set;
	}

	public byte[] Buffer
	{
		get;
		private set;
	}

	public uint StatementCount
	{
		get;
		private set;
	}

	public KeystoneEncoded(byte[] buffer, uint statementCount, ulong address)
	{
		Buffer = buffer;
		StatementCount = statementCount;
		Address = address;
	}
}
