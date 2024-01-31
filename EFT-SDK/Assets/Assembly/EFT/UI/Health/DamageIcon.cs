using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Health
{
	// Token: 0x02002E95 RID: 11925
	public class DamageIcon : UIElement
	{
		// Token: 0x0600EB67 RID: 60263 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(DamageStats.EDamageResult iconType, List<DamageStats> damageList)
		{
			throw null;
		}

		// Token: 0x0600EB69 RID: 60265 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600EB6B RID: 60267 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData _)
		{
			throw null;
		}

		// Token: 0x0400F071 RID: 61553
		[SerializeField]
		private Image _icon;

		// Token: 0x0400F072 RID: 61554
		private HoverTrigger hoverTrigger_0;

		// Token: 0x0400F073 RID: 61555
		private SimpleTooltip simpleTooltip_0;

		// Token: 0x0400F074 RID: 61556
		private string string_0;
	}
}
