using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GPUInstancer
{
	// Token: 0x02000E59 RID: 3673
	public class SpaceshipMobileJoystick : MonoBehaviour, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
	{
		// Token: 0x06004CB8 RID: 19640 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnDrag(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x06004CBA RID: 19642 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerDown(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x06004CBB RID: 19643 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void OnPointerUp(PointerEventData data)
		{
			throw null;
		}

		// Token: 0x0400580B RID: 22539
		[HideInInspector]
		public Vector3 inputDirection;

		// Token: 0x0400580C RID: 22540
		private Image image_0;

		// Token: 0x0400580D RID: 22541
		private Image image_1;

		// Token: 0x0400580E RID: 22542
		private Vector2 vector2_0;
	}
}
