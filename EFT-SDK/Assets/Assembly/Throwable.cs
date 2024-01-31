using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000706 RID: 1798
public abstract class Throwable : MonoBehaviour
{
	// Token: 0x1400007B RID: 123
	// (add) Token: 0x060029EE RID: 10734 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060029EF RID: 10735 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Throwable> DestroyEvent
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

	// Token: 0x1400007C RID: 124
	// (add) Token: 0x060029F0 RID: 10736 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060029F1 RID: 10737 RVA: 0x00002050 File Offset: 0x00000250
	public event Action<Throwable> VelocityBelowThreshold
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

	// Token: 0x17000749 RID: 1865
	// (get) Token: 0x060029F2 RID: 10738 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060029F3 RID: 10739 RVA: 0x00002050 File Offset: 0x00000250
	public byte CollisionNumber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x1700074A RID: 1866
	// (get) Token: 0x060029F4 RID: 10740
	public abstract int Id { get; }

	// Token: 0x1700074B RID: 1867
	// (get) Token: 0x060029F5 RID: 10741
	public abstract bool HasNetData { get; }

	// Token: 0x060029F6 RID: 10742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(ThrowableSettings throwableSettings)
	{
		throw null;
	}

	// Token: 0x060029F7 RID: 10743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnCollisionHandler()
	{
		throw null;
	}

	// Token: 0x060029F8 RID: 10744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDestroy()
	{
		throw null;
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual GStruct126 GetNetPacket()
	{
		throw null;
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ApplyNetPacket(GStruct126 packet)
	{
		throw null;
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator method_0(GStruct126 packet)
	{
		throw null;
	}

	// Token: 0x060029FD RID: 10749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(GStruct126 packet)
	{
		throw null;
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnDoneFromNet()
	{
		throw null;
	}

	// Token: 0x0400280B RID: 10251
	private const float float_0 = 0.5f;

	// Token: 0x0400280C RID: 10252
	[CompilerGenerated]
	private Action<Throwable> action_0;

	// Token: 0x0400280D RID: 10253
	[CompilerGenerated]
	private Action<Throwable> action_1;

	// Token: 0x0400280E RID: 10254
	protected Rigidbody Rigidbody;

	// Token: 0x0400280F RID: 10255
	protected Vector3 Velocity;

	// Token: 0x04002810 RID: 10256
	protected float IgnoreCollisionTrackingTimer;

	// Token: 0x04002811 RID: 10257
	private int int_0;

	// Token: 0x04002812 RID: 10258
	private const int int_1 = 180;

	// Token: 0x04002813 RID: 10259
	private bool bool_0;

	// Token: 0x04002814 RID: 10260
	private bool bool_1;

	// Token: 0x04002815 RID: 10261
	private ThrowableSettings throwableSettings_0;

	// Token: 0x04002816 RID: 10262
	private float float_1;

	// Token: 0x04002817 RID: 10263
	private byte byte_0;

	// Token: 0x04002818 RID: 10264
	private Coroutine coroutine_0;

	// Token: 0x04002819 RID: 10265
	private const float float_2 = 0.2f;
}
