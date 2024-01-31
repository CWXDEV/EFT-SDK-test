using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EFD RID: 7933
	public class PlayerSpring : MonoBehaviour
	{
		// Token: 0x0600A3D4 RID: 41940 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x0400AB52 RID: 43858
		[HideInInspector]
		[NonSerialized]
		public WeaponPrefab.AimPlane DefaultAimPlane;

		// Token: 0x0400AB53 RID: 43859
		[HideInInspector]
		[NonSerialized]
		public WeaponPrefab.AimPlane[] CustomAimPlanes;

		// Token: 0x0400AB54 RID: 43860
		[HideInInspector]
		[NonSerialized]
		public WeaponPrefab.AimPlane FarPlane;

		// Token: 0x0400AB55 RID: 43861
		public Spring HandsPosition;

		// Token: 0x0400AB56 RID: 43862
		public Spring HandsRotation;

		// Token: 0x0400AB57 RID: 43863
		public Spring CameraRotation;

		// Token: 0x0400AB58 RID: 43864
		public Spring CameraPosition;

		// Token: 0x0400AB59 RID: 43865
		public BetterSpring SwaySpring;

		// Token: 0x0400AB5A RID: 43866
		public Transform TrackingTransform;

		// Token: 0x0400AB5B RID: 43867
		public Transform WeaponRootAnim;

		// Token: 0x0400AB5C RID: 43868
		public Transform CameraTransform;

		// Token: 0x0400AB5D RID: 43869
		public Transform WeaponRoot;

		// Token: 0x0400AB5E RID: 43870
		public Transform Weapon;

		// Token: 0x0400AB5F RID: 43871
		public Transform Fireport;

		// Token: 0x0400AB60 RID: 43872
		public Transform CameraAnimatedFP;

		// Token: 0x0400AB61 RID: 43873
		public Transform CameraAnimatedTP;

		// Token: 0x0400AB62 RID: 43874
		public Vector3 RotationCenter;

		// Token: 0x0400AB63 RID: 43875
		public Vector3 RotationCenterWoStock;

		// Token: 0x0400AB64 RID: 43876
		public Vector3 RecoilPivot;

		// Token: 0x0400AB65 RID: 43877
		public Vector3 CameraOffset;

		// Token: 0x0400AB66 RID: 43878
		public Transform RootJoint;
	}
}
