using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

namespace Audio.Vehicles.BTR
{
	// Token: 0x02000D20 RID: 3360
	public class BtrDoorSoundHandler : MonoBehaviour
	{
		// Token: 0x0600477C RID: 18300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Awake()
		{
			throw null;
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(float value)
		{
			throw null;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnFilterEnd(bool onEnabled, bool isOn)
		{
			throw null;
		}

		// Token: 0x06004780 RID: 18304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(SoundBank bank)
		{
			throw null;
		}

		// Token: 0x04005253 RID: 21075
		[SerializeField]
		private HysteresisFilter _filter;

		// Token: 0x04005254 RID: 21076
		[SerializeField]
		private Transform _hingeTransform;

		// Token: 0x04005255 RID: 21077
		[SerializeField]
		private float _closeEndSoundFilterValue;

		// Token: 0x04005256 RID: 21078
		[SerializeField]
		private SoundBank _openSound;

		// Token: 0x04005257 RID: 21079
		[SerializeField]
		private SoundBank _closeStartSound;

		// Token: 0x04005258 RID: 21080
		[SerializeField]
		private SoundBank _closeEndSound;

		// Token: 0x04005259 RID: 21081
		private bool bool_0;
	}
}
