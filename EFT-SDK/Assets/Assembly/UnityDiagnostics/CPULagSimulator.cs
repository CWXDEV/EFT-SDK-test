using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityDiagnostics
{
	// Token: 0x02000F70 RID: 3952
	public class CPULagSimulator : MonoBehaviour
	{
		// Token: 0x0600532F RID: 21295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06005330 RID: 21296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x06005333 RID: 21299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnGUI()
		{
			throw null;
		}

		// Token: 0x06005334 RID: 21300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x06005335 RID: 21301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(string info, Color color, Rect rect)
		{
			throw null;
		}

		// Token: 0x06005336 RID: 21302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static CPULagSimulator Add()
		{
			throw null;
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Remove()
		{
			throw null;
		}

		// Token: 0x04005ECE RID: 24270
		private GUIStyle guistyle_0;

		// Token: 0x04005ECF RID: 24271
		public CPULagSimulator.LagSimulator FixedUpdateLagSimulator;

		// Token: 0x04005ED0 RID: 24272
		public CPULagSimulator.LagSimulator UpdateLagSimulator;

		// Token: 0x02000F71 RID: 3953
		public enum ELoadType
		{
			// Token: 0x04005ED2 RID: 24274
			Calculation,
			// Token: 0x04005ED3 RID: 24275
			ThreadSleep
		}

		// Token: 0x02000F72 RID: 3954
		[Serializable]
		public class LagSimulator
		{
			// Token: 0x17000CF0 RID: 3312
			// (get) Token: 0x06005338 RID: 21304 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06005339 RID: 21305 RVA: 0x00002050 File Offset: 0x00000250
			public int LastLag
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

			// Token: 0x0600533A RID: 21306 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void MakeLag()
			{
				throw null;
			}

			// Token: 0x0600533B RID: 21307 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(long ms)
			{
				throw null;
			}

			// Token: 0x0600533C RID: 21308 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private bool method_1()
			{
				throw null;
			}

			// Token: 0x0600533D RID: 21309 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void CheckToggleInput()
			{
				throw null;
			}

			// Token: 0x04005ED4 RID: 24276
			public const int MIN_LAG = 0;

			// Token: 0x04005ED5 RID: 24277
			public const int MAX_LAG = 5000;

			// Token: 0x04005ED6 RID: 24278
			private readonly Stopwatch _stopwatch;

			// Token: 0x04005ED7 RID: 24279
			public bool Enabled;

			// Token: 0x04005ED8 RID: 24280
			public GClass1154 TimeMesurer;

			// Token: 0x04005ED9 RID: 24281
			public KeyCode ToggleGameKey;

			// Token: 0x04005EDA RID: 24282
			[Range(0f, 5000f)]
			public int FramesBetweenSpikes;

			// Token: 0x04005EDB RID: 24283
			[Range(0f, 5000f)]
			public int LagDispersion;

			// Token: 0x04005EDC RID: 24284
			[Range(0f, 5000f)]
			public int ConstantLagMS;

			// Token: 0x04005EDD RID: 24285
			public CPULagSimulator.ELoadType LoadType;

			// Token: 0x04005EDE RID: 24286
			private int _lastLagFrame;
		}
	}
}
