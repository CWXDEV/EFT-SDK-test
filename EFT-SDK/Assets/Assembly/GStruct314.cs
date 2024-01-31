using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020020A3 RID: 8355
[StructLayout(LayoutKind.Auto)]
public struct GStruct314
{
	// Token: 0x0600AD2F RID: 44335 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override string ToString()
	{
		throw null;
	}

	// Token: 0x0400B331 RID: 45873
	public static readonly GStruct314 ALIVE_PACKET;

	// Token: 0x0400B332 RID: 45874
	public static readonly string KILLED_STATUS;

	// Token: 0x0400B333 RID: 45875
	public static readonly string DIED_STATUS;

	// Token: 0x0400B334 RID: 45876
	public bool IsAlive;

	// Token: 0x0400B335 RID: 45877
	public int InventoryHashSum;

	// Token: 0x0400B336 RID: 45878
	public double Time;

	// Token: 0x0400B337 RID: 45879
	public string AccountId;

	// Token: 0x0400B338 RID: 45880
	public string ProfileId;

	// Token: 0x0400B339 RID: 45881
	public string Nickname;

	// Token: 0x0400B33A RID: 45882
	public int Side;

	// Token: 0x0400B33B RID: 45883
	public string Status;

	// Token: 0x0400B33C RID: 45884
	public string KillerAccountId;

	// Token: 0x0400B33D RID: 45885
	public string KillerProfileId;

	// Token: 0x0400B33E RID: 45886
	public string KillerName;

	// Token: 0x0400B33F RID: 45887
	public int Level;

	// Token: 0x0400B340 RID: 45888
	public string WeaponName;

	// Token: 0x0400B341 RID: 45889
	public GStruct315 CorpseImpulse;
}
