using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.Jobs
{
	// Token: 0x020030D7 RID: 12503
	public class JobScheduler : MonoBehaviour
	{
		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600F50A RID: 62730 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F50B RID: 62731 RVA: 0x00002050 File Offset: 0x00000250
		public static int AvgTimeBufferSize
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

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x0600F50C RID: 62732 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F50D RID: 62733 RVA: 0x00002050 File Offset: 0x00000250
		public long FrameTicks
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

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x0600F50E RID: 62734 RVA: 0x00002050 File Offset: 0x00000250
		public long LoopTicks
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x0600F50F RID: 62735 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600F510 RID: 62736 RVA: 0x00002050 File Offset: 0x00000250
		public byte SlowFrames
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

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x0600F511 RID: 62737 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x0600F512 RID: 62738 RVA: 0x00002050 File Offset: 0x00000250
		private static bool Boolean_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x0600F513 RID: 62739 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600F514 RID: 62740 RVA: 0x00002050 File Offset: 0x00000250
		public static int QueueLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F515 RID: 62741 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(bool enableContinuationProfiler)
		{
			throw null;
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600F516 RID: 62742 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsForceModeEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600F517 RID: 62743 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetForceMode(bool enable, float forceModeMultiplier = -1f)
		{
			throw null;
		}

		// Token: 0x0600F518 RID: 62744 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetTargetFrameRate(int frameRate)
		{
			throw null;
		}

		// Token: 0x0600F519 RID: 62745 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator Start()
		{
			throw null;
		}

		// Token: 0x0600F51A RID: 62746 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600F51B RID: 62747 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600F51C RID: 62748 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Interface19 executeCondition)
		{
			throw null;
		}

		// Token: 0x0600F51D RID: 62749 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(ref List<Struct1039> continuations, ref List<Struct1039> continuationsDoubleBuffer, List<Struct1039> delayedContinuations, Interface19 executeCondition)
		{
			throw null;
		}

		// Token: 0x0600F51E RID: 62750 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool ForceExecuteContinuations(GClass3349 jobYield)
		{
			throw null;
		}

		// Token: 0x0600F51F RID: 62751 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(List<Struct1039> continuations)
		{
			throw null;
		}

		// Token: 0x0600F520 RID: 62752 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void smethod_1(Action action, GClass3349 jobYield)
		{
			throw null;
		}

		// Token: 0x0600F521 RID: 62753 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GInterface384 Yield(EJobPriority priority = EJobPriority.General, GClass3349 jobYield = null)
		{
			throw null;
		}

		// Token: 0x0600F522 RID: 62754 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetPerformanceReport()
		{
			throw null;
		}

		// Token: 0x0600F523 RID: 62755 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_3(Struct1039 continuation)
		{
			throw null;
		}

		// Token: 0x0400FAFF RID: 64255
		public static int FreeTimeWindowFrame;

		// Token: 0x0400FB00 RID: 64256
		public static float MaxAvgFrameLoad;

		// Token: 0x0400FB01 RID: 64257
		private static GClass3351 gclass3351_0;

		// Token: 0x0400FB02 RID: 64258
		public static readonly JobScheduler.GClass3348 WorkingStats;

		// Token: 0x0400FB03 RID: 64259
		private static bool bool_0;

		// Token: 0x0400FB04 RID: 64260
		private const int int_0 = 1024;

		// Token: 0x0400FB05 RID: 64261
		private static List<Struct1039> list_0;

		// Token: 0x0400FB06 RID: 64262
		private static List<Struct1039> list_1;

		// Token: 0x0400FB07 RID: 64263
		private static List<Struct1039> list_2;

		// Token: 0x0400FB08 RID: 64264
		private static List<Struct1039> list_3;

		// Token: 0x0400FB09 RID: 64265
		private static List<Struct1039> list_4;

		// Token: 0x0400FB0A RID: 64266
		private Class3154 class3154_0;

		// Token: 0x0400FB0B RID: 64267
		private static Class3155 class3155_0;

		// Token: 0x0400FB0C RID: 64268
		internal static readonly Class3152 class3152_0;

		// Token: 0x0400FB0D RID: 64269
		private static readonly Class3151 class3151_0;

		// Token: 0x0400FB0E RID: 64270
		internal static Class3153 class3153_0;

		// Token: 0x0400FB0F RID: 64271
		private static readonly WaitForEndOfFrame waitForEndOfFrame_0;

		// Token: 0x0400FB10 RID: 64272
		private readonly Stopwatch stopwatch_0;

		// Token: 0x0400FB11 RID: 64273
		private readonly Stopwatch stopwatch_1;

		// Token: 0x0400FB12 RID: 64274
		private bool bool_1;

		// Token: 0x0400FB13 RID: 64275
		public float DefaultForceModeMultiplier;

		// Token: 0x0400FB14 RID: 64276
		private float float_0;

		// Token: 0x0400FB15 RID: 64277
		[CompilerGenerated]
		private long long_0;

		// Token: 0x0400FB16 RID: 64278
		[CompilerGenerated]
		private byte byte_0;

		// Token: 0x0400FB17 RID: 64279
		private int int_1;

		// Token: 0x0400FB18 RID: 64280
		private int int_2;

		// Token: 0x020030D8 RID: 12504
		public class GClass3348
		{
			// Token: 0x0600F524 RID: 62756 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override string ToString()
			{
				throw null;
			}

			// Token: 0x0400FB19 RID: 64281
			public long WorkCpuLoad;

			// Token: 0x0400FB1A RID: 64282
			public float WorkCpuLoadPercent;

			// Token: 0x0400FB1B RID: 64283
			public GClass3350 AvgWorkCpuLoad;

			// Token: 0x0400FB1C RID: 64284
			public float MaxWorkCpuLoadPercent;
		}
	}
}
