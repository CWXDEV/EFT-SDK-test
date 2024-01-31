using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x0200151D RID: 5405
[StructLayout(LayoutKind.Auto)]
public struct GStruct165 : GInterface67
{
	// Token: 0x1700124B RID: 4683
	// (get) Token: 0x060073FA RID: 29690 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060073FB RID: 29691 RVA: 0x00002050 File Offset: 0x00000250
	public double remoteTime
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

	// Token: 0x1700124C RID: 4684
	// (get) Token: 0x060073FC RID: 29692 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060073FD RID: 29693 RVA: 0x00002050 File Offset: 0x00000250
	public double localTime
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

	// Token: 0x060073FE RID: 29694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x060073FF RID: 29695 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007400 RID: 29696 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007401 RID: 29697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007402 RID: 29698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GInterface79 writer)
	{
		throw null;
	}

	// Token: 0x06007403 RID: 29699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(GInterface76 reader)
	{
		throw null;
	}

	// Token: 0x06007404 RID: 29700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GStruct165 Interpolate(GStruct165 fromSnapshot, GStruct165 toSnapshot, float t)
	{
		throw null;
	}

	// Token: 0x04007A38 RID: 31288
	public byte Iteration;

	// Token: 0x04007A39 RID: 31289
	public Vector3 TransformPosition;

	// Token: 0x04007A3A RID: 31290
	public Vector2 Rotation;

	// Token: 0x04007A3B RID: 31291
	public Vector2 MovementDirection;

	// Token: 0x04007A3C RID: 31292
	public EPlayerState State;

	// Token: 0x04007A3D RID: 31293
	[CompilerGenerated]
	private double double_0;

	// Token: 0x04007A3E RID: 31294
	[CompilerGenerated]
	private double double_1;

	// Token: 0x04007A3F RID: 31295
	private const float float_0 = -90f;

	// Token: 0x04007A40 RID: 31296
	private const float float_1 = 90f;

	// Token: 0x04007A41 RID: 31297
	private const float float_2 = -1f;

	// Token: 0x04007A42 RID: 31298
	private const float float_3 = 1f;
}
