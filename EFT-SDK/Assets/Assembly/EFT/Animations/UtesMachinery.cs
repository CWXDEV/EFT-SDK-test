using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EF1 RID: 7921
	public class UtesMachinery : WeaponMachinery
	{
		// Token: 0x0600A397 RID: 41879 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetTransforms(TransformLinks hierarchy)
		{
			throw null;
		}

		// Token: 0x0600A398 RID: 41880 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void UpdateJoints()
		{
			throw null;
		}

		// Token: 0x0600A399 RID: 41881 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnRotation()
		{
			throw null;
		}

		// Token: 0x0400AAC5 RID: 43717
		[SerializeField]
		private Transform _hingeJoint1;

		// Token: 0x0400AAC6 RID: 43718
		[SerializeField]
		private Transform _hingeJoint2;

		// Token: 0x0400AAC7 RID: 43719
		[SerializeField]
		private Transform _hingeJoint2DirectionTransform;

		// Token: 0x0400AAC8 RID: 43720
		[SerializeField]
		private Transform _weaponJoint;

		// Token: 0x0400AAC9 RID: 43721
		[SerializeField]
		private Transform _verticalJoint;
	}
}
