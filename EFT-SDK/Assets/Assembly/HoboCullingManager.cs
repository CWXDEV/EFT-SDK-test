using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BC3 RID: 3011
public class HoboCullingManager : ComponentSystem<DisablerCullingObjectBase, HoboCullingManager>
{
	// Token: 0x17000A9F RID: 2719
	// (get) Token: 0x06004190 RID: 16784 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000AA0 RID: 2720
	// (get) Token: 0x06004191 RID: 16785 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasLateUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06004192 RID: 16786 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateComponent(DisablerCullingObjectBase component)
	{
		throw null;
	}

	// Token: 0x06004193 RID: 16787 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdateComponent(DisablerCullingObjectBase component)
	{
		throw null;
	}
}
