using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001F0F RID: 7951
	[Serializable]
	public class Spring
	{
		// Token: 0x0600A479 RID: 42105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void FixedUpdate(float dt, int nFixedFrames = 1)
		{
			throw null;
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 Get()
		{
			throw null;
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetRelative()
		{
			throw null;
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Vector3 GetWithRedirection()
		{
			throw null;
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_0(Vector3 vec)
		{
			throw null;
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static AnimationCurve smethod_0(float min, float max, float softness = 1f)
		{
			throw null;
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAcceleration(int comp, float val)
		{
			throw null;
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddZero()
		{
			throw null;
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAcceleration(Vector3 acceleration)
		{
			throw null;
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAccelerationLimitless(int comp, float val)
		{
			throw null;
		}

		// Token: 0x0600A484 RID: 42116 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddAccelerationLimitless(Vector3 acceleration)
		{
			throw null;
		}

		// Token: 0x0400AC43 RID: 44099
		public Vector3 Zero;

		// Token: 0x0400AC44 RID: 44100
		public float InputIntensity;

		// Token: 0x0400AC45 RID: 44101
		public float ReturnSpeed;

		// Token: 0x0400AC46 RID: 44102
		public float Damping;

		// Token: 0x0400AC47 RID: 44103
		public Vector3 Min;

		// Token: 0x0400AC48 RID: 44104
		public Vector3 Max;

		// Token: 0x0400AC49 RID: 44105
		public float AccelerationMax;

		// Token: 0x0400AC4A RID: 44106
		private AnimationCurve _curveLimitX;

		// Token: 0x0400AC4B RID: 44107
		private AnimationCurve _curveLimitY;

		// Token: 0x0400AC4C RID: 44108
		private AnimationCurve _curveLimitZ;

		// Token: 0x0400AC4D RID: 44109
		protected float CurveTime;

		// Token: 0x0400AC4E RID: 44110
		public bool Refrash;

		// Token: 0x0400AC4F RID: 44111
		public float Softness;

		// Token: 0x0400AC50 RID: 44112
		public Spring.VecComponent X;

		// Token: 0x0400AC51 RID: 44113
		public Spring.VecComponent Y;

		// Token: 0x0400AC52 RID: 44114
		public Spring.VecComponent Z;

		// Token: 0x0400AC53 RID: 44115
		public Vector3 Velocity;

		// Token: 0x0400AC54 RID: 44116
		public Vector3 Current;

		// Token: 0x0400AC55 RID: 44117
		protected Vector3 ForceAccumulator;

		// Token: 0x0400AC56 RID: 44118
		protected Vector3 ForceAccumulatorLimitless;

		// Token: 0x0400AC57 RID: 44119
		public bool _update;

		// Token: 0x02001F10 RID: 7952
		public enum VecComponent
		{
			// Token: 0x0400AC59 RID: 44121
			X,
			// Token: 0x0400AC5A RID: 44122
			Y,
			// Token: 0x0400AC5B RID: 44123
			Z
		}
	}
}
