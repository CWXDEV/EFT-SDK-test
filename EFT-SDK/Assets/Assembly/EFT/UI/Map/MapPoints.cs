using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.Interactive;
using UnityEngine;

namespace EFT.UI.Map
{
	// Token: 0x02002F10 RID: 12048
	public class MapPoints : ScriptableObject
	{
		// Token: 0x0600EDD8 RID: 60888 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static MapPoints Load(string locationId)
		{
			throw null;
		}

		// Token: 0x0600EDD9 RID: 60889 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FillEligablePoints(ExfiltrationPoint point, string locationId)
		{
			throw null;
		}

		// Token: 0x0400F304 RID: 62212
		public List<EntryPoint> EntryPoints;

		// Token: 0x0400F305 RID: 62213
		public List<ExtractionPoint> ExtractionPoints;

		// Token: 0x0400F306 RID: 62214
		private const string string_0 = "MapPointConfigs/";

		// Token: 0x0400F307 RID: 62215
		private static readonly Dictionary<string, MapPoints> dictionary_0;

		// Token: 0x02002F11 RID: 12049
		[CompilerGenerated]
		private sealed class Class2973
		{
			// Token: 0x0600EDDA RID: 60890 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(EntryPoint x)
			{
				throw null;
			}

			// Token: 0x0400F308 RID: 62216
			public ExfiltrationPoint point;
		}

		// Token: 0x02002F12 RID: 12050
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2974
		{
			// Token: 0x0600EDDB RID: 60891 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(EntryPoint x)
			{
				throw null;
			}

			// Token: 0x0400F309 RID: 62217
			public static readonly MapPoints.Class2974 class2974_0;

			// Token: 0x0400F30A RID: 62218
			public static Func<EntryPoint, string> func_0;
		}
	}
}
