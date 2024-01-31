using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EFB RID: 7931
	[Serializable]
	public class RecoilProcessBase
	{
		// Token: 0x0600A3D1 RID: 41937 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void CalculateRecoil(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3D2 RID: 41938 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void AddAccelerationLimitless(int comp, float val)
		{
			throw null;
		}

		// Token: 0x0600A3D3 RID: 41939 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual Vector3 GetRecoil(bool useOffset)
		{
			throw null;
		}

		// Token: 0x0400AB47 RID: 43847
		[Tooltip("Скорость возврата к исходному положению")]
		public float ReturnSpeed;

		// Token: 0x0400AB48 RID: 43848
		[Tooltip("Раскачивание")]
		public float Damping;

		// Token: 0x0400AB49 RID: 43849
		[Tooltip("Сила отдачи")]
		public float Intensity;

		// Token: 0x0400AB4A RID: 43850
		[Tooltip("Применение смещения извне, например эффект дыхния")]
		public bool UseOffset;

		// Token: 0x0400AB4B RID: 43851
		[HideInInspector]
		public Vector3 Offset;

		// Token: 0x0400AB4C RID: 43852
		[HideInInspector]
		public Vector3 Velocity;

		// Token: 0x0400AB4D RID: 43853
		[HideInInspector]
		public Vector3 Current;

		// Token: 0x0400AB4E RID: 43854
		[HideInInspector]
		public Vector3 ForceAccumulatorLimitless;

		// Token: 0x0400AB4F RID: 43855
		[HideInInspector]
		public bool NeedUpdate;

		// Token: 0x0400AB50 RID: 43856
		[HideInInspector]
		public bool StableOn;
	}
}
