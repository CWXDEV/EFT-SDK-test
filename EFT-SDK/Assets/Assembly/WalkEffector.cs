using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Animations;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x0200091E RID: 2334
[Serializable]
public class WalkEffector : IEffector
{
	// Token: 0x17000903 RID: 2307
	// (get) Token: 0x060034B2 RID: 13490 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060034B3 RID: 13491 RVA: 0x00002050 File Offset: 0x00000250
	public Transform Transform
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

	// Token: 0x17000904 RID: 2308
	// (get) Token: 0x060034B4 RID: 13492 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060034B5 RID: 13493 RVA: 0x00002050 File Offset: 0x00000250
	public float Speed
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060034B6 RID: 13494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x060034B7 RID: 13495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnStop()
	{
		throw null;
	}

	// Token: 0x060034B8 RID: 13496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float deltaTime)
	{
		throw null;
	}

	// Token: 0x060034B9 RID: 13497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x060034BA RID: 13498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AdjustPose()
	{
		throw null;
	}

	// Token: 0x04003595 RID: 13717
	public float StepFrequency;

	// Token: 0x04003596 RID: 13718
	public float Intensity;

	// Token: 0x04003597 RID: 13719
	public float SideSpeedMultyplyer;

	// Token: 0x04003598 RID: 13720
	public float BackSpeedMultyplyer;

	// Token: 0x04003599 RID: 13721
	public float Treshold;

	// Token: 0x0400359A RID: 13722
	private Vector3 _lastPosition;

	// Token: 0x0400359B RID: 13723
	private bool _isWalking;

	// Token: 0x0400359C RID: 13724
	public WalkPreset[] Presets;

	// Token: 0x0400359D RID: 13725
	[FormerlySerializedAs("CameraPresets")]
	public WalkPreset[] OverweightPresets;

	// Token: 0x0400359E RID: 13726
	public GClass2210[][] PresetProcessors;

	// Token: 0x0400359F RID: 13727
	public GClass2210[][] OverweightPresetProcessors;

	// Token: 0x040035A0 RID: 13728
	public Vector2[] IntensityMinMax;

	// Token: 0x040035A1 RID: 13729
	public float Overweight;

	// Token: 0x040035A2 RID: 13730
	public WalkEffector.EWalkPreset CurrentWalkPreset;

	// Token: 0x040035A3 RID: 13731
	private float _speed;

	// Token: 0x0200091F RID: 2335
	public enum EWalkPreset
	{
		// Token: 0x040035A5 RID: 13733
		normal,
		// Token: 0x040035A6 RID: 13734
		lame,
		// Token: 0x040035A7 RID: 13735
		sprint,
		// Token: 0x040035A8 RID: 13736
		duck
	}

	// Token: 0x02000920 RID: 2336
	[CompilerGenerated]
	[Serializable]
	private sealed class Class487
	{
		// Token: 0x060034BB RID: 13499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2210[] method_0(WalkPreset p)
		{
			throw null;
		}

		// Token: 0x060034BC RID: 13500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2210 method_1(AnimVal curve)
		{
			throw null;
		}

		// Token: 0x060034BD RID: 13501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2210[] method_2(WalkPreset p)
		{
			throw null;
		}

		// Token: 0x060034BE RID: 13502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2210 method_3(AnimVal curve)
		{
			throw null;
		}

		// Token: 0x060034BF RID: 13503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2210> method_4(GClass2210[] presets)
		{
			throw null;
		}

		// Token: 0x060034C0 RID: 13504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<GClass2210> method_5(GClass2210[] presets)
		{
			throw null;
		}

		// Token: 0x040035A9 RID: 13737
		public static readonly WalkEffector.Class487 class487_0;

		// Token: 0x040035AA RID: 13738
		public static Func<AnimVal, GClass2210> func_0;

		// Token: 0x040035AB RID: 13739
		public static Func<WalkPreset, GClass2210[]> func_1;

		// Token: 0x040035AC RID: 13740
		public static Func<AnimVal, GClass2210> func_2;

		// Token: 0x040035AD RID: 13741
		public static Func<WalkPreset, GClass2210[]> func_3;

		// Token: 0x040035AE RID: 13742
		public static Func<GClass2210[], IEnumerable<GClass2210>> func_4;

		// Token: 0x040035AF RID: 13743
		public static Func<GClass2210[], IEnumerable<GClass2210>> func_5;
	}
}
