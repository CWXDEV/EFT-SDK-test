using System;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;

// Token: 0x02000B15 RID: 2837
[PreferBinarySerialization]
[CreateAssetMenu(fileName = "TextureArray", menuName = "Scriptable objects/TextureArray")]
public class TexArraySO : ScriptableObject
{
	// Token: 0x06003D92 RID: 15762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Texture2DArray textureArray, Texture2D[] textures)
	{
		throw null;
	}

	// Token: 0x06003D93 RID: 15763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color32[] smethod_1(Texture2D texture, int width, int height)
	{
		throw null;
	}

	// Token: 0x06003D94 RID: 15764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(Texture2D[] textures, ref string errorMessage, ref InfoMessageType? messageType)
	{
		throw null;
	}

	// Token: 0x06003D95 RID: 15765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_1(Texture2D[] textures, ref string errorMessage, ref InfoMessageType? messageType)
	{
		throw null;
	}

	// Token: 0x040043EE RID: 17390
	[Delayed]
	[SerializeField]
	private int _width;

	// Token: 0x040043EF RID: 17391
	[Delayed]
	[SerializeField]
	private int _height;

	// Token: 0x040043F0 RID: 17392
	[SerializeField]
	private TextureFormat _format;

	// Token: 0x040043F1 RID: 17393
	[SerializeField]
	private bool _mips;

	// Token: 0x040043F2 RID: 17394
	[SerializeField]
	private Texture2D[] _textures;

	// Token: 0x040043F3 RID: 17395
	[HideInInspector]
	[SerializeField]
	private Texture2DArray _textureArray;

	// Token: 0x040043F4 RID: 17396
	[SerializeField]
	[HideInInspector]
	private bool _hadMips;
}
