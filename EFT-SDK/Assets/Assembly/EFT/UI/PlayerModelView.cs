using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002901 RID: 10497
	public sealed class PlayerModelView : UIElement
	{
		// Token: 0x17002552 RID: 9554
		// (get) Token: 0x0600D18E RID: 53646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D18F RID: 53647 RVA: 0x00002050 File Offset: 0x00000250
		public MenuPlayerPoser ModelPlayerPoser
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

		// Token: 0x17002553 RID: 9555
		// (get) Token: 0x0600D190 RID: 53648 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D191 RID: 53649 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerBody PlayerBody
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

		// Token: 0x17002554 RID: 9556
		// (get) Token: 0x0600D192 RID: 53650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D193 RID: 53651 RVA: 0x00002050 File Offset: 0x00000250
		public bool LoadingComplete
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

		// Token: 0x140002DF RID: 735
		// (add) Token: 0x0600D194 RID: 53652 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D195 RID: 53653 RVA: 0x00002050 File Offset: 0x00000250
		public event Action LoadingCompletedEvent
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

		// Token: 0x0600D196 RID: 53654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(Profile profile, GInterface311 inventoryController = null, Action onCreated = null, float update = 0f, Vector3? position = null, bool animateWeapon = true)
		{
			throw null;
		}

		// Token: 0x0600D197 RID: 53655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task Show(PlayerVisualRepresentation playerVisual, GInterface311 inventoryController = null, Action onCreated = null, float update = 0f, Vector3? position = null, bool animateWeapon = true)
		{
			throw null;
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task method_0(PlayerVisualRepresentation playerVisual, [CanBeNull] GInterface311 inventoryController, [CanBeNull] Action onCreated, float update, CancellationToken ct)
		{
			throw null;
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Fold(IAnimator animator, bool folded)
		{
			throw null;
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D19D RID: 53661 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400D27B RID: 53883
		private const int EMPTY_HANDS = -1;

		// Token: 0x0400D27C RID: 53884
		private const int TWO_HANDED_FIREARM = 0;

		// Token: 0x0400D27D RID: 53885
		private const int ONE_HANDED_FIREARM = 1;

		// Token: 0x0400D27E RID: 53886
		private const int THROWABLE_WEAPON = 2;

		// Token: 0x0400D27F RID: 53887
		private const int MELEE_WEAPON = 3;

		// Token: 0x0400D280 RID: 53888
		[SerializeField]
		private ProgressSpinner _progressSpinner;

		// Token: 0x0400D283 RID: 53891
		private DependencyGraph<IEasyBundle>.GClass3388 _bundles;

		// Token: 0x0400D284 RID: 53892
		private CancellationTokenSource _loadingCancellation;

		// Token: 0x0400D285 RID: 53893
		private WeaponPrefab _weaponPrefab;

		// Token: 0x0400D286 RID: 53894
		private IAnimator _weaponAnimator;

		// Token: 0x0400D287 RID: 53895
		private Coroutine _weaponAnimationCoroutine;

		// Token: 0x0400D288 RID: 53896
		private GInterface99 _filter;

		// Token: 0x0400D289 RID: 53897
		private Vector3 _position;

		// Token: 0x0400D28A RID: 53898
		private bool _animateWeapon;

		// Token: 0x0400D28B RID: 53899
		private Vector3 _lastLossyScale;

		// Token: 0x02002904 RID: 10500
		[CompilerGenerated]
		private sealed class Class2390
		{
			// Token: 0x0600D1A2 RID: 53666 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal ResourceKey method_0(string x)
			{
				throw null;
			}

			// Token: 0x0600D1A3 RID: 53667 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(KeyValuePair<EBodyModelPart, string> x)
			{
				throw null;
			}

			// Token: 0x0600D1A4 RID: 53668 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(float p)
			{
				throw null;
			}

			// Token: 0x0400D2A3 RID: 53923
			public GClass1441 solver;

			// Token: 0x0400D2A4 RID: 53924
			public PlayerModelView playerModelView_0;
		}

		// Token: 0x02002905 RID: 10501
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2391
		{
			// Token: 0x0600D1A5 RID: 53669 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Item method_0(Slot x)
			{
				throw null;
			}

			// Token: 0x0600D1A6 RID: 53670 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item x)
			{
				throw null;
			}

			// Token: 0x0600D1A7 RID: 53671 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(ResourceKey x)
			{
				throw null;
			}

			// Token: 0x0600D1A8 RID: 53672 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_3(ResourceKey x)
			{
				throw null;
			}

			// Token: 0x0600D1A9 RID: 53673 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_4(string x)
			{
				throw null;
			}

			// Token: 0x0600D1AA RID: 53674 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(Item x)
			{
				throw null;
			}

			// Token: 0x0600D1AB RID: 53675 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_6(string x)
			{
				throw null;
			}

			// Token: 0x0400D2A5 RID: 53925
			public static readonly PlayerModelView.Class2391 class2391_0;

			// Token: 0x0400D2A6 RID: 53926
			public static Func<Slot, Item> func_0;

			// Token: 0x0400D2A7 RID: 53927
			public static Func<Item, bool> func_1;

			// Token: 0x0400D2A8 RID: 53928
			public static Func<ResourceKey, bool> func_2;

			// Token: 0x0400D2A9 RID: 53929
			public static Func<ResourceKey, string> func_3;

			// Token: 0x0400D2AA RID: 53930
			public static Func<string, bool> func_4;

			// Token: 0x0400D2AB RID: 53931
			public static Func<Item, string> func_5;

			// Token: 0x0400D2AC RID: 53932
			public static Func<string, bool> func_6;
		}
	}
}
