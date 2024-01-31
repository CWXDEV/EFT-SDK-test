using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BFB RID: 7163
	[Serializable]
	public class RailCameraMoveSettings
	{
		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x0600965E RID: 38494 RVA: 0x00002050 File Offset: 0x00000250
		public float Delta
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x0600965F RID: 38495 RVA: 0x00002050 File Offset: 0x00000250
		public float DefaultNormalizedTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06009660 RID: 38496 RVA: 0x00002050 File Offset: 0x00000250
		public Animation Animation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06009661 RID: 38497 RVA: 0x00002050 File Offset: 0x00000250
		public float AnimationSpeed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009D35 RID: 40245
		[SerializeField]
		private float _delta;

		// Token: 0x04009D36 RID: 40246
		[SerializeField]
		private float _defaultNormalizedTime;

		// Token: 0x04009D37 RID: 40247
		[SerializeField]
		private Animation _animation;

		// Token: 0x04009D38 RID: 40248
		[SerializeField]
		private float _animationSpeed;
	}
}
