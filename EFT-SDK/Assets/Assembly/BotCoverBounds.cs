using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200022E RID: 558
public class BotCoverBounds : MonoBehaviour
{
	// Token: 0x06000A52 RID: 2642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BoxCollider> GetBoundsAsColliders(bool wall, bool foliage, bool snipe)
	{
		throw null;
	}

	// Token: 0x06000A53 RID: 2643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BotCoverBounds> GetAllBounds()
	{
		throw null;
	}

	// Token: 0x06000A54 RID: 2644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BotCoverBounds> GetBoundsExclude()
	{
		throw null;
	}

	// Token: 0x06000A55 RID: 2645 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static List<BotCoverBounds> GetBounds(bool wall, bool foliage, bool snipe)
	{
		throw null;
	}

	// Token: 0x06000A56 RID: 2646 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DisableAllCoilliders()
	{
		throw null;
	}

	// Token: 0x04000B59 RID: 2905
	public BoxCollider Collider;

	// Token: 0x04000B5A RID: 2906
	public bool WallCovers;

	// Token: 0x04000B5B RID: 2907
	public bool FoliageCovers;

	// Token: 0x04000B5C RID: 2908
	public bool SnipeCovers;

	// Token: 0x04000B5D RID: 2909
	public bool ExcludeCovers;

	// Token: 0x04000B5E RID: 2910
	public int Id;

	// Token: 0x0200022F RID: 559
	[CompilerGenerated]
	[Serializable]
	private sealed class Class130
	{
		// Token: 0x06000A57 RID: 2647 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotCoverBounds x)
		{
			throw null;
		}

		// Token: 0x04000B5F RID: 2911
		public static readonly BotCoverBounds.Class130 class130_0;

		// Token: 0x04000B60 RID: 2912
		public static Func<BotCoverBounds, bool> func_0;
	}

	// Token: 0x02000230 RID: 560
	[CompilerGenerated]
	private sealed class Class131
	{
		// Token: 0x06000A58 RID: 2648 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BotCoverBounds x)
		{
			throw null;
		}

		// Token: 0x04000B61 RID: 2913
		public bool wall;

		// Token: 0x04000B62 RID: 2914
		public bool foliage;

		// Token: 0x04000B63 RID: 2915
		public bool snipe;
	}
}
