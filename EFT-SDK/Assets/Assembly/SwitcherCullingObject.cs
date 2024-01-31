using System;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

// Token: 0x02000BC7 RID: 3015
[ExecuteInEditMode]
public class SwitcherCullingObject : DisablerCullingObject
{
	// Token: 0x17000AA4 RID: 2724
	// (get) Token: 0x060041A4 RID: 16804 RVA: 0x00002050 File Offset: 0x00000250
	public override bool HasEntered
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060041A5 RID: 16805 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void ManualUpdate(float dt)
	{
		throw null;
	}

	// Token: 0x060041A6 RID: 16806 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4()
	{
		throw null;
	}

	// Token: 0x060041A7 RID: 16807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnTriggerEnterEvent(ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnTriggerExitEvent(ColliderReporter colliderReporter, Collider collider)
	{
		throw null;
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Camera method_5()
	{
		throw null;
	}

	// Token: 0x04004AB2 RID: 19122
	[Header("Первая проверка делается по радиусу, дальше по коллайдерам")]
	[SerializeField]
	[Header("Синяя стрелка (ось Z) коллайдеров должна указывать на вход в помещение")]
	private float _firstCheckRadius;

	// Token: 0x04004AB3 RID: 19123
	private bool bool_1;

	// Token: 0x04004AB4 RID: 19124
	private ColliderReporter colliderReporter_0;

	// Token: 0x04004AB5 RID: 19125
	private Vector3 vector3_0;

	// Token: 0x04004AB6 RID: 19126
	private bool bool_2;
}
