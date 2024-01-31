using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AF6 RID: 6902
	public abstract class ProduceViewBase<TItemsProducer, TProductionScheme> : UIElement, GInterface167 where TItemsProducer : GClass1912 where TProductionScheme : GClass1919
	{
		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x060091BD RID: 37309 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091BE RID: 37310 RVA: 0x00002050 File Offset: 0x00000250
		private bool GettingItems
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

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091C0 RID: 37312 RVA: 0x00002050 File Offset: 0x00000250
		private InventoryControllerClass InventoryController
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091C2 RID: 37314 RVA: 0x00002050 File Offset: 0x00000250
		private ItemUiContext ItemUiContext
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

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060091C3 RID: 37315 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091C4 RID: 37316 RVA: 0x00002050 File Offset: 0x00000250
		private TItemsProducer Producer
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

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060091C5 RID: 37317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091C6 RID: 37318 RVA: 0x00002050 File Offset: 0x00000250
		private TProductionScheme Scheme
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060091C7 RID: 37319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091C8 RID: 37320 RVA: 0x00002050 File Offset: 0x00000250
		private Action<string> OnStartProducing
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

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060091C9 RID: 37321 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060091CA RID: 37322 RVA: 0x00002050 File Offset: 0x00000250
		private Action<string> OnGetProducedItems
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060091CB RID: 37323
		protected abstract bool ShowItemsListWindow { get; }

		// Token: 0x060091CC RID: 37324 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void UpdateView()
		{
			throw null;
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show(ItemUiContext itemUiContext, InventoryControllerClass inventoryController, TProductionScheme scheme, TItemsProducer producer, Action<string> onStartProducing, Action<string> getProducedItems)
		{
			throw null;
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void GetProducedItems()
		{
			throw null;
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ApplyState(EProductionState state, Dictionary<EProductionState, List<GameObject>> _stateActiveObjects)
		{
			throw null;
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task RestartProducing()
		{
			throw null;
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected Task CancelProducing()
		{
			throw null;
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0()
		{
			throw null;
		}

		// Token: 0x0400988F RID: 39055
		protected const string REQUIREMENTS_NOT_FULFILLED = "hideout/Requirements are not fulfilled";

		// Token: 0x04009890 RID: 39056
		protected const string OUT_OF_FUEL = "hideout/Cannot start production without the fuel in Generator";

		// Token: 0x04009891 RID: 39057
		protected const string OTHER_ITEMS_READY = "hideout/Take crafted items";

		// Token: 0x04009892 RID: 39058
		[SerializeField]
		protected Dictionary<EProductionState, List<GameObject>> _stateActiveObjects;

		// Token: 0x04009893 RID: 39059
		[SerializeField]
		protected DefaultUIButton _restartButton;

		// Token: 0x04009894 RID: 39060
		[SerializeField]
		protected DefaultUIButton _cancelButton;

		// Token: 0x04009895 RID: 39061
		[SerializeField]
		private InteractableElement _electricityNeededIcon;

		// Token: 0x04009896 RID: 39062
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04009897 RID: 39063
		[CompilerGenerated]
		private InventoryControllerClass gclass2757_0;

		// Token: 0x04009898 RID: 39064
		[CompilerGenerated]
		private ItemUiContext itemUiContext_0;

		// Token: 0x04009899 RID: 39065
		[CompilerGenerated]
		private TItemsProducer gparam_0;

		// Token: 0x0400989A RID: 39066
		[CompilerGenerated]
		private TProductionScheme gparam_1;

		// Token: 0x0400989B RID: 39067
		[CompilerGenerated]
		private Action<string> action_0;

		// Token: 0x0400989C RID: 39068
		[CompilerGenerated]
		private Action<string> action_1;
	}
}
