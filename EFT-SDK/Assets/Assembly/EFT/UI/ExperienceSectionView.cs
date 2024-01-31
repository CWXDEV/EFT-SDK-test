using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002ADE RID: 10974
	public sealed class ExperienceSectionView : UIElement
	{
		// Token: 0x0600DA0C RID: 55820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass3103 section)
		{
			throw null;
		}

		// Token: 0x0400DCFD RID: 56573
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400DCFE RID: 56574
		[SerializeField]
		private CustomTextMeshProUGUI _value;

		// Token: 0x0400DCFF RID: 56575
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DD00 RID: 56576
		[SerializeField]
		[Space]
		private Transform _articlesContainer;

		// Token: 0x0400DD01 RID: 56577
		[SerializeField]
		private ExperienceArticleView _articleTemplate;

		// Token: 0x02002ADF RID: 10975
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2572
		{
			// Token: 0x0600DA0D RID: 55821 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GStruct397 article, ExperienceArticleView view)
			{
				throw null;
			}

			// Token: 0x0400DD02 RID: 56578
			public static readonly ExperienceSectionView.Class2572 class2572_0;

			// Token: 0x0400DD03 RID: 56579
			public static Action<GStruct397, ExperienceArticleView> action_0;
		}
	}
}
