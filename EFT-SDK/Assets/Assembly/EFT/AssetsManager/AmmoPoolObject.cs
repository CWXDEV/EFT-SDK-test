using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.AssetsManager
{
	// Token: 0x02002862 RID: 10338
	[DisallowMultipleComponent]
	public class AmmoPoolObject : AssetPoolObject
	{
		// Token: 0x170024E9 RID: 9449
		// (get) Token: 0x0600CE73 RID: 52851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CE74 RID: 52852 RVA: 0x00002050 File Offset: 0x00000250
		public bool ShouldBeDestroyed
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

		// Token: 0x0600CE75 RID: 52853 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent)
		{
			throw null;
		}

		// Token: 0x0600CE76 RID: 52854 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600CE77 RID: 52855 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void ReturnToPool()
		{
			throw null;
		}

		// Token: 0x0600CE78 RID: 52856 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CE79 RID: 52857 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void EnablePhysics(Vector3 force, Vector3 torque, Vector3 parentForce, Vector3 weaponForward)
		{
			throw null;
		}

		// Token: 0x0600CE7A RID: 52858 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetUsed(bool isUsed)
		{
			throw null;
		}

		// Token: 0x0600CE7B RID: 52859 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartAutoDestroyCountDown(float countdownTime = 1f)
		{
			throw null;
		}

		// Token: 0x0600CE7C RID: 52860 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0400CF30 RID: 53040
		public Shell Shell;

		// Token: 0x0400CF31 RID: 53041
		private List<Transform> list_0;

		// Token: 0x0400CF32 RID: 53042
		private List<Transform> list_1;

		// Token: 0x0400CF33 RID: 53043
		[SerializeField]
		private ECaliber _caliber;

		// Token: 0x0400CF34 RID: 53044
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x0400CF35 RID: 53045
		private float float_0;
	}
}
