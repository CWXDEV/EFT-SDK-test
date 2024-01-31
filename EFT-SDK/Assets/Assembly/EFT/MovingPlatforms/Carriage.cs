using System;
using System.Runtime.CompilerServices;
using BezierSplineTools;
using UnityEngine;

namespace EFT.MovingPlatforms
{
	// Token: 0x020026CD RID: 9933
	public class Carriage : MovingPlatform
	{
		// Token: 0x1700232D RID: 9005
		// (get) Token: 0x0600C4F9 RID: 50425 RVA: 0x00002050 File Offset: 0x00000250
		public override Vector3[] CachedDirections
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700232E RID: 9006
		// (get) Token: 0x0600C4FA RID: 50426 RVA: 0x00002050 File Offset: 0x00000250
		public override float CurveApproxLength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700232F RID: 9007
		// (get) Token: 0x0600C4FB RID: 50427 RVA: 0x00002050 File Offset: 0x00000250
		public override BezierSpline Spline
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002330 RID: 9008
		// (get) Token: 0x0600C4FC RID: 50428 RVA: 0x00002050 File Offset: 0x00000250
		public Transform ParentPlatform
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Init(DateTime depart)
		{
			throw null;
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Move(bool force = false)
		{
			throw null;
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(float currentDistance, float locomotiveDistance)
		{
			throw null;
		}

		// Token: 0x0600C501 RID: 50433 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Start_Position")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PlaceAtStartPosition()
		{
			throw null;
		}

		// Token: 0x0600C502 RID: 50434 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("End_Position")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PlaceAtEndPosition()
		{
			throw null;
		}

		// Token: 0x0600C503 RID: 50435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600C504 RID: 50436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400C6B8 RID: 50872
		[SerializeField]
		private float _suspensionStiffness;

		// Token: 0x0400C6B9 RID: 50873
		[SerializeField]
		private Vector2 _suspension;

		// Token: 0x0400C6BA RID: 50874
		[SerializeField]
		private float _shiftDelta;

		// Token: 0x0400C6BB RID: 50875
		public Carriage.CarriageMoveType carriageMoveType;

		// Token: 0x0400C6BC RID: 50876
		public Locomotive Locomotive;

		// Token: 0x0400C6BD RID: 50877
		public Vector3 LocomotivePivot;

		// Token: 0x0400C6BE RID: 50878
		public Vector3 LocalPivot;

		// Token: 0x0400C6BF RID: 50879
		[Header("Trailer shift and jitter")]
		[Tooltip("Смещение вагона относительно локомотива")]
		public float Shift;

		// Token: 0x0400C6C0 RID: 50880
		[Tooltip("Диапозон тряски вагона назад/вперед")]
		public Vector3 ShiftRange;

		// Token: 0x0400C6C1 RID: 50881
		[Tooltip("Объект в направлении которого вагон смотрит (локомотив или след. вагон)")]
		public Transform RotationTarget;

		// Token: 0x0400C6C2 RID: 50882
		[Tooltip("Смещение вагона, использовать чтобы выровнять его (менять крайне аккуратно)")]
		public Vector3 CarriagePosOffset;

		// Token: 0x0400C6C3 RID: 50883
		private Transform transform_0;

		// Token: 0x0400C6C4 RID: 50884
		private float float_0;

		// Token: 0x0400C6C5 RID: 50885
		private Vector2 vector2_0;

		// Token: 0x0400C6C6 RID: 50886
		private float float_1;

		// Token: 0x0400C6C7 RID: 50887
		private bool bool_0;

		// Token: 0x0400C6C8 RID: 50888
		private float float_2;

		// Token: 0x020026CE RID: 9934
		public enum CarriageMoveType
		{
			// Token: 0x0400C6CA RID: 50890
			LegacyBySelfRoute,
			// Token: 0x0400C6CB RID: 50891
			BasedOnLocomotivePos
		}

		// Token: 0x020026CF RID: 9935
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2235
		{
			// Token: 0x0600C505 RID: 50437 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal float method_0(Keyframe x)
			{
				throw null;
			}

			// Token: 0x0400C6CC RID: 50892
			public static readonly Carriage.Class2235 class2235_0;

			// Token: 0x0400C6CD RID: 50893
			public static Func<Keyframe, float> func_0;
		}
	}
}
