using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200297E RID: 10622
	public class FilterButton : UIElement
	{
		// Token: 0x1700258D RID: 9613
		// (get) Token: 0x0600D366 RID: 54118 RVA: 0x00002050 File Offset: 0x00000250
		public Button.ButtonClickedEvent OnClicked
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D367 RID: 54119 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show()
		{
			throw null;
		}

		// Token: 0x0600D368 RID: 54120 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyAscend()
		{
			throw null;
		}

		// Token: 0x0600D369 RID: 54121 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyDescend()
		{
			throw null;
		}

		// Token: 0x0600D36A RID: 54122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowIcon()
		{
			throw null;
		}

		// Token: 0x0600D36B RID: 54123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideIcon()
		{
			throw null;
		}

		// Token: 0x0400D56C RID: 54636
		[SerializeField]
		protected Button _button;

		// Token: 0x0400D56D RID: 54637
		[SerializeField]
		protected Image _icon;

		// Token: 0x0400D56E RID: 54638
		[SerializeField]
		protected Sprite _on;

		// Token: 0x0400D56F RID: 54639
		[SerializeField]
		protected Sprite _off;
	}
}
