using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B44 RID: 11076
	public sealed class QuestsSortPanel : BaseSortPanel<EQuestsSortType>
	{
		// Token: 0x0600DB56 RID: 56150 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EQuestsSortType defaultSortingType, bool defaultAscending)
		{
			throw null;
		}

		// Token: 0x0400DEE9 RID: 57065
		[SerializeField]
		private QuestsSortPanel.QuestSortToButtonDictionary _buttons;

		// Token: 0x02002B45 RID: 11077
		[Serializable]
		public sealed class QuestSortToButtonDictionary : SerializableEnumDictionary<EQuestsSortType, FilterButton>
		{
		}
	}
}
