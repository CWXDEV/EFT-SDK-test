using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC7 RID: 7111
	[Serializable]
	public sealed class ResourceRequirement : Requirement
	{
		// Token: 0x17001707 RID: 5895
		// (get) Token: 0x06009553 RID: 38227 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009C13 RID: 39955
		[JsonProperty("templateId")]
		public string TemplateId;

		// Token: 0x04009C14 RID: 39956
		[JsonProperty("resource")]
		public int Resource;
	}
}
