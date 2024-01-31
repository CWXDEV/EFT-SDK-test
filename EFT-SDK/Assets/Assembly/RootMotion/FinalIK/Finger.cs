using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02001091 RID: 4241
	[Serializable]
	public class Finger
	{
		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x00002050 File Offset: 0x00000250
		public bool initiated
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

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 IKPosition
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

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06005885 RID: 22661 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005886 RID: 22662 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion IKRotation
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

		// Token: 0x06005887 RID: 22663 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsValid(ref string errorMessage)
		{
			throw null;
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initiate(Transform hand, int index)
		{
			throw null;
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FixTransforms()
		{
			throw null;
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update(float masterWeight)
		{
			throw null;
		}

		// Token: 0x04006449 RID: 25673
		[Tooltip("Master Weight for the finger.")]
		[Range(0f, 1f)]
		public float weight;

		// Token: 0x0400644A RID: 25674
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		// Token: 0x0400644B RID: 25675
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		// Token: 0x0400644C RID: 25676
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		// Token: 0x0400644D RID: 25677
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		// Token: 0x0400644E RID: 25678
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		// Token: 0x04006450 RID: 25680
		private IKSolverLimb solver;

		// Token: 0x04006451 RID: 25681
		private Quaternion bone3RelativeToTarget;

		// Token: 0x04006452 RID: 25682
		private Vector3 bone3DefaultLocalPosition;

		// Token: 0x04006453 RID: 25683
		private Quaternion bone3DefaultLocalRotation;
	}
}
