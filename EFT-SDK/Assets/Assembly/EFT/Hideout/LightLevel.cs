using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001AE3 RID: 6883
	public sealed class LightLevel : SerializedMonoBehaviour
	{
		// Token: 0x170015F1 RID: 5617
		// (set) Token: 0x060090CC RID: 37068 RVA: 0x00002050 File Offset: 0x00000250
		public bool Enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04009809 RID: 38921
		[SerializeField]
		private List<GInterface351> _lightSwitchers;
	}
}
