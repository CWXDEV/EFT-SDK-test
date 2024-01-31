using System;

// Token: 0x02000FAD RID: 4013
public interface IMeasureStatistics
{
	// Token: 0x17000D47 RID: 3399
	// (get) Token: 0x060054EB RID: 21739
	byte[] Buffer { get; }

	// Token: 0x17000D48 RID: 3400
	// (get) Token: 0x060054EC RID: 21740
	bool IsOverflow { get; }

	// Token: 0x17000D49 RID: 3401
	// (get) Token: 0x060054ED RID: 21741
	int BitsWritten { get; }

	// Token: 0x17000D4A RID: 3402
	// (get) Token: 0x060054EE RID: 21742
	int BitsCount { get; }

	// Token: 0x17000D4B RID: 3403
	// (get) Token: 0x060054EF RID: 21743
	int BytesWritten { get; }

	// Token: 0x17000D4C RID: 3404
	// (get) Token: 0x060054F0 RID: 21744
	int TotalBytes { get; }

	// Token: 0x060054F1 RID: 21745
	void WriteBits(uint value, int bits);

	// Token: 0x060054F2 RID: 21746
	void WriteBytes(byte[] bytes, int startIndex, int length);

	// Token: 0x060054F3 RID: 21747
	void WriteBytes(byte[] bytes);

	// Token: 0x060054F4 RID: 21748
	void FlushBits();

	// Token: 0x060054F5 RID: 21749
	void WriteByteAlign();

	// Token: 0x060054F6 RID: 21750
	void Reset();
}
