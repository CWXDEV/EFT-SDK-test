using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000463 RID: 1123
public class BotPeaceLook : GClass362
{
	// Token: 0x06001B13 RID: 6931 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartLook(GClass346 closest)
	{
		throw null;
	}

	// Token: 0x06001B14 RID: 6932 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartLook(IPlayer lookTo)
	{
		throw null;
	}

	// Token: 0x06001B15 RID: 6933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HaveActions()
	{
		throw null;
	}

	// Token: 0x06001B16 RID: 6934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EndAim()
	{
		throw null;
	}

	// Token: 0x06001B17 RID: 6935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Activate()
	{
		throw null;
	}

	// Token: 0x06001B18 RID: 6936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06001B19 RID: 6937 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void TryAddRequest(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06001B1A RID: 6938 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(bool isPeace)
	{
		throw null;
	}

	// Token: 0x06001B1B RID: 6939 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x04001732 RID: 5938
	private const float AIM_SDIST_REPLY = 400f;

	// Token: 0x04001733 RID: 5939
	private const float STANDARD_LOOK_PERIOD = 3f;

	// Token: 0x04001734 RID: 5940
	private const float STANDARD_AIM_REQUEST_CHANCE_100 = 50f;

	// Token: 0x04001735 RID: 5941
	private bool _doing;

	// Token: 0x04001736 RID: 5942
	private IPlayer _lookTo;

	// Token: 0x04001737 RID: 5943
	private float _aimEndTime;
}
