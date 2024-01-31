using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200046A RID: 1130
public abstract class GClass441 : GClass362
{
	// Token: 0x170004DC RID: 1244
	// (get) Token: 0x06001B44 RID: 6980 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00002050 File Offset: 0x00000250
	public bool Complete
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

	// Token: 0x170004DD RID: 1245
	// (get) Token: 0x06001B46 RID: 6982 RVA: 0x00002050 File Offset: 0x00000250
	public CustomNavigationPoint PointToSuppressFrom
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06001B47 RID: 6983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float Delta()
	{
		throw null;
	}

	// Token: 0x06001B48 RID: 6984
	public abstract void Activate();

	// Token: 0x06001B49 RID: 6985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_0(EnemyInfo enemyToSupress, CustomNavigationPoint pos = null)
	{
		throw null;
	}

	// Token: 0x06001B4A RID: 6986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool method_1(Vector3 posToShoot, CustomNavigationPoint pos = null)
	{
		throw null;
	}

	// Token: 0x06001B4B RID: 6987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual Vector3? GetPoint()
	{
		throw null;
	}

	// Token: 0x06001B4C RID: 6988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void method_2(float delta)
	{
		throw null;
	}

	// Token: 0x06001B4D RID: 6989
	public abstract void Dispose();

	// Token: 0x04001751 RID: 5969
	protected bool bool_0;

	// Token: 0x04001752 RID: 5970
	protected CustomNavigationPoint customNavigationPoint_0;

	// Token: 0x04001753 RID: 5971
	protected EnemyInfo enemyInfo_0;

	// Token: 0x04001754 RID: 5972
	private float float_0;

	// Token: 0x04001755 RID: 5973
	private Vector3? nullable_0;

	// Token: 0x04001756 RID: 5974
	protected float float_1;

	// Token: 0x04001757 RID: 5975
	[CompilerGenerated]
	private bool bool_1;
}
