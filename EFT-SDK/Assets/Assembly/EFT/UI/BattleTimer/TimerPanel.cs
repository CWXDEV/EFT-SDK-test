using System;
using System.Runtime.CompilerServices;
using System.Text;
using TMPro;
using UnityEngine;

namespace EFT.UI.BattleTimer
{
	// Token: 0x02002D7C RID: 11644
	public class TimerPanel : UIElement
	{
		// Token: 0x170027DC RID: 10204
		// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x00002050 File Offset: 0x00000250
		protected TextMeshProUGUI TimerText
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170027DD RID: 10205
		// (get) Token: 0x0600E4F4 RID: 58612 RVA: 0x00002050 File Offset: 0x00000250
		protected virtual bool DisplayTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E4F5 RID: 58613 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(DateTime dateTime, StringBuilder stringBuilder)
		{
			throw null;
		}

		// Token: 0x0600E4F6 RID: 58614 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600E4F7 RID: 58615 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateTimer()
		{
			throw null;
		}

		// Token: 0x0600E4F8 RID: 58616 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetTimerText(TimeSpan timeSpan)
		{
			throw null;
		}

		// Token: 0x0400EA2B RID: 59947
		private const float float_0 = 1f;

		// Token: 0x0400EA2C RID: 59948
		[SerializeField]
		private TextMeshProUGUI _timerText;

		// Token: 0x0400EA2D RID: 59949
		protected TimeSpan TimeSpan;

		// Token: 0x0400EA2E RID: 59950
		private DateTime dateTime_0;

		// Token: 0x0400EA2F RID: 59951
		private StringBuilder stringBuilder_0;

		// Token: 0x0400EA30 RID: 59952
		private string string_0;

		// Token: 0x0400EA31 RID: 59953
		private double double_0;
	}
}
