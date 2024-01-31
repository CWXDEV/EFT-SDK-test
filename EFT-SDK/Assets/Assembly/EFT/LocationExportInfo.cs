using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x020014B7 RID: 5303
	public sealed class LocationExportInfo : MonoBehaviour
	{
		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060071BF RID: 29119 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060071C0 RID: 29120 RVA: 0x00002050 File Offset: 0x00000250
		public DateTime DateTime
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

		// Token: 0x04007859 RID: 30809
		[SerializeField]
		public long _unixDateTime;
	}
}
