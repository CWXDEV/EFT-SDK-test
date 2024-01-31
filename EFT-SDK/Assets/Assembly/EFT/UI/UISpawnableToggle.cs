using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x0200291A RID: 10522
	public class UISpawnableToggle : ButtonFeedback
	{
		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600D219 RID: 53785 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D21A RID: 53786 RVA: 0x00002050 File Offset: 0x00000250
		internal bool Boolean_0
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

		// Token: 0x1700256D RID: 9581
		// (get) Token: 0x0600D21B RID: 53787 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D21C RID: 53788 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Interactable
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

		// Token: 0x0600D21D RID: 53789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1(ToggleGroup group)
		{
			throw null;
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_2(string headerText, int headerSize, [CanBeNull] Sprite sprite, [CanBeNull] GameObject hoverImage)
		{
			throw null;
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_3(bool useEllipsis)
		{
			throw null;
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_4(float minWidth)
		{
			throw null;
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Highlighted()
		{
			throw null;
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Default()
		{
			throw null;
		}

		// Token: 0x0400D36F RID: 54127
		[SerializeField]
		private CustomTextMeshProUGUI _headerLabel;

		// Token: 0x0400D370 RID: 54128
		[SerializeField]
		private CustomTextMeshProUGUI _sizeLabel;

		// Token: 0x0400D371 RID: 54129
		[SerializeField]
		private Image _iconSprite;

		// Token: 0x0400D372 RID: 54130
		[SerializeField]
		private bool _isBoldOnHover;

		// Token: 0x0400D373 RID: 54131
		private GameObject gameObject_0;

		// Token: 0x0400D374 RID: 54132
		public AnimatedToggle Toggle;

		// Token: 0x0400D375 RID: 54133
		private FontStyles fontStyles_0;
	}
}
