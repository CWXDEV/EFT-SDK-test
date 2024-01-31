using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x020002D1 RID: 721
public class BotReceiver : GClass362
{
	// Token: 0x06000EF8 RID: 3832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool CanReceiveFromPoint(Vector3 p, Vector3 from, Vector3 dir, float cos)
	{
		throw null;
	}

	// Token: 0x06000EF9 RID: 3833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06000EFA RID: 3834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(GClass595.GClass596 info)
	{
		throw null;
	}

	// Token: 0x06000EFB RID: 3835 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GClass595.GClass596 info, float distToCenter, float period)
	{
		throw null;
	}

	// Token: 0x06000EFC RID: 3836 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2(GClass595.GClass596 info)
	{
		throw null;
	}

	// Token: 0x06000EFD RID: 3837 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(IPlayer player, bool status)
	{
		throw null;
	}

	// Token: 0x06000EFE RID: 3838 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F00 RID: 3840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(GClass454 data)
	{
		throw null;
	}

	// Token: 0x06000F01 RID: 3841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_7(bool comandFromMyBoss, bool addVal)
	{
		throw null;
	}

	// Token: 0x06000F02 RID: 3842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06000F03 RID: 3843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04000E8E RID: 3726
	private const float BIG_SDIST = 10000f;

	// Token: 0x04000E8F RID: 3727
	private const float DELAY_FollowMe = 120f;

	// Token: 0x04000E90 RID: 3728
	private const float DELAY_GetInCover = 120f;

	// Token: 0x04000E91 RID: 3729
	private const float DELAY_NeedHelp = 120f;

	// Token: 0x04000E92 RID: 3730
	private const float DELAY_Silence = 120f;

	// Token: 0x04000E93 RID: 3731
	private const float DELAY_Spreadout = 120f;

	// Token: 0x04000E94 RID: 3732
	private const float DELAY_Stop = 120f;

	// Token: 0x04000E95 RID: 3733
	private const float MED_SDIST = 625f;

	// Token: 0x04000E96 RID: 3734
	private const float SMALL_SDIST = 100f;

	// Token: 0x04000E97 RID: 3735
	private const float STANDART_DELAY = 120f;

	// Token: 0x04000E98 RID: 3736
	private const float TALK_DELAY = 30f;

	// Token: 0x04000E99 RID: 3737
	private readonly GClass535<int, EPhraseTrigger, float> _nextPossibleUse;

	// Token: 0x04000E9A RID: 3738
	private readonly GClass535<int, EPhraseTrigger, bool> _foreverBlock;
}
