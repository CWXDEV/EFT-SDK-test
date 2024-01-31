using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;

namespace EFT.Utilities
{
	// Token: 0x02001E23 RID: 7715
	[RequireComponent(typeof(CinemachinePathBase))]
	public class AutoCameraController : MonoBehaviour
	{
		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x06009E8A RID: 40586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009E8B RID: 40587 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnComplete
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

		// Token: 0x17001927 RID: 6439
		// (get) Token: 0x06009E8C RID: 40588 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsComplete
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001928 RID: 6440
		// (get) Token: 0x06009E8D RID: 40589 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsProcess
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001929 RID: 6441
		// (get) Token: 0x06009E8E RID: 40590 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E8F RID: 40591 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentWaypointIndex
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

		// Token: 0x1700192A RID: 6442
		// (get) Token: 0x06009E90 RID: 40592 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E91 RID: 40593 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFpsIndependent
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

		// Token: 0x1700192B RID: 6443
		// (get) Token: 0x06009E92 RID: 40594 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E93 RID: 40595 RVA: 0x00002050 File Offset: 0x00000250
		public bool WaitStableFPS
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

		// Token: 0x1700192C RID: 6444
		// (get) Token: 0x06009E94 RID: 40596 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E95 RID: 40597 RVA: 0x00002050 File Offset: 0x00000250
		public int WaitStableFPSSampleCount
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

		// Token: 0x1700192D RID: 6445
		// (get) Token: 0x06009E96 RID: 40598 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E97 RID: 40599 RVA: 0x00002050 File Offset: 0x00000250
		public float WaitStableFPSDeltaThreshold
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

		// Token: 0x1700192E RID: 6446
		// (get) Token: 0x06009E98 RID: 40600 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009E99 RID: 40601 RVA: 0x00002050 File Offset: 0x00000250
		public int IdleFrameCount
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

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x06009E9A RID: 40602 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06009E9B RID: 40603 RVA: 0x00002050 File Offset: 0x00000250
		public event Action OnManualUpdate
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

		// Token: 0x06009E9C RID: 40604 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Setup()
		{
			throw null;
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ManualUpdate(float deltaTime)
		{
			throw null;
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_0()
		{
			throw null;
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400A6CE RID: 42702
		private const string string_0 = "Debug/AutoCamera";

		// Token: 0x0400A6CF RID: 42703
		public CinemachineVirtualCamera CamVM;

		// Token: 0x0400A6D0 RID: 42704
		public float Speed;

		// Token: 0x0400A6D1 RID: 42705
		public AutoCameraController.PointAction[] Points;

		// Token: 0x0400A6D2 RID: 42706
		[CompilerGenerated]
		private Action action_0;

		// Token: 0x0400A6D3 RID: 42707
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400A6D4 RID: 42708
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400A6D5 RID: 42709
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x0400A6D6 RID: 42710
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400A6D7 RID: 42711
		[CompilerGenerated]
		private float float_1;

		// Token: 0x0400A6D8 RID: 42712
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400A6D9 RID: 42713
		[CompilerGenerated]
		private Action action_1;

		// Token: 0x0400A6DA RID: 42714
		private CinemachineTrackedDolly cinemachineTrackedDolly_0;

		// Token: 0x0400A6DB RID: 42715
		private Queue<ValueTuple<AutoCameraController.PointAction, Transform>> queue_0;

		// Token: 0x0400A6DC RID: 42716
		private float float_2;

		// Token: 0x0400A6DD RID: 42717
		private bool bool_2;

		// Token: 0x0400A6DE RID: 42718
		private bool bool_3;

		// Token: 0x0400A6DF RID: 42719
		private GameObject gameObject_0;

		// Token: 0x0400A6E0 RID: 42720
		private AutoCameraController.PointAction pointAction_0;

		// Token: 0x0400A6E1 RID: 42721
		private double[] double_0;

		// Token: 0x0400A6E2 RID: 42722
		private int int_2;

		// Token: 0x0400A6E3 RID: 42723
		private int int_3;

		// Token: 0x02001E24 RID: 7716
		[Serializable]
		public enum EAction
		{
			// Token: 0x0400A6E5 RID: 42725
			None,
			// Token: 0x0400A6E6 RID: 42726
			AimObject,
			// Token: 0x0400A6E7 RID: 42727
			AimPoint,
			// Token: 0x0400A6E8 RID: 42728
			AimForward,
			// Token: 0x0400A6E9 RID: 42729
			Wait
		}

		// Token: 0x02001E25 RID: 7717
		[Serializable]
		public struct PointAction
		{
			// Token: 0x0400A6EA RID: 42730
			public float Index;

			// Token: 0x0400A6EB RID: 42731
			public AutoCameraController.EAction Action;

			// Token: 0x0400A6EC RID: 42732
			public string StringValue;

			// Token: 0x0400A6ED RID: 42733
			public float FloatValue;

			// Token: 0x0400A6EE RID: 42734
			public Vector3 VectorValue;
		}

		// Token: 0x02001E26 RID: 7718
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1801
		{
			// Token: 0x06009EA3 RID: 40611 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(AutoCameraController.PointAction o)
			{
				throw null;
			}

			// Token: 0x0400A6EF RID: 42735
			public static readonly AutoCameraController.Class1801 class1801_0;

			// Token: 0x0400A6F0 RID: 42736
			public static Func<AutoCameraController.PointAction, float> func_0;
		}
	}
}
