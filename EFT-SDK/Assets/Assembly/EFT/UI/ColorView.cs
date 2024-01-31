using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029F1 RID: 10737
	public class ColorView : MonoBehaviour
	{
		// Token: 0x140002EB RID: 747
		// (add) Token: 0x0600D556 RID: 54614 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D557 RID: 54615 RVA: 0x00002050 File Offset: 0x00000250
		public event EventHandler OnSelected
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170025E2 RID: 9698
		// (get) Token: 0x0600D558 RID: 54616 RVA: 0x00002050 File Offset: 0x00000250
		public Color Color
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600D559 RID: 54617 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Color color)
		{
			throw null;
		}

		// Token: 0x0600D55A RID: 54618 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SelectionChanged(bool selected)
		{
			throw null;
		}

		// Token: 0x0600D55B RID: 54619 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnClick()
		{
			throw null;
		}

		// Token: 0x0400D76E RID: 55150
		[SerializeField]
		private GameObject _selectBorder;

		// Token: 0x0400D76F RID: 55151
		[SerializeField]
		private Image _colorImage;

		// Token: 0x0400D770 RID: 55152
		[CompilerGenerated]
		private EventHandler eventHandler_0;
	}
}
