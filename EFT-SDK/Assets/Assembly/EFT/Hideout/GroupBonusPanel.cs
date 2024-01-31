using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Comfort.Common;
using TMPro;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B76 RID: 7030
	public sealed class GroupBonusPanel : AbstractPanel<List<GClass1404>>
	{
		// Token: 0x06009410 RID: 37904 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(RelatedBonuses relatedBonuses, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session, IReadOnlyDictionary<ELevelType, string> localizationTexts)
		{
			throw null;
		}

		// Token: 0x06009411 RID: 37905 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override Task ShowContents()
		{
			throw null;
		}

		// Token: 0x06009412 RID: 37906 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetInfo()
		{
			throw null;
		}

		// Token: 0x06009413 RID: 37907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06009414 RID: 37908 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(ELightStatus status)
		{
			throw null;
		}

		// Token: 0x06009415 RID: 37909 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool state)
		{
			throw null;
		}

		// Token: 0x06009416 RID: 37910 RVA: 0x00002050 File Offset: 0x00000250
		[DebuggerHidden]
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_3(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryControllerClass inventoryController, ISession session)
		{
			throw null;
		}

		// Token: 0x06009417 RID: 37911 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private BonusPanel method_4(GClass1404 arg)
		{
			throw null;
		}

		// Token: 0x06009418 RID: 37912 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Transform method_5(GClass1404 arg)
		{
			throw null;
		}

		// Token: 0x06009419 RID: 37913 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(GClass1404 item, BonusPanel view)
		{
			throw null;
		}

		// Token: 0x04009ACF RID: 39631
		[SerializeField]
		private BonusesPanelSettings _settings;

		// Token: 0x04009AD0 RID: 39632
		[SerializeField]
		private BonusPanel _bonusPanel;

		// Token: 0x04009AD1 RID: 39633
		[SerializeField]
		private TextMeshProUGUI _bonusesLabel;

		// Token: 0x04009AD2 RID: 39634
		[SerializeField]
		private RectTransform _container;

		// Token: 0x04009AD3 RID: 39635
		private GClass3076<GClass1404, BonusPanel> gclass3076_0;

		// Token: 0x04009AD4 RID: 39636
		private IReadOnlyDictionary<ELevelType, string> ireadOnlyDictionary_0;

		// Token: 0x02001B78 RID: 7032
		[CompilerGenerated]
		private sealed class Class1664
		{
			// Token: 0x0600941C RID: 37916 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<Texture2D> result)
			{
				throw null;
			}

			// Token: 0x04009AE0 RID: 39648
			public BonusPanel view;
		}
	}
}
