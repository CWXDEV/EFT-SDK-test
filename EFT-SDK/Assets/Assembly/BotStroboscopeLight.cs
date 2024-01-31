using System;
using System.Runtime.CompilerServices;

// Token: 0x020002CA RID: 714
public class BotStroboscopeLight : GClass362
{
	// Token: 0x06000EE3 RID: 3811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableFor(float period)
	{
		throw null;
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x04000E6C RID: 3692
	private bool _canUse;

	// Token: 0x04000E6D RID: 3693
	private bool _switcher;

	// Token: 0x04000E6E RID: 3694
	private bool _enabled;

	// Token: 0x04000E6F RID: 3695
	private float _nextSwitch;

	// Token: 0x04000E70 RID: 3696
	private float _endTotal;

	// Token: 0x04000E71 RID: 3697
	private BotLight _light;

	// Token: 0x04000E72 RID: 3698
	private const float SWITCH_PERIOD = 0.1f;
}
