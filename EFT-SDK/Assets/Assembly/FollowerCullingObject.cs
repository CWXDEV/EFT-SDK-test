using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BBD RID: 3005
[ExecuteInEditMode]
public class FollowerCullingObject : CullingObject
{
	// Token: 0x140000D6 RID: 214
	// (add) Token: 0x0600415A RID: 16730 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600415B RID: 16731 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<bool> OnVisibilityChanged
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600415C RID: 16732 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init(Func<Transform> transformGetter)
	{
		throw null;
	}

	// Token: 0x0600415D RID: 16733 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetParams(float radius, Vector3 shift, float cullDistance)
	{
		throw null;
	}

	// Token: 0x0600415E RID: 16734 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override Transform GetTransform()
	{
		throw null;
	}

	// Token: 0x0600415F RID: 16735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetVisibility(bool isVisible)
	{
		throw null;
	}

	// Token: 0x04004A81 RID: 19073
	[CompilerGenerated]
	private Action<bool> action_0;

	// Token: 0x04004A82 RID: 19074
	private Func<Transform> func_0;
}
