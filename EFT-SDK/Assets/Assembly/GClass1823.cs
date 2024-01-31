using System;
using System.Runtime.CompilerServices;
using EFT;
using EFT.Hideout;
using Newtonsoft.Json;

// Token: 0x0200178A RID: 6026
public sealed class GClass1823 : ISerializer<Stage>
{
	// Token: 0x060080A5 RID: 32933 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Stage Deserialize()
	{
		throw null;
	}

	// Token: 0x060080A6 RID: 32934 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public object Serialize(Stage stage)
	{
		throw null;
	}

	// Token: 0x04008958 RID: 35160
	[JsonProperty("requirements")]
	public Requirement[] Requirements;

	// Token: 0x04008959 RID: 35161
	[JsonProperty("bonuses")]
	public GClass1404[] Bonuses;

	// Token: 0x0400895A RID: 35162
	[JsonProperty("constructionTime")]
	public float ConstructionTime;

	// Token: 0x0400895B RID: 35163
	[JsonProperty("boost")]
	public Requirement[] Boost;

	// Token: 0x0400895C RID: 35164
	[JsonProperty("fuelSupply")]
	public HideoutControllerClass[] FuelSupply;

	// Token: 0x0400895D RID: 35165
	[JsonProperty("improvements")]
	public GClass1908[] Improvements;

	// Token: 0x0400895E RID: 35166
	[JsonProperty("startTime")]
	public double StartTime;

	// Token: 0x0400895F RID: 35167
	[JsonProperty("autoUpgrade")]
	public bool AutoUpgrade;

	// Token: 0x04008960 RID: 35168
	[JsonProperty("displayInterface")]
	public bool DisplayInterface;
}
