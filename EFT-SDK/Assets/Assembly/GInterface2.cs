using System;

// Token: 0x02000157 RID: 343
public interface GInterface2 : IPositionPoint
{
	// Token: 0x06000769 RID: 1897
	bool IsSameMeaning(GInterface2 p1, float sDist, out GInterface2 worst);
}
