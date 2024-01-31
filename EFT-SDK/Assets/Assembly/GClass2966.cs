using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;

// Token: 0x0200277C RID: 10108
public abstract class GClass2966
{
	// Token: 0x0600CA90 RID: 51856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2966 CreateReferenceTree(GClass2970 root)
	{
		throw null;
	}

	// Token: 0x170023FA RID: 9210
	// (get) Token: 0x0600CA91 RID: 51857
	public abstract ENodeStatus CurrentStatus { get; }

	// Token: 0x0600CA92 RID: 51858
	public abstract void SetSelectedRecursive(bool value);

	// Token: 0x0600CA93 RID: 51859
	public abstract IEnumerable<GClass2966> GetSelected();

	// Token: 0x0600CA94 RID: 51860
	public abstract void SetFilter(IEnumerable<LootableContainerParameters> filters);

	// Token: 0x0400CAAB RID: 51883
	public GClass2970 Node;

	// Token: 0x0400CAAC RID: 51884
	public int Quantity;

	// Token: 0x0400CAAD RID: 51885
	public int SpawnProbability;
}
