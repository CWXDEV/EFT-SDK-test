using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.HandBook
{
	// Token: 0x02002606 RID: 9734
	public sealed class EntityListElement : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		// Token: 0x17002284 RID: 8836
		// (get) Token: 0x0600C136 RID: 49462 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C137 RID: 49463 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17002285 RID: 8837
		// (get) Token: 0x0600C138 RID: 49464 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17002286 RID: 8838
		// (get) Token: 0x0600C139 RID: 49465 RVA: 0x00002050 File Offset: 0x00000250
		private Color Color_1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600C13A RID: 49466 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(GClass2884 node, Action<GClass2884> onChosen)
		{
			throw null;
		}

		// Token: 0x0600C13B RID: 49467 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(bool isNew)
		{
			throw null;
		}

		// Token: 0x0600C13F RID: 49471 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600C140 RID: 49472 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeselectView()
		{
			throw null;
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0400C357 RID: 50007
		[SerializeField]
		private EntityIcon _icon;

		// Token: 0x0400C358 RID: 50008
		[SerializeField]
		private Image _background;

		// Token: 0x0400C359 RID: 50009
		[SerializeField]
		private GameObject _newNodeObject;

		// Token: 0x0400C35A RID: 50010
		[SerializeField]
		private TextMeshProUGUI _name;

		// Token: 0x0400C35B RID: 50011
		[SerializeField]
		private TextMeshProUGUI _itemCategory;

		// Token: 0x0400C35C RID: 50012
		[SerializeField]
		private Color32 _defaultTextColor;

		// Token: 0x0400C35D RID: 50013
		[SerializeField]
		private Color32 _defaultCategoryColor;

		// Token: 0x0400C35E RID: 50014
		[SerializeField]
		private Color32 _hoverTextColor;

		// Token: 0x0400C35F RID: 50015
		[SerializeField]
		private Color _selectedBackgroundColor;

		// Token: 0x0400C360 RID: 50016
		private GClass2884 gclass2884_0;

		// Token: 0x0400C361 RID: 50017
		private Action<GClass2884> action_0;

		// Token: 0x0400C362 RID: 50018
		private GClass818 gclass818_0;

		// Token: 0x0400C363 RID: 50019
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x02002607 RID: 9735
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2188
		{
			// Token: 0x0600C143 RID: 49475 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(string x)
			{
				throw null;
			}

			// Token: 0x0400C364 RID: 50020
			public static readonly EntityListElement.Class2188 class2188_0;

			// Token: 0x0400C365 RID: 50021
			public static Func<string, string> func_0;
		}
	}
}
