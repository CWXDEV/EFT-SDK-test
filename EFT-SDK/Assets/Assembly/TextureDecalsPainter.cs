using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000A64 RID: 2660
public class TextureDecalsPainter : MonoBehaviour
{
	// Token: 0x06003A83 RID: 14979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private RenderTexture method_0()
	{
		throw null;
	}

	// Token: 0x06003A85 RID: 14981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1(RenderTexture rendererDecalTex)
	{
		throw null;
	}

	// Token: 0x06003A86 RID: 14982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003A87 RID: 14983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawDecal(Renderer objRenderer)
	{
		throw null;
	}

	// Token: 0x06003A88 RID: 14984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Vector3 point, Vector3 normal)
	{
		throw null;
	}

	// Token: 0x06003A89 RID: 14985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Texture2D method_3(EDecalTextureType type)
	{
		throw null;
	}

	// Token: 0x06003A8A RID: 14986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DrawDecal(List<GStruct53> renderers, Vector3 point, Vector3 normal)
	{
		throw null;
	}

	// Token: 0x06003A8B RID: 14987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Renderer objRenderer, Vector3 point, Vector3 normal, Texture2D texture, bool hasToSetShaderVars, bool hasToSetTexture)
	{
		throw null;
	}

	// Token: 0x06003A8C RID: 14988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5(Renderer objRenderer)
	{
		throw null;
	}

	// Token: 0x06003A8D RID: 14989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003A8E RID: 14990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Clear()
	{
		throw null;
	}

	// Token: 0x04003DCE RID: 15822
	[SerializeField]
	[Header("Render textures settings")]
	private PowOfTwoDimensions _renderTexDimension;

	// Token: 0x04003DCF RID: 15823
	[SerializeField]
	private DepthSize _renderTexDepthSize;

	// Token: 0x04003DD0 RID: 15824
	[Header("Shaders")]
	[SerializeField]
	private Shader _drawInterceptionShader;

	// Token: 0x04003DD1 RID: 15825
	[SerializeField]
	private Shader _blitShader;

	// Token: 0x04003DD2 RID: 15826
	[Header("Textures")]
	[SerializeField]
	private Texture2D _bloodDecalTexture;

	// Token: 0x04003DD3 RID: 15827
	[SerializeField]
	private Texture2D _vestDecalTexture;

	// Token: 0x04003DD4 RID: 15828
	[SerializeField]
	private Texture2D _backDecalTexture;

	// Token: 0x04003DD5 RID: 15829
	[SerializeField]
	[Header("Decal settings")]
	private float _projectorHeight;

	// Token: 0x04003DD6 RID: 15830
	private Vector2 _decalSize;

	// Token: 0x04003DD7 RID: 15831
	private Material material_0;

	// Token: 0x04003DD8 RID: 15832
	private Material material_1;

	// Token: 0x04003DD9 RID: 15833
	private RenderTexture renderTexture_0;

	// Token: 0x04003DDA RID: 15834
	private RenderTexture renderTexture_1;

	// Token: 0x04003DDB RID: 15835
	private CommandBuffer commandBuffer_0;

	// Token: 0x04003DDC RID: 15836
	private Dictionary<Renderer, RenderTexture> dictionary_0;

	// Token: 0x04003DDD RID: 15837
	private List<TextureDecalsPainter.GStruct59> list_0;

	// Token: 0x04003DDE RID: 15838
	private static readonly int int_0;

	// Token: 0x04003DDF RID: 15839
	private static int int_1;

	// Token: 0x04003DE0 RID: 15840
	private const int int_2 = 128;

	// Token: 0x04003DE1 RID: 15841
	private GClass737<RenderTexture> gclass737_0;

	// Token: 0x04003DE2 RID: 15842
	private static readonly int int_3;

	// Token: 0x04003DE3 RID: 15843
	private static readonly int int_4;

	// Token: 0x04003DE4 RID: 15844
	private static readonly int int_5;

	// Token: 0x04003DE5 RID: 15845
	private static readonly int int_6;

	// Token: 0x04003DE6 RID: 15846
	private static readonly int int_7;

	// Token: 0x04003DE7 RID: 15847
	private static readonly int int_8;

	// Token: 0x04003DE8 RID: 15848
	private static readonly int int_9;

	// Token: 0x04003DE9 RID: 15849
	private static readonly int int_10;

	// Token: 0x02000A65 RID: 2661
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct59
	{
		// Token: 0x04003DEA RID: 15850
		public Renderer Renderer;

		// Token: 0x04003DEB RID: 15851
		public Vector3 Point;

		// Token: 0x04003DEC RID: 15852
		public Vector3 Normal;

		// Token: 0x04003DED RID: 15853
		public Texture2D Texture;

		// Token: 0x04003DEE RID: 15854
		public bool HasToSetShaderVars;

		// Token: 0x04003DEF RID: 15855
		public bool HasToSetTexture;
	}
}
