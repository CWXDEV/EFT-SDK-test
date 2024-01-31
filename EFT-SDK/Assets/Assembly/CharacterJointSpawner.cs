using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005C4 RID: 1476
[DisallowMultipleComponent]
public class CharacterJointSpawner : JointSpawner
{
	// Token: 0x0600226B RID: 8811 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("Create")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Joint Create()
	{
		throw null;
	}

	// Token: 0x0600226C RID: 8812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Joint CreateComponent()
	{
		throw null;
	}

	// Token: 0x04002187 RID: 8583
	public Vector3 swingAxis;

	// Token: 0x04002188 RID: 8584
	public CharacterJointSpawner.SoftJointLimitSpring_ twistLimitSpring;

	// Token: 0x04002189 RID: 8585
	public CharacterJointSpawner.SoftJointLimit_ lowTwistLimit;

	// Token: 0x0400218A RID: 8586
	public CharacterJointSpawner.SoftJointLimit_ highTwistLimit;

	// Token: 0x0400218B RID: 8587
	public CharacterJointSpawner.SoftJointLimitSpring_ swingLimitSpring;

	// Token: 0x0400218C RID: 8588
	public CharacterJointSpawner.SoftJointLimit_ swing1Limit;

	// Token: 0x0400218D RID: 8589
	public CharacterJointSpawner.SoftJointLimit_ swing2Limit;

	// Token: 0x0400218E RID: 8590
	public bool enableProjection;

	// Token: 0x0400218F RID: 8591
	public float projectionDistance;

	// Token: 0x04002190 RID: 8592
	public float projectionAngle;

	// Token: 0x020005C5 RID: 1477
	[Serializable]
	public struct SoftJointLimitSpring_
	{
		// Token: 0x04002191 RID: 8593
		public float spring;

		// Token: 0x04002192 RID: 8594
		public float damper;
	}

	// Token: 0x020005C6 RID: 1478
	[Serializable]
	public struct SoftJointLimit_
	{
		// Token: 0x04002193 RID: 8595
		public float limit;

		// Token: 0x04002194 RID: 8596
		public float bounciness;

		// Token: 0x04002195 RID: 8597
		public float contactDistance;
	}
}
