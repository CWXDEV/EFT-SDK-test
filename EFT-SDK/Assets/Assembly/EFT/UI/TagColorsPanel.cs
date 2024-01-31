using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020029F3 RID: 10739
	public class TagColorsPanel : MonoBehaviour
	{
		// Token: 0x0600D564 RID: 54628 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Color[] colors, int selectedIndex, Action<ColorView, int> OnSelected)
		{
			throw null;
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(object sender, EventArgs e)
		{
			throw null;
		}

		// Token: 0x0400D77F RID: 55167
		[SerializeField]
		private GameObject _cellTemplate;

		// Token: 0x0400D780 RID: 55168
		private ColorView[] colorView_0;

		// Token: 0x0400D781 RID: 55169
		private Action<ColorView, int> action_0;
	}
}
