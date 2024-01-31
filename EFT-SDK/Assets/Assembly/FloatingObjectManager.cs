using System;
using System.Runtime.CompilerServices;

// Token: 0x02000BCF RID: 3023
public class FloatingObjectManager : ComponentSystem<FloatingObject, FloatingObjectManager>
{
	// Token: 0x17000AB8 RID: 2744
	// (get) Token: 0x060041E8 RID: 16872 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000AB9 RID: 2745
	// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00002050 File Offset: 0x00000250
	protected override bool HasLateUpdate
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateComponent(FloatingObject component)
	{
		throw null;
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void LateUpdateComponent(FloatingObject component)
	{
		throw null;
	}
}
