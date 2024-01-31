using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000ADB RID: 2779
public class MuzzleSystem : ComponentSystem<MuzzleManager, MuzzleSystem>
{
	// Token: 0x170009EC RID: 2540
	// (get) Token: 0x06003C96 RID: 15510 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170009ED RID: 2541
	// (get) Token: 0x06003C97 RID: 15511 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasLateUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateComponent(MuzzleManager component)
	{
		throw null;
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdateComponent(MuzzleManager component)
	{
		throw null;
	}

	// Token: 0x04004281 RID: 17025
	private Camera camera_0;
}
