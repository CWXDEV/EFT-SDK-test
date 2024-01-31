using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010DD RID: 4317
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		// Token: 0x06005B2D RID: 23341 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("TUTORIAL VIDEO")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06005B2E RID: 23342 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Support Group")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06005B2F RID: 23343 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Asset Store Thread")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06005B30 RID: 23344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06005B31 RID: 23345 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			throw null;
		}

		// Token: 0x040066A1 RID: 26273
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public InteractionTrigger.Range[] ranges;

		// Token: 0x020010DE RID: 4318
		[Serializable]
		public class CharacterPosition
		{
			// Token: 0x17000E46 RID: 3654
			// (get) Token: 0x06005B32 RID: 23346 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 offset3D
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000E47 RID: 3655
			// (get) Token: 0x06005B33 RID: 23347 RVA: 0x00002050 File Offset: 0x00000250
			public Vector3 direction3D
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06005B34 RID: 23348 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				throw null;
			}

			// Token: 0x040066A2 RID: 26274
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			// Token: 0x040066A3 RID: 26275
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			// Token: 0x040066A4 RID: 26276
			[Range(-180f, 180f)]
			[Tooltip("Angle offset from the default forward direction.")]
			public float angleOffset;

			// Token: 0x040066A5 RID: 26277
			[Range(0f, 180f)]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			public float maxAngle;

			// Token: 0x040066A6 RID: 26278
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			// Token: 0x040066A7 RID: 26279
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			// Token: 0x040066A8 RID: 26280
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;
		}

		// Token: 0x020010DF RID: 4319
		[Serializable]
		public class CameraPosition
		{
			// Token: 0x06005B35 RID: 23349 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public Quaternion GetRotation()
			{
				throw null;
			}

			// Token: 0x06005B36 RID: 23350 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				throw null;
			}

			// Token: 0x040066A9 RID: 26281
			[Tooltip("What the camera should be looking at to trigger the interaction?")]
			public Collider lookAtTarget;

			// Token: 0x040066AA RID: 26282
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			// Token: 0x040066AB RID: 26283
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			// Token: 0x040066AC RID: 26284
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			// Token: 0x040066AD RID: 26285
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;
		}

		// Token: 0x020010E0 RID: 4320
		[Serializable]
		public class Range
		{
			// Token: 0x06005B37 RID: 23351 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				throw null;
			}

			// Token: 0x040066AE RID: 26286
			[SerializeField]
			[HideInInspector]
			public string name;

			// Token: 0x040066AF RID: 26287
			[SerializeField]
			[HideInInspector]
			public bool show;

			// Token: 0x040066B0 RID: 26288
			[Tooltip("The range for the character's position and rotation.")]
			public InteractionTrigger.CharacterPosition characterPosition;

			// Token: 0x040066B1 RID: 26289
			[Tooltip("The range for the character camera's position and rotation.")]
			public InteractionTrigger.CameraPosition cameraPosition;

			// Token: 0x040066B2 RID: 26290
			[Tooltip("Definitions of the interactions associated with this range.")]
			public InteractionTrigger.Range.Interaction[] interactions;

			// Token: 0x020010E1 RID: 4321
			[Serializable]
			public class Interaction
			{
				// Token: 0x040066B3 RID: 26291
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				// Token: 0x040066B4 RID: 26292
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;
			}
		}
	}
}
