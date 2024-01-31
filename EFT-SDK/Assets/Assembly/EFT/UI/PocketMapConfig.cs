using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.UI
{
	// Token: 0x02002B34 RID: 11060
	[CreateAssetMenu(fileName = "New PocketMapConfig", menuName = "Scriptable objects/PocketMapConfig")]
	public class PocketMapConfig : ScriptableObject
	{
		// Token: 0x0600DB2C RID: 56108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Texture GetTexture(int x, int y, int scale)
		{
			throw null;
		}

		// Token: 0x0600DB2D RID: 56109 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConvertTexturesToTiles()
		{
			throw null;
		}

		// Token: 0x0400DEAE RID: 57006
		public int ScalePreset;

		// Token: 0x0400DEAF RID: 57007
		public Texture[] Textures;

		// Token: 0x0400DEB0 RID: 57008
		public PocketMapConfig.TileInfo[] Tiles;

		// Token: 0x02002B35 RID: 11061
		[Serializable]
		public struct TileInfo
		{
			// Token: 0x0400DEB1 RID: 57009
			public Texture Tile;

			// Token: 0x0400DEB2 RID: 57010
			public int X;

			// Token: 0x0400DEB3 RID: 57011
			public int Y;

			// Token: 0x0400DEB4 RID: 57012
			public int Scale;
		}
	}
}
