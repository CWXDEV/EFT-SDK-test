using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT;
using UnityEngine;

// Token: 0x02001537 RID: 5431
[StructLayout(LayoutKind.Auto)]
public struct GStruct178 : GInterface141<GStruct178>
{
	// Token: 0x06007459 RID: 29785 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Serialize(GInterface79 writer, ref GStruct178? packet)
	{
		throw null;
	}

	// Token: 0x0600745A RID: 29786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct178? Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x0600745B RID: 29787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x17001252 RID: 4690
	// (get) Token: 0x0600745C RID: 29788 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600745D RID: 29789 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface141<GStruct178> Nested
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x04007ABB RID: 31419
	private static readonly GClass1174 gclass1174_0;

	// Token: 0x04007ABC RID: 31420
	private static readonly GClass1174 gclass1174_1;

	// Token: 0x04007ABD RID: 31421
	public bool IsPrimaryActive;

	// Token: 0x04007ABE RID: 31422
	public int AmmoAfterShot;

	// Token: 0x04007ABF RID: 31423
	public EShotType EShotType;

	// Token: 0x04007AC0 RID: 31424
	public Vector3 ShotPosition;

	// Token: 0x04007AC1 RID: 31425
	public Vector3 ShotDirection;

	// Token: 0x04007AC2 RID: 31426
	public Vector3 FireportPosition;

	// Token: 0x04007AC3 RID: 31427
	public int ChamberIndex;

	// Token: 0x04007AC4 RID: 31428
	public float Overheat;

	// Token: 0x04007AC5 RID: 31429
	public bool UnderbarrelShot;

	// Token: 0x04007AC6 RID: 31430
	[CompilerGenerated]
	private GInterface141<GStruct178> ginterface141_0;
}
