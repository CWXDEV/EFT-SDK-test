using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.Map
{
	// Token: 0x02002F13 RID: 12051
	[UsedImplicitly]
	public sealed class MapScreen : UIElement, GClass2816.GInterface335
	{
		// Token: 0x14000351 RID: 849
		// (add) Token: 0x0600EDDC RID: 60892 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EDDD RID: 60893 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item, bool> OnItemSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600EDDE RID: 60894 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0600EDDF RID: 60895 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(GInterface313 itemController, LootItemClass container)
		{
			throw null;
		}

		// Token: 0x0600EDE0 RID: 60896 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsActive(GClass2816 context, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600EDE1 RID: 60897 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600EDE2 RID: 60898 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GClass2816.GInterface335.ToggleSelection(GClass2816 context)
		{
			throw null;
		}

		// Token: 0x0600EDE3 RID: 60899 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0600EDE4 RID: 60900 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600EDE5 RID: 60901 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Item item)
		{
			throw null;
		}

		// Token: 0x0600EDE6 RID: 60902 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400F30B RID: 62219
		[CompilerGenerated]
		private Action<Item, bool> action_0;

		// Token: 0x0400F30C RID: 62220
		[SerializeField]
		private PocketMap _pocketMap;

		// Token: 0x0400F30D RID: 62221
		[SerializeField]
		private PocketMapMarkerManager _mapMarkerManager;

		// Token: 0x0400F30E RID: 62222
		[SerializeField]
		private MapMarkerWindow _markerWindow;

		// Token: 0x0400F30F RID: 62223
		[SerializeField]
		private GameObject _mapBlock;

		// Token: 0x0400F310 RID: 62224
		[SerializeField]
		private GameObject _emptyBlock;

		// Token: 0x0400F311 RID: 62225
		[SerializeField]
		private DropdownItemSelector _mapSelector;

		// Token: 0x0400F312 RID: 62226
		private GInterface313 ginterface313_0;

		// Token: 0x0400F313 RID: 62227
		private MapComponent mapComponent_0;

		// Token: 0x0400F314 RID: 62228
		private GClass2816 gclass2816_0;

		// Token: 0x02002F14 RID: 12052
		public sealed class GClass3062 : GClass3058<MapScreen>
		{
			// Token: 0x0600EDE7 RID: 60903 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Show()
			{
				throw null;
			}

			// Token: 0x0400F315 RID: 62229
			private readonly GInterface313 ginterface313_0;

			// Token: 0x0400F316 RID: 62230
			private readonly LootItemClass gclass2625_0;
		}

		// Token: 0x02002F15 RID: 12053
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2975
		{
			// Token: 0x0600EDE8 RID: 60904 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(MapComponent x)
			{
				throw null;
			}

			// Token: 0x0400F317 RID: 62231
			public static readonly MapScreen.Class2975 class2975_0;

			// Token: 0x0400F318 RID: 62232
			public static Func<MapComponent, Item> func_0;
		}
	}
}
