using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002BE1 RID: 11233
	public class ServiceListItem : UIElement
	{
		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x0600DD6F RID: 56687 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DD70 RID: 56688 RVA: 0x00002050 File Offset: 0x00000250
		public ServicesListView.ServiceInfo ServiceInfo
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

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Init(Action<ServiceListItem> onSelected, ServicesListView.ServiceInfo serviceInfo)
		{
			throw null;
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateView(bool selected)
		{
			throw null;
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0400E1F1 RID: 57841
		[SerializeField]
		private Image _serviceIcon;

		// Token: 0x0400E1F2 RID: 57842
		[SerializeField]
		private Image _serviceIconBackground;

		// Token: 0x0400E1F3 RID: 57843
		[SerializeField]
		private Image _serviceIconBorder;

		// Token: 0x0400E1F4 RID: 57844
		[SerializeField]
		private Button _serviceButton;

		// Token: 0x0400E1F5 RID: 57845
		[SerializeField]
		private Image _serviceBackgroud;

		// Token: 0x0400E1F6 RID: 57846
		[SerializeField]
		private Image _selectedArrow;

		// Token: 0x0400E1F7 RID: 57847
		[SerializeField]
		private TextMeshProUGUI _serviceText;

		// Token: 0x0400E1F8 RID: 57848
		[SerializeField]
		private ColorMap _backColors;

		// Token: 0x0400E1F9 RID: 57849
		[SerializeField]
		private ColorMap _textColors;

		// Token: 0x0400E1FA RID: 57850
		private Action<ServiceListItem> action_0;

		// Token: 0x0400E1FB RID: 57851
		[CompilerGenerated]
		private ServicesListView.ServiceInfo serviceInfo_0;
	}
}
