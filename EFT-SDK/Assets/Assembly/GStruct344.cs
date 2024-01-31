using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.HealthSystem;

// Token: 0x020021F4 RID: 8692
[StructLayout(LayoutKind.Auto)]
public struct GStruct344
{
	// Token: 0x0600B1B7 RID: 45495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SaveInfo(int id, IHealthController hController, Type type, EBodyPart bodyPart, float strength, float currentStrength, float delayTime, float stateTime, float workStateTime, float buildUpTime, float residueStateTime, EEffectState state)
	{
		throw null;
	}

	// Token: 0x0400B61C RID: 46620
	public int ID;

	// Token: 0x0400B61D RID: 46621
	public IHealthController HealthController;

	// Token: 0x0400B61E RID: 46622
	public Type Type;

	// Token: 0x0400B61F RID: 46623
	public EBodyPart BodyPart;

	// Token: 0x0400B620 RID: 46624
	public float Strength;

	// Token: 0x0400B621 RID: 46625
	public float CurrentStrength;

	// Token: 0x0400B622 RID: 46626
	public float DelayTime;

	// Token: 0x0400B623 RID: 46627
	public float StateTime;

	// Token: 0x0400B624 RID: 46628
	public float WorkStateTime;

	// Token: 0x0400B625 RID: 46629
	public float BuildUpTime;

	// Token: 0x0400B626 RID: 46630
	public float ResidueStateTime;

	// Token: 0x0400B627 RID: 46631
	public int UpdateTime;

	// Token: 0x0400B628 RID: 46632
	public EEffectState State;
}
