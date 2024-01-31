using System;
using System.Runtime.CompilerServices;
using Diz.Binding;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x020009CD RID: 2509
[UsedImplicitly]
public sealed class PointerEventsProxy : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	// Token: 0x1700096D RID: 2413
	// (get) Token: 0x060037DF RID: 14303 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface386 OnPointerEnter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700096E RID: 2414
	// (get) Token: 0x060037E0 RID: 14304 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface386 OnPointerExit
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060037E1 RID: 14305 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x060037E2 RID: 14306 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
	{
		throw null;
	}

	// Token: 0x0400399E RID: 14750
	private readonly BindableEvent bindableEvent_0;

	// Token: 0x0400399F RID: 14751
	private readonly BindableEvent bindableEvent_1;
}
