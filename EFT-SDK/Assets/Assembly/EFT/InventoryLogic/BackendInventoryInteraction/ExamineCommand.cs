using System;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace EFT.InventoryLogic.BackendInventoryInteraction
{
	// Token: 0x02002598 RID: 9624
	[Serializable]
	public sealed class ExamineCommand : GClass2830, ICommandWithItem
	{
		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600C007 RID: 49159 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C008 RID: 49160 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public string ItemTemplate
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0400C1FC RID: 49660
		[JsonProperty("Action")]
		public string Action;

		// Token: 0x0400C1FD RID: 49661
		[JsonProperty("item")]
		public string Item;
	}
}
