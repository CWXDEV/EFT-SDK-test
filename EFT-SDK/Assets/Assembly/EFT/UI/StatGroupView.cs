using System;
using System.Runtime.CompilerServices;
using EFT.UI.SessionEnd;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AF7 RID: 10999
	public sealed class StatGroupView : UIElement
	{
		// Token: 0x0600DA6E RID: 55918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(SessionResultStatistics.GClass3105 statGroup)
		{
			throw null;
		}

		// Token: 0x0400DD64 RID: 56676
		[SerializeField]
		private GameObject _headerGameObject;

		// Token: 0x0400DD65 RID: 56677
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400DD66 RID: 56678
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DD67 RID: 56679
		[SerializeField]
		private Transform _itemsContainer;

		// Token: 0x0400DD68 RID: 56680
		[SerializeField]
		private StatItemView _statItemViewTemplate;

		// Token: 0x02002AF8 RID: 11000
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2581
		{
			// Token: 0x0600DA6F RID: 55919 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(ProfileStats.GClass690 statItem, StatItemView statItemView)
			{
				throw null;
			}

			// Token: 0x0400DD69 RID: 56681
			public static readonly StatGroupView.Class2581 class2581_0;

			// Token: 0x0400DD6A RID: 56682
			public static Action<ProfileStats.GClass690, StatItemView> action_0;
		}
	}
}
