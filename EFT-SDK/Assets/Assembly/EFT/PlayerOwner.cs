using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Comfort.Common;
using EFT.InputSystem;
using EFT.Interactive;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001952 RID: 6482
	public class PlayerOwner : InputNode, GInterface136
	{
		// Token: 0x06008B3A RID: 35642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static T smethod_0<T>(Player player, GInterface155 inputTree) where T : PlayerOwner
		{
			throw null;
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06008B3B RID: 35643 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008B3C RID: 35644 RVA: 0x00002050 File Offset: 0x00000250
		private PlayerOwner.EState State
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

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06008B3D RID: 35645 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008B3E RID: 35646 RVA: 0x00002050 File Offset: 0x00000250
		public virtual GInterface149 PlayerInputTranslator
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

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06008B3F RID: 35647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008B40 RID: 35648 RVA: 0x00002050 File Offset: 0x00000250
		public virtual GInterface150 HandsInputTranslator
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

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06008B41 RID: 35649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008B42 RID: 35650 RVA: 0x00002050 File Offset: 0x00000250
		public Player Player
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

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06008B43 RID: 35651 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008B44 RID: 35652 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface155 InputTree
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

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06008B45 RID: 35653 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool SetItemInHandsImmediately
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008B46 RID: 35654 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06008B47 RID: 35655 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_0()
		{
			throw null;
		}

		// Token: 0x06008B48 RID: 35656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal virtual void vmethod_1()
		{
			throw null;
		}

		// Token: 0x06008B49 RID: 35657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008B4A RID: 35658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void TranslateAxes(ref float[] axes)
		{
			throw null;
		}

		// Token: 0x06008B4B RID: 35659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override ECursorResult ShouldLockCursor()
		{
			throw null;
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GInterface123 controller)
		{
			throw null;
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GInterface135 quickUseController)
		{
			throw null;
		}

		// Token: 0x06008B4E RID: 35662 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(IFirearmHandsController controller)
		{
			throw null;
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(IHandsController grenadeController)
		{
			throw null;
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(GInterface129 usableItemController)
		{
			throw null;
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(IKnifeController knifeController)
		{
			throw null;
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(GInterface125 controller)
		{
			throw null;
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(GInterface130 medsController)
		{
			throw null;
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(IGrenadeController grenadeQuickUseController)
		{
			throw null;
		}

		// Token: 0x06008B55 RID: 35669 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetHandsController(GInterface134 quickKnifeKickController)
		{
			throw null;
		}

		// Token: 0x06008B56 RID: 35670 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2([CanBeNull] Item previousItem, object controller)
		{
			throw null;
		}

		// Token: 0x06008B57 RID: 35671 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ResetHands()
		{
			throw null;
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_1(ECommand command)
		{
			throw null;
		}

		// Token: 0x06008B59 RID: 35673 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyComponent GetKey(WorldInteractiveObject worldInteractiveObject)
		{
			throw null;
		}

		// Token: 0x06008B5A RID: 35674 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<KeycardComponent> GetAllKeyCards()
		{
			throw null;
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CleanupOnDestroy()
		{
			throw null;
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool x)
		{
			throw null;
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(bool y)
		{
			throw null;
		}

		// Token: 0x040090B7 RID: 37047
		private static readonly WaitForSeconds waitForSeconds_0;

		// Token: 0x040090B8 RID: 37048
		protected readonly GClass763 OnDestroyCompositeDisposable;

		// Token: 0x040090B9 RID: 37049
		[CompilerGenerated]
		private PlayerOwner.EState estate_0;

		// Token: 0x040090BA RID: 37050
		private Class1450 class1450_0;

		// Token: 0x040090BB RID: 37051
		[CompilerGenerated]
		private GInterface149 ginterface149_0;

		// Token: 0x040090BC RID: 37052
		[CompilerGenerated]
		private GInterface150 ginterface150_0;

		// Token: 0x040090BD RID: 37053
		[CompilerGenerated]
		private Player player_0;

		// Token: 0x040090BE RID: 37054
		[CompilerGenerated]
		private GInterface155 ginterface155_0;

		// Token: 0x040090BF RID: 37055
		[CanBeNull]
		public Item PreviousItem;

		// Token: 0x040090C0 RID: 37056
		private Coroutine coroutine_0;

		// Token: 0x040090C1 RID: 37057
		private Action action_0;

		// Token: 0x040090C2 RID: 37058
		private Action action_1;

		// Token: 0x02001953 RID: 6483
		protected enum EState
		{
			// Token: 0x040090C4 RID: 37060
			None,
			// Token: 0x040090C5 RID: 37061
			Started,
			// Token: 0x040090C6 RID: 37062
			Stopped
		}

		// Token: 0x02001954 RID: 6484
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1512
		{
			// Token: 0x06008B5E RID: 35678 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x06008B5F RID: 35679 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1(Result<GInterface123> result)
			{
				throw null;
			}

			// Token: 0x06008B60 RID: 35680 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_2(Result<GInterface125> result)
			{
				throw null;
			}

			// Token: 0x040090C7 RID: 37063
			public static readonly PlayerOwner.Class1512 class1512_0;

			// Token: 0x040090C8 RID: 37064
			public static Callback<GInterface123> callback_0;

			// Token: 0x040090C9 RID: 37065
			public static Callback<GInterface123> callback_1;

			// Token: 0x040090CA RID: 37066
			public static Callback<GInterface125> callback_2;
		}

		// Token: 0x02001955 RID: 6485
		[CompilerGenerated]
		private sealed class Class1513
		{
			// Token: 0x06008B61 RID: 35681 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface135> resultController)
			{
				throw null;
			}

			// Token: 0x040090CB RID: 37067
			public PlayerOwner playerOwner_0;

			// Token: 0x040090CC RID: 37068
			public Item previousItem;

			// Token: 0x040090CD RID: 37069
			public GInterface135 quickUseController;
		}

		// Token: 0x02001956 RID: 6486
		[CompilerGenerated]
		private sealed class Class1514
		{
			// Token: 0x06008B62 RID: 35682 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<IHandsController> resultController)
			{
				throw null;
			}

			// Token: 0x040090CE RID: 37070
			public PlayerOwner playerOwner_0;

			// Token: 0x040090CF RID: 37071
			public Item previousItem;

			// Token: 0x040090D0 RID: 37072
			public IHandsController grenadeController;
		}

		// Token: 0x02001957 RID: 6487
		[CompilerGenerated]
		private sealed class Class1515
		{
			// Token: 0x06008B63 RID: 35683 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface135> resultController)
			{
				throw null;
			}

			// Token: 0x040090D1 RID: 37073
			public PlayerOwner playerOwner_0;

			// Token: 0x040090D2 RID: 37074
			public Item previousItem;

			// Token: 0x040090D3 RID: 37075
			public GInterface130 medsController;
		}

		// Token: 0x02001958 RID: 6488
		[CompilerGenerated]
		private sealed class Class1516
		{
			// Token: 0x06008B64 RID: 35684 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface132<GrenadeClass>> resultController)
			{
				throw null;
			}

			// Token: 0x040090D4 RID: 37076
			public PlayerOwner playerOwner_0;

			// Token: 0x040090D5 RID: 37077
			public Item previousItem;

			// Token: 0x040090D6 RID: 37078
			public IGrenadeController grenadeQuickUseController;
		}

		// Token: 0x02001959 RID: 6489
		[CompilerGenerated]
		private sealed class Class1517
		{
			// Token: 0x06008B65 RID: 35685 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<GInterface132<KnifeClass>> resultController)
			{
				throw null;
			}

			// Token: 0x040090D7 RID: 37079
			public PlayerOwner playerOwner_0;

			// Token: 0x040090D8 RID: 37080
			public Item previousItem;

			// Token: 0x040090D9 RID: 37081
			public GInterface134 quickKnifeKickController;
		}

		// Token: 0x0200195A RID: 6490
		[CompilerGenerated]
		private sealed class Class1518
		{
			// Token: 0x06008B66 RID: 35686 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(KeyComponent x)
			{
				throw null;
			}

			// Token: 0x040090DA RID: 37082
			public WorldInteractiveObject worldInteractiveObject;
		}
	}
}
