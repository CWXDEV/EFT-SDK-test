using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002DFA RID: 11770
	public class GridView : MonoBehaviour, GInterface104, GInterface105, GInterface106, GInterface112, GInterface113, GInterface119, GInterface376
	{
		// Token: 0x1700282C RID: 10284
		// (get) Token: 0x0600E789 RID: 59273 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E78A RID: 59274 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2809 SourceContext
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

		// Token: 0x1700282D RID: 10285
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E78C RID: 59276 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsMagnified
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			private get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600E78D RID: 59277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2495 grid, [NotNull] GClass2809 parentContext, [NotNull] TraderControllerClass itemController, ItemUiContext itemUiContext, FilterPanel filterPanel = null, bool magnify = false)
		{
			throw null;
		}

		// Token: 0x0600E78E RID: 59278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(int gridHeight, int gridWidth)
		{
			throw null;
		}

		// Token: 0x0600E78F RID: 59279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600E790 RID: 59280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void PrepareItems()
		{
			throw null;
		}

		// Token: 0x0600E791 RID: 59281 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E792 RID: 59282 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task TransferAllItems()
		{
			throw null;
		}

		// Token: 0x0600E793 RID: 59283 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600E794 RID: 59284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void MagnifyIfPossible()
		{
			throw null;
		}

		// Token: 0x0600E795 RID: 59285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task MagnifyIfPossible(Rect rect, bool force)
		{
			throw null;
		}

		// Token: 0x0600E796 RID: 59286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDrawGizmos()
		{
			throw null;
		}

		// Token: 0x0600E797 RID: 59287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemAdded(GEventArgs2 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E798 RID: 59288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemRemoved(GEventArgs3 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E799 RID: 59289 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRefreshItem(GEventArgs22 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E79A RID: 59290 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnRefreshContainer(GEventArgs23 args)
		{
			throw null;
		}

		// Token: 0x0600E79B RID: 59291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDiscoverItem(GEventArgs18 eventArgs)
		{
			throw null;
		}

		// Token: 0x0600E79C RID: 59292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SetItemViewPosition(ItemView itemView, LocationInGrid location)
		{
			throw null;
		}

		// Token: 0x0600E79D RID: 59293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ItemView method_4(Item item, LocationInGrid location, ItemUiContext itemUiContext, IItemOwner itemOwner = null)
		{
			throw null;
		}

		// Token: 0x0600E79E RID: 59294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(ItemView itemView, LocationInGrid location)
		{
			throw null;
		}

		// Token: 0x0600E79F RID: 59295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600E7A0 RID: 59296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600E7A1 RID: 59297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual Color GetHighlightColor(GClass2821 itemContext, GStruct412 possibleOperation, [CanBeNull] GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E7A2 RID: 59298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightItemViewPosition(GClass2821 itemContext, GClass2809 targetItemContext, bool preview)
		{
			throw null;
		}

		// Token: 0x0600E7A3 RID: 59299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool CanAccept(GClass2821 itemContext, GClass2809 targetItemContext, out GStruct412 operation)
		{
			throw null;
		}

		// Token: 0x0600E7A4 RID: 59300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableHighlight()
		{
			throw null;
		}

		// Token: 0x0600E7A5 RID: 59301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public LocationInGrid CalculateItemLocation(GClass2821 itemContext)
		{
			throw null;
		}

		// Token: 0x0600E7A6 RID: 59302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Item method_8(GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E7A7 RID: 59303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragStarted()
		{
			throw null;
		}

		// Token: 0x0600E7A8 RID: 59304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DragCancelled()
		{
			throw null;
		}

		// Token: 0x0600E7A9 RID: 59305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool CanDrag(GClass2809 itemContext)
		{
			throw null;
		}

		// Token: 0x0600E7AA RID: 59306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Task AcceptItem(GClass2821 itemContext, GClass2809 targetItemContext)
		{
			throw null;
		}

		// Token: 0x0600E7AB RID: 59307 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ItemView method_9(Item item, Func<ItemView, bool> check)
		{
			throw null;
		}

		// Token: 0x0600E7AC RID: 59308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Hide()
		{
			throw null;
		}

		// Token: 0x0600E7AD RID: 59309 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(int gridHeight)
		{
			throw null;
		}

		// Token: 0x0600E7AE RID: 59310 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11(int gridWidth)
		{
			throw null;
		}

		// Token: 0x0600E7AF RID: 59311 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12()
		{
			throw null;
		}

		// Token: 0x0600E7B0 RID: 59312 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(Item item)
		{
			throw null;
		}

		// Token: 0x0600E7B1 RID: 59313 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14()
		{
			throw null;
		}

		// Token: 0x0600E7B2 RID: 59314 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int smethod_0(MagazineClass mag, BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x0600E7B3 RID: 59315 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int smethod_1(Weapon weapon, BulletClass ammo)
		{
			throw null;
		}

		// Token: 0x0600E7B4 RID: 59316 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_15()
		{
			throw null;
		}

		// Token: 0x0600E7B5 RID: 59317 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_16()
		{
			throw null;
		}

		// Token: 0x0400ECB7 RID: 60599
		[SerializeField]
		private Image _highlightPanel;

		// Token: 0x0400ECB8 RID: 60600
		[SerializeField]
		private bool _nonInteractable;

		// Token: 0x0400ECB9 RID: 60601
		[SerializeField]
		private bool _isAsyncAllowed;

		// Token: 0x0400ECBA RID: 60602
		[SerializeField]
		protected FilterPanel _filterPanel;

		// Token: 0x0400ECBB RID: 60603
		[SerializeField]
		private bool _drawDebugGizmos;

		// Token: 0x0400ECBC RID: 60604
		[CompilerGenerated]
		private GClass2809 gclass2809_0;

		// Token: 0x0400ECBD RID: 60605
		private bool bool_0;

		// Token: 0x0400ECBE RID: 60606
		public GClass2495 Grid;

		// Token: 0x0400ECBF RID: 60607
		internal readonly Dictionary<string, ItemView> dictionary_0;

		// Token: 0x0400ECC0 RID: 60608
		protected readonly GClass763 CompositeDisposable;

		// Token: 0x0400ECC1 RID: 60609
		private IItemOwner iitemOwner_0;

		// Token: 0x0400ECC2 RID: 60610
		private TraderControllerClass gclass2754_0;

		// Token: 0x0400ECC3 RID: 60611
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400ECC4 RID: 60612
		private GStruct370? nullable_0;

		// Token: 0x0400ECC5 RID: 60613
		private RectTransform rectTransform_0;

		// Token: 0x0400ECC6 RID: 60614
		protected static readonly Color InvalidOperationColor;

		// Token: 0x0400ECC7 RID: 60615
		protected static readonly Color ValidMoveColor;

		// Token: 0x0400ECC8 RID: 60616
		private static readonly Color color_0;

		// Token: 0x0400ECC9 RID: 60617
		private static readonly Color color_1;

		// Token: 0x0400ECCA RID: 60618
		private IEnumerable<KeyValuePair<Item, LocationInGrid>> ienumerable_0;

		// Token: 0x0400ECCB RID: 60619
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400ECCC RID: 60620
		private Rect rect_0;

		// Token: 0x0400ECCD RID: 60621
		private GStruct23 gstruct23_0;

		// Token: 0x02002DFC RID: 11772
		[CompilerGenerated]
		private sealed class Class2868
		{
			// Token: 0x0600E7B8 RID: 59320 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemView x)
			{
				throw null;
			}

			// Token: 0x0400ECD3 RID: 60627
			public GClass2765 gridItemAddress;

			// Token: 0x0400ECD4 RID: 60628
			public GridView gridView_0;
		}

		// Token: 0x02002DFD RID: 11773
		[CompilerGenerated]
		private sealed class Class2869
		{
			// Token: 0x0600E7B9 RID: 59321 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemView x)
			{
				throw null;
			}

			// Token: 0x0400ECD5 RID: 60629
			public GClass2765 gridItemAddress;

			// Token: 0x0400ECD6 RID: 60630
			public GridView gridView_0;
		}

		// Token: 0x02002DFE RID: 11774
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2870
		{
			// Token: 0x0600E7BA RID: 59322 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7BB RID: 59323 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7BC RID: 59324 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7BD RID: 59325 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7BE RID: 59326 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7BF RID: 59327 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_5(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7C0 RID: 59328 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_6(KeyValuePair<Item, LocationInGrid> elem)
			{
				throw null;
			}

			// Token: 0x0600E7C1 RID: 59329 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal LocationInGrid method_7(KeyValuePair<Item, LocationInGrid> elem)
			{
				throw null;
			}

			// Token: 0x0600E7C2 RID: 59330 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_8(ItemView iv)
			{
				throw null;
			}

			// Token: 0x0600E7C3 RID: 59331 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_9(ItemView view)
			{
				throw null;
			}

			// Token: 0x0600E7C4 RID: 59332 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_10(ItemView view)
			{
				throw null;
			}

			// Token: 0x0600E7C5 RID: 59333 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_11(ItemView _)
			{
				throw null;
			}

			// Token: 0x0600E7C6 RID: 59334 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_12(ItemView view)
			{
				throw null;
			}

			// Token: 0x0600E7C7 RID: 59335 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_13(ItemView view)
			{
				throw null;
			}

			// Token: 0x0600E7C8 RID: 59336 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_14(ItemView _)
			{
				throw null;
			}

			// Token: 0x0400ECD7 RID: 60631
			public static readonly GridView.Class2870 class2870_0;

			// Token: 0x0400ECD8 RID: 60632
			public static Func<ItemView, bool> func_0;

			// Token: 0x0400ECD9 RID: 60633
			public static Func<ItemView, bool> func_1;

			// Token: 0x0400ECDA RID: 60634
			public static Func<ItemView, bool> func_2;

			// Token: 0x0400ECDB RID: 60635
			public static Func<ItemView, bool> func_3;

			// Token: 0x0400ECDC RID: 60636
			public static Func<ItemView, bool> func_4;

			// Token: 0x0400ECDD RID: 60637
			public static Func<ItemView, bool> func_5;

			// Token: 0x0400ECDE RID: 60638
			public static Func<KeyValuePair<Item, LocationInGrid>, Item> func_6;

			// Token: 0x0400ECDF RID: 60639
			public static Func<KeyValuePair<Item, LocationInGrid>, LocationInGrid> func_7;

			// Token: 0x0400ECE0 RID: 60640
			public static Func<ItemView, bool> func_8;

			// Token: 0x0400ECE1 RID: 60641
			public static Func<ItemView, bool> func_9;

			// Token: 0x0400ECE2 RID: 60642
			public static Func<ItemView, bool> func_10;

			// Token: 0x0400ECE3 RID: 60643
			public static Func<ItemView, bool> func_11;

			// Token: 0x0400ECE4 RID: 60644
			public static Func<ItemView, bool> func_12;

			// Token: 0x0400ECE5 RID: 60645
			public static Func<ItemView, bool> func_13;

			// Token: 0x0400ECE6 RID: 60646
			public static Func<ItemView, bool> func_14;
		}

		// Token: 0x02002E00 RID: 11776
		[CompilerGenerated]
		private sealed class Class2871
		{
			// Token: 0x0600E7CB RID: 59339 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(int count)
			{
				throw null;
			}

			// Token: 0x0600E7CC RID: 59340 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(int count)
			{
				throw null;
			}

			// Token: 0x0400ECF0 RID: 60656
			public GridView gridView_0;
		}

		// Token: 0x02002E02 RID: 11778
		[CompilerGenerated]
		private sealed class Class2872
		{
			// Token: 0x0600E7CF RID: 59343 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyValuePair<string, ItemView> view)
			{
				throw null;
			}

			// Token: 0x0400ECF8 RID: 60664
			public Item item;

			// Token: 0x0400ECF9 RID: 60665
			public Func<ItemView, bool> check;
		}
	}
}
