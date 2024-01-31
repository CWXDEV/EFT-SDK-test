using System;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F34 RID: 7988
public class GClass2227 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x0600A53D RID: 42301 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2227 CreateInstance()
	{
		throw null;
	}

	// Token: 0x17001B2C RID: 6956
	// (get) Token: 0x0600A53E RID: 42302 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A53F RID: 42303 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A540 RID: 42304 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A541 RID: 42305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetEffectTypeForChange(out GClass2227.EHealthEffectType effectType, IEffect healthEffect)
	{
		throw null;
	}

	// Token: 0x0600A542 RID: 42306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A543 RID: 42307 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400AD1F RID: 44319
	public GClass2227.EHealthEffectType ChangedEffectType;

	// Token: 0x0400AD20 RID: 44320
	public bool IsActive;

	// Token: 0x02001F35 RID: 7989
	public enum EHealthEffectType
	{
		// Token: 0x0400AD22 RID: 44322
		None,
		// Token: 0x0400AD23 RID: 44323
		HeavyBleeding,
		// Token: 0x0400AD24 RID: 44324
		Fracture
	}
}
