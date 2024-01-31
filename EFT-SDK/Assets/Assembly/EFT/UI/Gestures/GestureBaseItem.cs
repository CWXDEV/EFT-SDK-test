using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.InputSystem;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.UI.Gestures
{
	// Token: 0x02002EA0 RID: 11936
	public abstract class GestureBaseItem : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x1700287F RID: 10367
		// (get) Token: 0x0600EB8B RID: 60299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EB8C RID: 60300 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsUnderPointer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002880 RID: 10368
		// (get) Token: 0x0600EB8D RID: 60301
		public abstract int ItemIndex { get; }

		// Token: 0x0600EB8E RID: 60302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ShowInternal(ECommand command, int index, string caption)
		{
			throw null;
		}

		// Token: 0x0600EB90 RID: 60304
		protected abstract void BindUpdatedHandler(GesturesMenu.GStruct400 bind);

		// Token: 0x0600EB91 RID: 60305
		protected abstract void UnderPointerChanged(bool isUnderPointer);

		// Token: 0x0600EB92 RID: 60306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerClickHandler.OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F0AB RID: 61611
		[NonSerialized]
		public readonly GClass3355<GestureBaseItem.GStruct399> OnPointerClicked;

		// Token: 0x0400F0AC RID: 61612
		private bool bool_0;

		// Token: 0x02002EA1 RID: 11937
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct399
		{
			// Token: 0x0400F0AD RID: 61613
			public int ItemIndex;

			// Token: 0x0400F0AE RID: 61614
			public Vector2 Position;

			// Token: 0x0400F0AF RID: 61615
			public PointerEventData.InputButton Button;
		}
	}
}
