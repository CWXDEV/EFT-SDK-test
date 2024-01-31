using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002C05 RID: 11269
	public class TraderTooltip : MonoBehaviour
	{
		// Token: 0x0600DE24 RID: 56868 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile.TraderInfo traderInfo)
		{
			throw null;
		}

		// Token: 0x0600DE25 RID: 56869 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DE26 RID: 56870 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Vector2 position)
		{
			throw null;
		}

		// Token: 0x0600DE27 RID: 56871 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0400E2D7 RID: 58071
		[SerializeField]
		private CustomTextMeshProUGUI _nickname;

		// Token: 0x0400E2D8 RID: 58072
		[SerializeField]
		private CustomTextMeshProUGUI _location;

		// Token: 0x0400E2D9 RID: 58073
		[SerializeField]
		private CustomTextMeshProUGUI _description;

		// Token: 0x0400E2DA RID: 58074
		[SerializeField]
		private CustomTextMeshProUGUI _loyaltyLevel;

		// Token: 0x0400E2DB RID: 58075
		[SerializeField]
		private CustomTextMeshProUGUI _standing;

		// Token: 0x0400E2DC RID: 58076
		[SerializeField]
		private CustomTextMeshProUGUI _moneySpent;

		// Token: 0x0400E2DD RID: 58077
		[SerializeField]
		private GameObject _nextLevelContainer;

		// Token: 0x0400E2DE RID: 58078
		[SerializeField]
		private CustomTextMeshProUGUI _standingRequired;

		// Token: 0x0400E2DF RID: 58079
		[SerializeField]
		private CustomTextMeshProUGUI _moneySpentRequired;

		// Token: 0x0400E2E0 RID: 58080
		[SerializeField]
		private CustomTextMeshProUGUI _playerLevelRequired;

		// Token: 0x0400E2E1 RID: 58081
		[SerializeField]
		private GameObject _standingMet;

		// Token: 0x0400E2E2 RID: 58082
		[SerializeField]
		private GameObject _moneySpentMet;

		// Token: 0x0400E2E3 RID: 58083
		[SerializeField]
		private GameObject _playerLevelMet;

		// Token: 0x0400E2E4 RID: 58084
		[SerializeField]
		private GameObject _detailsPanel;

		// Token: 0x0400E2E5 RID: 58085
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x0400E2E6 RID: 58086
		[SerializeField]
		private CustomTextMeshProUGUI _lockedText;

		// Token: 0x0400E2E7 RID: 58087
		[SerializeField]
		private GameObject _separator;

		// Token: 0x0400E2E8 RID: 58088
		private const string string_0 = "traders/trader_is_locked";

		// Token: 0x0400E2E9 RID: 58089
		private const string string_1 = "#747b7e";

		// Token: 0x0400E2EA RID: 58090
		private const string string_2 = "#54c1ff";

		// Token: 0x0400E2EB RID: 58091
		private const string string_3 = "#c40000";
	}
}
