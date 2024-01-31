using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.HealthSystem;
using EFT.InputSystem;
using EFT.InventoryLogic;
using EFT.UI.DragAndDrop;
using EFT.UI.Screens;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C1A RID: 11290
	public sealed class TransferItemsScreen : EftScreen<TransferItemsScreen.GClass3138, TransferItemsScreen>
	{
		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x0600DE8B RID: 56971 RVA: 0x00002050 File Offset: 0x00000250
		private Dictionary<string, ItemView> Dictionary_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DE8C RID: 56972 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DE8D RID: 56973 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DE8E RID: 56974 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(TransferItemsScreen.GClass3138 controller)
		{
			throw null;
		}

		// Token: 0x0600DE8F RID: 56975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Show(IEnumerable<ChatMessageClass> messages, IHealthController healthController, InventoryControllerClass controller, StashClass playerStash, ISession session, DateTime? expirationTime)
		{
			throw null;
		}

		// Token: 0x0600DE90 RID: 56976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool isReceiving)
		{
			throw null;
		}

		// Token: 0x0600DE91 RID: 56977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task<bool> method_4()
		{
			throw null;
		}

		// Token: 0x0600DE92 RID: 56978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DE93 RID: 56979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override InputNode.ETranslateResult TranslateCommand(ECommand command)
		{
			throw null;
		}

		// Token: 0x0600DE94 RID: 56980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DE95 RID: 56981 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0400E36F RID: 58223
		private const float float_0 = 12f;

		// Token: 0x0400E370 RID: 58224
		private const string string_0 = "UI/TransferScreen/PackageHasExpired";

		// Token: 0x0400E371 RID: 58225
		private const string string_1 = "You still have untransfered items. Are you sure you want to end the transfer? You will be able to return to this process later.";

		// Token: 0x0400E372 RID: 58226
		[SerializeField]
		private SimpleStashPanel _stashPanel;

		// Token: 0x0400E373 RID: 58227
		[SerializeField]
		private GridView _itemsToTransferGridView;

		// Token: 0x0400E374 RID: 58228
		[SerializeField]
		private DefaultUIButton _closeButton;

		// Token: 0x0400E375 RID: 58229
		[SerializeField]
		private DefaultUIButton _acceptButton;

		// Token: 0x0400E376 RID: 58230
		[SerializeField]
		private DefaultUIButton _receiveAllButton;

		// Token: 0x0400E377 RID: 58231
		[SerializeField]
		private GameObject _expirationTimePanel;

		// Token: 0x0400E378 RID: 58232
		[SerializeField]
		private TextMeshProUGUI _expirationLabel;

		// Token: 0x0400E379 RID: 58233
		private BindableState<bool> gclass3370_0;

		// Token: 0x0400E37A RID: 58234
		private ItemUiContext itemUiContext_0;

		// Token: 0x0400E37B RID: 58235
		private IEnumerable<ChatMessageClass> ienumerable_0;

		// Token: 0x0400E37C RID: 58236
		private InventoryControllerClass gclass2757_0;

		// Token: 0x0400E37D RID: 58237
		private LootItemClass gclass2625_0;

		// Token: 0x0400E37E RID: 58238
		private DateTime? nullable_0;

		// Token: 0x0400E37F RID: 58239
		private ItemView[] itemView_0;

		// Token: 0x0400E380 RID: 58240
		private GClass3006 gclass3006_0;

		// Token: 0x0400E381 RID: 58241
		private Action action_0;

		// Token: 0x02002C1B RID: 11291
		public sealed class GClass3138 : GClass3107.GClass3109<TransferItemsScreen.GClass3138, TransferItemsScreen>
		{
			// Token: 0x170026E4 RID: 9956
			// (get) Token: 0x0600DE96 RID: 56982 RVA: 0x00002050 File Offset: 0x00000250
			public override EEftScreenType ScreenType
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x170026E5 RID: 9957
			// (get) Token: 0x0600DE97 RID: 56983 RVA: 0x00002050 File Offset: 0x00000250
			protected override EStateSwitcher MenuChatBarVisibility
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0600DE98 RID: 56984 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override Task<bool> CloseScreenInterruption(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0600DE99 RID: 56985 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[DebuggerHidden]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private Task<bool> method_9(bool moveForward)
			{
				throw null;
			}

			// Token: 0x0400E382 RID: 58242
			public readonly IEnumerable<ChatMessageClass> Messages;

			// Token: 0x0400E383 RID: 58243
			public readonly IHealthController HealthController;

			// Token: 0x0400E384 RID: 58244
			public readonly InventoryControllerClass InventoryController;

			// Token: 0x0400E385 RID: 58245
			public readonly StashClass PlayerStash;

			// Token: 0x0400E386 RID: 58246
			public readonly ISession Session;

			// Token: 0x0400E387 RID: 58247
			public readonly DateTime? ExpirationTime;
		}

		// Token: 0x02002C1D RID: 11293
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2686
		{
			// Token: 0x0600DE9C RID: 56988 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal IEnumerable<Item> method_0(ChatMessageClass message)
			{
				throw null;
			}

			// Token: 0x0600DE9D RID: 56989 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(Item item)
			{
				throw null;
			}

			// Token: 0x0400E38D RID: 58253
			public static readonly TransferItemsScreen.Class2686 class2686_0;

			// Token: 0x0400E38E RID: 58254
			public static Func<ChatMessageClass, IEnumerable<Item>> func_0;

			// Token: 0x0400E38F RID: 58255
			public static Func<Item, bool> func_1;
		}

		// Token: 0x02002C1E RID: 11294
		[CompilerGenerated]
		private sealed class Class2687
		{
			// Token: 0x0600DE9E RID: 56990 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0600DE9F RID: 56991 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_1()
			{
				throw null;
			}

			// Token: 0x0400E390 RID: 58256
			public TaskCompletionSource<bool> taskSource;
		}
	}
}
