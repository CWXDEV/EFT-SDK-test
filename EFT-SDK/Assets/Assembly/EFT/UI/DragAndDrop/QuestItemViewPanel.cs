using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.Quests;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E3A RID: 11834
	public sealed class QuestItemViewPanel : UIElement
	{
		// Token: 0x0600E99D RID: 59805 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E99E RID: 59806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile profile, Item item, [CanBeNull] SimpleTooltip tooltip)
		{
			throw null;
		}

		// Token: 0x0600E99F RID: 59807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private QuestItemViewPanel.EPanelViewType method_0(Profile profile, Item item)
		{
			throw null;
		}

		// Token: 0x0600E9A0 RID: 59808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_0(IEnumerable<QuestDataClass> quests, Item item, out RawQuestClass questWithItem, out ConditionItem conditionItem)
		{
			throw null;
		}

		// Token: 0x0600E9A1 RID: 59809 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600E9A2 RID: 59810 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0400EE31 RID: 60977
		private const string string_0 = "Item found in raid";

		// Token: 0x0400EE32 RID: 60978
		private const string string_1 = "QUEST ITEM";

		// Token: 0x0400EE33 RID: 60979
		private const string string_2 = "Item is related to an active {0} quest";

		// Token: 0x0400EE34 RID: 60980
		private const string string_3 = "Item fits the active {0} quest requirements";

		// Token: 0x0400EE35 RID: 60981
		private const string string_4 = "Item that has been found in raid for the {0} quest";

		// Token: 0x0400EE36 RID: 60982
		[SerializeField]
		private Image _questIconImage;

		// Token: 0x0400EE37 RID: 60983
		[SerializeField]
		private Sprite _questItemSprite;

		// Token: 0x0400EE38 RID: 60984
		[SerializeField]
		private Sprite _foundInRaidSprite;

		// Token: 0x0400EE39 RID: 60985
		[SerializeField]
		private TextMeshProUGUI _questItemLabel;

		// Token: 0x0400EE3A RID: 60986
		[CanBeNull]
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400EE3B RID: 60987
		private string string_5;

		// Token: 0x02002E3B RID: 11835
		private enum EPanelViewType
		{
			// Token: 0x0400EE3D RID: 60989
			None,
			// Token: 0x0400EE3E RID: 60990
			Quest,
			// Token: 0x0400EE3F RID: 60991
			QuestFoundInRaid,
			// Token: 0x0400EE40 RID: 60992
			FoundInRaid
		}
	}
}
