using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using PlayerIcons;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C07 RID: 11271
	public sealed class TradingPlayerPanel : UIElement
	{
		// Token: 0x0600DE28 RID: 56872 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct395 GetMoneyTuple(Dictionary<ECurrencyType, int> moneySums)
		{
			throw null;
		}

		// Token: 0x0600DE29 RID: 56873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(Profile profile, Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0600DE2A RID: 56874 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStats(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0400E2EF RID: 58095
		[SerializeField]
		private TMP_Text _level;

		// Token: 0x0400E2F0 RID: 58096
		[SerializeField]
		private Image _levelIcon;

		// Token: 0x0400E2F1 RID: 58097
		[SerializeField]
		private CustomTextMeshProUGUI _nickname;

		// Token: 0x0400E2F2 RID: 58098
		[SerializeField]
		private DisplayMoneyPanelTMPText _moneyCountPanel;

		// Token: 0x0400E2F3 RID: 58099
		[SerializeField]
		private GameObject _nextRankPanel;

		// Token: 0x0400E2F4 RID: 58100
		[SerializeField]
		private RankPanel _currentRank;

		// Token: 0x0400E2F5 RID: 58101
		[SerializeField]
		private RankPanel _nextRank;

		// Token: 0x0400E2F6 RID: 58102
		[SerializeField]
		private CustomTextMeshProUGUI _currentLevel;

		// Token: 0x0400E2F7 RID: 58103
		[SerializeField]
		private CustomTextMeshProUGUI _nextLevel;

		// Token: 0x0400E2F8 RID: 58104
		[SerializeField]
		private CustomTextMeshProUGUI _currentStanding;

		// Token: 0x0400E2F9 RID: 58105
		[SerializeField]
		private CustomTextMeshProUGUI _nextStanding;

		// Token: 0x0400E2FA RID: 58106
		[SerializeField]
		private CustomTextMeshProUGUI _currentMoney;

		// Token: 0x0400E2FB RID: 58107
		[SerializeField]
		private CustomTextMeshProUGUI _nextMoney;

		// Token: 0x0400E2FC RID: 58108
		[SerializeField]
		private PlayerIconImage _playerIconImage;

		// Token: 0x0400E2FD RID: 58109
		private const string string_0 = "#54c1ff";

		// Token: 0x0400E2FE RID: 58110
		private const string string_1 = "#c40000";
	}
}
