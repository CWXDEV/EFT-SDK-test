using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Interactive;

// Token: 0x020027D4 RID: 10196
[StructLayout(LayoutKind.Auto)]
public struct GStruct386
{
	// Token: 0x1700247B RID: 9339
	// (get) Token: 0x0600CC4F RID: 52303 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasSelfFlag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700247C RID: 9340
	// (get) Token: 0x0600CC50 RID: 52304 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasConnectedFlag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700247D RID: 9341
	// (get) Token: 0x0600CC51 RID: 52305 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasVerticalFlag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700247E RID: 9342
	// (get) Token: 0x0600CC52 RID: 52306 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasStairsFlag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700247F RID: 9343
	// (get) Token: 0x0600CC53 RID: 52307 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasIsolatedFlag
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002480 RID: 9344
	// (get) Token: 0x0600CC54 RID: 52308 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasNone
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400CC60 RID: 52320
	public EVolumeRelationsMask RelationType;

	// Token: 0x0400CC61 RID: 52321
	public float Audibility;

	// Token: 0x0400CC62 RID: 52322
	public bool UseManualAudibilitySettings;
}
