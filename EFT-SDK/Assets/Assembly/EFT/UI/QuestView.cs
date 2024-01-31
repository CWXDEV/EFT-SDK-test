using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BA1 RID: 11169
	public sealed class QuestView : UIElement
	{
		// Token: 0x1700269C RID: 9884
		// (get) Token: 0x0600DC53 RID: 56403 RVA: 0x00002050 File Offset: 0x00000250
		public string QuestId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DC54 RID: 56404 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DC55 RID: 56405 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ISession backendSession, GInterface313 controller, AbstractQuestControllerClass questController, GClass1246 quest, TraderClass trader)
		{
			throw null;
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnQuestStatusChanged(GClass1246 quest, bool notify)
		{
			throw null;
		}

		// Token: 0x0600DC57 RID: 56407 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateView()
		{
			throw null;
		}

		// Token: 0x0600DC58 RID: 56408 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowButtonBlock()
		{
			throw null;
		}

		// Token: 0x0600DC59 RID: 56409 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool IsChangeRequirementsSatisfied()
		{
			throw null;
		}

		// Token: 0x0600DC5A RID: 56410 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GStruct404 QuestChangeRequirement()
		{
			throw null;
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckChangeStandingRequirement(GStruct404 changeRequirement)
		{
			throw null;
		}

		// Token: 0x0600DC5C RID: 56412 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool CheckChangeItemsRequirement(GStruct405 questChangeCost)
		{
			throw null;
		}

		// Token: 0x0600DC5D RID: 56413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetTotalCurrency(GStruct405 questChangeCost)
		{
			throw null;
		}

		// Token: 0x0600DC5E RID: 56414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task ShowChangeQuestConfirmation()
		{
			throw null;
		}

		// Token: 0x0600DC5F RID: 56415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ExpireQuestLocal()
		{
			throw null;
		}

		// Token: 0x0600DC60 RID: 56416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowReRollTooltip()
		{
			throw null;
		}

		// Token: 0x0600DC61 RID: 56417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GClass3093 QuestChangePriceInfos()
		{
			throw null;
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private int GetDiscountedPrice(int price)
		{
			throw null;
		}

		// Token: 0x0600DC63 RID: 56419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowInitialBlock(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC64 RID: 56420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowRewardsBlock(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC65 RID: 56421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowRequirementsBlock(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC66 RID: 56422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowObjectivesBlock(bool show)
		{
			throw null;
		}

		// Token: 0x0600DC67 RID: 56423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartQuest()
		{
			throw null;
		}

		// Token: 0x0600DC68 RID: 56424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task StartQuest(GClass1246 selectedQuest)
		{
			throw null;
		}

		// Token: 0x0600DC69 RID: 56425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LinkedQuestHandler(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600DC6A RID: 56426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FinishQuest()
		{
			throw null;
		}

		// Token: 0x0600DC6B RID: 56427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task FinishQuest(GClass1246 quest)
		{
			throw null;
		}

		// Token: 0x0600DC6C RID: 56428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowQuestMessage(RawQuestClass questTemplate, string message, Action callback = null)
		{
			throw null;
		}

		// Token: 0x0600DC6D RID: 56429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ShowQuestMessagesRecursively()
		{
			throw null;
		}

		// Token: 0x0600DC6E RID: 56430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E084 RID: 57476
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400E085 RID: 57477
		[SerializeField]
		private TextMeshProUGUI _status;

		// Token: 0x0400E086 RID: 57478
		[SerializeField]
		private GameObject _rewardListPrefab;

		// Token: 0x0400E087 RID: 57479
		[SerializeField]
		private GameObject _initialsContainer;

		// Token: 0x0400E088 RID: 57480
		[SerializeField]
		private GameObject _rewardsContainer;

		// Token: 0x0400E089 RID: 57481
		[SerializeField]
		private NotesTaskDescription _descriptionPanel;

		// Token: 0x0400E08A RID: 57482
		[SerializeField]
		private DelayTypeWindow _delayTypeWindow;

		// Token: 0x0400E08B RID: 57483
		[SerializeField]
		private QuestRequirementsView _requirementsBlock;

		// Token: 0x0400E08C RID: 57484
		[SerializeField]
		private QuestObjectivesView _objectivesBlock;

		// Token: 0x0400E08D RID: 57485
		[SerializeField]
		private SpriteMap _buttonIcons;

		// Token: 0x0400E08E RID: 57486
		[SerializeField]
		private DefaultUIButton _button;

		// Token: 0x0400E08F RID: 57487
		[SerializeField]
		private DefaultUIButton _buttonReRoll;

		// Token: 0x0400E090 RID: 57488
		private MultiLineTooltip _multiLineTooltip;

		// Token: 0x0400E091 RID: 57489
		private AbstractQuestControllerClass _questController;

		// Token: 0x0400E092 RID: 57490
		private GClass1246 _quest;

		// Token: 0x0400E093 RID: 57491
		private ISession _backendSession;

		// Token: 0x0400E094 RID: 57492
		private TraderClass _trader;

		// Token: 0x0400E095 RID: 57493
		private bool _performingAction;

		// Token: 0x0400E096 RID: 57494
		private GInterface313 _itemController;

		// Token: 0x0400E097 RID: 57495
		private Dictionary<ECurrencyType, int> _moneySums;

		// Token: 0x0400E098 RID: 57496
		private float _charismaDiscount;

		// Token: 0x0400E099 RID: 57497
		private Queue<RawQuestClass> _newQuestsQueue;

		// Token: 0x02002BA5 RID: 11173
		[CompilerGenerated]
		private sealed class Class2647
		{
			// Token: 0x0400E0A9 RID: 57513
			public QuestView questView_0;

			// Token: 0x0400E0AA RID: 57514
			public Action callback;
		}
	}
}
