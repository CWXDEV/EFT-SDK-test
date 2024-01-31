using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT.AssetsManager;
using UnityEngine;

// Token: 0x0200286E RID: 10350
public class GClass3004<T> : GClass3001<T> where T : AssetPoolObject
{
	// Token: 0x0600CEBF RID: 52927 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Task Create(T originalObject, int poolSize, Transform parentTransform, TaskCompletionSource<GInterface357> completionSource, GDelegate77 yield, CancellationToken ct)
	{
		throw null;
	}

	// Token: 0x170024F9 RID: 9465
	// (get) Token: 0x0600CEC0 RID: 52928 RVA: 0x00002050 File Offset: 0x00000250
	protected override string PoolFullName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170024FA RID: 9466
	// (get) Token: 0x0600CEC1 RID: 52929 RVA: 0x00002050 File Offset: 0x00000250
	public override string PoolShortName
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600CEC2 RID: 52930 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override GameObject GetOriginalGameObject(Transform parent)
	{
		throw null;
	}

	// Token: 0x0400CF68 RID: 53096
	protected T gparam_1;
}
