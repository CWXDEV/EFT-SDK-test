using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002AFB RID: 11003
	public sealed class AchievementsSortPanel : BaseSortPanel<EAchievementsSortType>
	{
		// Token: 0x0600DA73 RID: 55923 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(EAchievementsSortType defaultSortingType, bool defaultAscending)
		{
			throw null;
		}

		// Token: 0x0400DD6F RID: 56687
		[SerializeField]
		private AchievementsSortPanel.AchievementsSortToButtonDictionary _buttons;

		// Token: 0x02002AFC RID: 11004
		[Serializable]
		public sealed class AchievementsSortToButtonDictionary : SerializableEnumDictionary<EAchievementsSortType, FilterButton>
		{
		}
	}
}
