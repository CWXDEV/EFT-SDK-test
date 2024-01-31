using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x02002749 RID: 10057
	[ExecuteInEditMode]
	public class ExfiltrationDoor : ExfiltrationSubscriber
	{
		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600C933 RID: 51507 RVA: 0x00002050 File Offset: 0x00000250
		private List<Collider> List_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C934 RID: 51508 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Cache collision colliders")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600C935 RID: 51509 RVA: 0x00002050 File Offset: 0x00000250
		public ExfiltrationDoor.DoorTransform[] DoorTransforms
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C936 RID: 51510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600C937 RID: 51511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(bool value)
		{
			throw null;
		}

		// Token: 0x0600C938 RID: 51512 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Start()
		{
			throw null;
		}

		// Token: 0x0600C939 RID: 51513 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x0600C93A RID: 51514 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void OnStatusChangedHandler(ExfiltrationPoint point, EExfiltrationStatus prevStatus, bool force)
		{
			throw null;
		}

		// Token: 0x0600C93B RID: 51515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_2(bool isOpen, AudioClip clip, float delay)
		{
			throw null;
		}

		// Token: 0x0600C93C RID: 51516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_3(Quaternion q, Vector3 pos, AudioClip clip, float delay)
		{
			throw null;
		}

		// Token: 0x0600C93D RID: 51517 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("try open")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryOpen()
		{
			throw null;
		}

		// Token: 0x0600C93E RID: 51518 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("try close")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TryClose()
		{
			throw null;
		}

		// Token: 0x0600C93F RID: 51519 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Set open")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetOpenRotation()
		{
			throw null;
		}

		// Token: 0x0600C940 RID: 51520 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("Set close")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCloseRotation()
		{
			throw null;
		}

		// Token: 0x0600C941 RID: 51521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C942 RID: 51522 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static bool smethod_0(Collider currentCollider)
		{
			throw null;
		}

		// Token: 0x0400C944 RID: 51524
		[SerializeField]
		private ExfiltrationDoor.DoorTransform[] _doorTransforms;

		// Token: 0x0400C945 RID: 51525
		[HideInInspector]
		[Obsolete]
		public Quaternion OpenRotation;

		// Token: 0x0400C946 RID: 51526
		[Obsolete]
		[HideInInspector]
		public Quaternion CloseRotation;

		// Token: 0x0400C947 RID: 51527
		[Obsolete]
		[HideInInspector]
		public Vector3 OpenPosition;

		// Token: 0x0400C948 RID: 51528
		[Obsolete]
		[HideInInspector]
		public Vector3 ClosePosition;

		// Token: 0x0400C949 RID: 51529
		[Obsolete]
		[HideInInspector]
		public Vector3 OpenScale;

		// Token: 0x0400C94A RID: 51530
		[Obsolete]
		[HideInInspector]
		public Vector3 ClosedScale;

		// Token: 0x0400C94B RID: 51531
		public bool DisableWhenClosed;

		// Token: 0x0400C94C RID: 51532
		private Coroutine coroutine_0;

		// Token: 0x0400C94D RID: 51533
		public AudioClip OpenClip;

		// Token: 0x0400C94E RID: 51534
		public AudioClip CloseClip;

		// Token: 0x0400C94F RID: 51535
		public float Volume;

		// Token: 0x0400C950 RID: 51536
		public int Rolloff;

		// Token: 0x0400C951 RID: 51537
		public float LerpSpeed;

		// Token: 0x0400C952 RID: 51538
		public bool ForceStateOnStart;

		// Token: 0x0400C953 RID: 51539
		public AnimationCurve Curve;

		// Token: 0x0400C954 RID: 51540
		public EExfiltrationStatus[] OpenStatus;

		// Token: 0x0400C955 RID: 51541
		private bool bool_0;

		// Token: 0x0400C956 RID: 51542
		[SerializeField]
		private List<Collider> _collisionColliders;

		// Token: 0x0200274A RID: 10058
		[Serializable]
		public class DoorTransform
		{
			// Token: 0x0600C943 RID: 51523 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void StoreValues()
			{
				throw null;
			}

			// Token: 0x0400C957 RID: 51543
			[HideInInspector]
			public Quaternion OpenRotation;

			// Token: 0x0400C958 RID: 51544
			[HideInInspector]
			public Quaternion CloseRotation;

			// Token: 0x0400C959 RID: 51545
			[HideInInspector]
			public Vector3 OpenPosition;

			// Token: 0x0400C95A RID: 51546
			[HideInInspector]
			public Vector3 ClosePosition;

			// Token: 0x0400C95B RID: 51547
			[HideInInspector]
			public Vector3 OpenScale;

			// Token: 0x0400C95C RID: 51548
			[HideInInspector]
			public Vector3 CloseScale;

			// Token: 0x0400C95D RID: 51549
			public Transform Transform;

			// Token: 0x0400C95E RID: 51550
			public bool PlaySoundAt;

			// Token: 0x0400C95F RID: 51551
			[HideInInspector]
			public Vector3 StartPosition;

			// Token: 0x0400C960 RID: 51552
			[HideInInspector]
			public Vector3 StartScale;

			// Token: 0x0400C961 RID: 51553
			[HideInInspector]
			public Quaternion StartRotation;
		}
	}
}
