using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002BFF RID: 11263
	public sealed class TraderPanel : UIElement
	{
		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600DDF4 RID: 56820 RVA: 0x00002050 File Offset: 0x00000250
		public string TraderId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DDF5 RID: 56821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600DDF6 RID: 56822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile.TraderInfo trader, AbstractQuestControllerClass quests, TraderTooltip tooltip, Action onBarterSelected)
		{
			throw null;
		}

		// Token: 0x0600DDF7 RID: 56823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectBarter()
		{
			throw null;
		}

		// Token: 0x0600DDF8 RID: 56824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DDF9 RID: 56825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DDFA RID: 56826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600DDFB RID: 56827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DDFC RID: 56828 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PointerEventData _)
		{
			throw null;
		}

		// Token: 0x0600DDFD RID: 56829 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(PointerEventData _)
		{
			throw null;
		}

		// Token: 0x0600DDFE RID: 56830 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DDFF RID: 56831 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600DE00 RID: 56832 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0400E2A0 RID: 58016
		private const double double_0 = 1.0;

		// Token: 0x0400E2A1 RID: 58017
		[SerializeField]
		private CustomTextMeshProUGUI _nickName;

		// Token: 0x0400E2A2 RID: 58018
		[SerializeField]
		private RankPanel _rankPanel;

		// Token: 0x0400E2A3 RID: 58019
		[SerializeField]
		private GameObject _questionMark;

		// Token: 0x0400E2A4 RID: 58020
		[SerializeField]
		private GameObject _newTraderLabel;

		// Token: 0x0400E2A5 RID: 58021
		[SerializeField]
		private TraderAvatar _traderAvatar;

		// Token: 0x0400E2A6 RID: 58022
		[SerializeField]
		private CustomTextMeshProUGUI _standing;

		// Token: 0x0400E2A7 RID: 58023
		[SerializeField]
		private CustomTextMeshProUGUI _timeLeft;

		// Token: 0x0400E2A8 RID: 58024
		[SerializeField]
		private TraderHoverPanel _proceedPanel;

		// Token: 0x0400E2A9 RID: 58025
		[SerializeField]
		private CanvasGroup _baseInfoGroup;

		// Token: 0x0400E2AA RID: 58026
		[SerializeField]
		private GameObject _detailsGroup;

		// Token: 0x0400E2AB RID: 58027
		[SerializeField]
		private GameObject _hiddenGroup;

		// Token: 0x0400E2AC RID: 58028
		[SerializeField]
		private GameObject _timeGroup;

		// Token: 0x0400E2AD RID: 58029
		[SerializeField]
		private GameObject _restockedGroup;

		// Token: 0x0400E2AE RID: 58030
		private TraderTooltip traderTooltip_0;

		// Token: 0x0400E2AF RID: 58031
		private DateTime dateTime_0;

		// Token: 0x0400E2B0 RID: 58032
		private Profile.TraderInfo traderInfo_0;

		// Token: 0x0400E2B1 RID: 58033
		private Action action_0;
	}
}
