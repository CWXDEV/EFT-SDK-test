using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C4B RID: 11339
	public class SideSelectionToggle : Toggle
	{
		// Token: 0x0600DF82 RID: 57218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<EPlayerSide> onSelectedAction)
		{
			throw null;
		}

		// Token: 0x0600DF83 RID: 57219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool value)
		{
			throw null;
		}

		// Token: 0x0600DF84 RID: 57220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DF85 RID: 57221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400E444 RID: 58436
		[SerializeField]
		private EPlayerSide _side;

		// Token: 0x0400E445 RID: 58437
		[SerializeField]
		private UIAnimatedToggleSpawner _sideSelectionToggle;

		// Token: 0x0400E446 RID: 58438
		[NonSerialized]
		public GClass3355<bool> OnHover;

		// Token: 0x0400E447 RID: 58439
		private Action<EPlayerSide> _onSelectedAction;
	}
}
