using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010FF RID: 4351
	public abstract class OffsetModifier : MonoBehaviour
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x00002050 File Offset: 0x00000250
		protected float deltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005BB9 RID: 23481
		protected abstract void OnModifyOffset();

		// Token: 0x06005BBA RID: 23482 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Start()
		{
			throw null;
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0()
		{
			throw null;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ApplyLimits(OffsetModifier.OffsetLimits[] limits)
		{
			throw null;
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0400673D RID: 26429
		[Tooltip("The master weight")]
		public float weight;

		// Token: 0x0400673E RID: 26430
		[Tooltip("Reference to the FBBIK component")]
		[SerializeField]
		protected FullBodyBipedIK ik;

		// Token: 0x0400673F RID: 26431
		private float float_0;

		// Token: 0x02001100 RID: 4352
		[Serializable]
		public class OffsetLimits
		{
			// Token: 0x06005BBF RID: 23487 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
				throw null;
			}

			// Token: 0x06005BC0 RID: 23488 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_0(float value, float min, float max)
			{
				throw null;
			}

			// Token: 0x06005BC1 RID: 23489 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private float method_1(float value, float limit, bool negative)
			{
				throw null;
			}

			// Token: 0x04006740 RID: 26432
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			// Token: 0x04006741 RID: 26433
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			// Token: 0x04006742 RID: 26434
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			// Token: 0x04006743 RID: 26435
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			// Token: 0x04006744 RID: 26436
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			// Token: 0x04006745 RID: 26437
			[Tooltip("The limits")]
			public float minX;

			// Token: 0x04006746 RID: 26438
			[Tooltip("The limits")]
			public float maxX;

			// Token: 0x04006747 RID: 26439
			[Tooltip("The limits")]
			public float minY;

			// Token: 0x04006748 RID: 26440
			[Tooltip("The limits")]
			public float maxY;

			// Token: 0x04006749 RID: 26441
			[Tooltip("The limits")]
			public float minZ;

			// Token: 0x0400674A RID: 26442
			[Tooltip("The limits")]
			public float maxZ;
		}
	}
}
