using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002BA0 RID: 11168
	[UsedImplicitly]
	public sealed class QuestRewardList : UIElement
	{
		// Token: 0x0600DC52 RID: 56402 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(string title, IEnumerable<GClass3244> rewards, bool showUnknown, string info = null)
		{
			throw null;
		}

		// Token: 0x0400E07C RID: 57468
		[SerializeField]
		private TMP_Text _title;

		// Token: 0x0400E07D RID: 57469
		[SerializeField]
		private TMP_Text _info;

		// Token: 0x0400E07E RID: 57470
		[SerializeField]
		private ItemWideView _itemPrefab;

		// Token: 0x0400E07F RID: 57471
		[SerializeField]
		private StatView _statPrefab;

		// Token: 0x0400E080 RID: 57472
		[SerializeField]
		private TraderRewardView _traderRewardView;

		// Token: 0x0400E081 RID: 57473
		[SerializeField]
		private StashRowsRewardView _stashRowsViewTemplate;

		// Token: 0x0400E082 RID: 57474
		[SerializeField]
		private GameObject _unknownPrefab;

		// Token: 0x0400E083 RID: 57475
		[SerializeField]
		private RectTransform _container;
	}
}
