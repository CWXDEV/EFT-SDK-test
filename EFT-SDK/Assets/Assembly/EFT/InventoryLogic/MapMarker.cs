using System;
using System.Runtime.CompilerServices;

namespace EFT.InventoryLogic
{
	// Token: 0x02002297 RID: 8855
	[Serializable]
	public class MapMarker : ICloneable
	{
		// Token: 0x0600B420 RID: 46112 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CopyFieldsFrom(MapMarker marker)
		{
			throw null;
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x0400B841 RID: 47169
		public MapMarkerType Type;

		// Token: 0x0400B842 RID: 47170
		public int X;

		// Token: 0x0400B843 RID: 47171
		public int Y;

		// Token: 0x0400B844 RID: 47172
		public string Note;

		// Token: 0x0400B845 RID: 47173
		[NonSerialized]
		public const int CHARACTER_LIMIT = 75;
	}
}
