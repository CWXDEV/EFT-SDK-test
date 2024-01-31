using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x020011D7 RID: 4567
[StructLayout(LayoutKind.Auto)]
public struct GStruct125
{
	// Token: 0x06006179 RID: 24953 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer, GStruct125 previousPacket)
	{
		throw null;
	}

	// Token: 0x0600617A RID: 24954 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x0600617B RID: 24955 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer, bool hasPreviousPacket, GStruct125 previousPacket)
	{
		throw null;
	}

	// Token: 0x0600617C RID: 24956 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader, GStruct125 previousPacket)
	{
		throw null;
	}

	// Token: 0x0600617D RID: 24957 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x0600617E RID: 24958 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader, bool hasPreviousPacket, GStruct125 previousPacket)
	{
		throw null;
	}

	// Token: 0x04006B60 RID: 27488
	private const float float_0 = 5f;

	// Token: 0x04006B61 RID: 27489
	private const float float_1 = 25f;

	// Token: 0x04006B62 RID: 27490
	private static readonly GClass1174 gclass1174_0;

	// Token: 0x04006B63 RID: 27491
	private static readonly GClass1169 gclass1169_0;

	// Token: 0x04006B64 RID: 27492
	private const int int_0 = 12;

	// Token: 0x04006B65 RID: 27493
	public int Id;

	// Token: 0x04006B66 RID: 27494
	public Vector3 Position;

	// Token: 0x04006B67 RID: 27495
	public bool Done;

	// Token: 0x04006B68 RID: 27496
	public GStruct104[] TransformSyncs;

	// Token: 0x04006B69 RID: 27497
	public bool IsNotValidPosition;
}
