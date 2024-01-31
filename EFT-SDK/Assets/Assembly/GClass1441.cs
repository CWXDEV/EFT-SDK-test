using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using JetBrains.Annotations;

// Token: 0x020012AD RID: 4781
public class GClass1441
{
	// Token: 0x17001002 RID: 4098
	// (get) Token: 0x06006361 RID: 25441 RVA: 0x00002050 File Offset: 0x00000250
	public bool NeedToCheckAvailable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001003 RID: 4099
	// (get) Token: 0x06006362 RID: 25442 RVA: 0x00002050 File Offset: 0x00000250
	public GClass2933[] Templates
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001004 RID: 4100
	// (get) Token: 0x06006363 RID: 25443 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass2934> AvailableSuites
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001005 RID: 4101
	// (get) Token: 0x06006364 RID: 25444 RVA: 0x00002050 File Offset: 0x00000250
	public IEnumerable<GClass2937> Voices
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06006365 RID: 25445 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ResourceKey GetBundle(string templateId)
	{
		throw null;
	}

	// Token: 0x06006366 RID: 25446 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct380 GetWatchBundle(string templateId)
	{
		throw null;
	}

	// Token: 0x06006367 RID: 25447 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasIntegratedArmor(string templateId)
	{
		throw null;
	}

	// Token: 0x06006368 RID: 25448 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string GetBundleIdByPath(string path)
	{
		throw null;
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2933 GetItem(string templateId)
	{
		throw null;
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2934 GetSuite(string suiteId)
	{
		throw null;
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetAvailableSuites([CanBeNull] params string[] availableSuites)
	{
		throw null;
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsSuiteAvailable(string suiteId)
	{
		throw null;
	}

	// Token: 0x0600636D RID: 25453 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2932 GetAnyCustomizationItem(string id)
	{
		throw null;
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GClass2937 GetVoice(string id)
	{
		throw null;
	}

	// Token: 0x04006FFA RID: 28666
	private const float float_0 = 600f;

	// Token: 0x04006FFB RID: 28667
	private readonly Dictionary<string, GClass2933> dictionary_0;

	// Token: 0x04006FFC RID: 28668
	private readonly Dictionary<string, GClass2934> dictionary_1;

	// Token: 0x04006FFD RID: 28669
	private readonly Dictionary<string, GClass2937> dictionary_2;

	// Token: 0x04006FFE RID: 28670
	private readonly Dictionary<string, string> dictionary_3;

	// Token: 0x04006FFF RID: 28671
	private readonly HashSet<string> hashSet_0;

	// Token: 0x04007000 RID: 28672
	private float? nullable_0;
}
