using System;
using System.Runtime.CompilerServices;
using EFT.UI.Gestures;
using EFT.UI.Screens;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002990 RID: 10640
	[UsedImplicitly]
	public sealed class GameUI : MonoBehaviourSingleton<GameUI>
	{
		// Token: 0x0600D3AB RID: 54187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400D5FB RID: 54779
		[SerializeField]
		public BattleUIScreen BattleUiScreen;

		// Token: 0x0400D5FC RID: 54780
		[SerializeField]
		public ExtractionTimersPanel TimerPanel;

		// Token: 0x0400D5FD RID: 54781
		[SerializeField]
		public BattleUIPanelDeath BattleUiPanelDeath;

		// Token: 0x0400D5FE RID: 54782
		[SerializeField]
		public GameObject BattleUiInvalidEPPanel;

		// Token: 0x0400D5FF RID: 54783
		[SerializeField]
		public BattleUIPanelExitTrigger BattleUiPanelExitTrigger;

		// Token: 0x0400D600 RID: 54784
		[SerializeField]
		public BattleUIPanelExtraction BattleUiPanelExtraction;

		// Token: 0x0400D601 RID: 54785
		[SerializeField]
		public GesturesMenu BattleUIGesturesMenu;

		// Token: 0x0400D602 RID: 54786
		[SerializeField]
		public BattleUIPmcCount BattleUiPmcCount;

		// Token: 0x0400D603 RID: 54787
		[SerializeField]
		public BattleUIBtrSeatsCount BattleUiBtrSeatsCount;

		// Token: 0x0400D604 RID: 54788
		[SerializeField]
		public GesturesQuickPanel GesturesQuickPanel;

		// Token: 0x0400D605 RID: 54789
		[SerializeField]
		public PostFXPreviewScreen PostFXPreview;
	}
}
