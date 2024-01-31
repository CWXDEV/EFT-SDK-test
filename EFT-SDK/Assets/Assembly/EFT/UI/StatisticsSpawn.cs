using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.UI.SessionEnd;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AD7 RID: 10967
	public sealed class StatisticsSpawn : UIElement
	{
		// Token: 0x0600DA04 RID: 55812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(Profile profile, SessionCountersClass counters, StatisticsSpawn.EStatisticsType type)
		{
			throw null;
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private GameObject method_1()
		{
			throw null;
		}

		// Token: 0x0400DCE6 RID: 56550
		[SerializeField]
		private StatGroupView _statGroupViewTemplate;

		// Token: 0x0400DCE7 RID: 56551
		[SerializeField]
		private Transform _statsContainer;

		// Token: 0x0400DCE8 RID: 56552
		[SerializeField]
		private HorizontalLayoutGroup _horizontalGroup;

		// Token: 0x02002AD8 RID: 10968
		public enum EStatisticsType
		{
			// Token: 0x0400DCEA RID: 56554
			Overall,
			// Token: 0x0400DCEB RID: 56555
			Session
		}

		// Token: 0x02002AD9 RID: 10969
		public enum EStatGroupLayoutType
		{
			// Token: 0x0400DCED RID: 56557
			Default,
			// Token: 0x0400DCEE RID: 56558
			SameColumn
		}

		// Token: 0x02002ADA RID: 10970
		[CompilerGenerated]
		private sealed class Class2570
		{
			// Token: 0x0600DA06 RID: 55814 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(SessionResultStatistics.GClass3105 group, StatGroupView groupView)
			{
				throw null;
			}

			// Token: 0x0600DA07 RID: 55815 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Task method_1()
			{
				throw null;
			}

			// Token: 0x0400DCEF RID: 56559
			public StatisticsSpawn statisticsSpawn_0;

			// Token: 0x0400DCF0 RID: 56560
			public StatGroupView prevGroupView;

			// Token: 0x0400DCF1 RID: 56561
			public List<ValueTuple<StatGroupView, StatGroupView>> updateParents;

			// Token: 0x0400DCF2 RID: 56562
			public int currentViewCount;

			// Token: 0x0400DCF3 RID: 56563
			public GameObject currentGroup;

			// Token: 0x0400DCF4 RID: 56564
			public GClass3076<SessionResultStatistics.GClass3105, StatGroupView> viewList;

			// Token: 0x0400DCF5 RID: 56565
			public CancellationToken cancellationToken;

			// Token: 0x02002ADB RID: 10971
			[StructLayout(LayoutKind.Auto)]
			public struct Struct894 : IAsyncStateMachine
			{
				// Token: 0x0600DA08 RID: 55816 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.MoveNext()
				{
					throw null;
				}

				// Token: 0x0600DA09 RID: 55817 RVA: 0x00002050 File Offset: 0x00000250
				[DebuggerHidden]
				[MethodImpl(MethodImplOptions.NoInlining)]
				void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
				{
					throw null;
				}

				// Token: 0x0400DCF6 RID: 56566
				public int int_0;

				// Token: 0x0400DCF7 RID: 56567
				public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

				// Token: 0x0400DCF8 RID: 56568
				public StatisticsSpawn.Class2570 class2570_0;

				// Token: 0x0400DCF9 RID: 56569
				private TaskAwaiter taskAwaiter_0;
			}
		}

		// Token: 0x02002ADC RID: 10972
		[CompilerGenerated]
		private sealed class Class2571
		{
			// Token: 0x0600DA0A RID: 55818 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400DCFA RID: 56570
			public HorizontalLayoutGroup group;
		}
	}
}
