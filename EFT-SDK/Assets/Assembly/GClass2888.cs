using System;
using System.Runtime.CompilerServices;

// Token: 0x0200262D RID: 9773
public class GClass2888 : GClass2885
{
	// Token: 0x170022A4 RID: 8868
	// (get) Token: 0x0600C223 RID: 49699 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2888.EZoneState ZoneState
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600C224 RID: 49700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Invoke(GClass2888.EZoneState zoneState)
	{
		throw null;
	}

	// Token: 0x0600C225 RID: 49701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Reset()
	{
		throw null;
	}

	// Token: 0x0400C3F0 RID: 50160
	private GClass2888.EZoneState ezoneState_0;

	// Token: 0x0200262E RID: 9774
	public enum EZoneState
	{
		// Token: 0x0400C3F2 RID: 50162
		None,
		// Token: 0x0400C3F3 RID: 50163
		Common,
		// Token: 0x0400C3F4 RID: 50164
		KickSoon,
		// Token: 0x0400C3F5 RID: 50165
		DisabledAfterZryachiyKilled,
		// Token: 0x0400C3F6 RID: 50166
		DisabledAfterPlayerKilled,
		// Token: 0x0400C3F7 RID: 50167
		TimeEndingWarning,
		// Token: 0x0400C3F8 RID: 50168
		CantShowTimeEndingWarning
	}
}
