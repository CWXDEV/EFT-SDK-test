using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B9C RID: 7068
	public sealed class AreaRequirementPanel : AreaPanel, IDisposable, GInterface172, IUIView
	{
		// Token: 0x060094B9 RID: 38073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, Requirement requirement, EAreaType areaType, bool ignoreFulfillment)
		{
			throw null;
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetInfo()
		{
			throw null;
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x04009B86 RID: 39814
		[SerializeField]
		private Color _fulfilledColor;

		// Token: 0x04009B87 RID: 39815
		[SerializeField]
		private Color _failedColor;

		// Token: 0x04009B88 RID: 39816
		[SerializeField]
		private RequirementFulfilledStatus _fulfilledStatus;

		// Token: 0x04009B89 RID: 39817
		private AreaRequirement areaRequirement_0;

		// Token: 0x02001B9D RID: 7069
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1671
		{
			// Token: 0x060094BD RID: 38077 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(AreaPanel arg)
			{
				throw null;
			}

			// Token: 0x04009B8A RID: 39818
			public static readonly AreaRequirementPanel.Class1671 class1671_0;

			// Token: 0x04009B8B RID: 39819
			public static Action<AreaPanel> action_0;
		}
	}
}
