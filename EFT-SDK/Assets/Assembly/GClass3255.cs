using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT;
using EFT.Quests;
using Newtonsoft.Json;
using UnityEngine;

// Token: 0x02003089 RID: 12425
public class GClass3255
{
	// Token: 0x170029DA RID: 10714
	// (get) Token: 0x0600F3B5 RID: 62389 RVA: 0x00002050 File Offset: 0x00000250
	public string Title
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170029DB RID: 10715
	// (get) Token: 0x0600F3B6 RID: 62390 RVA: 0x00002050 File Offset: 0x00000250
	public string Description
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F3B7 RID: 62391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Sprite LoadIconSprite(GInterface144 session, Callback<Sprite> callback = null)
	{
		throw null;
	}

	// Token: 0x0400F9FF RID: 63999
	[JsonProperty("index")]
	public int Index;

	// Token: 0x0400FA00 RID: 64000
	[JsonProperty("id")]
	public string Id;

	// Token: 0x0400FA01 RID: 64001
	[JsonProperty("imageUrl")]
	public string ImageUrl;

	// Token: 0x0400FA02 RID: 64002
	[JsonProperty("assetPath")]
	public string AssetPath;

	// Token: 0x0400FA03 RID: 64003
	[JsonProperty("hidden")]
	public bool Hidden;

	// Token: 0x0400FA04 RID: 64004
	[JsonProperty("showConditions")]
	public bool ShowConditions;

	// Token: 0x0400FA05 RID: 64005
	[JsonProperty("progressBarEnabled")]
	public bool ShowProgressBar;

	// Token: 0x0400FA06 RID: 64006
	[JsonProperty("rewards")]
	public Dictionary<EQuestStatus, List<GClass3244>> Rewards;

	// Token: 0x0400FA07 RID: 64007
	[JsonProperty("conditions")]
	public GClass3220 Conditions;

	// Token: 0x0400FA08 RID: 64008
	[JsonProperty("showProgress")]
	public bool ShowProgress;

	// Token: 0x0400FA09 RID: 64009
	[JsonProperty("rarity")]
	public EAchievementRarity Rarity;

	// Token: 0x0400FA0A RID: 64010
	[JsonProperty("side")]
	public ETaskPlayerSide PlayerSide;

	// Token: 0x0400FA0B RID: 64011
	public float GlobalProgress;

	// Token: 0x0200308A RID: 12426
	[CompilerGenerated]
	private sealed class Class3128
	{
		// Token: 0x0600F3B8 RID: 62392 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Result<Texture2D> result)
		{
			throw null;
		}

		// Token: 0x0400FA0C RID: 64012
		public Sprite sprite;

		// Token: 0x0400FA0D RID: 64013
		public Callback<Sprite> callback;
	}
}
