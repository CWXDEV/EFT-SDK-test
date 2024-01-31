using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02000BC1 RID: 3009
public abstract class DisablerCullingObjectBase : UpdateInEditorSystemComponent<DisablerCullingObjectBase>, IBotController
{
	// Token: 0x17000A9E RID: 2718
	// (get) Token: 0x0600417B RID: 16763 RVA: 0x00002050 File Offset: 0x00000250
	public virtual bool HasEntered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600417C RID: 16764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnPreProcess()
	{
		throw null;
	}

	// Token: 0x0600417D RID: 16765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CollidersNullCheck()
	{
		throw null;
	}

	// Token: 0x0600417E RID: 16766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void CollidersNullCheck(ref List<Collider> colliders)
	{
		throw null;
	}

	// Token: 0x0600417F RID: 16767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	// Token: 0x06004180 RID: 16768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Awake()
	{
		throw null;
	}

	// Token: 0x06004181 RID: 16769 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PrepareCullingObject()
	{
		throw null;
	}

	// Token: 0x06004182 RID: 16770 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06004183 RID: 16771 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualUpdate(float dt)
	{
		throw null;
	}

	// Token: 0x06004184 RID: 16772
	protected abstract void SetComponentsEnabled(bool hasEntered);

	// Token: 0x06004185 RID: 16773 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnValidate()
	{
		throw null;
	}

	// Token: 0x06004186 RID: 16774 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Validate()
	{
		throw null;
	}

	// Token: 0x06004187 RID: 16775 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(List<Collider> colliders, List<ColliderReporter> colliderReporters, bool inverse)
	{
		throw null;
	}

	// Token: 0x06004188 RID: 16776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected bool IsRightCollider(Collider col)
	{
		throw null;
	}

	// Token: 0x06004189 RID: 16777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnTriggerEnterEvent(ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x0600418A RID: 16778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(List<ColliderReporter> enteredColliders, ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x0600418B RID: 16779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnTriggerExitEvent(ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x0600418C RID: 16780 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(List<ColliderReporter> enteredColliders, ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x0600418D RID: 16781 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void UpdateComponentsStatusOnUpdate()
	{
		throw null;
	}

	// Token: 0x04004A9D RID: 19101
	[SerializeField]
	protected List<Collider> _colliders;

	// Token: 0x04004A9E RID: 19102
	[SerializeField]
	protected List<Collider> _inverseColliders;

	// Token: 0x04004A9F RID: 19103
	protected List<ColliderReporter> _enteredColliders;

	// Token: 0x04004AA0 RID: 19104
	protected List<ColliderReporter> _enteredInverseColliders;

	// Token: 0x04004AA1 RID: 19105
	protected List<ColliderReporter> _colliderReporters;

	// Token: 0x04004AA2 RID: 19106
	protected List<ColliderReporter> _inverseColliderReporters;

	// Token: 0x04004AA3 RID: 19107
	protected bool _updateComponentsStatus;
}
