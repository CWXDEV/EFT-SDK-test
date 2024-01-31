using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EF7 RID: 7927
	[Serializable]
	public class NewRotationRecoilProcess : RotationRecoilProcessBase
	{
		// Token: 0x0600A3B3 RID: 41907 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateRecoil(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3B4 RID: 41908 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void AddAccelerationLimitless(int comp, float val)
		{
			throw null;
		}

		// Token: 0x0600A3B7 RID: 41911 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStableMode(bool enable)
		{
			throw null;
		}

		// Token: 0x0600A3B8 RID: 41912 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetAutoFireMode(bool enable)
		{
			throw null;
		}

		// Token: 0x0600A3B9 RID: 41913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_2()
		{
			throw null;
		}

		// Token: 0x0600A3BA RID: 41914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0400AB15 RID: 43797
		[Tooltip("Диапазон вертикального смещения ствола в состоянии покоя после отдачи, прилетает с бэка")]
		public Vector2 AfterRecoilOffsetVerticalRange;

		// Token: 0x0400AB16 RID: 43798
		[Tooltip("Диапазон горизонтального смещения ствола в состоянии покоя после отдачи, прилетает с бэка")]
		public Vector2 AfterRecoilOffsetHorizontalRange;

		// Token: 0x0400AB17 RID: 43799
		[Tooltip("Диапазон допустимых значений для добавляемого во время стабилизации к основному углу разброса, прилетает с бэка")]
		public Vector2 ProgressRecoilAngleOnStable;

		// Token: 0x0400AB18 RID: 43800
		[Tooltip("Диапазон вертикального смещения ствола в состоянии покоя после отдачи")]
		public float ToNextStablePointDistanceLimit;

		// Token: 0x0400AB19 RID: 43801
		[Tooltip("Диапазон рандомной дистанции следующией точки отдачи по расчитанному направлению из точки стабилизации")]
		public Vector2 NextStablePointDistanceRange;

		// Token: 0x0400AB1A RID: 43802
		[Tooltip("Сила с которой ствол будет отклоняться в сторону во время расчет траектории возврата оружия, прилетает с бэка")]
		public float RecoilReturnTrajectoryOffset;

		// Token: 0x0400AB1B RID: 43803
		[Tooltip("Величина, добавляемая к общему углу разброса отдачи за каждый выстрел во время стабилизации огня, прилетает с бэка")]
		public float StableAngleIncreaseStep;

		// Token: 0x0400AB1C RID: 43804
		[Tooltip("Величина затухания импульса силы смещения траектории возвращения ствола, прилетает с бэка")]
		public float ReturnTrajectoryDumping;

		// Token: 0x0400AB1D RID: 43805
		[Tooltip("Множитель силы вращения ствола для категории оружия, прилетает с бэка")]
		public float CategoryIntensityMultiplier;

		// Token: 0x0400AB1E RID: 43806
		[Tooltip("Скорость смещения ствола к следующей точке потенциального выстрела во время стабилизации огня")]
		public float ToNextCurrentSpeed;

		// Token: 0x0400AB1F RID: 43807
		[Tooltip("Множитель скорости возврата вращения ствола в зависимости от времени автоматического огня")]
		public AnimationCurve ReturnSpeedCurve;

		// Token: 0x0400AB20 RID: 43808
		[HideInInspector]
		public bool AutoFireOn;

		// Token: 0x0400AB21 RID: 43809
		[HideInInspector]
		public float MultiplayerByShotIndex;

		// Token: 0x0400AB22 RID: 43810
		[HideInInspector]
		public float CurrentAngleAdd;

		// Token: 0x0400AB23 RID: 43811
		private Vector3 _previousCurrent;

		// Token: 0x0400AB24 RID: 43812
		private Vector2 _afterRecoilDefaultPosition;

		// Token: 0x0400AB25 RID: 43813
		private Vector3 _stableCurrent;

		// Token: 0x0400AB26 RID: 43814
		private Vector3 _nextCurrent;

		// Token: 0x0400AB27 RID: 43815
		private Vector3 _nextCurrentDirection;

		// Token: 0x0400AB28 RID: 43816
		private float _curveTime;

		// Token: 0x0400AB29 RID: 43817
		private float _autoFireSpeed;

		// Token: 0x0400AB2A RID: 43818
		private float _toOffsetPosSpeed;

		// Token: 0x0400AB2B RID: 43819
		private float _recoilOffsetImpulse;

		// Token: 0x0400AB2C RID: 43820
		private float _afterOffsetCalculateCurrentX;

		// Token: 0x0400AB2D RID: 43821
		private bool _returnTrajectoryOn;

		// Token: 0x0400AB2E RID: 43822
		private NewRotationRecoilProcess.ReturnTrajectorySideType ReturnTrajectorySide;

		// Token: 0x02001EF8 RID: 7928
		private enum ReturnTrajectorySideType
		{
			// Token: 0x0400AB30 RID: 43824
			Left,
			// Token: 0x0400AB31 RID: 43825
			Right,
			// Token: 0x0400AB32 RID: 43826
			None
		}
	}
}
