using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001BA3 RID: 7075
	public sealed class AreaPanelSettings : SerializedScriptableObject
	{
		// Token: 0x170016C7 RID: 5831
		public Sprite this[EAreaStatus status]
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04009BA7 RID: 39847
		public Dictionary<EAreaStatus, Sprite> StatusAreaMap;
	}
}
