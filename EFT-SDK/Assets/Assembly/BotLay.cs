using System;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020002C7 RID: 711
public class BotLay : GClass362
{
	// Token: 0x14000021 RID: 33
	// (add) Token: 0x06000EB6 RID: 3766 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x06000EB7 RID: 3767 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnLay
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x170003A7 RID: 935
	// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsLay
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170003A8 RID: 936
	// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanProne
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DelayPosibleLayFor(float period)
	{
		throw null;
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLayByPeriod()
	{
		throw null;
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool TryLay()
	{
		throw null;
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanShootPos([CanBeNull] EnemyInfo goalEnemy, bool withCheckShoot, bool withFriendlyFire)
	{
		throw null;
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanShootPos(Vector3 goalEnemy, bool withCheckShoot, bool withFriendlyFire)
	{
		throw null;
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void GetUp(bool withCheck)
	{
		throw null;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CheckGetUp()
	{
		throw null;
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Damaged()
	{
		throw null;
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckDistGood()
	{
		throw null;
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanLayWithoutCheck()
	{
		throw null;
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(ECantRotate cause)
	{
		throw null;
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000E52 RID: 3666
	public const float LAY_SHOOT_HEIGHT = 0.14f;

	// Token: 0x04000E53 RID: 3667
	private int _damageTimes;

	// Token: 0x04000E54 RID: 3668
	private float _layTime;

	// Token: 0x04000E55 RID: 3669
	private float _nextAttackCheckCanLay;

	// Token: 0x04000E56 RID: 3670
	private float _nextPosibleCheckCanLay;

	// Token: 0x04000E57 RID: 3671
	private float _nextPosibleGetUp;

	// Token: 0x04000E58 RID: 3672
	private readonly float _tan;

	// Token: 0x04000E59 RID: 3673
	private readonly MovementContext _movementContext;

	// Token: 0x04000E5A RID: 3674
	private float _endPeriodNoCheck;
}
