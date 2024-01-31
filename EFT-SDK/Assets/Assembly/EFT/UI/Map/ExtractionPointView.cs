using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI.Map
{
	// Token: 0x02002F17 RID: 12055
	public sealed class ExtractionPointView : UIElement, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x170028CD RID: 10445
		// (get) Token: 0x0600EDF1 RID: 60913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EDF2 RID: 60914 RVA: 0x00002050 File Offset: 0x00000250
		public ExtractionPoint ExtractionPoint
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600EDF3 RID: 60915 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(ExtractionPoint point, Action<ExtractionPoint> onDoubleClick)
		{
			throw null;
		}

		// Token: 0x0600EDF4 RID: 60916 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600EDF5 RID: 60917 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetMainColor(Color32 color)
		{
			throw null;
		}

		// Token: 0x0600EDF6 RID: 60918 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnPointerClick([CanBeNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0400F331 RID: 62257
		[SerializeField]
		private Image _background;

		// Token: 0x0400F332 RID: 62258
		[SerializeField]
		private Image _whiteIcon;

		// Token: 0x0400F333 RID: 62259
		[SerializeField]
		private GameObject _icon;

		// Token: 0x0400F334 RID: 62260
		[SerializeField]
		private GameObject _notGuaranteedIcon;

		// Token: 0x0400F335 RID: 62261
		[SerializeField]
		private CustomTextMeshProUGUI _nameLeft;

		// Token: 0x0400F336 RID: 62262
		[SerializeField]
		private CustomTextMeshProUGUI _nameRight;

		// Token: 0x0400F337 RID: 62263
		[SerializeField]
		private Image _textLeft;

		// Token: 0x0400F338 RID: 62264
		[SerializeField]
		private Image _textRight;

		// Token: 0x0400F339 RID: 62265
		[CompilerGenerated]
		private ExtractionPoint extractionPoint_0;
	}
}
