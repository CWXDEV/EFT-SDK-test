using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InputSystem;

// Token: 0x02001A5D RID: 6749
public class GClass1895
{
	// Token: 0x06008E8D RID: 36493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAxis(params GClass1891[] axisCombinations)
	{
		throw null;
	}

	// Token: 0x06008E8E RID: 36494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetCombinations(float doubleClickTimeout, params GClass1892[] combinations)
	{
		throw null;
	}

	// Token: 0x06008E8F RID: 36495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBindings(KeyGroup[] keyGroups, AxisGroup[] axisGroups, float doubleClickTimeout)
	{
		throw null;
	}

	// Token: 0x06008E90 RID: 36496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateInput(List<ECommand> commands, float[] axis, float deltaTime)
	{
		throw null;
	}

	// Token: 0x040095D3 RID: 38355
	private GClass1892[] gclass1892_0;

	// Token: 0x040095D4 RID: 38356
	private GClass1891[] gclass1891_0;

	// Token: 0x040095D5 RID: 38357
	private GClass1890[] gclass1890_0;

	// Token: 0x040095D6 RID: 38358
	private GClass1891[] gclass1891_1;

	// Token: 0x040095D7 RID: 38359
	private GInterface157[] ginterface157_0;

	// Token: 0x040095D8 RID: 38360
	private GInterface157[] ginterface157_1;

	// Token: 0x040095D9 RID: 38361
	private ECommand ecommand_0;

	// Token: 0x02001A5E RID: 6750
	[CompilerGenerated]
	private sealed class Class1590
	{
		// Token: 0x06008E91 RID: 36497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(GClass1892 keyCombination)
		{
			throw null;
		}

		// Token: 0x040095DA RID: 38362
		public GClass1891 axisCombination;

		// Token: 0x040095DB RID: 38363
		public Func<GClass1892, bool> func_0;
	}

	// Token: 0x02001A5F RID: 6751
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1591
	{
		// Token: 0x06008E92 RID: 36498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(AxisGroup.AxisPair axisPair)
		{
			throw null;
		}

		// Token: 0x040095DC RID: 38364
		public static readonly GClass1895.Class1591 class1591_0;

		// Token: 0x040095DD RID: 38365
		public static Func<AxisGroup.AxisPair, bool> func_0;
	}
}
