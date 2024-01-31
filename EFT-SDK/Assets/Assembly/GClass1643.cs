using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine.Networking;

// Token: 0x020014CE RID: 5326
public class GClass1643
{
	// Token: 0x1700119A RID: 4506
	// (set) Token: 0x060071F7 RID: 29175 RVA: 0x00002050 File Offset: 0x00000250
	public bool Started
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x060071F8 RID: 29176 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate(float time)
	{
		throw null;
	}

	// Token: 0x060071F9 RID: 29177 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(float time, int rtt, int loss)
	{
		throw null;
	}

	// Token: 0x040078A8 RID: 30888
	private NetworkConnection networkConnection_0;

	// Token: 0x040078A9 RID: 30889
	private GClass1643.GDelegate57 gdelegate57_0;

	// Token: 0x040078AA RID: 30890
	private Class1120 class1120_0;

	// Token: 0x040078AB RID: 30891
	private Class1120 class1120_1;

	// Token: 0x020014CF RID: 5327
	// (Invoke) Token: 0x060071FA RID: 29178
	public delegate void GDelegate57(GClass1642 networkQualityParam, EDisconnectionCode disconnectionCode, float time, float period);
}
