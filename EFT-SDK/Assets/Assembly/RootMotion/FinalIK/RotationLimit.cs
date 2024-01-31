using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020010E9 RID: 4329
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x06005B5C RID: 23388 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetDefaultLocalRotation()
		{
			throw null;
		}

		// Token: 0x06005B5D RID: 23389 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			throw null;
		}

		// Token: 0x06005B5E RID: 23390 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Apply()
		{
			throw null;
		}

		// Token: 0x06005B5F RID: 23391 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x06005B60 RID: 23392 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 secondaryAxis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x06005B61 RID: 23393 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 crossAxis
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06005B62 RID: 23394
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		// Token: 0x06005B63 RID: 23395 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06005B64 RID: 23396 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LateUpdate()
		{
			throw null;
		}

		// Token: 0x06005B65 RID: 23397 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LogWarning(string message)
		{
			throw null;
		}

		// Token: 0x06005B66 RID: 23398 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			throw null;
		}

		// Token: 0x06005B67 RID: 23399 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			throw null;
		}

		// Token: 0x06005B68 RID: 23400 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			throw null;
		}

		// Token: 0x040066E0 RID: 26336
		public Vector3 axis;

		// Token: 0x040066E1 RID: 26337
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		// Token: 0x040066E2 RID: 26338
		private bool initiated;

		// Token: 0x040066E3 RID: 26339
		private bool applicationQuit;
	}
}
