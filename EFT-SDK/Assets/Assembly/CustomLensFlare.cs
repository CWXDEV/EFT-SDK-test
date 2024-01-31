using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B1F RID: 2847
[Serializable]
public class CustomLensFlare
{
	// Token: 0x06003DC9 RID: 15817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Initialize()
	{
		throw null;
	}

	// Token: 0x06003DCA RID: 15818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Draw(Vector2 positionOnScreen)
	{
		throw null;
	}

	// Token: 0x0400443B RID: 17467
	public Material FlareMaterial;

	// Token: 0x0400443C RID: 17468
	public int GridSize;

	// Token: 0x0400443D RID: 17469
	public CustomLensFlare.Element[] Elements;

	// Token: 0x0400443E RID: 17470
	private Vector2 _center;

	// Token: 0x02000B20 RID: 2848
	[Serializable]
	public class Element
	{
		// Token: 0x06003DCB RID: 15819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Calc(Vector2 texScale, float screenAspect)
		{
			throw null;
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw(Vector2 pos, float distance, float alpha)
		{
			throw null;
		}

		// Token: 0x0400443F RID: 17471
		public float Position;

		// Token: 0x04004440 RID: 17472
		public float Size;

		// Token: 0x04004441 RID: 17473
		public float Rotation;

		// Token: 0x04004442 RID: 17474
		public Color Color;

		// Token: 0x04004443 RID: 17475
		public int X;

		// Token: 0x04004444 RID: 17476
		public int Y;

		// Token: 0x04004445 RID: 17477
		public int Width;

		// Token: 0x04004446 RID: 17478
		public int Heigth;

		// Token: 0x04004447 RID: 17479
		private Vector3[] _texCoords;

		// Token: 0x04004448 RID: 17480
		private Vector2 _halfSize;

		// Token: 0x04004449 RID: 17481
		private float _screenAspect;
	}
}
