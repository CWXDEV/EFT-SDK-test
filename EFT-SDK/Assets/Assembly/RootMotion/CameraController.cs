using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02001063 RID: 4195
	public class CameraController : MonoBehaviour
	{
		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06005793 RID: 22419 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005794 RID: 22420 RVA: 0x00002050 File Offset: 0x00000250
		public float x
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

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06005795 RID: 22421 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005796 RID: 22422 RVA: 0x00002050 File Offset: 0x00000250
		public float y
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

		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x06005797 RID: 22423 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005798 RID: 22424 RVA: 0x00002050 File Offset: 0x00000250
		public float distanceTarget
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

		// Token: 0x06005799 RID: 22425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600579A RID: 22426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600579B RID: 22427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600579C RID: 22428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void LateUpdate()
		{
			throw null;
		}

		// Token: 0x0600579D RID: 22429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateInput()
		{
			throw null;
		}

		// Token: 0x0600579E RID: 22430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTransform()
		{
			throw null;
		}

		// Token: 0x0600579F RID: 22431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateTransform(float deltaTime)
		{
			throw null;
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x060057A0 RID: 22432 RVA: 0x00002050 File Offset: 0x00000250
		private float Single_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060057A1 RID: 22433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_0(float angle, float min, float max)
		{
			throw null;
		}

		// Token: 0x04006326 RID: 25382
		public Transform target;

		// Token: 0x04006327 RID: 25383
		public CameraController.UpdateMode updateMode;

		// Token: 0x04006328 RID: 25384
		public bool lockCursor;

		// Token: 0x04006329 RID: 25385
		public bool smoothFollow;

		// Token: 0x0400632A RID: 25386
		public float followSpeed;

		// Token: 0x0400632B RID: 25387
		public float distance;

		// Token: 0x0400632C RID: 25388
		public float minDistance;

		// Token: 0x0400632D RID: 25389
		public float maxDistance;

		// Token: 0x0400632E RID: 25390
		public float zoomSpeed;

		// Token: 0x0400632F RID: 25391
		public float zoomSensitivity;

		// Token: 0x04006330 RID: 25392
		public float rotationSensitivity;

		// Token: 0x04006331 RID: 25393
		public float yMinLimit;

		// Token: 0x04006332 RID: 25394
		public float yMaxLimit;

		// Token: 0x04006333 RID: 25395
		public Vector3 offset;

		// Token: 0x04006334 RID: 25396
		public bool rotateAlways;

		// Token: 0x04006335 RID: 25397
		public bool rotateOnLeftButton;

		// Token: 0x04006336 RID: 25398
		public bool rotateOnRightButton;

		// Token: 0x04006337 RID: 25399
		public bool rotateOnMiddleButton;

		// Token: 0x04006338 RID: 25400
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04006339 RID: 25401
		[CompilerGenerated]
		private float float_1;

		// Token: 0x0400633A RID: 25402
		[CompilerGenerated]
		private float float_2;

		// Token: 0x0400633B RID: 25403
		private Vector3 vector3_0;

		// Token: 0x0400633C RID: 25404
		private Vector3 vector3_1;

		// Token: 0x0400633D RID: 25405
		private Quaternion quaternion_0;

		// Token: 0x0400633E RID: 25406
		private Vector3 vector3_2;

		// Token: 0x0400633F RID: 25407
		private Camera camera_0;

		// Token: 0x02001064 RID: 4196
		[Serializable]
		public enum UpdateMode
		{
			// Token: 0x04006341 RID: 25409
			Update,
			// Token: 0x04006342 RID: 25410
			FixedUpdate,
			// Token: 0x04006343 RID: 25411
			LateUpdate
		}
	}
}
