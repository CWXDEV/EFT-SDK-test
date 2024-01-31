using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;

namespace EFT.Quests
{
	// Token: 0x02002FE7 RID: 12263
	public sealed class ConditionHandoverItem : ConditionItem, GInterface380
	{
		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600F1EB RID: 61931 RVA: 0x00002050 File Offset: 0x00000250
		public override string FormattedDescription
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600F1EC RID: 61932 RVA: 0x00002050 File Offset: 0x00000250
		private string LocalizationActionKey
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F1ED RID: 61933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GClass1223[] ConvertToHandoverItems(Item[] items)
		{
			throw null;
		}

		// Token: 0x0600F1EE RID: 61934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private string GenerateDescription()
		{
			throw null;
		}

		// Token: 0x02002FE8 RID: 12264
		private enum ETagHandoverTypes
		{
			// Token: 0x0400F7F1 RID: 63473
			Item,
			// Token: 0x0400F7F2 RID: 63474
			OnlyFoundInRaid,
			// Token: 0x0400F7F3 RID: 63475
			Durability,
			// Token: 0x0400F7F4 RID: 63476
			DurabilityStrict,
			// Token: 0x0400F7F5 RID: 63477
			IsEncoded
		}
	}
}
