using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000462 RID: 1122
public class BotPeaceHardAim : GClass362
{
	// Token: 0x06001B0A RID: 6922 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartAim(GClass346 closest)
	{
		throw null;
	}

	// Token: 0x06001B0B RID: 6923 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartAim(IPlayer lookTo)
	{
		throw null;
	}

	// Token: 0x06001B0C RID: 6924 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001B0D RID: 6925 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAim()
	{
		throw null;
	}

	// Token: 0x06001B0E RID: 6926 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001B0F RID: 6927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001B10 RID: 6928 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAddRequest(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001B11 RID: 6929 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool isPeace)
	{
		throw null;
	}

	// Token: 0x06001B12 RID: 6930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400172C RID: 5932
	private const float AIM_SDIST_REPLY = 400f;

	// Token: 0x0400172D RID: 5933
	private const float STANDARD_AIM_PERIOD = 7f;

	// Token: 0x0400172E RID: 5934
	private const float STANDARD_AIM_REQUEST_CHANCE_100 = 50f;

	// Token: 0x0400172F RID: 5935
	private bool _doing;

	// Token: 0x04001730 RID: 5936
	private IPlayer _lookTo;

	// Token: 0x04001731 RID: 5937
	private float _aimEndTime;
}
