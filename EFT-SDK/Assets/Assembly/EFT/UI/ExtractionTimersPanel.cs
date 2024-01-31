using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using EFT.Interactive;
using EFT.UI.BattleTimer;
using EFT.Vehicle;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002912 RID: 10514
	public sealed class ExtractionTimersPanel : UIElement
	{
		// Token: 0x17002560 RID: 9568
		// (get) Token: 0x0600D1D8 RID: 53720 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D1D9 RID: 53721 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
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

		// Token: 0x0600D1DA RID: 53722 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTime(DateTime dateTime, EPlayerSide side, float seconds, ExfiltrationPoint[] points)
		{
			throw null;
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(EBtrState btrState)
		{
			throw null;
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetEventTimerText(string text)
		{
			throw null;
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBtrTimerText(string text)
		{
			throw null;
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowBtrTimer(DateTime dateTime = default(DateTime))
		{
			throw null;
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowEventTimer(DateTime dateTime = default(DateTime))
		{
			throw null;
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(GClass2901 invokedEvent)
		{
			throw null;
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass2900 invokedEvent)
		{
			throw null;
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SwitchTimers([CanBeNull] string pointName, bool showOnePoint)
		{
			throw null;
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ForceUpdateExfiltrationPointsVisitedStatus()
		{
			throw null;
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateExfiltrationTimers(ExfiltrationPoint point, bool availability, bool contains, bool initial, float time, EExfiltrationStatus status)
		{
			throw null;
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BlinkPointTimer(string point, Color color)
		{
			throw null;
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMainTimerState(string pointName, EMainTimerState status)
		{
			throw null;
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowTimer(bool showExits, bool updateExits = false)
		{
			throw null;
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3(ExitTimerPanel panel, int count, Color color, float delay = 0f)
		{
			throw null;
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4()
		{
			throw null;
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_5()
		{
			throw null;
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_6(RectTransform panel, Vector3 to)
		{
			throw null;
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_7(RectTransform panel, Vector2 to)
		{
			throw null;
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Hide()
		{
			throw null;
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reveal()
		{
			throw null;
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8()
		{
			throw null;
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0400D326 RID: 54054
		private const string string_0 = "00:00:00";

		// Token: 0x0400D327 RID: 54055
		private const string string_1 = "Buffer Zone Timer";

		// Token: 0x0400D328 RID: 54056
		private const string string_2 = "BtrTimer";

		// Token: 0x0400D329 RID: 54057
		private const string string_3 = "EventTimer";

		// Token: 0x0400D32A RID: 54058
		private const float float_0 = 143f;

		// Token: 0x0400D32B RID: 54059
		private const int int_0 = 60;

		// Token: 0x0400D32C RID: 54060
		[SerializeField]
		private AnimationCurve _inCurve;

		// Token: 0x0400D32D RID: 54061
		[SerializeField]
		private float _animationSpeed;

		// Token: 0x0400D32E RID: 54062
		[SerializeField]
		private RectTransform _mainDescription;

		// Token: 0x0400D32F RID: 54063
		[SerializeField]
		private RectTransform _timersPanel;

		// Token: 0x0400D330 RID: 54064
		[SerializeField]
		private MainTimerPanel _mainTimerPanel;

		// Token: 0x0400D331 RID: 54065
		[SerializeField]
		private ExitTimerPanel _timerPanelTemplate;

		// Token: 0x0400D332 RID: 54066
		[SerializeField]
		private RectTransform _container;

		// Token: 0x0400D333 RID: 54067
		[SerializeField]
		private ExitTimerPanel _bufferZoneTimerPanelTemplate;

		// Token: 0x0400D334 RID: 54068
		[SerializeField]
		private CustomTimerPanel _eventTimerTemplate;

		// Token: 0x0400D335 RID: 54069
		[SerializeField]
		private CustomTimerPanel _btrTimerTemplate;

		// Token: 0x0400D336 RID: 54070
		[SerializeField]
		private RectTransform _mainContainer;

		// Token: 0x0400D337 RID: 54071
		private ExitTimerPanel exitTimerPanel_0;

		// Token: 0x0400D338 RID: 54072
		private CustomTimerPanel customTimerPanel_0;

		// Token: 0x0400D339 RID: 54073
		private CustomTimerPanel customTimerPanel_1;

		// Token: 0x0400D33A RID: 54074
		private readonly Dictionary<string, ExitTimerPanel> dictionary_0;

		// Token: 0x0400D33B RID: 54075
		private readonly Dictionary<string, CustomTimerPanel> dictionary_1;

		// Token: 0x0400D33C RID: 54076
		private StringBuilder stringBuilder_0;

		// Token: 0x0400D33D RID: 54077
		private Coroutine coroutine_0;

		// Token: 0x0400D33E RID: 54078
		private Coroutine coroutine_1;

		// Token: 0x0400D33F RID: 54079
		private Coroutine coroutine_2;

		// Token: 0x0400D340 RID: 54080
		private CanvasGroup canvasGroup_0;

		// Token: 0x0400D341 RID: 54081
		private DateTime dateTime_0;

		// Token: 0x0400D342 RID: 54082
		private EPlayerSide eplayerSide_0;

		// Token: 0x0400D343 RID: 54083
		private bool bool_0;

		// Token: 0x0400D344 RID: 54084
		private bool bool_1;

		// Token: 0x0400D345 RID: 54085
		private bool bool_2;

		// Token: 0x0400D346 RID: 54086
		private Action action_0;

		// Token: 0x0400D347 RID: 54087
		private Action action_1;

		// Token: 0x0400D348 RID: 54088
		private bool bool_3;

		// Token: 0x0400D349 RID: 54089
		[CompilerGenerated]
		private string string_4;

		// Token: 0x02002913 RID: 10515
		[CompilerGenerated]
		private sealed class Class2399
		{
			// Token: 0x0600D1F4 RID: 53748 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D34A RID: 54090
			public BTRView btrView;

			// Token: 0x0400D34B RID: 54091
			public ExtractionTimersPanel extractionTimersPanel_0;
		}
	}
}
