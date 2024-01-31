using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InventoryLogic;
using Newtonsoft.Json;

// Token: 0x0200236A RID: 9066
public class GClass2602 : ItemTemplate, GInterface287, GInterface289, GInterface290
{
	// Token: 0x17001F89 RID: 8073
	// (get) Token: 0x0600B6BD RID: 46781 RVA: 0x00002050 File Offset: 0x00000250
	float GInterface287.MaxResource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F8A RID: 8074
	// (get) Token: 0x0600B6BE RID: 46782 RVA: 0x00002050 File Offset: 0x00000250
	float GInterface290.UseTime
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F8B RID: 8075
	// (get) Token: 0x0600B6BF RID: 46783 RVA: 0x00002050 File Offset: 0x00000250
	KeyValuePair<EBodyPart, float>[] GInterface290.BodyPartTimeMults
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F8C RID: 8076
	// (get) Token: 0x0600B6C0 RID: 46784 RVA: 0x00002050 File Offset: 0x00000250
	Dictionary<EHealthFactorType, GClass1233> GInterface290.HealthEffects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F8D RID: 8077
	// (get) Token: 0x0600B6C1 RID: 46785 RVA: 0x00002050 File Offset: 0x00000250
	Dictionary<EDamageEffectType, GClass1232> GInterface290.DamageEffects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17001F8E RID: 8078
	// (get) Token: 0x0600B6C2 RID: 46786 RVA: 0x00002050 File Offset: 0x00000250
	string GInterface289.StimulatorBuffs
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0400BA51 RID: 47697
	public float MaxResource;

	// Token: 0x0400BA52 RID: 47698
	[JsonProperty("foodUseTime")]
	public int UseTime;

	// Token: 0x0400BA53 RID: 47699
	[JsonProperty("effects_health")]
	public Dictionary<EHealthFactorType, GClass1233> HealthEffects;

	// Token: 0x0400BA54 RID: 47700
	[JsonProperty("effects_damage")]
	public Dictionary<EDamageEffectType, GClass1232> DamageEffects;

	// Token: 0x0400BA55 RID: 47701
	public string StimulatorBuffs;
}
