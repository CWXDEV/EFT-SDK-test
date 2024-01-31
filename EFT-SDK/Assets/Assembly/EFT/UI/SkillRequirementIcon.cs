using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B53 RID: 11091
	public sealed class SkillRequirementIcon : UIElement
	{
		// Token: 0x0600DB78 RID: 56184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass1765 skill, Action<bool, PointerEventData> onHover)
		{
			throw null;
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Sprite smethod_0(GClass1765 skill)
		{
			throw null;
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DB7D RID: 56189 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400DF23 RID: 57123
		[SerializeField]
		private Image _border;

		// Token: 0x0400DF24 RID: 57124
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DF25 RID: 57125
		[SerializeField]
		private SkillLevelPanel _levelPanel;

		// Token: 0x0400DF26 RID: 57126
		private GClass1765 gclass1765_0;

		// Token: 0x0400DF27 RID: 57127
		private Action<bool, PointerEventData> action_0;

		// Token: 0x0400DF28 RID: 57128
		private readonly Color color_0;
	}
}
