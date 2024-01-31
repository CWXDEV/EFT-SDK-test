using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020007AC RID: 1964
public class GClass735
{
	// Token: 0x17000816 RID: 2070
	// (get) Token: 0x06002D89 RID: 11657 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInFrustrumView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000817 RID: 2071
	// (get) Token: 0x06002D8A RID: 11658 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsInDistance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000818 RID: 2072
	// (get) Token: 0x06002D8B RID: 11659 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsVisible
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x04002C11 RID: 11281
	private Transform transform_0;

	// Token: 0x04002C12 RID: 11282
	private Renderer[] renderer_0;

	// Token: 0x04002C13 RID: 11283
	private Camera camera_0;

	// Token: 0x04002C14 RID: 11284
	private GClass735.GStruct44 gstruct44_0;

	// Token: 0x020007AD RID: 1965
	[Flags]
	public enum CheckType
	{
		// Token: 0x04002C16 RID: 11286
		Distance = 1,
		// Token: 0x04002C17 RID: 11287
		Frustrum = 2
	}

	// Token: 0x020007AE RID: 1966
	[SerializeField]
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct44
	{
		// Token: 0x04002C18 RID: 11288
		public GClass735.CheckType check;

		// Token: 0x04002C19 RID: 11289
		public float sqrDistance;
	}
}
