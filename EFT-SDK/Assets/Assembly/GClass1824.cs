using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Hideout;
using Newtonsoft.Json;

// Token: 0x0200178B RID: 6027
public sealed class GClass1824 : ISerializer<AreaTemplate>
{
	// Token: 0x060080A7 RID: 32935 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AreaTemplate Deserialize()
	{
		throw null;
	}

	// Token: 0x060080A8 RID: 32936 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(AreaTemplate template)
	{
		throw null;
	}

	// Token: 0x04008961 RID: 35169
	[JsonProperty("_id")]
	public string Id;

	// Token: 0x04008962 RID: 35170
	[JsonProperty("type")]
	public int Type;

	// Token: 0x04008963 RID: 35171
	[JsonProperty("needsFuel")]
	public bool NeedsFuel;

	// Token: 0x04008964 RID: 35172
	[JsonProperty("craftGivesExp")]
	public bool CraftGivesExp;

	// Token: 0x04008965 RID: 35173
	[JsonProperty("takeFromSlotLocked")]
	public bool TakeFromSlotLocked;

	// Token: 0x04008966 RID: 35174
	[JsonProperty("requirements")]
	public Requirement[] Requirements;

	// Token: 0x04008967 RID: 35175
	[JsonProperty("stages")]
	public Dictionary<int, Stage> Stages;

	// Token: 0x04008968 RID: 35176
	[JsonProperty("enabled")]
	public bool Enabled;

	// Token: 0x04008969 RID: 35177
	[JsonProperty("displayLevel")]
	public bool DisplayLevel;

	// Token: 0x0400896A RID: 35178
	[JsonProperty("parentArea")]
	public string ParentAreaId;
}
