using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using EFT.UI.Ragfair;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AB2 RID: 10930
	public abstract class PaginationWindow : HandoverItemsWindow
	{
		// Token: 0x1700265C RID: 9820
		// (get) Token: 0x0600D937 RID: 55607 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool CanStretchVertically
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700265D RID: 9821
		// (get) Token: 0x0600D938 RID: 55608 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool CanStretchHorizontally
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700265E RID: 9822
		// (get) Token: 0x0600D939 RID: 55609 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D93A RID: 55610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected new GClass3087 Show(string title, string message, GInterface312 profile, TraderControllerClass itemController, GClass2809 itemContext, Action acceptAction, [CanBeNull] Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600D93D RID: 55613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateItems(IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IEnumerable<Item> items)
		{
			throw null;
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(int page)
		{
			throw null;
		}

		// Token: 0x0600D940 RID: 55616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D941 RID: 55617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D942 RID: 55618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600D943 RID: 55619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10()
		{
			throw null;
		}

		// Token: 0x0600D944 RID: 55620 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600D945 RID: 55621 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600D946 RID: 55622 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13()
		{
			throw null;
		}

		// Token: 0x0600D947 RID: 55623 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0400DC13 RID: 56339
		[SerializeField]
		private Button _firstPageButton;

		// Token: 0x0400DC14 RID: 56340
		[SerializeField]
		private Button _lastPageButton;

		// Token: 0x0400DC15 RID: 56341
		[SerializeField]
		private Button _previousPageButton;

		// Token: 0x0400DC16 RID: 56342
		[SerializeField]
		private Button _nextPageButton;

		// Token: 0x0400DC17 RID: 56343
		[SerializeField]
		private PageButton _pageButtonTemplate;

		// Token: 0x0400DC18 RID: 56344
		[SerializeField]
		private Transform _pageButtonsRoot;

		// Token: 0x0400DC19 RID: 56345
		[SerializeField]
		private int _pageButtonsCount;

		// Token: 0x0400DC1A RID: 56346
		private List<PageButton> list_0;

		// Token: 0x0400DC1B RID: 56347
		private int int_3;

		// Token: 0x0400DC1C RID: 56348
		protected int CurrentPage;

		// Token: 0x02002AB3 RID: 10931
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2559
		{
			// Token: 0x0600D948 RID: 55624 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(GClass2495 grid)
			{
				throw null;
			}

			// Token: 0x0400DC1D RID: 56349
			public static readonly PaginationWindow.Class2559 class2559_0;

			// Token: 0x0400DC1E RID: 56350
			public static Func<GClass2495, bool> func_0;
		}
	}
}
