using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002AFF RID: 11007
	public sealed class BuffIcon : BuffThumb, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x0600DA7A RID: 55930 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Sprite smethod_0(SkillManager.GClass1770 buff)
		{
			throw null;
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetBuffDescription(SkillManager.GClass1770 buff)
		{
			throw null;
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(SkillManager.GClass1770 buff, GClass1765 skill)
		{
			throw null;
		}

		// Token: 0x0600DA7D RID: 55933 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateBuff()
		{
			throw null;
		}

		// Token: 0x0600DA7E RID: 55934 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DA7F RID: 55935 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DD77 RID: 56695
		[SerializeField]
		private Image _icon;

		// Token: 0x0400DD78 RID: 56696
		[SerializeField]
		private Image _background;

		// Token: 0x0400DD79 RID: 56697
		[SerializeField]
		private Sprite _normalBackgroundSprite;

		// Token: 0x0400DD7A RID: 56698
		[SerializeField]
		private Sprite _eliteBackgroundSprite;

		// Token: 0x0400DD7B RID: 56699
		private SimpleTooltip simpleTooltip_0;
	}
}
