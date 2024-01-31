using System;
using UnityEngine;

namespace EFT.UI.Map
{
	// Token: 0x02002F0F RID: 12047
	[Serializable]
	public class ExtractionPoint
	{
		// Token: 0x0400F2FF RID: 62207
		public string Name;

		// Token: 0x0400F300 RID: 62208
		public bool NotGuaranteed;

		// Token: 0x0400F301 RID: 62209
		public Vector2 PositionOnMap;

		// Token: 0x0400F302 RID: 62210
		public bool ShowRadius;

		// Token: 0x0400F303 RID: 62211
		public float Radius;
	}
}
