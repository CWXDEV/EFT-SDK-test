using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B67 RID: 7015
	public sealed class AreaSubstrateSettings : SerializedScriptableObject
	{
		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x060093D0 RID: 37840 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EPanelType, GInterface171> Panels
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x060093D1 RID: 37841 RVA: 0x00002050 File Offset: 0x00000250
		public Dictionary<EAreaStatus, PanelVisibilitySettings> VisibilitySettings
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009A6E RID: 39534
		[SerializeField]
		private Dictionary<EPanelType, GInterface171> _areaRelatedPanels;

		// Token: 0x04009A6F RID: 39535
		[SerializeField]
		private Dictionary<EAreaStatus, PanelVisibilitySettings> _panelsVisibilitySettings;
	}
}
