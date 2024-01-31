using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002896 RID: 10390
	public sealed class AmmoSelector : UIInputNode
	{
		// Token: 0x17002515 RID: 9493
		// (get) Token: 0x0600CF89 RID: 53129 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsShown
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002516 RID: 9494
		// (get) Token: 0x0600CF8A RID: 53130 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CF8B RID: 53131 RVA: 0x00002050 File Offset: 0x00000250
		private int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CF8C RID: 53132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Item> ShowAcceptableMags(IEnumerable<Item> foundMags, InventoryControllerClass inventoryController, Vector2 screenPosition, InsuranceCompanyClass insurance)
		{
			throw null;
		}

		// Token: 0x0600CF8D RID: 53133 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Item GetSelectedMagazine()
		{
			throw null;
		}

		// Token: 0x0600CF8E RID: 53134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600CF8F RID: 53135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool TryFindAmmoForWeapon(InventoryControllerClass controller, Weapon weapon, out IEnumerable<Item> result)
		{
			throw null;
		}

		// Token: 0x0600CF90 RID: 53136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Item result)
		{
			throw null;
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static IEnumerable<Item> smethod_0(InventoryControllerClass controller, Weapon weapon)
		{
			throw null;
		}

		// Token: 0x0600CF92 RID: 53138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600CF93 RID: 53139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x0600CF94 RID: 53140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x0600CF95 RID: 53141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(int prevSelectionIndex, int currentSelectionIndex)
		{
			throw null;
		}

		// Token: 0x0600CF96 RID: 53142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(int index, bool isSelected)
		{
			throw null;
		}

		// Token: 0x0600CF97 RID: 53143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CF98 RID: 53144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x0600CF99 RID: 53145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GridItemView view, Item magazine)
		{
			throw null;
		}

		// Token: 0x0600CF9A RID: 53146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(int index)
		{
			throw null;
		}

		// Token: 0x0400D057 RID: 53335
		[SerializeField]
		private LayoutElement _cancelView;

		// Token: 0x0400D058 RID: 53336
		[SerializeField]
		private Image _cancelBackground;

		// Token: 0x0400D059 RID: 53337
		[SerializeField]
		private Vector2 _arrowOffset;

		// Token: 0x0400D05A RID: 53338
		[SerializeField]
		private Color _normalCancelColor;

		// Token: 0x0400D05B RID: 53339
		[SerializeField]
		private Color _selectedCancelColor;

		// Token: 0x0400D05C RID: 53340
		private readonly List<GridItemView> list_0;

		// Token: 0x0400D05D RID: 53341
		private readonly List<Item> list_1;

		// Token: 0x0400D05E RID: 53342
		private int int_0;

		// Token: 0x0400D05F RID: 53343
		private TaskCompletionSource<Item> taskCompletionSource_0;

		// Token: 0x02002897 RID: 10391
		[CompilerGenerated]
		private sealed class Class2355
		{
			// Token: 0x0600CF9B RID: 53147 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_0()
			{
				throw null;
			}

			// Token: 0x0600CF9C RID: 53148 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_1()
			{
				throw null;
			}

			// Token: 0x0600CF9D RID: 53149 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(BulletClass ammo)
			{
				throw null;
			}

			// Token: 0x0600CF9E RID: 53150 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_3()
			{
				throw null;
			}

			// Token: 0x0600CF9F RID: 53151 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(BulletClass ammo)
			{
				throw null;
			}

			// Token: 0x0600CFA0 RID: 53152 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_5()
			{
				throw null;
			}

			// Token: 0x0600CFA1 RID: 53153 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<BulletClass> method_6()
			{
				throw null;
			}

			// Token: 0x0600CFA2 RID: 53154 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_7(BulletClass x)
			{
				throw null;
			}

			// Token: 0x0400D060 RID: 53344
			public Weapon weapon;

			// Token: 0x0400D061 RID: 53345
			public InventoryControllerClass controller;

			// Token: 0x0400D062 RID: 53346
			public MagazineClass currentMagazine;
		}

		// Token: 0x02002898 RID: 10392
		[CompilerGenerated]
		private sealed class Class2356
		{
			// Token: 0x0600CFA3 RID: 53155 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(MagazineClass mag)
			{
				throw null;
			}

			// Token: 0x0400D063 RID: 53347
			public GClass2763 magAddress;

			// Token: 0x0400D064 RID: 53348
			public AmmoSelector.Class2355 class2355_0;
		}

		// Token: 0x02002899 RID: 10393
		[CompilerGenerated]
		private sealed class Class2357
		{
			// Token: 0x0600CFA4 RID: 53156 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(BulletClass ammo)
			{
				throw null;
			}

			// Token: 0x0400D065 RID: 53349
			public GClass2664 ubWeapon;
		}
	}
}
