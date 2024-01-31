using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020028B6 RID: 10422
	public sealed class BattleUIPanelExitTrigger : BattleUIPanel
	{
		// Token: 0x0600CFFA RID: 53242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(float duration)
		{
			throw null;
		}

		// Token: 0x0600CFFB RID: 53243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowRequirements(string tip)
		{
			throw null;
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_1(float duration)
		{
			throw null;
		}

		// Token: 0x0400D0F6 RID: 53494
		[SerializeField]
		private CustomTextMeshProUGUI _extractionLabel;

		// Token: 0x0400D0F7 RID: 53495
		[SerializeField]
		private Color _countdownColor;

		// Token: 0x0400D0F8 RID: 53496
		[SerializeField]
		private Color _requirementsColor;

		// Token: 0x0400D0F9 RID: 53497
		[SerializeField]
		private Image _background;

		// Token: 0x0400D0FA RID: 53498
		[SerializeField]
		private Image _glow;

		// Token: 0x0400D0FB RID: 53499
		private Coroutine coroutine_0;

		// Token: 0x0400D0FC RID: 53500
		private Coroutine coroutine_1;
	}
}
