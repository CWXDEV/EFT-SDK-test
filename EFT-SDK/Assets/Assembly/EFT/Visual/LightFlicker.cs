using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.Visual
{
	// Token: 0x02001A1A RID: 6682
	public class LightFlicker : Flicker
	{
		// Token: 0x06008DC5 RID: 36293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x06008DC6 RID: 36294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void ManualUpdate()
		{
			throw null;
		}

		// Token: 0x04009427 RID: 37927
		[SerializeField]
		private Light _light;
	}
}
