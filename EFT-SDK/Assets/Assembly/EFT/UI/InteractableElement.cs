using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002A1A RID: 10778
	public class InteractableElement : UIElement
	{
		// Token: 0x170025FA RID: 9722
		// (get) Token: 0x0600D641 RID: 54849 RVA: 0x00002050 File Offset: 0x00000250
		protected CanvasGroup CanvasGroup
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025FB RID: 9723
		// (get) Token: 0x0600D642 RID: 54850 RVA: 0x00002050 File Offset: 0x00000250
		private HoverTooltipArea HoverTooltipArea_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170025FC RID: 9724
		// (get) Token: 0x0600D643 RID: 54851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D644 RID: 54852 RVA: 0x00002050 File Offset: 0x00000250
		public virtual bool Interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600D645 RID: 54853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnabledTooltip(string tooltip, bool rawText = false)
		{
			throw null;
		}

		// Token: 0x0600D646 RID: 54854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledTooltip(string tooltip, bool rawText = false)
		{
			throw null;
		}

		// Token: 0x0600D647 RID: 54855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEnabledTooltip(Func<string> tooltipGetter, bool rawText = false)
		{
			throw null;
		}

		// Token: 0x0600D648 RID: 54856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDisabledTooltip(Func<string> tooltipGetter)
		{
			throw null;
		}

		// Token: 0x0600D649 RID: 54857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400D8A0 RID: 55456
		[SerializeField]
		protected bool _unavailable;

		// Token: 0x0400D8A1 RID: 55457
		private CanvasGroup canvasGroup_0;

		// Token: 0x0400D8A2 RID: 55458
		private HoverTooltipArea hoverTooltipArea_0;

		// Token: 0x0400D8A3 RID: 55459
		private Func<string> func_0;

		// Token: 0x0400D8A4 RID: 55460
		private Func<string> func_1;

		// Token: 0x02002A1B RID: 10779
		[CompilerGenerated]
		private sealed class Class2486
		{
			// Token: 0x0600D64A RID: 54858 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x0400D8A5 RID: 55461
			public bool rawText;

			// Token: 0x0400D8A6 RID: 55462
			public string tooltip;
		}

		// Token: 0x02002A1C RID: 10780
		[CompilerGenerated]
		private sealed class Class2487
		{
			// Token: 0x0600D64B RID: 54859 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x0400D8A7 RID: 55463
			public bool rawText;

			// Token: 0x0400D8A8 RID: 55464
			public string tooltip;
		}

		// Token: 0x02002A1D RID: 10781
		[CompilerGenerated]
		private sealed class Class2488
		{
			// Token: 0x0600D64C RID: 54860 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0()
			{
				throw null;
			}

			// Token: 0x0400D8A9 RID: 55465
			public Func<string> tooltipGetter;
		}
	}
}
