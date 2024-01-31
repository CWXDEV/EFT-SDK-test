using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC4 RID: 7108
	[Serializable]
	public sealed class AreaRequirement : Requirement
	{
		// Token: 0x170016F9 RID: 5881
		// (get) Token: 0x0600953A RID: 38202 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600953B RID: 38203 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public AreaData AreaData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600953C RID: 38204 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(Dictionary<EAreaType, AreaData> areaData)
		{
			throw null;
		}

		// Token: 0x04009C08 RID: 39944
		[JsonProperty("areaType")]
		public EAreaType AreaType;

		// Token: 0x04009C09 RID: 39945
		[JsonProperty("requiredLevel")]
		public int RequiredLevel;
	}
}
