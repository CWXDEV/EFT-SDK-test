using System;
using System.Runtime.CompilerServices;
using JsonType;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Matchmaker
{
	// Token: 0x02002DC7 RID: 11719
	public sealed class LocationConditionsPanel : UIElement
	{
		// Token: 0x17002806 RID: 10246
		// (get) Token: 0x0600E659 RID: 58969 RVA: 0x00002050 File Offset: 0x00000250
		private static DateTime DateTime_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002807 RID: 10247
		// (get) Token: 0x0600E65A RID: 58970 RVA: 0x00002050 File Offset: 0x00000250
		private static DateTime DateTime_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000342 RID: 834
		// (add) Token: 0x0600E65B RID: 58971 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600E65C RID: 58972 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EDateTime> OnTimeChanged
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

		// Token: 0x17002808 RID: 10248
		// (get) Token: 0x0600E65D RID: 58973 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600E65E RID: 58974 RVA: 0x00002050 File Offset: 0x00000250
		public EDateTime SelectedDateTime
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

		// Token: 0x17002809 RID: 10249
		// (get) Token: 0x0600E65F RID: 58975 RVA: 0x00002050 File Offset: 0x00000250
		private DateTime DateTime_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600E660 RID: 58976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600E661 RID: 58977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Set(ISession session, RaidSettings raidSettings, bool takeFromCurrent)
		{
			throw null;
		}

		// Token: 0x0600E662 RID: 58978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600E663 RID: 58979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E664 RID: 58980 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool arg)
		{
			throw null;
		}

		// Token: 0x0600E665 RID: 58981 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(bool arg)
		{
			throw null;
		}

		// Token: 0x0400EB6B RID: 60267
		public const string DATE_TIME_FORMAT = "HH:mm:ss";

		// Token: 0x0400EB6C RID: 60268
		[SerializeField]
		private TextMeshProUGUI _currentPhaseTime;

		// Token: 0x0400EB6D RID: 60269
		[SerializeField]
		private TextMeshProUGUI _nextPhaseTime;

		// Token: 0x0400EB6E RID: 60270
		[SerializeField]
		private Image _weatherIcon;

		// Token: 0x0400EB6F RID: 60271
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0400EB70 RID: 60272
		[SerializeField]
		private Toggle _amTimeToggle;

		// Token: 0x0400EB71 RID: 60273
		[SerializeField]
		private Toggle _pmTimeToggle;

		// Token: 0x0400EB72 RID: 60274
		[CompilerGenerated]
		private Action<EDateTime> action_0;

		// Token: 0x0400EB73 RID: 60275
		private bool bool_0;

		// Token: 0x0400EB74 RID: 60276
		private ISession ginterface145_0;

		// Token: 0x0400EB75 RID: 60277
		private EDateTime edateTime_0;

		// Token: 0x0400EB76 RID: 60278
		private bool bool_1;
	}
}
