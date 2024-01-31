using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020002E2 RID: 738
public class BotTalk : GClass362
{
	// Token: 0x170003C4 RID: 964
	// (get) Token: 0x06000F9B RID: 3995 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsSilenced
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06000F9C RID: 3996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Say(EPhraseTrigger type, bool sayImmediately = false, ETagStatus? additionalMask = null)
	{
		throw null;
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrySay(EPhraseTrigger type)
	{
		throw null;
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrySay(EPhraseTrigger type, bool withGroupDelay)
	{
		throw null;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TrySay(EPhraseTrigger type, ETagStatus? additionaMask, bool withGroupDelay)
	{
		throw null;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private ETagStatus method_1(ETagStatus? additionaMask = null)
	{
		throw null;
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(EPhraseTrigger type, bool demand, float delay, ETagStatus mask)
	{
		throw null;
	}

	// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GClass457 method_3(GClass457 data, GClass457 tryToTalk)
	{
		throw null;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(EPhraseTrigger type)
	{
		throw null;
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetSilence(float period)
	{
		throw null;
	}

	// Token: 0x04000EE5 RID: 3813
	private const float QUERY_WAIT_TIME = 0.15f;

	// Token: 0x04000EE6 RID: 3814
	private float _nextCanSayTime;

	// Token: 0x04000EE7 RID: 3815
	private bool _haveSomeThingToSay;

	// Token: 0x04000EE8 RID: 3816
	private bool _canSay;

	// Token: 0x04000EE9 RID: 3817
	private float _endWaitQueryTime;

	// Token: 0x04000EEA RID: 3818
	private GClass457 _tryToTalk;

	// Token: 0x04000EEB RID: 3819
	private readonly Dictionary<EPhraseTrigger, float> _priority;

	// Token: 0x04000EEC RID: 3820
	private bool _isSilence;

	// Token: 0x04000EED RID: 3821
	private float _silenceEnds;
}
