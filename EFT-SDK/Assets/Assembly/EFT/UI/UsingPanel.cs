using System;
using System.Collections;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200291B RID: 10523
	public class UsingPanel : UIElement
	{
		// Token: 0x0600D223 RID: 53795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(IHealthController healthController, GInterface311 itemController)
		{
			throw null;
		}

		// Token: 0x0600D224 RID: 53796 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string itemName, float useTime)
		{
			throw null;
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(GEventArgs6 args)
		{
			throw null;
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4(float duration)
		{
			throw null;
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D376 RID: 54134
		[SerializeField]
		private CustomTextMeshProUGUI _caption;

		// Token: 0x0400D377 RID: 54135
		[SerializeField]
		private CustomTextMeshProUGUI _itemName;

		// Token: 0x0400D378 RID: 54136
		[SerializeField]
		private Image _progressBarImage;

		// Token: 0x0400D379 RID: 54137
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0400D37A RID: 54138
		[SerializeField]
		private Color _examineColor;

		// Token: 0x0400D37B RID: 54139
		private DateTime dateTime_0;

		// Token: 0x0400D37C RID: 54140
		private DateTime dateTime_1;

		// Token: 0x0400D37D RID: 54141
		private Coroutine coroutine_0;

		// Token: 0x0400D37E RID: 54142
		private IEffect ginterface229_0;
	}
}
