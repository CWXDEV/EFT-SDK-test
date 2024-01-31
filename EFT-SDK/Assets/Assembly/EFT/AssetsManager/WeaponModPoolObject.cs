using System;
using System.Runtime.CompilerServices;
using EFT.CameraControl;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.AssetsManager
{
	// Token: 0x02002867 RID: 10343
	[DisallowMultipleComponent]
	public class WeaponModPoolObject : AssetPoolObject
	{
		// Token: 0x0600CE8C RID: 52876 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent)
		{
			throw null;
		}

		// Token: 0x0600CE8D RID: 52877 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReturnToPool()
		{
			throw null;
		}

		// Token: 0x0400CF48 RID: 53064
		private OpticSight[] opticSight_0;
	}
}
