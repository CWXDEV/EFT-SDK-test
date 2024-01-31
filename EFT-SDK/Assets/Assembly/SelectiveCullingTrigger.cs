using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BC6 RID: 3014
[ExecuteInEditMode]
public class SelectiveCullingTrigger : DisablerCullingObject
{
	// Token: 0x17000AA2 RID: 2722
	// (get) Token: 0x0600419E RID: 16798 RVA: 0x00002050 File Offset: 0x00000250
	public override bool HasEntered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000AA3 RID: 2723
	// (get) Token: 0x0600419F RID: 16799 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasEnteredSelfOnly
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060041A0 RID: 16800 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void NullClean()
	{
		throw null;
	}

	// Token: 0x060041A1 RID: 16801 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnParentEnter(SelectiveCullingTrigger parent)
	{
		throw null;
	}

	// Token: 0x060041A2 RID: 16802 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnParentExit(SelectiveCullingTrigger parent)
	{
		throw null;
	}

	// Token: 0x060041A3 RID: 16803 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void UpdateComponentsStatusOnUpdate()
	{
		throw null;
	}

	// Token: 0x04004AAF RID: 19119
	[SerializeField]
	private Color _childGizmosColor;

	// Token: 0x04004AB0 RID: 19120
	[SerializeField]
	private List<SelectiveCullingTrigger> _childs;

	// Token: 0x04004AB1 RID: 19121
	private List<SelectiveCullingTrigger> list_0;
}
