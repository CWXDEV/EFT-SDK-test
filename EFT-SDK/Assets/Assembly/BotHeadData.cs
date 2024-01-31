using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020002C6 RID: 710
public class BotHeadData : GClass362
{
	// Token: 0x170003A6 RID: 934
	// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00002050 File Offset: 0x00000250
	private BotGlobalPatrolSettings BotGlobalPatrolSettings_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartRotate()
	{
		throw null;
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetRotateHead(Vector3 target, Vector3 lookDirection)
	{
		throw null;
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTargetRotateHead(float target)
	{
		throw null;
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetHeadActive(bool headActive)
	{
		throw null;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateDirection()
	{
		throw null;
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x04000E4B RID: 3659
	private Vector3 dir;

	// Token: 0x04000E4C RID: 3660
	private bool _headActive;

	// Token: 0x04000E4D RID: 3661
	private float _targetX;

	// Token: 0x04000E4E RID: 3662
	private float _curX;

	// Token: 0x04000E4F RID: 3663
	private float _nextHeadChange;

	// Token: 0x04000E50 RID: 3664
	private float _updatePointTimer;

	// Token: 0x04000E51 RID: 3665
	private EBotHeadDirection _dirType;
}
