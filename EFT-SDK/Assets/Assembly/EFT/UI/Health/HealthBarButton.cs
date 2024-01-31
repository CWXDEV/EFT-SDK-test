using System;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Health
{
	// Token: 0x02002E9A RID: 11930
	public sealed class HealthBarButton : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IDropHandler
	{
		// Token: 0x0600EB73 RID: 60275 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(IHealthController healthController, EBodyPart bodyPart)
		{
			throw null;
		}

		// Token: 0x0600EB74 RID: 60276 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB75 RID: 60277 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDrop([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600EB77 RID: 60279 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F07E RID: 61566
		private static readonly int int_0;

		// Token: 0x0400F07F RID: 61567
		private static readonly int int_1;

		// Token: 0x0400F080 RID: 61568
		[SerializeField]
		private Animator _animator;

		// Token: 0x0400F081 RID: 61569
		private EBodyPart ebodyPart_0;

		// Token: 0x0400F082 RID: 61570
		private IHealthController ihealthController_0;

		// Token: 0x0400F083 RID: 61571
		private ItemUiContext itemUiContext_0;
	}
}
