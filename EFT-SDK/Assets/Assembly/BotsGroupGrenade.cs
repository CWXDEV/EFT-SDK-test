using System;
using System.Runtime.CompilerServices;
using EFT;

// Token: 0x02000491 RID: 1169
public class BotsGroupGrenade
{
	// Token: 0x06001C23 RID: 7203 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ThrowGrenade(BotOwner thrower)
	{
		throw null;
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CanThrow()
	{
		throw null;
	}

	// Token: 0x040017D4 RID: 6100
	private int _throwCount;

	// Token: 0x040017D5 RID: 6101
	private const float STANDART_PERIOD = 2f;

	// Token: 0x040017D6 RID: 6102
	private const float START_PERIOD = 5f;

	// Token: 0x040017D7 RID: 6103
	private float _endThrow;
}
