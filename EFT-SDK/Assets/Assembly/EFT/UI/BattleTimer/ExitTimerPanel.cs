using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using EFT.Interactive;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.BattleTimer
{
	// Token: 0x02002D75 RID: 11637
	public class ExitTimerPanel : TimerPanel
	{
		// Token: 0x0600E4D3 RID: 58579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show(DateTime dateTime, EPlayerSide side, int index, StringBuilder stringBuilder, bool subscribe, string profileId, ExfiltrationPoint point = null, bool isActiveBufferZoneTimer = false)
		{
			throw null;
		}

		// Token: 0x0600E4D4 RID: 58580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600E4D5 RID: 58581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetVisitedStatus(ExitTimerPanel.EVisitedStatus visited)
		{
			throw null;
		}

		// Token: 0x0600E4D6 RID: 58582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RedrawCurrentVisitedStatus()
		{
			throw null;
		}

		// Token: 0x0600E4D7 RID: 58583 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateVisitedStatus()
		{
			throw null;
		}

		// Token: 0x0600E4D8 RID: 58584 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_1(string profileId)
		{
			throw null;
		}

		// Token: 0x0600E4D9 RID: 58585 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTimerColor(EMainTimerState status)
		{
			throw null;
		}

		// Token: 0x0600E4DA RID: 58586 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600E4DB RID: 58587 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetTimerTextActive()
		{
			throw null;
		}

		// Token: 0x0600E4DC RID: 58588 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3()
		{
			throw null;
		}

		// Token: 0x0600E4DD RID: 58589 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected TimeSpan GetTimerRequirementTime()
		{
			throw null;
		}

		// Token: 0x0600E4DE RID: 58590 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TimeSpan method_4()
		{
			throw null;
		}

		// Token: 0x0600E4DF RID: 58591 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void UpdateTimer()
		{
			throw null;
		}

		// Token: 0x0600E4E0 RID: 58592 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void SetTimerText(TimeSpan timeSpan)
		{
			throw null;
		}

		// Token: 0x0600E4E1 RID: 58593 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerator Co_ChangeColor(Color to)
		{
			throw null;
		}

		// Token: 0x0400E9F1 RID: 59889
		private const string string_1 = "Buffer_zone_timer";

		// Token: 0x0400E9F2 RID: 59890
		private const int int_0 = 10;

		// Token: 0x0400E9F3 RID: 59891
		[SerializeField]
		protected GameObject _itemsObject;

		// Token: 0x0400E9F4 RID: 59892
		[SerializeField]
		private CustomTextMeshProUGUI _itemsToBringLabel;

		// Token: 0x0400E9F5 RID: 59893
		[SerializeField]
		private CustomTextMeshProUGUI _pointStatusLabel;

		// Token: 0x0400E9F6 RID: 59894
		[SerializeField]
		private CustomTextMeshProUGUI _pointName;

		// Token: 0x0400E9F7 RID: 59895
		[SerializeField]
		private Image _backgroundImage;

		// Token: 0x0400E9F8 RID: 59896
		[SerializeField]
		private Image _requirementImage;

		// Token: 0x0400E9F9 RID: 59897
		[SerializeField]
		private Image _timerImage;

		// Token: 0x0400E9FA RID: 59898
		[SerializeField]
		private Image _bufferZoneTimerIcon;

		// Token: 0x0400E9FB RID: 59899
		[SerializeField]
		private Color _visitedTextColor;

		// Token: 0x0400E9FC RID: 59900
		[SerializeField]
		private Color _notVisitedTextColor;

		// Token: 0x0400E9FD RID: 59901
		[SerializeField]
		private Color _lockedTextColor;

		// Token: 0x0400E9FE RID: 59902
		[SerializeField]
		private Color _bufferZoneBackgroundColor;

		// Token: 0x0400E9FF RID: 59903
		[SerializeField]
		private Color _bufferZoneTextColor;

		// Token: 0x0400EA00 RID: 59904
		[SerializeField]
		private Color _defaultTimerColor;

		// Token: 0x0400EA01 RID: 59905
		[SerializeField]
		private Color _warningTimerColor;

		// Token: 0x0400EA02 RID: 59906
		[SerializeField]
		private Color _defaultTimerBackgroundColor;

		// Token: 0x0400EA03 RID: 59907
		[SerializeField]
		private Color _warningTimerBackgroundColor;

		// Token: 0x0400EA04 RID: 59908
		[SerializeField]
		private GameObject _discountStats;

		// Token: 0x0400EA05 RID: 59909
		[SerializeField]
		private TextMeshProUGUI _totalDiscount;

		// Token: 0x0400EA06 RID: 59910
		[SerializeField]
		private TextMeshProUGUI _fencerRep;

		// Token: 0x0400EA07 RID: 59911
		private Color color_0;

		// Token: 0x0400EA08 RID: 59912
		protected ExfiltrationPoint _point;

		// Token: 0x0400EA09 RID: 59913
		private Coroutine coroutine_0;

		// Token: 0x0400EA0A RID: 59914
		private DateTime dateTime_1;

		// Token: 0x0400EA0B RID: 59915
		private ExitTimerPanel.EVisitedStatus evisitedStatus_0;

		// Token: 0x0400EA0C RID: 59916
		private EPlayerSide eplayerSide_0;

		// Token: 0x0400EA0D RID: 59917
		private int int_1;

		// Token: 0x0400EA0E RID: 59918
		private string string_2;

		// Token: 0x0400EA0F RID: 59919
		private bool bool_0;

		// Token: 0x0400EA10 RID: 59920
		private bool bool_1;

		// Token: 0x0400EA11 RID: 59921
		private int int_2;

		// Token: 0x02002D76 RID: 11638
		public enum EVisitedStatus
		{
			// Token: 0x0400EA13 RID: 59923
			NotVisited,
			// Token: 0x0400EA14 RID: 59924
			Visited,
			// Token: 0x0400EA15 RID: 59925
			Locked,
			// Token: 0x0400EA16 RID: 59926
			BufferZone
		}

		// Token: 0x02002D77 RID: 11639
		[CompilerGenerated]
		private sealed class Class2807
		{
			// Token: 0x0600E4E2 RID: 58594 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer x)
			{
				throw null;
			}

			// Token: 0x0400EA17 RID: 59927
			public string profileId;
		}
	}
}
