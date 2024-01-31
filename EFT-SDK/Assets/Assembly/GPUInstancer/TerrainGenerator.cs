using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace GPUInstancer
{
	// Token: 0x02000E4B RID: 3659
	public class TerrainGenerator : MonoBehaviour
	{
		// Token: 0x06004C6D RID: 19565 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Start()
		{
			throw null;
		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddTerrain()
		{
			throw null;
		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveTerrain()
		{
			throw null;
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Terrain terrain)
		{
			throw null;
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReInitializeManagers()
		{
			throw null;
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateDetailSettings()
		{
			throw null;
		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowHelpDescription(Text itemTitle)
		{
			throw null;
		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void HideHelpDescription()
		{
			throw null;
		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004C7A RID: 19578 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x06004C7B RID: 19579 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Terrain method_6(Vector3 position, int terrainSize, float terrainHeight, int baseTextureResolution = 16, int detailResolutionPerPatch = 16, SplatPrototype[] splatPrototypes = null, DetailPrototype[] detailPrototypes = null)
		{
			throw null;
		}

		// Token: 0x06004C7C RID: 19580 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TerrainData method_7(int terrainSize, float terrainHeight, int baseTextureResolution = 16, int detailResolutionPerPatch = 16, SplatPrototype[] splatPrototypes = null, DetailPrototype[] detailPrototypes = null)
		{
			throw null;
		}

		// Token: 0x06004C7D RID: 19581 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TerrainLayer[] method_8(SplatPrototype[] splatPrototypes)
		{
			throw null;
		}

		// Token: 0x06004C7E RID: 19582 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9(Terrain terrain)
		{
			throw null;
		}

		// Token: 0x0400575F RID: 22367
		public Texture2D groundTexture;

		// Token: 0x04005760 RID: 22368
		public Texture2D detailTexture;

		// Token: 0x04005761 RID: 22369
		public GameObject FpsController;

		// Token: 0x04005762 RID: 22370
		public GameObject FixedCamera;

		// Token: 0x04005763 RID: 22371
		private int int_0;

		// Token: 0x04005764 RID: 22372
		private int int_1;

		// Token: 0x04005765 RID: 22373
		private Vector3 vector3_0;

		// Token: 0x04005766 RID: 22374
		private Vector3 vector3_1;

		// Token: 0x04005767 RID: 22375
		private Terrain[] terrain_0;

		// Token: 0x04005768 RID: 22376
		private bool bool_0;

		// Token: 0x04005769 RID: 22377
		private Color color_0;

		// Token: 0x0400576A RID: 22378
		private Color color_1;

		// Token: 0x0400576B RID: 22379
		private float float_0;

		// Token: 0x0400576C RID: 22380
		private float float_1;

		// Token: 0x0400576D RID: 22381
		private float float_2;

		// Token: 0x0400576E RID: 22382
		private float float_3;

		// Token: 0x0400576F RID: 22383
		private bool bool_1;

		// Token: 0x04005770 RID: 22384
		private float float_4;

		// Token: 0x04005771 RID: 22385
		private float float_5;

		// Token: 0x04005772 RID: 22386
		private float float_6;

		// Token: 0x04005773 RID: 22387
		private Color color_2;

		// Token: 0x04005774 RID: 22388
		private bool bool_2;

		// Token: 0x04005775 RID: 22389
		private bool bool_3;

		// Token: 0x04005776 RID: 22390
		private int int_2;

		// Token: 0x04005777 RID: 22391
		private float float_7;

		// Token: 0x04005778 RID: 22392
		private Vector4 vector4_0;

		// Token: 0x04005779 RID: 22393
		private bool bool_4;

		// Token: 0x0400577A RID: 22394
		private bool bool_5;

		// Token: 0x0400577B RID: 22395
		private float float_8;

		// Token: 0x0400577C RID: 22396
		private float float_9;

		// Token: 0x0400577D RID: 22397
		private Image image_0;

		// Token: 0x0400577E RID: 22398
		private Image image_1;

		// Token: 0x0400577F RID: 22399
		private Slider slider_0;

		// Token: 0x04005780 RID: 22400
		private Slider slider_1;

		// Token: 0x04005781 RID: 22401
		private Slider slider_2;

		// Token: 0x04005782 RID: 22402
		private Slider slider_3;

		// Token: 0x04005783 RID: 22403
		private Toggle toggle_0;

		// Token: 0x04005784 RID: 22404
		private Slider slider_4;

		// Token: 0x04005785 RID: 22405
		private Slider slider_5;

		// Token: 0x04005786 RID: 22406
		private Slider slider_6;

		// Token: 0x04005787 RID: 22407
		private Image image_2;

		// Token: 0x04005788 RID: 22408
		private Toggle toggle_1;

		// Token: 0x04005789 RID: 22409
		private Toggle toggle_2;

		// Token: 0x0400578A RID: 22410
		private Slider slider_7;

		// Token: 0x0400578B RID: 22411
		private Slider slider_8;

		// Token: 0x0400578C RID: 22412
		private InputField inputField_0;

		// Token: 0x0400578D RID: 22413
		private InputField inputField_1;

		// Token: 0x0400578E RID: 22414
		private InputField inputField_2;

		// Token: 0x0400578F RID: 22415
		private InputField inputField_3;

		// Token: 0x04005790 RID: 22416
		private Toggle toggle_3;

		// Token: 0x04005791 RID: 22417
		private Toggle toggle_4;

		// Token: 0x04005792 RID: 22418
		private Slider slider_9;

		// Token: 0x04005793 RID: 22419
		private Slider slider_10;

		// Token: 0x04005794 RID: 22420
		private Text text_0;

		// Token: 0x04005795 RID: 22421
		private Text text_1;

		// Token: 0x04005796 RID: 22422
		private Selectable selectable_0;

		// Token: 0x04005797 RID: 22423
		private Selectable selectable_1;

		// Token: 0x04005798 RID: 22424
		private Canvas canvas_0;

		// Token: 0x04005799 RID: 22425
		public static readonly string HELPTEXT_detailHealthyColor;

		// Token: 0x0400579A RID: 22426
		public static readonly string HELPTEXT_detailDryColor;

		// Token: 0x0400579B RID: 22427
		public static readonly string HELPTEXT_noiseSpread;

		// Token: 0x0400579C RID: 22428
		public static readonly string HELPTEXT_ambientOcclusion;

		// Token: 0x0400579D RID: 22429
		public static readonly string HELPTEXT_gradientPower;

		// Token: 0x0400579E RID: 22430
		public static readonly string HELPTEXT_windIdleSway;

		// Token: 0x0400579F RID: 22431
		public static readonly string HELPTEXT_windWavesOn;

		// Token: 0x040057A0 RID: 22432
		public static readonly string HELPTEXT_windWaveTintColor;

		// Token: 0x040057A1 RID: 22433
		public static readonly string HELPTEXT_windWaveSize;

		// Token: 0x040057A2 RID: 22434
		public static readonly string HELPTEXT_windWaveSway;

		// Token: 0x040057A3 RID: 22435
		public static readonly string HELPTEXT_windWaveTint;

		// Token: 0x040057A4 RID: 22436
		public static readonly string HELPTEXT_isBillboard;

		// Token: 0x040057A5 RID: 22437
		public static readonly string HELPTEXT_crossQuads;

		// Token: 0x040057A6 RID: 22438
		public static readonly string HELPTEXT_quadCount;

		// Token: 0x040057A7 RID: 22439
		public static readonly string HELPTEXT_billboardDistance;

		// Token: 0x040057A8 RID: 22440
		public static readonly string HELPTEXT_detailScale;

		// Token: 0x040057A9 RID: 22441
		public static readonly string HELPTEXT_isShadowCasting;

		// Token: 0x040057AA RID: 22442
		public static readonly string HELPTEXT_isFrustumCulling;

		// Token: 0x040057AB RID: 22443
		public static readonly string HELPTEXT_frustumOffset;

		// Token: 0x040057AC RID: 22444
		public static readonly string HELPTEXT_maxDetailDistance;

		// Token: 0x040057AD RID: 22445
		public static readonly string HELPTEXT_windVector;
	}
}
