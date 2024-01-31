using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Animations
{
	// Token: 0x02001EFA RID: 7930
	[Serializable]
	public class OldRotationRecoilProcess : RotationRecoilProcessBase
	{
		// Token: 0x0600A3CE RID: 41934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void CalculateRecoil(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600A3CF RID: 41935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveOriginalReturnSpeedCurveValues()
		{
			throw null;
		}

		// Token: 0x0600A3D0 RID: 41936 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReturnSpeedCurveScale(float mult)
		{
			throw null;
		}

		// Token: 0x0400AB44 RID: 43844
		public AnimationCurve ReturnSpeedCurve;

		// Token: 0x0400AB45 RID: 43845
		private float[] _originalReturnCurveValues;

		// Token: 0x0400AB46 RID: 43846
		private float _curveTime;
	}
}
