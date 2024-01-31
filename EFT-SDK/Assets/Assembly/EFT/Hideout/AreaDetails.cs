using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B98 RID: 7064
	public class AreaDetails : UIElement
	{
		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x0600949A RID: 38042 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600949B RID: 38043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(AreaData data)
		{
			throw null;
		}

		// Token: 0x0600949C RID: 38044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600949D RID: 38045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600949E RID: 38046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(GClass1925 datails, GStruct239 oldData)
		{
			throw null;
		}

		// Token: 0x0600949F RID: 38047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x060094A0 RID: 38048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x060094A1 RID: 38049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(GClass1925 detailsData)
		{
			throw null;
		}

		// Token: 0x060094A2 RID: 38050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6(DetailsPanel view, GClass1925 datails, GStruct239 oldData, bool force)
		{
			throw null;
		}

		// Token: 0x060094A3 RID: 38051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(GClass1926 group, GClass1925 detailsData, GStruct239 oldData, EDetailsChangeType changeType)
		{
			throw null;
		}

		// Token: 0x060094A4 RID: 38052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(DetailsPanel view, bool value)
		{
			throw null;
		}

		// Token: 0x060094A5 RID: 38053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(DetailsPanel detailsPanel, GClass1925 detailsData, GStruct239 oldData, bool force)
		{
			throw null;
		}

		// Token: 0x060094A6 RID: 38054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x04009B69 RID: 39785
		[SerializeField]
		private DetailsPanel _importantDetailsPanel;

		// Token: 0x04009B6A RID: 39786
		[SerializeField]
		private DetailsPanel _regularDetailsPanelTemplate;

		// Token: 0x04009B6B RID: 39787
		[SerializeField]
		private Transform _detailsContainer;

		// Token: 0x04009B6C RID: 39788
		[SerializeField]
		private Dictionary<EDetailsType, AreaDetails.DetailsDisplaySettings> _detailsSettings;

		// Token: 0x04009B6D RID: 39789
		private GClass1925 gclass1925_0;

		// Token: 0x04009B6E RID: 39790
		private GClass1926 gclass1926_0;

		// Token: 0x04009B6F RID: 39791
		private bool bool_0;

		// Token: 0x04009B70 RID: 39792
		private bool bool_1;

		// Token: 0x04009B71 RID: 39793
		private AreaData areaData_0;

		// Token: 0x04009B72 RID: 39794
		private Action action_0;

		// Token: 0x04009B73 RID: 39795
		private readonly Dictionary<GClass1925, DetailsPanel> dictionary_0;

		// Token: 0x02001B99 RID: 7065
		[Serializable]
		public class DetailsDisplaySettings
		{
			// Token: 0x04009B74 RID: 39796
			public Sprite Icon;

			// Token: 0x04009B75 RID: 39797
			public Color BackgroundColor;
		}
	}
}
