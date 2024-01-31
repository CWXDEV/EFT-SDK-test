using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.AssetsManager
{
	// Token: 0x0200283A RID: 10298
	public class PoolContainerObject : MonoBehaviour
	{
		// Token: 0x170024DD RID: 9437
		// (get) Token: 0x0600CDEE RID: 52718 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CDEF RID: 52719 RVA: 0x00002050 File Offset: 0x00000250
		public GameObject OriginGameObject
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600CDF0 RID: 52720 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToContainer(AssetPoolObject poolObject)
		{
			throw null;
		}

		// Token: 0x0600CDF1 RID: 52721 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromContainer(AssetPoolObject poolObject)
		{
			throw null;
		}

		// Token: 0x0400CE9E RID: 52894
		[SerializeField]
		private GameObject _originGameObject;

		// Token: 0x0400CE9F RID: 52895
		public List<AssetPoolObject> PoolObjects;
	}
}
