using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200157F RID: 5503
public abstract class GClass1666
{
	// Token: 0x060075F4 RID: 30196 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(GameObject gameObject, MagazineClass magazine, bool isAnimated)
	{
		throw null;
	}

	// Token: 0x060075F5 RID: 30197 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnReturnToPool()
	{
		throw null;
	}

	// Token: 0x060075F6 RID: 30198
	public abstract void Update();

	// Token: 0x060075F7 RID: 30199 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Reset()
	{
		throw null;
	}

	// Token: 0x060075F8 RID: 30200
	protected abstract void InitializeVisualOnStart();

	// Token: 0x060075F9 RID: 30201
	protected abstract void ReturnVisualPartsToPool();

	// Token: 0x060075FA RID: 30202
	protected abstract void CacheDataTransforms();

	// Token: 0x060075FB RID: 30203
	protected abstract void RefreshVisualParts();

	// Token: 0x04007C03 RID: 31747
	protected const string string_0 = "patron_";

	// Token: 0x04007C04 RID: 31748
	protected MagazineClass gclass2665_0;

	// Token: 0x04007C05 RID: 31749
	protected GameObject gameObject_0;

	// Token: 0x04007C06 RID: 31750
	protected bool bool_0;
}
