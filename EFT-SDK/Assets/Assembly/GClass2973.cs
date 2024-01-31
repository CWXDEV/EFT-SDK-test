using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;

// Token: 0x020027C9 RID: 10185
public abstract class GClass2973
{
	// Token: 0x0600CC29 RID: 52265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2973 CreateReferenceTree(GClass2970 root)
	{
		throw null;
	}

	// Token: 0x17002472 RID: 9330
	// (get) Token: 0x0600CC2A RID: 52266
	public abstract ENodeStatus CurrentStatus { get; }

	// Token: 0x0600CC2B RID: 52267
	public abstract void SetSelected(bool value);

	// Token: 0x0600CC2C RID: 52268
	public abstract void SetFilter(IEnumerable<string> filters);

	// Token: 0x0600CC2D RID: 52269
	public abstract IEnumerable<GClass2973> GetSelected();

	// Token: 0x0600CC2E RID: 52270
	public abstract void GetSelectedLeavesNonAlloc(List<GClass2973> list);

	// Token: 0x0400CC42 RID: 52290
	public GClass2970 Node;
}
