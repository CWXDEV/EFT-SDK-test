using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace EFT.Visual
{
	// Token: 0x02001A1B RID: 6683
	public class GunShadowDisabler : MonoBehaviour
	{
		// Token: 0x06008DC7 RID: 36295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x06008DC8 RID: 36296 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("DisableGunShadow")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisableGunShadow()
		{
			throw null;
		}

		// Token: 0x06008DC9 RID: 36297 RVA: 0x00002050 File Offset: 0x00000250
		[ContextMenu("EnableGunShadow")]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnableGunShadow()
		{
			throw null;
		}

		// Token: 0x04009428 RID: 37928
		[SerializeField]
		private List<Light> Lights;

		// Token: 0x04009429 RID: 37929
		private CommandBuffer commandBuffer_0;

		// Token: 0x0400942A RID: 37930
		private CommandBuffer commandBuffer_1;

		// Token: 0x0400942B RID: 37931
		private static readonly int int_0;
	}
}
