using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B21 RID: 2849
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Image Effects/SunOnGlass")]
public class SunOnGlass : MonoBehaviour
{
	// Token: 0x17000A01 RID: 2561
	// (set) Token: 0x06003DCD RID: 15821 RVA: 0x00002050 File Offset: 0x00000250
	public int Settings
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Start()
	{
		throw null;
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06003DD0 RID: 15824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_0()
	{
		throw null;
	}

	// Token: 0x06003DD1 RID: 15825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Material method_1()
	{
		throw null;
	}

	// Token: 0x06003DD2 RID: 15826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnApplicationQuit()
	{
		throw null;
	}

	// Token: 0x06003DD5 RID: 15829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(RenderTexture source, RenderTexture destination, Vector4 sunPos)
	{
		throw null;
	}

	// Token: 0x06003DD6 RID: 15830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Color smethod_0(Color color)
	{
		throw null;
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(Vector3 lightDirection, out Vector2 onScreen)
	{
		throw null;
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_4(Vector2 lightPos)
	{
		throw null;
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D GetTexFromCurve(AnimationCurve curve, int width = 255)
	{
		throw null;
	}

	// Token: 0x0400444A RID: 17482
	public float Size;

	// Token: 0x0400444B RID: 17483
	public Transform Sun;

	// Token: 0x0400444C RID: 17484
	public Texture ScreenTexture;

	// Token: 0x0400444D RID: 17485
	public Shader ScreenShader;

	// Token: 0x0400444E RID: 17486
	public Shader VisibilityCheckerShader;

	// Token: 0x0400444F RID: 17487
	public CustomLensFlare LensFlares;

	// Token: 0x04004450 RID: 17488
	public SunOnGlass.SunBack SunBackGround;

	// Token: 0x04004451 RID: 17489
	public Color SunColor;

	// Token: 0x04004452 RID: 17490
	public AnimationCurve SunCurve;

	// Token: 0x04004453 RID: 17491
	private bool bool_0;

	// Token: 0x04004454 RID: 17492
	private bool bool_1;

	// Token: 0x04004455 RID: 17493
	private bool bool_2;

	// Token: 0x04004456 RID: 17494
	private Texture texture_0;

	// Token: 0x04004457 RID: 17495
	private Material material_0;

	// Token: 0x04004458 RID: 17496
	private Material material_1;

	// Token: 0x04004459 RID: 17497
	private Camera camera_0;

	// Token: 0x0400445A RID: 17498
	private Transform transform_0;

	// Token: 0x0400445B RID: 17499
	private Texture2D texture2D_0;

	// Token: 0x0400445C RID: 17500
	private RenderTexture renderTexture_0;

	// Token: 0x0400445D RID: 17501
	private RenderTexture renderTexture_1;

	// Token: 0x0400445E RID: 17502
	private Rect rect_0;

	// Token: 0x0400445F RID: 17503
	private static readonly int int_0;

	// Token: 0x04004460 RID: 17504
	private static readonly int int_1;

	// Token: 0x04004461 RID: 17505
	private static readonly int int_2;

	// Token: 0x04004462 RID: 17506
	private static readonly int int_3;

	// Token: 0x04004463 RID: 17507
	private static readonly int int_4;

	// Token: 0x02000B22 RID: 2850
	[Serializable]
	public class SunBack
	{
		// Token: 0x06003DDA RID: 15834 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Initialize(bool formEditor = false)
		{
			throw null;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdatePos(Vector3 camPos)
		{
			throw null;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform GetSun()
		{
			throw null;
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Transform CreatePolygon()
		{
			throw null;
		}

		// Token: 0x04004464 RID: 17508
		public Transform Light;

		// Token: 0x04004465 RID: 17509
		public Texture SunTexture;

		// Token: 0x04004466 RID: 17510
		public Color SunColor;

		// Token: 0x04004467 RID: 17511
		public float size;

		// Token: 0x04004468 RID: 17512
		public Transform _trans;

		// Token: 0x04004469 RID: 17513
		private Vector3 _position;
	}
}
