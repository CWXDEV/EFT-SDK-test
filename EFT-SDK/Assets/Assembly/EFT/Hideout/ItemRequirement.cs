using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using Newtonsoft.Json;

namespace EFT.Hideout
{
	// Token: 0x02001BC6 RID: 7110
	[Serializable]
	public class ItemRequirement : Requirement, IExchangeRequirement
	{
		// Token: 0x170016FC RID: 5884
		// (get) Token: 0x0600953F RID: 38207 RVA: 0x00002050 File Offset: 0x00000250
		public override ERequirementType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016FD RID: 5885
		// (get) Token: 0x06009540 RID: 38208 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009541 RID: 38209 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("templateId")]
		public string TemplateId
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

		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x06009542 RID: 38210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009543 RID: 38211 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("count")]
		public int BaseCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x00002050 File Offset: 0x00000250
		public double PreciseCount
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x06009545 RID: 38213 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009546 RID: 38214 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("isFunctional")]
		public bool OnlyFunctional
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

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x06009547 RID: 38215 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009548 RID: 38216 RVA: 0x00002050 File Offset: 0x00000250
		[JsonProperty("isEncoded")]
		public bool IsEncoded
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

		// Token: 0x17001702 RID: 5890
		// (get) Token: 0x06009549 RID: 38217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600954A RID: 38218 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public int UserItemsCount
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

		// Token: 0x17001703 RID: 5891
		// (get) Token: 0x0600954B RID: 38219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600954C RID: 38220 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public int IntCount
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

		// Token: 0x17001704 RID: 5892
		// (get) Token: 0x0600954D RID: 38221 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public Item Item
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001705 RID: 5893
		// (get) Token: 0x0600954E RID: 38222 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public string ItemName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001706 RID: 5894
		// (set) Token: 0x0600954F RID: 38223 RVA: 0x00002050 File Offset: 0x00000250
		public float CountModifier
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsSuitableItem(Item item)
		{
			throw null;
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Retest()
		{
			throw null;
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Test(IEnumerable<Item> value)
		{
			throw null;
		}

		// Token: 0x04009C0B RID: 39947
		private int _notEmptyCompoundItems;

		// Token: 0x04009C0C RID: 39948
		private Item _item;

		// Token: 0x04009C12 RID: 39954
		private int _baseCount;
	}
}
