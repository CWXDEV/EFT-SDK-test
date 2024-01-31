using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.Screens;
using EFT.UI.WeaponModding;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002A9B RID: 10907
	public abstract class ItemObserveScreen<TScreenController, TScreen> : EftScreen<TScreenController, TScreen>, GClass2817.GInterface334, GClass2816.GInterface335, GInterface363 where TScreenController : GClass3107.GClass3109<TScreenController, TScreen> where TScreen : EftScreen<TScreenController, TScreen>
	{
		// Token: 0x140002F7 RID: 759
		// (add) Token: 0x0600D8B8 RID: 55480 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D8B9 RID: 55481 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x17002654 RID: 9812
		// (get) Token: 0x0600D8BA RID: 55482 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D8BB RID: 55483 RVA: 0x00002050 File Offset: 0x00000250
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

		// Token: 0x0600D8BC RID: 55484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600D8BD RID: 55485
		protected abstract GClass2825 CreateBuildManipulation();

		// Token: 0x0600D8BE RID: 55486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TScreenController controller)
		{
			throw null;
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void Show([CanBeNull] Item item, InventoryControllerClass inventoryController)
		{
			throw null;
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdateManipulation(GClass2825 manipulation)
		{
			throw null;
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2817.GInterface334.IsInventoryItem(Item item)
		{
			throw null;
		}

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsActive(GClass2816 context, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600D8C3 RID: 55491 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GClass2816.GInterface335.ToggleSelection(GClass2816 context)
		{
			throw null;
		}

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GClass2817.GInterface334.Highlight(GClass2816 context, bool selected)
		{
			throw null;
		}

		// Token: 0x0600D8C6 RID: 55494 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		IEnumerable<Item> GClass2817.GInterface334.GetAllItems(ItemAddress itemAddress)
		{
			throw null;
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateItem([CanBeNull] Item newItem)
		{
			throw null;
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			throw null;
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(Slot slot)
		{
			throw null;
		}

		// Token: 0x0600D8CA RID: 55498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(Slot slot, Item item)
		{
			throw null;
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void WeaponUpdate()
		{
			throw null;
		}

		// Token: 0x0600D8CC RID: 55500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CheckForVitalParts()
		{
			throw null;
		}

		// Token: 0x0600D8CD RID: 55501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RefreshWeapon()
		{
			throw null;
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D8CF RID: 55503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(LootItemClass weapon)
		{
			throw null;
		}

		// Token: 0x0600D8D0 RID: 55504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(LootItemClass weapon)
		{
			throw null;
		}

		// Token: 0x0600D8D1 RID: 55505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600D8D2 RID: 55506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ToggleChangedHandler()
		{
			throw null;
		}

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HighlightMod(Transform modTransform, Color color, bool overriding = false)
		{
			throw null;
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideModHighlight(bool overriding = false)
		{
			throw null;
		}

		// Token: 0x0600D8D5 RID: 55509 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UpdatePositions()
		{
			throw null;
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2[] smethod_0(Vector2[] points, Vector2 center, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static float smethod_1(Vector2 point, Vector2 center, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2 smethod_2(float angle, Vector2 center, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_9(float angle, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_10(float pos, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Vector2[] smethod_3(Vector2[] points, Vector2 center, float a, float b)
		{
			throw null;
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600D8DF RID: 55519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D8E1 RID: 55521 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_11()
		{
			throw null;
		}

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_12(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_13(PointerEventData pointerData)
		{
			throw null;
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_14(bool x)
		{
			throw null;
		}

		// Token: 0x0400DB8E RID: 56206
		private const string string_0 = "NO BUILD SELECTED";

		// Token: 0x0400DB8F RID: 56207
		[SerializeField]
		private TextMeshProUGUI _weaponName;

		// Token: 0x0400DB90 RID: 56208
		[SerializeField]
		private DropDownMenu _menu;

		// Token: 0x0400DB91 RID: 56209
		[SerializeField]
		private DefaultUIButton _backButton;

		// Token: 0x0400DB92 RID: 56210
		[SerializeField]
		private CameraViewporter _viewporter;

		// Token: 0x0400DB93 RID: 56211
		[SerializeField]
		private RectTransform _slotsContainer;

		// Token: 0x0400DB94 RID: 56212
		[SerializeField]
		private WeaponPreview _weaponPreview;

		// Token: 0x0400DB95 RID: 56213
		[SerializeField]
		private CharacteristicsPanel _characteristics;

		// Token: 0x0400DB96 RID: 56214
		[SerializeField]
		protected Toggle[] ModClassToggles;

		// Token: 0x0400DB97 RID: 56215
		[SerializeField]
		private RectTransform _ellipseRect;

		// Token: 0x0400DB98 RID: 56216
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400DB99 RID: 56217
		[CompilerGenerated]
		private Action<Item, bool> action_0;

		// Token: 0x0400DB9A RID: 56218
		public Camera LineCamera;

		// Token: 0x0400DB9B RID: 56219
		[CanBeNull]
		protected Item Item;

		// Token: 0x0400DB9C RID: 56220
		private Item item_0;

		// Token: 0x0400DB9D RID: 56221
		protected readonly Dictionary<Transform, ModdingScreenSlotView> ModIcons;

		// Token: 0x0400DB9E RID: 56222
		protected EModClass VisibleModClasses;

		// Token: 0x0400DB9F RID: 56223
		protected bool RefreshingWeapon;

		// Token: 0x0400DBA0 RID: 56224
		protected ItemUiContext _itemUiContext;

		// Token: 0x0400DBA1 RID: 56225
		private Slot[] slot_0;

		// Token: 0x0400DBA2 RID: 56226
		private ModdingScreenSlotView moddingScreenSlotView_0;

		// Token: 0x0400DBA3 RID: 56227
		private readonly GClass594 gclass594_0;

		// Token: 0x0400DBA4 RID: 56228
		private GClass2825 gclass2825_0;

		// Token: 0x0400DBA5 RID: 56229
		private bool bool_1;

		// Token: 0x0400DBA6 RID: 56230
		private bool bool_2;

		// Token: 0x0400DBA7 RID: 56231
		private Vector2 vector2_0;

		// Token: 0x0400DBA8 RID: 56232
		private Light[] light_0;

		// Token: 0x0400DBA9 RID: 56233
		private Transform[] transform_0;

		// Token: 0x0400DBAA RID: 56234
		private HighLightMesh highLightMesh_0;

		// Token: 0x0400DBAB RID: 56235
		private GClass2817 gclass2817_0;

		// Token: 0x0400DBAC RID: 56236
		[CompilerGenerated]
		private InventoryControllerClass gclass2757_0;

		// Token: 0x02002A9C RID: 10908
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2548
		{
			// Token: 0x0600D8E5 RID: 55525 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Light x)
			{
				throw null;
			}

			// Token: 0x0600D8E6 RID: 55526 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Slot x)
			{
				throw null;
			}

			// Token: 0x0600D8E7 RID: 55527 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal int method_2(KeyValuePair<float, ModdingScreenSlotView> pair1, KeyValuePair<float, ModdingScreenSlotView> pair2)
			{
				throw null;
			}

			// Token: 0x0600D8E8 RID: 55528 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(Light x)
			{
				throw null;
			}

			// Token: 0x0400DBAD RID: 56237
			public static readonly ItemObserveScreen<TScreenController, TScreen>.Class2548 class2548_0;

			// Token: 0x0400DBAE RID: 56238
			public static Func<Light, bool> func_0;

			// Token: 0x0400DBAF RID: 56239
			public static Func<Slot, bool> func_1;

			// Token: 0x0400DBB0 RID: 56240
			public static Comparison<KeyValuePair<float, ModdingScreenSlotView>> comparison_0;

			// Token: 0x0400DBB1 RID: 56241
			public static Func<Light, bool> func_2;
		}

		// Token: 0x02002A9D RID: 10909
		[CompilerGenerated]
		private sealed class Class2549
		{
			// Token: 0x0600D8E9 RID: 55529 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600D8EA RID: 55530 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0600D8EB RID: 55531 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(IResult error)
			{
				throw null;
			}

			// Token: 0x0400DBB3 RID: 56243
			public LootItemClass compoundItem;
		}

		// Token: 0x02002A9E RID: 10910
		[CompilerGenerated]
		private sealed class Class2550
		{
			// Token: 0x0600D8EC RID: 55532 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Vector2 method_0(Vector2 point)
			{
				throw null;
			}

			// Token: 0x0400DBB4 RID: 56244
			public Vector2 center;
		}
	}
}
