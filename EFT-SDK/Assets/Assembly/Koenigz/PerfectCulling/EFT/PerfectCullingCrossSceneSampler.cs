using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Koenigz.PerfectCulling.EFT
{
	// Token: 0x02000E32 RID: 3634
	public sealed class PerfectCullingCrossSceneSampler : MonoBehaviour
	{
		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x06004BE3 RID: 19427 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004BE4 RID: 19428 RVA: 0x00002050 File Offset: 0x00000250
		public static PerfectCullingCrossSceneSampler Instance
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06004BE5 RID: 19429 RVA: 0x00002050 File Offset: 0x00000250
		public static bool Exists
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06004BE6 RID: 19430 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004BE7 RID: 19431 RVA: 0x00002050 File Offset: 0x00000250
		public PerfectCullingCamera CullingCamera
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

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06004BE8 RID: 19432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004BE9 RID: 19433 RVA: 0x00002050 File Offset: 0x00000250
		public bool ShowStats
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

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06004BEA RID: 19434 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUpdatingVisibility
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BEB RID: 19435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004BEC RID: 19436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004BED RID: 19437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004BEE RID: 19438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06004BEF RID: 19439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shutdown()
		{
			throw null;
		}

		// Token: 0x06004BF0 RID: 19440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task InitializeAutoCulling(CancellationToken token, IProgress<float> progress = null)
		{
			throw null;
		}

		// Token: 0x06004BF1 RID: 19441 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(Scene prev, Scene newScene)
		{
			throw null;
		}

		// Token: 0x06004BF2 RID: 19442 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1()
		{
			throw null;
		}

		// Token: 0x06004BF3 RID: 19443 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int GetRuntimeMemoryUsageMb()
		{
			throw null;
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06004BF4 RID: 19444 RVA: 0x00002050 File Offset: 0x00000250
		public static bool IsAutocullingExists
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004BF5 RID: 19445 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DeinitializeAutoCulling()
		{
			throw null;
		}

		// Token: 0x06004BF6 RID: 19446 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0()
		{
			throw null;
		}

		// Token: 0x06004BF7 RID: 19447 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004BF8 RID: 19448 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06004BF9 RID: 19449 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ScheduleUpdate(GClass1013<int> inputRuntimeVolumeIds, GClass1013<int> inputGroupIds)
		{
			throw null;
		}

		// Token: 0x06004BFA RID: 19450 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public JobHandle? ScheduleJob(GClass1013<int> inputRuntimeVolumeIds, GClass1013<int> inputGroupIds)
		{
			throw null;
		}

		// Token: 0x06004BFB RID: 19451 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool FinishJob(JobHandle handle)
		{
			throw null;
		}

		// Token: 0x06004BFC RID: 19452 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AwaitWorkJobFinish()
		{
			throw null;
		}

		// Token: 0x06004BFD RID: 19453 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(object p)
		{
			throw null;
		}

		// Token: 0x06004BFE RID: 19454 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_3(CancellationToken terminateToken, PerfectCullingCamera camera, Vector3 worldPos, HashSet<int> volumeIds, HashSet<int> groupIds, List<int> removeCells, List<int> sortedIndices)
		{
			throw null;
		}

		// Token: 0x06004BFF RID: 19455 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_4(CancellationToken terminateToken, Vector3 worldPos, HashSet<int> volumeIds, List<int> removeCells, List<int> sortedIndices)
		{
			throw null;
		}

		// Token: 0x06004C00 RID: 19456 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_5(CancellationToken terminateToken, PerfectCullingCamera camera, HashSet<int> groupIds)
		{
			throw null;
		}

		// Token: 0x06004C01 RID: 19457 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UpdateBakedLODVisibility(PerfectCullingCrossSceneGroup group, ScreenDistanceSwitcher lod)
		{
			throw null;
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06004C02 RID: 19458 RVA: 0x00002050 File Offset: 0x00000250
		internal static int Int32_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004C03 RID: 19459 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static CullingCellData smethod_6(CullingCellData newCell)
		{
			throw null;
		}

		// Token: 0x06004C04 RID: 19460 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_7()
		{
			throw null;
		}

		// Token: 0x06004C05 RID: 19461 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static bool smethod_8(ScreenDistanceSwitcher sw, List<PerfectCullingCrossSceneSampler.Class721> cameras)
		{
			throw null;
		}

		// Token: 0x06004C06 RID: 19462 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_9()
		{
			throw null;
		}

		// Token: 0x06004C07 RID: 19463 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004C08 RID: 19464 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004C09 RID: 19465 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x040056DA RID: 22234
		[CompilerGenerated]
		private static PerfectCullingCrossSceneSampler perfectCullingCrossSceneSampler_0;

		// Token: 0x040056DB RID: 22235
		[Tooltip("Current culling camera.")]
		[SerializeField]
		private PerfectCullingCamera _cullingCamera;

		// Token: 0x040056DC RID: 22236
		[SerializeField]
		[Tooltip("Number of work threads for presampling data. Typically 2 threads is enough. More threads may lead to poor performance.")]
		private int _numWorkThreads;

		// Token: 0x040056DD RID: 22237
		[SerializeField]
		private PerfectCullingCrossSceneVolume[] _forceInitializeVolumes;

		// Token: 0x040056DE RID: 22238
		private Thread[] thread_0;

		// Token: 0x040056DF RID: 22239
		private float float_0;

		// Token: 0x040056E0 RID: 22240
		private float float_1;

		// Token: 0x040056E1 RID: 22241
		private int int_0;

		// Token: 0x040056E2 RID: 22242
		private float float_2;

		// Token: 0x040056E3 RID: 22243
		private volatile bool bool_0;

		// Token: 0x040056E4 RID: 22244
		private JobHandle? nullable_0;

		// Token: 0x040056E5 RID: 22245
		private static CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x040056E6 RID: 22246
		private static CancellationToken cancellationToken_0;

		// Token: 0x040056E7 RID: 22247
		public static bool disableWorkThread;

		// Token: 0x040056E8 RID: 22248
		public static bool disableReuse;

		// Token: 0x040056E9 RID: 22249
		public static bool disableSampling;

		// Token: 0x040056EA RID: 22250
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040056EB RID: 22251
		private static AnalyticSource[] analyticSource_0;

		// Token: 0x040056EC RID: 22252
		private static readonly PerfectCullingCrossSceneSampler.Class718[] class718_0;

		// Token: 0x040056ED RID: 22253
		private static GClass1030 gclass1030_0;

		// Token: 0x040056EE RID: 22254
		private static GClass1029 gclass1029_0;

		// Token: 0x040056EF RID: 22255
		private Task task_0;

		// Token: 0x040056F0 RID: 22256
		private static int int_1;

		// Token: 0x040056F1 RID: 22257
		private Bounds bounds_0;

		// Token: 0x040056F2 RID: 22258
		internal static float float_3;

		// Token: 0x040056F3 RID: 22259
		private const int int_2 = 1;

		// Token: 0x040056F4 RID: 22260
		private const int int_3 = 100;

		// Token: 0x040056F5 RID: 22261
		private static CullingCellData cullingCellData_0;

		// Token: 0x040056F6 RID: 22262
		private static float float_4;

		// Token: 0x040056F7 RID: 22263
		private static object object_0;

		// Token: 0x040056F8 RID: 22264
		private static readonly List<PerfectCullingCrossSceneSampler.Class721> list_0;

		// Token: 0x040056F9 RID: 22265
		private JobHandle jobHandle_0;

		// Token: 0x040056FA RID: 22266
		private static int int_4;

		// Token: 0x02000E33 RID: 3635
		private sealed class Class717
		{
			// Token: 0x040056FB RID: 22267
			public PerfectCullingCamera camera;

			// Token: 0x040056FC RID: 22268
			public int threadId;

			// Token: 0x040056FD RID: 22269
			public int numThreads;
		}

		// Token: 0x02000E34 RID: 3636
		private sealed class Class718
		{
			// Token: 0x06004C0A RID: 19466 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Clear()
			{
				throw null;
			}

			// Token: 0x040056FE RID: 22270
			public HashSet<int> VolumeIds;

			// Token: 0x040056FF RID: 22271
			public HashSet<int> GroupIds;

			// Token: 0x04005700 RID: 22272
			public ManualResetEventSlim WorkThreadWaitHandle;

			// Token: 0x04005701 RID: 22273
			public object LockUpdate;

			// Token: 0x04005702 RID: 22274
			public long WorkTime;
		}

		// Token: 0x02000E35 RID: 3637
		private static class Class719
		{
			// Token: 0x04005703 RID: 22275
			public static PerfectCullingCrossSceneSampler.Class717 JobParams;

			// Token: 0x04005704 RID: 22276
			public static CancellationTokenSource TerminateToken;

			// Token: 0x04005705 RID: 22277
			public static readonly HashSet<int>[] VolumeIds;

			// Token: 0x04005706 RID: 22278
			public static readonly HashSet<int>[] GroupIds;

			// Token: 0x04005707 RID: 22279
			private static readonly List<int>[] list_0;

			// Token: 0x04005708 RID: 22280
			private static readonly List<int>[] list_1;

			// Token: 0x02000E36 RID: 3638
			[StructLayout(LayoutKind.Auto, Size = 1)]
			public struct Struct164 : IJobParallelFor
			{
				// Token: 0x06004C0B RID: 19467 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Execute(int index)
				{
					throw null;
				}
			}

			// Token: 0x02000E37 RID: 3639
			[StructLayout(LayoutKind.Auto, Size = 1)]
			public struct Struct165 : IJobParallelFor
			{
				// Token: 0x06004C0C RID: 19468 RVA: 0x00002050 File Offset: 0x00000250
				[MethodImpl(MethodImplOptions.NoInlining)]
				public void Execute(int index)
				{
					throw null;
				}
			}
		}

		// Token: 0x02000E38 RID: 3640
		private sealed class Class720
		{
			// Token: 0x04005709 RID: 22281
			public PerfectCullingAdaptiveGrid grid;
		}

		// Token: 0x02000E39 RID: 3641
		private sealed class Class721
		{
			// Token: 0x06004C0D RID: 19469 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Update()
			{
				throw null;
			}

			// Token: 0x0400570A RID: 22282
			public bool IsActive;

			// Token: 0x0400570B RID: 22283
			public Vector3 Position;

			// Token: 0x0400570C RID: 22284
			public float FieldOfView;

			// Token: 0x0400570D RID: 22285
			public Func<Camera> CameraGetter;
		}

		// Token: 0x02000E3A RID: 3642
		[StructLayout(LayoutKind.Auto)]
		public struct Struct166 : IJob
		{
			// Token: 0x06004C0E RID: 19470 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(GStruct78 e)
			{
				throw null;
			}

			// Token: 0x06004C0F RID: 19471 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private static CullingCellData smethod_0(CullingCellData[] buffer, int numElementsInBuffer, Vector3 point)
			{
				throw null;
			}

			// Token: 0x06004C10 RID: 19472 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Execute()
			{
				throw null;
			}

			// Token: 0x0400570E RID: 22286
			public Vector3 ObservePosition;

			// Token: 0x0400570F RID: 22287
			private const int int_0 = 512;

			// Token: 0x04005710 RID: 22288
			private static CullingCellData[] cullingCellData_0;
		}

		// Token: 0x02000E3C RID: 3644
		[CompilerGenerated]
		[Serializable]
		private sealed class Class722
		{
			// Token: 0x06004C13 RID: 19475 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Camera method_0()
			{
				throw null;
			}

			// Token: 0x06004C14 RID: 19476 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal Camera method_1()
			{
				throw null;
			}

			// Token: 0x04005716 RID: 22294
			public static readonly PerfectCullingCrossSceneSampler.Class722 class722_0;

			// Token: 0x04005717 RID: 22295
			public static Func<Camera> func_0;

			// Token: 0x04005718 RID: 22296
			public static Func<Camera> func_1;
		}
	}
}
