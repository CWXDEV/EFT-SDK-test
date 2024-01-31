using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Counters;

// Token: 0x02001D44 RID: 7492
[StructLayout(LayoutKind.Auto)]
public readonly struct GStruct246
{
	// Token: 0x0400A238 RID: 41528
	public readonly string DescriptionKey;

	// Token: 0x0400A239 RID: 41529
	public readonly GStruct243 NextState;

	// Token: 0x0400A23A RID: 41530
	public readonly GStruct246.EDialogLiteIconType IconType;

	// Token: 0x0400A23B RID: 41531
	public readonly GStruct246.GStruct247? SaveState;

	// Token: 0x0400A23C RID: 41532
	public readonly GStruct246.GStruct247? SaveStateTrigger;

	// Token: 0x02001D45 RID: 7493
	public enum ESaveStateType
	{
		// Token: 0x0400A23E RID: 41534
		Profile,
		// Token: 0x0400A23F RID: 41535
		Global,
		// Token: 0x0400A240 RID: 41536
		Local
	}

	// Token: 0x02001D46 RID: 7494
	public enum EDialogLiteIconType
	{
		// Token: 0x0400A242 RID: 41538
		QuestionMark,
		// Token: 0x0400A243 RID: 41539
		QuestIcon,
		// Token: 0x0400A244 RID: 41540
		Suitcase,
		// Token: 0x0400A245 RID: 41541
		IndexFinger,
		// Token: 0x0400A246 RID: 41542
		CheckMark,
		// Token: 0x0400A247 RID: 41543
		OpenPalm,
		// Token: 0x0400A248 RID: 41544
		BackArrow,
		// Token: 0x0400A249 RID: 41545
		QuitIcon,
		// Token: 0x0400A24A RID: 41546
		DialogBubble,
		// Token: 0x0400A24B RID: 41547
		ShoppingCart,
		// Token: 0x0400A24C RID: 41548
		BtrItemsDeliveryService,
		// Token: 0x0400A24D RID: 41549
		PlayerTaxiService,
		// Token: 0x0400A24E RID: 41550
		BtrBotCoverIcon,
		// Token: 0x0400A24F RID: 41551
		ZryachiyAidIcon,
		// Token: 0x0400A250 RID: 41552
		ExUsecLoyaltyIcon,
		// Token: 0x0400A251 RID: 41553
		CultistsAidIcon
	}

	// Token: 0x02001D47 RID: 7495
	[StructLayout(LayoutKind.Auto)]
	public readonly struct GStruct247
	{
		// Token: 0x06009AF4 RID: 39668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Deconstruct(out CounterTag tag, out int value, out GStruct246.ESaveStateType type)
		{
			throw null;
		}

		// Token: 0x0400A252 RID: 41554
		public readonly CounterTag Tag;

		// Token: 0x0400A253 RID: 41555
		public readonly int Value;

		// Token: 0x0400A254 RID: 41556
		public readonly GStruct246.ESaveStateType Type;
	}
}
