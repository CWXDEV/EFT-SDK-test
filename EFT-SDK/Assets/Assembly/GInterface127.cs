using System;
using EFT;
using EFT.InventoryLogic;

// Token: 0x02001504 RID: 5380
public interface GInterface127
{
	// Token: 0x17001238 RID: 4664
	// (get) Token: 0x06007399 RID: 29593
	Weapon Weapon { get; }

	// Token: 0x0600739A RID: 29594
	void RecalculateErgonomic();

	// Token: 0x17001239 RID: 4665
	// (get) Token: 0x0600739B RID: 29595
	float ErgonomicWeight { get; }

	// Token: 0x1700123A RID: 4666
	// (get) Token: 0x0600739C RID: 29596
	float TotalErgonomics { get; }

	// Token: 0x1700123B RID: 4667
	// (get) Token: 0x0600739D RID: 29597
	BifacialTransform CurrentFireport { get; }

	// Token: 0x1700123C RID: 4668
	// (get) Token: 0x0600739E RID: 29598
	bool MouseLookControl { get; }
}
