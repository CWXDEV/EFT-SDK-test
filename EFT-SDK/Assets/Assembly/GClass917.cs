using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Token: 0x02000C97 RID: 3223
public sealed class GClass917
{
	// Token: 0x17000B06 RID: 2822
	// (get) Token: 0x0600456B RID: 17771 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600456C RID: 17772 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass917.GStruct70> currentBallisticData
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x17000B07 RID: 2823
	// (get) Token: 0x0600456D RID: 17773 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600456E RID: 17774 RVA: 0x00002050 File Offset: 0x00000250
	public List<GClass917.GStruct71> currentMeasurementData
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x0600456F RID: 17775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass917 getInstance()
	{
		throw null;
	}

	// Token: 0x06004570 RID: 17776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<GClass917.GStruct70> method_0(int shootingHeight, int shootingRangeLimit, GClass917.GStruct69 ammo)
	{
		throw null;
	}

	// Token: 0x06004571 RID: 17777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private List<GClass917.GStruct71> method_1(List<GClass917.GStruct70> trajectory, int step, int height)
	{
		throw null;
	}

	// Token: 0x06004572 RID: 17778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Calculate(int shootingHeight, int shootingRangeLimit, int measurementStep, GClass917.GStruct69 ammo)
	{
		throw null;
	}

	// Token: 0x0400501E RID: 20510
	private static GClass917 gclass917_0;

	// Token: 0x0400501F RID: 20511
	[CompilerGenerated]
	private List<GClass917.GStruct70> list_0;

	// Token: 0x04005020 RID: 20512
	[CompilerGenerated]
	private List<GClass917.GStruct71> list_1;

	// Token: 0x02000C98 RID: 3224
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct69
	{
		// Token: 0x04005021 RID: 20513
		public float StartVelocity;

		// Token: 0x04005022 RID: 20514
		public float BulletMassGram;

		// Token: 0x04005023 RID: 20515
		public float BulletDiameterMilimeters;

		// Token: 0x04005024 RID: 20516
		public float BallisticCoefficientG1;
	}

	// Token: 0x02000C99 RID: 3225
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct70
	{
		// Token: 0x04005025 RID: 20517
		public Vector3 Position;

		// Token: 0x04005026 RID: 20518
		public Vector3 Velocity;
	}

	// Token: 0x02000C9A RID: 3226
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct71
	{
		// Token: 0x04005027 RID: 20519
		public float Distance;

		// Token: 0x04005028 RID: 20520
		public float Velocity;

		// Token: 0x04005029 RID: 20521
		public float Drop;
	}
}
