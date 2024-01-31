using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001BBD RID: 7101
	public sealed class SkillRequirementPanel : UIElement, IDisposable, GInterface172, IUIView
	{
		// Token: 0x06009521 RID: 38177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment)
		{
			throw null;
		}

		// Token: 0x06009522 RID: 38178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009BE7 RID: 39911
		private const string string_0 = "Required skill <b>{0}</b>, level <b>{1}</b>";

		// Token: 0x04009BE8 RID: 39912
		[SerializeField]
		private SkillRequirementIcon _skillIcon;

		// Token: 0x04009BE9 RID: 39913
		[SerializeField]
		private RequirementFulfilledStatus _fulfilledStatus;

		// Token: 0x04009BEA RID: 39914
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x02001BBE RID: 7102
		[CompilerGenerated]
		private sealed class Class1679
		{
			// Token: 0x06009523 RID: 38179 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(bool hover, PointerEventData eventData)
			{
				throw null;
			}

			// Token: 0x06009524 RID: 38180 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x04009BEB RID: 39915
			public SkillRequirement skillRequirement;

			// Token: 0x04009BEC RID: 39916
			public SkillRequirementPanel skillRequirementPanel_0;

			// Token: 0x04009BED RID: 39917
			public bool ignoreFulfillment;
		}
	}
}
