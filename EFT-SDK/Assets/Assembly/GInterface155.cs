using System;
using EFT.InputSystem;

// Token: 0x02001A31 RID: 6705
public interface GInterface155
{
	// Token: 0x06008E07 RID: 36359
	void AddWithLowPriority(InputNode node);

	// Token: 0x06008E08 RID: 36360
	void Add(InputNode node);

	// Token: 0x06008E09 RID: 36361
	void Remove(InputNode node);

	// Token: 0x06008E0A RID: 36362
	bool Contains(InputNode node);
}
