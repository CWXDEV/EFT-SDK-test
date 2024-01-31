using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B95 RID: 11157
	public class QuestListItem : UIElement
	{
		// Token: 0x0600DC2F RID: 56367 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DC30 RID: 56368 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(GClass1246 quest, Action<QuestListItem> onSelect)
		{
			throw null;
		}

		// Token: 0x0600DC31 RID: 56369 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateView()
		{
			throw null;
		}

		// Token: 0x0600DC32 RID: 56370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PrepareTimer()
		{
			throw null;
		}

		// Token: 0x0600DC33 RID: 56371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UpdateDailyView(GClass1247 daily, bool isSelected)
		{
			throw null;
		}

		// Token: 0x0600DC34 RID: 56372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetSelected(bool selected)
		{
			throw null;
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnQuestStatusChanged(GClass1246 quest, bool notify)
		{
			throw null;
		}

		// Token: 0x0600DC36 RID: 56374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Task UpdateTimer(CancellationToken token)
		{
			throw null;
		}

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool HandleDailyTimer(GClass1247 dailyQuest)
		{
			throw null;
		}

		// Token: 0x0600DC38 RID: 56376 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool HandleDefaultTimer(int timeToFail)
		{
			throw null;
		}

		// Token: 0x0600DC39 RID: 56377 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopTimer()
		{
			throw null;
		}

		// Token: 0x0600DC3A RID: 56378 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400E03F RID: 57407
		[SerializeField]
		private Button _questButton;

		// Token: 0x0400E040 RID: 57408
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0400E041 RID: 57409
		[SerializeField]
		private CustomTextMeshProUGUI _title;

		// Token: 0x0400E042 RID: 57410
		[SerializeField]
		private Image _starIcon;

		// Token: 0x0400E043 RID: 57411
		[SerializeField]
		private CustomTextMeshProUGUI _status;

		// Token: 0x0400E044 RID: 57412
		[SerializeField]
		private Image _lockedIcon;

		// Token: 0x0400E045 RID: 57413
		[SerializeField]
		private CustomTextMeshProUGUI _timer;

		// Token: 0x0400E046 RID: 57414
		[SerializeField]
		private Image _timerIcon;

		// Token: 0x0400E047 RID: 57415
		[SerializeField]
		private Image _selectedIcon;

		// Token: 0x0400E048 RID: 57416
		[SerializeField]
		private Image _background;

		// Token: 0x0400E049 RID: 57417
		[SerializeField]
		private GameObject _dailyBackground;

		// Token: 0x0400E04A RID: 57418
		[SerializeField]
		private Image _scavBackground;

		// Token: 0x0400E04B RID: 57419
		[SerializeField]
		private ColorMap _backColors;

		// Token: 0x0400E04C RID: 57420
		[SerializeField]
		private ColorMap _scavBackColors;

		// Token: 0x0400E04D RID: 57421
		[SerializeField]
		private ColorMap _textColors;

		// Token: 0x0400E04E RID: 57422
		public GClass1246 Quest;

		// Token: 0x0400E04F RID: 57423
		private Action<QuestListItem> _onSelect;

		// Token: 0x0400E050 RID: 57424
		private bool _isSelected;

		// Token: 0x0400E051 RID: 57425
		private IEnumerator _timerWorker;

		// Token: 0x0400E052 RID: 57426
		private CancellationTokenSource _timerCancellation;
	}
}
