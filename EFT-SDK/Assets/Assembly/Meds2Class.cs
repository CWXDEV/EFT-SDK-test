using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x020023B5 RID: 9141
public class Meds2Class : ItemTemplate, GInterface289, GInterface290, GInterface296
{
	// Token: 0x17002033 RID: 8243
	// (get) Token: 0x0600B890 RID: 47248 RVA: 0x00002050 File Offset: 0x00000250
	float GInterface290.UseTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002034 RID: 8244
	// (get) Token: 0x0600B891 RID: 47249 RVA: 0x00002050 File Offset: 0x00000250
	KeyValuePair<EBodyPart, float>[] GInterface290.BodyPartTimeMults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002035 RID: 8245
	// (get) Token: 0x0600B892 RID: 47250 RVA: 0x00002050 File Offset: 0x00000250
	Dictionary<EHealthFactorType, GClass1233> GInterface290.HealthEffects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002036 RID: 8246
	// (get) Token: 0x0600B893 RID: 47251 RVA: 0x00002050 File Offset: 0x00000250
	Dictionary<EDamageEffectType, GClass1232> GInterface290.DamageEffects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002037 RID: 8247
	// (get) Token: 0x0600B894 RID: 47252 RVA: 0x00002050 File Offset: 0x00000250
	string GInterface289.StimulatorBuffs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002038 RID: 8248
	// (get) Token: 0x0600B895 RID: 47253 RVA: 0x00002050 File Offset: 0x00000250
	int GInterface296.MaxHpResource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17002039 RID: 8249
	// (get) Token: 0x0600B896 RID: 47254 RVA: 0x00002050 File Offset: 0x00000250
	float GInterface296.HpResourceRate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400BB79 RID: 47993
	[JsonProperty("medUseTime")]
	public float UseTime;

	// Token: 0x0400BB7A RID: 47994
	[JsonProperty("bodyPartTimeMults")]
	public KeyValuePair<EBodyPart, float>[] BodyPartTimeMults;

	// Token: 0x0400BB7B RID: 47995
	[JsonProperty("effects_health")]
	public Dictionary<EHealthFactorType, GClass1233> HealthEffects;

	// Token: 0x0400BB7C RID: 47996
	[JsonProperty("effects_damage")]
	public Dictionary<EDamageEffectType, GClass1232> DamageEffects;

	// Token: 0x0400BB7D RID: 47997
	public string StimulatorBuffs;

	// Token: 0x0400BB7E RID: 47998
	[JsonProperty("MaxHpResource")]
	public int MaxHpResource;

	// Token: 0x0400BB7F RID: 47999
	[JsonProperty("hpResourceRate")]
	public float HpResourceRate;
}
