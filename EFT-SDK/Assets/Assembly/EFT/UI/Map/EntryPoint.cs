using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI.Map
{
	// Token: 0x02002F0E RID: 12046
	[Serializable]
	public class EntryPoint
	{
		// Token: 0x14000350 RID: 848
		// (add) Token: 0x0600EDD5 RID: 60885 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600EDD6 RID: 60886 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EntryPoint> OnDisable
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600EDD7 RID: 60887 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x0400F2F5 RID: 62197
		[NonSerialized]
		public int Index;

		// Token: 0x0400F2F6 RID: 62198
		public string Name;

		// Token: 0x0400F2F7 RID: 62199
		public Vector2 PositionOnMap;

		// Token: 0x0400F2F8 RID: 62200
		public bool IsActive;

		// Token: 0x0400F2F9 RID: 62201
		public bool Locked;

		// Token: 0x0400F2FA RID: 62202
		public string[] OpenExtractionPoints;

		// Token: 0x0400F2FB RID: 62203
		public bool ShowRadius;

		// Token: 0x0400F2FC RID: 62204
		public float Radius;

		// Token: 0x0400F2FD RID: 62205
		public Color32 MainColor;
	}
}
