using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Sirenix.OdinInspector;
using UnityEngine;

namespace EFT.Hideout
{
	// Token: 0x02001B8E RID: 7054
	public sealed class HideoutAreasInfo : SerializedScriptableObject
	{
		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x0600945E RID: 37982 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<AreaTemplate> Templates
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Load()
		{
			throw null;
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<HideoutAreasInfo> LoadAsync()
		{
			throw null;
		}

		// Token: 0x04009B36 RID: 39734
		[SerializeField]
		private Dictionary<EAreaType, AreaTemplate> _areas;
	}
}
