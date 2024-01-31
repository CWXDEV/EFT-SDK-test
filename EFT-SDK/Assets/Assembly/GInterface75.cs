using System;

// Token: 0x02000FA8 RID: 4008
public interface GInterface75
{
	// Token: 0x17000D3B RID: 3387
	// (get) Token: 0x060054A6 RID: 21670
	byte[] Buffer { get; }

	// Token: 0x17000D3C RID: 3388
	// (get) Token: 0x060054A7 RID: 21671
	bool IsOverflow { get; }

	// Token: 0x17000D3D RID: 3389
	// (get) Token: 0x060054A8 RID: 21672
	int BitsRead { get; }

	// Token: 0x17000D3E RID: 3390
	// (get) Token: 0x060054A9 RID: 21673
	int BitsCount { get; }

	// Token: 0x17000D3F RID: 3391
	// (get) Token: 0x060054AA RID: 21674
	int BytesRead { get; }

	// Token: 0x060054AB RID: 21675
	uint ReadBits(int bits);

	// Token: 0x060054AC RID: 21676
	void ReadBytes(byte[] destination, int destinationStartIndex, int bytesCount);

	// Token: 0x060054AD RID: 21677
	int GetAlignBits();

	// Token: 0x060054AE RID: 21678
	void ReadAlign();

	// Token: 0x060054AF RID: 21679
	void Reset();
}
