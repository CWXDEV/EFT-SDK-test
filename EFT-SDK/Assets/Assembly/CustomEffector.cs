using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Animations;
using UnityEngine;

// Token: 0x02000908 RID: 2312
[Serializable]
public class CustomEffector : IEffector
{
	// Token: 0x06003452 RID: 13394 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateActivityTime()
	{
		throw null;
	}

	// Token: 0x170008EF RID: 2287
	// (get) Token: 0x06003453 RID: 13395 RVA: 0x00002050 File Offset: 0x00000250
	public Vector3 Offset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize(PlayerSpring playerSpring)
	{
		throw null;
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Process(float intensity)
	{
		throw null;
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ProcessRestPose()
	{
		throw null;
	}

	// Token: 0x170008F0 RID: 2288
	// (set) Token: 0x06003457 RID: 13399 RVA: 0x00002050 File Offset: 0x00000250
	public bool Aim
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string DebugOutput()
	{
		throw null;
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x040034D2 RID: 13522
	private bool _inited;

	// Token: 0x040034D3 RID: 13523
	public WalkPreset AimPose;

	// Token: 0x040034D4 RID: 13524
	public float RestTransitionSpeed;

	// Token: 0x040034D5 RID: 13525
	public float RestDelay;

	// Token: 0x040034D6 RID: 13526
	public AnimVal RestValues;

	// Token: 0x040034D7 RID: 13527
	public GClass2210[] _aimPose;

	// Token: 0x040034D8 RID: 13528
	private GClass2210 _restProcessor;

	// Token: 0x040034D9 RID: 13529
	private float _lastActivityTime;

	// Token: 0x040034DA RID: 13530
	private float _initAimRotation;

	// Token: 0x040034DB RID: 13531
	public Player.ValueBlender PoseBlender;

	// Token: 0x040034DC RID: 13532
	private float _poseNormalTime;

	// Token: 0x040034DD RID: 13533
	private float _aimTarget;

	// Token: 0x02000909 RID: 2313
	[CompilerGenerated]
	[Serializable]
	private sealed class Class483
	{
		// Token: 0x0600345A RID: 13402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GClass2210 method_0(AnimVal c)
		{
			throw null;
		}

		// Token: 0x040034DE RID: 13534
		public static readonly CustomEffector.Class483 class483_0;

		// Token: 0x040034DF RID: 13535
		public static Func<AnimVal, GClass2210> func_0;
	}
}
