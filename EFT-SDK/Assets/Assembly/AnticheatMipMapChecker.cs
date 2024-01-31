using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A38 RID: 2616
public class AnticheatMipMapChecker : MonoBehaviour
{
	// Token: 0x06003969 RID: 14697 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600396A RID: 14698 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x0600396B RID: 14699 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x0600396C RID: 14700 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1()
	{
		throw null;
	}

	// Token: 0x0600396D RID: 14701 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(bool isMipMapCorrect)
	{
		throw null;
	}

	// Token: 0x0600396E RID: 14702 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_3()
	{
		throw null;
	}

	// Token: 0x0600396F RID: 14703 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x04003BEE RID: 15342
	public static AnticheatMipMapChecker Instance;

	// Token: 0x04003BEF RID: 15343
	[HideInInspector]
	public bool IsMipMapCorrect;

	// Token: 0x04003BF0 RID: 15344
	[SerializeField]
	private Shader _mipMapChecker;

	// Token: 0x04003BF1 RID: 15345
	[SerializeField]
	private AnticheatMipMapChecker.TextureChecker textureChecker;

	// Token: 0x04003BF2 RID: 15346
	private Material material_0;

	// Token: 0x04003BF3 RID: 15347
	private RenderTexture renderTexture_0;

	// Token: 0x04003BF4 RID: 15348
	private Texture2D texture2D_0;

	// Token: 0x04003BF5 RID: 15349
	private Material material_1;

	// Token: 0x04003BF6 RID: 15350
	private static readonly int int_0;

	// Token: 0x04003BF7 RID: 15351
	private static readonly int int_1;

	// Token: 0x02000A39 RID: 2617
	[Serializable]
	private class TextureChecker
	{
		// Token: 0x04003BF8 RID: 15352
		[SerializeField]
		public Texture2D CheckTexture;

		// Token: 0x04003BF9 RID: 15353
		[SerializeField]
		public float CheckValue;
	}
}
