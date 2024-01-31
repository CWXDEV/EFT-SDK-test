using System;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B0A RID: 11018
	public class ItemIconView : UIElement
	{
		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x0600DAA9 RID: 55977 RVA: 0x00002050 File Offset: 0x00000250
		protected Image MainImage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x0600DAAA RID: 55978 RVA: 0x00002050 File Offset: 0x00000250
		protected GameObject IconLoader
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DAAB RID: 55979 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DAAC RID: 55980 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show([CanBeNull] Item item, Action<bool, PointerEventData> onHover, Sprite emptyIconSprite = null)
		{
			throw null;
		}

		// Token: 0x0600DAAD RID: 55981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnHoverEnd(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DAAE RID: 55982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DAAF RID: 55983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Sprite emptySprite)
		{
			throw null;
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void UpdateScale()
		{
			throw null;
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400DDBA RID: 56762
		[SerializeField]
		private Image _mainImage;

		// Token: 0x0400DDBB RID: 56763
		[SerializeField]
		private GameObject _iconLoader;

		// Token: 0x0400DDBC RID: 56764
		[SerializeField]
		private Vector3 _iconRotation;

		// Token: 0x0400DDBD RID: 56765
		[SerializeField]
		private RectTransform _mainRect;

		// Token: 0x0400DDBE RID: 56766
		private Action<bool, PointerEventData> action_0;

		// Token: 0x0400DDBF RID: 56767
		protected GClass818 ItemIcon;
	}
}
