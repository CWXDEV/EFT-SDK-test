using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.UI.Screens;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B87 RID: 11143
	public sealed class MerchantsList : UIScreen
	{
		// Token: 0x0600DC03 RID: 56323 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IEnumerable<TraderClass> tradersList, AbstractQuestControllerClass questController, InventoryControllerClass inventoryController, IHealthController healthController, ISession session, Profile profile)
		{
			throw null;
		}

		// Token: 0x0600DC04 RID: 56324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DC05 RID: 56325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0600DC06 RID: 56326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DC07 RID: 56327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(TraderClass trader, TraderPanel traderPanel)
		{
			throw null;
		}

		// Token: 0x0400E001 RID: 57345
		[SerializeField]
		private RectTransform _tradersContainer;

		// Token: 0x0400E002 RID: 57346
		[SerializeField]
		private TraderTooltip _tooltip;

		// Token: 0x0400E003 RID: 57347
		[SerializeField]
		private TraderPanel _traderPanelTemplate;

		// Token: 0x0400E004 RID: 57348
		private TraderClass gclass2046_0;

		// Token: 0x0400E005 RID: 57349
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400E006 RID: 57350
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E007 RID: 57351
		private IHealthController ihealthController_0;

		// Token: 0x0400E008 RID: 57352
		private Profile profile_0;

		// Token: 0x0400E009 RID: 57353
		private ISession ginterface145_0;

		// Token: 0x0400E00A RID: 57354
		private IEnumerable<TraderClass> ienumerable_0;

		// Token: 0x02002B88 RID: 11144
		[CompilerGenerated]
		private sealed class Class2639
		{
			// Token: 0x0600DC09 RID: 56329 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E00B RID: 57355
			public TraderClass trader;

			// Token: 0x0400E00C RID: 57356
			public MerchantsList merchantsList_0;
		}
	}
}
