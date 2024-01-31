using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Diz.Binding;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI
{
	// Token: 0x02002AE6 RID: 10982
	public class SimpleContextMenu : UIElement, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x140002FE RID: 766
		// (add) Token: 0x0600DA20 RID: 55840 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DA21 RID: 55841 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<PointerEventData> OnMouseExit
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

		// Token: 0x1700267D RID: 9853
		// (set) Token: 0x0600DA22 RID: 55842 RVA: 0x00002050 File Offset: 0x00000250
		public SimpleContextMenu SubMenuTemplate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show<T>(Vector2 position, GClass3021<T> contextInteractions, IReadOnlyDictionary<T, string> names = null, Item item = null) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show<T>(Vector2 position, GClass3021<T> contextInteractions, IReadOnlyDictionary<T, string> names, IReadOnlyDictionary<T, Sprite> icons) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0<T>(Vector2 position, GClass3021<T> contextInteractions, IReadOnlyDictionary<T, string> names, IReadOnlyDictionary<T, Sprite> icons, Item item) where T : struct, Enum
		{
			throw null;
		}

		// Token: 0x0600DA27 RID: 55847 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600DA28 RID: 55848 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void CorrectPosition(GStruct55 margins = default(GStruct55))
		{
			throw null;
		}

		// Token: 0x0400DD1B RID: 56603
		[SerializeField]
		private InteractionButtonsContainer _interactionButtonsContainer;

		// Token: 0x0400DD1C RID: 56604
		[CompilerGenerated]
		private Action<PointerEventData> action_0;

		// Token: 0x0400DD1D RID: 56605
		[NonSerialized]
		public readonly BindableEvent OnMenuClosed;

		// Token: 0x02002AE7 RID: 10983
		[CompilerGenerated]
		private sealed class Class2575<T> where T : struct, Enum
		{
			// Token: 0x0600DA2A RID: 55850 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(IEnumerable<string> itemIds)
			{
				throw null;
			}

			// Token: 0x0400DD1E RID: 56606
			public Item item;

			// Token: 0x0400DD1F RID: 56607
			public SimpleContextMenu simpleContextMenu_0;
		}
	}
}
