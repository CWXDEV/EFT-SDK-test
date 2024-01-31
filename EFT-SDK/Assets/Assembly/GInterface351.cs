using System;
using EFT.Interactive;

// Token: 0x02002761 RID: 10081
public interface GInterface351
{
	// Token: 0x170023D6 RID: 9174
	// (get) Token: 0x0600C9EF RID: 51695
	// (set) Token: 0x0600C9F0 RID: 51696
	bool Enabled { get; set; }

	// Token: 0x0600C9F1 RID: 51697
	void Switch(Turnable.EState switchTo);
}
