using System;
using System.Runtime.CompilerServices;

// Token: 0x02000A20 RID: 2592
public class BaseLightSystem : ComponentSystem<BaseLight, BaseLightSystem>
{
	// Token: 0x17000983 RID: 2435
	// (get) Token: 0x06003906 RID: 14598 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000984 RID: 2436
	// (get) Token: 0x06003907 RID: 14599 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasLateUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateComponent(BaseLight component)
	{
		throw null;
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdateComponent(BaseLight component)
	{
		throw null;
	}
}
