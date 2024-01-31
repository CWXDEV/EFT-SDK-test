using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x020028B5 RID: 10421
	public class BattleUIPanelDeath : BattleUIPanel
	{
		// Token: 0x0600CFF7 RID: 53239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Profile activeProfile, ExitStatus exitStatus, TimeSpan playTime)
		{
			throw null;
		}

		// Token: 0x0600CFF8 RID: 53240 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void StopShowingPanel()
		{
			throw null;
		}

		// Token: 0x0600CFF9 RID: 53241 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400D0ED RID: 53485
		[SerializeField]
		private CustomTextMeshProUGUI _nickname;

		// Token: 0x0400D0EE RID: 53486
		[SerializeField]
		private CustomTextMeshProUGUI _time;

		// Token: 0x0400D0EF RID: 53487
		[SerializeField]
		private GameObject _survivedPanel;

		// Token: 0x0400D0F0 RID: 53488
		[SerializeField]
		private GameObject _leftPanel;

		// Token: 0x0400D0F1 RID: 53489
		[SerializeField]
		private GameObject _missingPanel;

		// Token: 0x0400D0F2 RID: 53490
		[SerializeField]
		private GameObject _killedPanel;

		// Token: 0x0400D0F3 RID: 53491
		[SerializeField]
		private GameObject _runnerPanel;

		// Token: 0x0400D0F4 RID: 53492
		[SerializeField]
		private BattleUIPanelExitTrigger _battleUiPanelExitTrigger;

		// Token: 0x0400D0F5 RID: 53493
		private Coroutine coroutine_0;
	}
}
