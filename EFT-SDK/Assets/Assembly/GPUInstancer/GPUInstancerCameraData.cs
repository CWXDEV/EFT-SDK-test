using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GPUInstancer
{
	// Token: 0x02000E76 RID: 3702
	[Serializable]
	public class GPUInstancerCameraData
	{
		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06004D72 RID: 19826 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsOptic
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06004D73 RID: 19827 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D74 RID: 19828 RVA: 0x00002050 File Offset: 0x00000250
		public float LastAngularFrustumOffset
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

		// Token: 0x06004D75 RID: 19829 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetCamera(Camera mainCamera)
		{
			throw null;
		}

		// Token: 0x06004D76 RID: 19830 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateCameraData()
		{
			throw null;
		}

		// Token: 0x06004D77 RID: 19831 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateHalfAngle()
		{
			throw null;
		}

		// Token: 0x06004D78 RID: 19832 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CalculateAngularFrustumOffset(float frustumOffset)
		{
			throw null;
		}

		// Token: 0x0400590D RID: 22797
		public Camera mainCamera;

		// Token: 0x0400590E RID: 22798
		public SSAA mainCameraSSAA;

		// Token: 0x0400590F RID: 22799
		public GPUInstancerHiZOcclusionGenerator hiZOcclusionGenerator;

		// Token: 0x04005910 RID: 22800
		public float[] mvpMatrixFloats;

		// Token: 0x04005911 RID: 22801
		public float[] mvpMatrix2Floats;

		// Token: 0x04005912 RID: 22802
		public Vector3 cameraPosition;

		// Token: 0x04005913 RID: 22803
		public bool hasOcclusionGenerator;

		// Token: 0x04005914 RID: 22804
		public float halfAngle;

		// Token: 0x04005916 RID: 22806
		private Quaternion previousRotation;
	}
}
