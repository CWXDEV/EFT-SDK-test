using System;
using System.Runtime.CompilerServices;
using JsonType;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DC8 RID: 11720
	public sealed class LocationConditionsPanelFactory : UIElement
	{
		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600E666 RID: 58982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E667 RID: 58983 RVA: 0x00002050 File Offset: 0x00000250
		private EDateTime EDateTime_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700280B RID: 10251
		// (get) Token: 0x0600E668 RID: 58984 RVA: 0x00002050 File Offset: 0x00000250
		private static DateTime DateTime_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700280C RID: 10252
		// (get) Token: 0x0600E669 RID: 58985 RVA: 0x00002050 File Offset: 0x00000250
		private static DateTime DateTime_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E66A RID: 58986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E66B RID: 58987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(EDateTime selectedTime, Action<EDateTime> onDateTimeSelected)
		{
			throw null;
		}

		// Token: 0x0600E66C RID: 58988 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool arg)
		{
			throw null;
		}

		// Token: 0x0600E66D RID: 58989 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool arg)
		{
			throw null;
		}

		// Token: 0x0400EB77 RID: 60279
		[SerializeField]
		private TextMeshProUGUI _currentPhaseTime;

		// Token: 0x0400EB78 RID: 60280
		[SerializeField]
		private TextMeshProUGUI _nextPhaseTime;

		// Token: 0x0400EB79 RID: 60281
		[SerializeField]
		private Image _weatherIcon;

		// Token: 0x0400EB7A RID: 60282
		[SerializeField]
		private Toggle _amTimeToggle;

		// Token: 0x0400EB7B RID: 60283
		[SerializeField]
		private Toggle _pmTimeToggle;

		// Token: 0x0400EB7C RID: 60284
		private Coroutine coroutine_0;

		// Token: 0x0400EB7D RID: 60285
		private Action<EDateTime> action_0;

		// Token: 0x0400EB7E RID: 60286
		[CompilerGenerated]
		private EDateTime edateTime_0;
	}
}
