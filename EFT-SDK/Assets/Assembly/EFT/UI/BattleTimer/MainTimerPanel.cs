using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;

namespace EFT.UI.BattleTimer
{
	// Token: 0x02002D7A RID: 11642
	public sealed class MainTimerPanel : TimerPanel
	{
		// Token: 0x170027D9 RID: 10201
		// (get) Token: 0x0600E4E7 RID: 58599 RVA: 0x00002050 File Offset: 0x00000250
		protected override bool DisplayTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E4E8 RID: 58600 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(DateTime dateTime, StringBuilder stringBuilder, EMainTimerState state)
		{
			throw null;
		}

		// Token: 0x0600E4E9 RID: 58601 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(EMainTimerState state)
		{
			throw null;
		}

		// Token: 0x0600E4EA RID: 58602 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E4EB RID: 58603 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateTimer()
		{
			throw null;
		}

		// Token: 0x0600E4EC RID: 58604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisplayTimer()
		{
			throw null;
		}

		// Token: 0x0600E4ED RID: 58605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideTimer()
		{
			throw null;
		}

		// Token: 0x0600E4EE RID: 58606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator Co_HideTimer(Action callback)
		{
			throw null;
		}

		// Token: 0x0400EA21 RID: 59937
		private const int int_0 = 600;

		// Token: 0x0400EA22 RID: 59938
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400EA23 RID: 59939
		[SerializeField]
		private TextMeshProUGUI _currentState;

		// Token: 0x0400EA24 RID: 59940
		[SerializeField]
		private Color _warningColor;

		// Token: 0x0400EA25 RID: 59941
		private EMainTimerState emainTimerState_0;

		// Token: 0x0400EA26 RID: 59942
		public bool ForcePull;
	}
}
