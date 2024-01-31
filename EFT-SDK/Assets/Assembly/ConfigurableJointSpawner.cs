using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020005C7 RID: 1479
[DisallowMultipleComponent]
public class ConfigurableJointSpawner : JointSpawner
{
	// Token: 0x0600226D RID: 8813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override Joint Create()
	{
		throw null;
	}

	// Token: 0x0600226E RID: 8814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Joint CreateComponent()
	{
		throw null;
	}

	// Token: 0x04002196 RID: 8598
	public float projectionAngle;

	// Token: 0x04002197 RID: 8599
	public float projectionDistance;

	// Token: 0x04002198 RID: 8600
	public JointProjectionMode projectionMode;

	// Token: 0x04002199 RID: 8601
	public ConfigurableJointSpawner.JointDrive_ slerpDrive;

	// Token: 0x0400219A RID: 8602
	public ConfigurableJointSpawner.JointDrive_ angularYZDrive;

	// Token: 0x0400219B RID: 8603
	public ConfigurableJointSpawner.JointDrive_ angularXDrive;

	// Token: 0x0400219C RID: 8604
	public RotationDriveMode rotationDriveMode;

	// Token: 0x0400219D RID: 8605
	public Vector3 targetAngularVelocity;

	// Token: 0x0400219E RID: 8606
	public Quaternion targetRotation;

	// Token: 0x0400219F RID: 8607
	public ConfigurableJointSpawner.JointDrive_ zDrive;

	// Token: 0x040021A0 RID: 8608
	public ConfigurableJointSpawner.JointDrive_ yDrive;

	// Token: 0x040021A1 RID: 8609
	public ConfigurableJointSpawner.JointDrive_ xDrive;

	// Token: 0x040021A2 RID: 8610
	public Vector3 targetVelocity;

	// Token: 0x040021A3 RID: 8611
	public Vector3 targetPosition;

	// Token: 0x040021A4 RID: 8612
	public ConfigurableJointSpawner.SoftJointLimit_ angularZLimit;

	// Token: 0x040021A5 RID: 8613
	public ConfigurableJointSpawner.SoftJointLimit_ angularYLimit;

	// Token: 0x040021A6 RID: 8614
	public ConfigurableJointSpawner.SoftJointLimit_ highAngularXLimit;

	// Token: 0x040021A7 RID: 8615
	public ConfigurableJointSpawner.SoftJointLimit_ lowAngularXLimit;

	// Token: 0x040021A8 RID: 8616
	public ConfigurableJointSpawner.SoftJointLimit_ linearLimit;

	// Token: 0x040021A9 RID: 8617
	public ConfigurableJointSpawner.SoftJointLimitSpring_ angularYZLimitSpring;

	// Token: 0x040021AA RID: 8618
	public ConfigurableJointSpawner.SoftJointLimitSpring_ angularXLimitSpring;

	// Token: 0x040021AB RID: 8619
	public ConfigurableJointSpawner.SoftJointLimitSpring_ linearLimitSpring;

	// Token: 0x040021AC RID: 8620
	public ConfigurableJointMotion angularZMotion;

	// Token: 0x040021AD RID: 8621
	public ConfigurableJointMotion angularYMotion;

	// Token: 0x040021AE RID: 8622
	public ConfigurableJointMotion angularXMotion;

	// Token: 0x040021AF RID: 8623
	public ConfigurableJointMotion zMotion;

	// Token: 0x040021B0 RID: 8624
	public ConfigurableJointMotion yMotion;

	// Token: 0x040021B1 RID: 8625
	public ConfigurableJointMotion xMotion;

	// Token: 0x040021B2 RID: 8626
	public Vector3 secondaryAxis;

	// Token: 0x040021B3 RID: 8627
	public bool configuredInWorldSpace;

	// Token: 0x040021B4 RID: 8628
	public bool swapBodies;

	// Token: 0x020005C8 RID: 1480
	[Serializable]
	public struct SoftJointLimitSpring_
	{
		// Token: 0x040021B5 RID: 8629
		public float spring;

		// Token: 0x040021B6 RID: 8630
		public float damper;
	}

	// Token: 0x020005C9 RID: 1481
	[Serializable]
	public struct SoftJointLimit_
	{
		// Token: 0x040021B7 RID: 8631
		public float limit;

		// Token: 0x040021B8 RID: 8632
		public float bounciness;

		// Token: 0x040021B9 RID: 8633
		public float contactDistance;
	}

	// Token: 0x020005CA RID: 1482
	[Serializable]
	public struct JointDrive_
	{
		// Token: 0x040021BA RID: 8634
		public float positionSpring;

		// Token: 0x040021BB RID: 8635
		public float positionDamper;

		// Token: 0x040021BC RID: 8636
		public float maximumForce;
	}
}
