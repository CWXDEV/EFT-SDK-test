using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.Hideout
{
	// Token: 0x02001B95 RID: 7061
	public sealed class RequirementFulfilledStatus : UIElement
	{
		// Token: 0x06009493 RID: 38035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(bool fulfilled)
		{
			throw null;
		}

		// Token: 0x04009B62 RID: 39778
		[SerializeField]
		private Image _requirementIcon;

		// Token: 0x04009B63 RID: 39779
		[SerializeField]
		private Sprite _fulfilledSprite;

		// Token: 0x04009B64 RID: 39780
		[SerializeField]
		private Sprite _failedSprite;
	}
}
