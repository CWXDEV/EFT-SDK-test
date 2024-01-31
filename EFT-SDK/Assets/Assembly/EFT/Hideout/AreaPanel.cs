using System;
using System.Runtime.CompilerServices;
using EFT.UI;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace EFT.Hideout
{
	// Token: 0x02001B9A RID: 7066
	public class AreaPanel : ButtonFeedback
	{
		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x060094A7 RID: 38055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060094A8 RID: 38056 RVA: 0x00002050 File Offset: 0x00000250
		public AreaData Data
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

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x060094A9 RID: 38057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060094AA RID: 38058 RVA: 0x00002050 File Offset: 0x00000250
		protected AreaIcon AreaIconCreated
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

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x00002050 File Offset: 0x00000250
		protected AreaIcon AreaIcon
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x060094AC RID: 38060 RVA: 0x00002050 File Offset: 0x00000250
		protected TextMeshProUGUI AreaName
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform Container
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x060094AE RID: 38062 RVA: 0x00002050 File Offset: 0x00000250
		private ValueTuple<string, string, bool> ValueTuple_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(AreaData data, Action<AreaPanel> onSelected = null)
		{
			throw null;
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init(AreaData data, Action<AreaPanel> onSelected)
		{
			throw null;
		}

		// Token: 0x060094B1 RID: 38065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void SetInfo()
		{
			throw null;
		}

		// Token: 0x060094B2 RID: 38066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerClick(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094B3 RID: 38067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerEnter(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnPointerExit(PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x04009B76 RID: 39798
		private const float float_0 = 0.5f;

		// Token: 0x04009B77 RID: 39799
		[SerializeField]
		private AreaIcon _areaIcon;

		// Token: 0x04009B78 RID: 39800
		[SerializeField]
		private RectTransform _iconImageContainer;

		// Token: 0x04009B79 RID: 39801
		[SerializeField]
		private TextMeshProUGUI _areaName;

		// Token: 0x04009B7A RID: 39802
		[SerializeField]
		private GameObject _statusObject;

		// Token: 0x04009B7B RID: 39803
		[SerializeField]
		private TextMeshProUGUI _areaStatus;

		// Token: 0x04009B7C RID: 39804
		[SerializeField]
		private TextMeshProUGUI _progressTextField;

		// Token: 0x04009B7D RID: 39805
		private int int_0;

		// Token: 0x04009B7E RID: 39806
		private Action<AreaPanel> action_0;

		// Token: 0x04009B7F RID: 39807
		[CompilerGenerated]
		private AreaData areaData_0;

		// Token: 0x04009B80 RID: 39808
		[CompilerGenerated]
		private AreaIcon areaIcon_0;

		// Token: 0x04009B81 RID: 39809
		private bool bool_0;
	}
}
