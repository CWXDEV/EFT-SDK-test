using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.NextObservedPlayer;

// Token: 0x02001F6C RID: 8044
public class GClass2280 : IDisposable, GInterface218, GInterface219
{
	// Token: 0x17001B63 RID: 7011
	// (get) Token: 0x0600A680 RID: 42624 RVA: 0x00002050 File Offset: 0x00000250
	public CommandMessageType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600A681 RID: 42625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GInterface218 CreateInstance()
	{
		throw null;
	}

	// Token: 0x0600A682 RID: 42626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Serialize(GClass1078 writer)
	{
		throw null;
	}

	// Token: 0x0600A683 RID: 42627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Deserialize(GClass1073 reader)
	{
		throw null;
	}

	// Token: 0x0600A684 RID: 42628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GInterface218 CloneCommand()
	{
		throw null;
	}

	// Token: 0x0600A685 RID: 42629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400ADC5 RID: 44485
	public string AmmoForLoad;

	// Token: 0x0400ADC6 RID: 44486
	public bool ReloadFast;

	// Token: 0x0400ADC7 RID: 44487
	public int CurrentCamoraIndex;

	// Token: 0x0400ADC8 RID: 44488
	public int WeaponLevel;

	// Token: 0x0400ADC9 RID: 44489
	public bool InInventory;

	// Token: 0x0400ADCA RID: 44490
	public int AmmoInMag;

	// Token: 0x0400ADCB RID: 44491
	public int FreeCamorasCount;

	// Token: 0x0400ADCC RID: 44492
	public List<int> FreeCamoras;

	// Token: 0x0400ADCD RID: 44493
	public int ShellsCount;

	// Token: 0x0400ADCE RID: 44494
	public List<int> Shells;
}
