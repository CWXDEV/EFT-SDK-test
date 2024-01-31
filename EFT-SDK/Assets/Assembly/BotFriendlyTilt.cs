using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x0200045D RID: 1117
public class BotFriendlyTilt : GClass362
{
	// Token: 0x06001AF6 RID: 6902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTilt(GClass346 closest)
	{
		throw null;
	}

	// Token: 0x06001AF7 RID: 6903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartTilt(IPlayer target)
	{
		throw null;
	}

	// Token: 0x06001AF8 RID: 6904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001AF9 RID: 6905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001AFA RID: 6906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndTilt()
	{
		throw null;
	}

	// Token: 0x06001AFB RID: 6907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001AFC RID: 6908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAddRequest(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001AFD RID: 6909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(Player player)
	{
		throw null;
	}

	// Token: 0x06001AFE RID: 6910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(bool isPeace)
	{
		throw null;
	}

	// Token: 0x06001AFF RID: 6911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001B00 RID: 6912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001716 RID: 5910
	private const float CHANCE_MUMBLE_TILT = 111f;

	// Token: 0x04001717 RID: 5911
	private const float PLAYER_ANSWER_PERIOD_AFTER_MAX = 6f;

	// Token: 0x04001718 RID: 5912
	private const int PLAYER_ANSWER_TIMES_MAX = 6;

	// Token: 0x04001719 RID: 5913
	private const float SIDE_TILT_PERIOD = 0.5f;

	// Token: 0x0400171A RID: 5914
	private const int TILT_LENGHT = 4;

	// Token: 0x0400171B RID: 5915
	private readonly float[] _times;

	// Token: 0x0400171C RID: 5916
	private bool prevTiltSide;

	// Token: 0x0400171D RID: 5917
	private int _tiltIndex;

	// Token: 0x0400171E RID: 5918
	private bool _tilting;

	// Token: 0x0400171F RID: 5919
	private IPlayer _lookTo;

	// Token: 0x04001720 RID: 5920
	private readonly Dictionary<IPlayer, BotFriendlyTilt.Class225> _timesRequests;

	// Token: 0x0200045E RID: 1118
	private class Class225
	{
		// Token: 0x04001721 RID: 5921
		public int Times;

		// Token: 0x04001722 RID: 5922
		public float LastTime;
	}
}
