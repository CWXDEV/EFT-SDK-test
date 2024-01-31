using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x020029AD RID: 10669
	public abstract class HandoverSelectItemsWindow : HandoverItemsWindow, GClass2816.GInterface335
	{
		// Token: 0x140002E8 RID: 744
		// (add) Token: 0x0600D43A RID: 54330 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600D43B RID: 54331 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<Item, bool> OnItemSelected
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

		// Token: 0x0600D43C RID: 54332 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Awake()
		{
			throw null;
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected GClass3087 Show(string title, string message, Profile profile, TraderControllerClass itemController, GClass2816 itemContext, Action cancelAction)
		{
			throw null;
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void AutoSelectButtonPressedHandler()
		{
			throw null;
		}

		// Token: 0x0600D43F RID: 54335
		protected abstract void TrySelectItemToHandover(Item item);

		// Token: 0x0600D440 RID: 54336
		protected abstract bool IsSelected(Item item);

		// Token: 0x0600D441 RID: 54337 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void GClass2816.GInterface335.ToggleSelection(GClass2816 context)
		{
			throw null;
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsSelected(Item item)
		{
			throw null;
		}

		// Token: 0x0600D443 RID: 54339
		protected abstract bool IsActive(Item item, out string tooltip);

		// Token: 0x0600D444 RID: 54340 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		bool GClass2816.GInterface335.IsActive(GClass2816 context, out string tooltip)
		{
			throw null;
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void SelectView(Item item)
		{
			throw null;
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void DeselectView(Item item)
		{
			throw null;
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void ClearSelectedList()
		{
			throw null;
		}

		// Token: 0x0600D448 RID: 54344 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected override void Clear()
		{
			throw null;
		}

		// Token: 0x0400D68D RID: 54925
		[SerializeField]
		private Button _autoSelectButton;

		// Token: 0x0400D68E RID: 54926
		protected double CurrentValue;

		// Token: 0x0400D68F RID: 54927
		[CompilerGenerated]
		private Action<Item, bool> action_2;

		// Token: 0x020029AE RID: 10670
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2452
		{
			// Token: 0x0600D449 RID: 54345 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400D690 RID: 54928
			public static readonly HandoverSelectItemsWindow.Class2452 class2452_0;

			// Token: 0x0400D691 RID: 54929
			public static Action action_0;
		}
	}
}
