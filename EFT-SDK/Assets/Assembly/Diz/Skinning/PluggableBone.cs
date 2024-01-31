using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Diz.Skinning
{
	// Token: 0x020030A4 RID: 12452
	public class PluggableBone : MonoBehaviour
	{
		// Token: 0x0600F484 RID: 62596 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plug(Skeleton skeleton, Vector3 localPosition, Vector3 localRotation)
		{
			throw null;
		}

		// Token: 0x0600F485 RID: 62597 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Unplug()
		{
			throw null;
		}

		// Token: 0x0400FA94 RID: 64148
		[SerializeField]
		public string BonePath;
	}
}
