using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002946 RID: 10566
	public sealed class ContextMenuButton : SimpleContextMenuButton
	{
		// Token: 0x0600D2C4 RID: 53956 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Show(string caption, string imageText, Sprite sprite, Action onClicked, Action onHover, bool subMenu = false, bool hideIcon = false)
		{
			throw null;
		}

		// Token: 0x0400D450 RID: 54352
		[SerializeField]
		private Image _icon;

		// Token: 0x0400D451 RID: 54353
		[SerializeField]
		private GameObject _iconContainer;

		// Token: 0x0400D452 RID: 54354
		[SerializeField]
		private TextMeshProUGUI _text;

		// Token: 0x0400D453 RID: 54355
		[SerializeField]
		private TextMeshProUGUI _iconLabel;

		// Token: 0x0400D454 RID: 54356
		[SerializeField]
		private GameObject _loader;
	}
}
