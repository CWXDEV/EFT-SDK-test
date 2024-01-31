using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AmplifyMotion;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

// Token: 0x0200005A RID: 90
[RequireComponent(typeof(Camera))]
[AddComponentMenu("")]
public class AmplifyMotionEffectBase : MonoBehaviour
{
	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600023F RID: 575 RVA: 0x00002050 File Offset: 0x00000250
	[Obsolete("workerThreads is deprecated, please use WorkerThreads instead.")]
	public int workerThreads
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			throw null;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
	internal Material Material_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
	internal Material Material_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
	internal Material Material_2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
	internal Material Material_3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
	internal RenderTexture RenderTexture_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
	public Dictionary<Camera, AmplifyMotionCamera> LinkedCameras
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
	internal float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
	internal float Single_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
	public AmplifyMotionCamera BaseCamera
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
	internal Class3217 Class3217_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
	public static bool IsD3D
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
	public bool CanUseGPU
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600024C RID: 588 RVA: 0x00002050 File Offset: 0x00000250
	public static bool IgnoreMotionScaleWarning
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
	public static AmplifyMotionEffectBase FirstInstance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
	public static AmplifyMotionEffectBase Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06000250 RID: 592 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0()
	{
		throw null;
	}

	// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal int method_1(GameObject obj)
	{
		throw null;
	}

	// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(ref Material mat)
	{
		throw null;
	}

	// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_3(Material material, string name)
	{
		throw null;
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_5()
	{
		throw null;
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private RenderTexture method_6(string name, int depth, RenderTextureFormat fmt, RenderTextureReadWrite rw, FilterMode fm)
	{
		throw null;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(ref RenderTexture rt)
	{
		throw null;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(ref Texture tex)
	{
		throw null;
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10(bool qualityChanged)
	{
		throw null;
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool CheckSupport()
	{
		throw null;
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13()
	{
		throw null;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_15(Camera reference)
	{
		throw null;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GameObject method_16(GameObject obj, string auxCameraName)
	{
		throw null;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_17()
	{
		throw null;
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateActiveCameras()
	{
		throw null;
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_0(AmplifyMotionCamera cam)
	{
		throw null;
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_1(AmplifyMotionCamera cam)
	{
		throw null;
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateActiveObjects()
	{
		throw null;
	}

	// Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_2(AmplifyMotionObjectBase obj)
	{
		throw null;
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_3(AmplifyMotionObjectBase obj)
	{
		throw null;
	}

	// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_4(Material[] materials)
	{
		throw null;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool smethod_5(GameObject gameObj, bool autoReg)
	{
		throw null;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_6(GameObject gameObj, bool autoReg)
	{
		throw null;
	}

	// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void smethod_7(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000271 RID: 625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Register(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000272 RID: 626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterS(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000273 RID: 627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterRecursively(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterRecursivelyS(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unregister(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterS(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UnregisterRecursively(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnregisterRecursivelyS(GameObject gameObj)
	{
		throw null;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_18()
	{
		throw null;
	}

	// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StopAutoStep()
	{
		throw null;
	}

	// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void StartAutoStep()
	{
		throw null;
	}

	// Token: 0x0600027D RID: 637 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Step(float delta)
	{
		throw null;
	}

	// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_19()
	{
		throw null;
	}

	// Token: 0x0600027F RID: 639 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void FixedUpdate()
	{
		throw null;
	}

	// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPreRender()
	{
		throw null;
	}

	// Token: 0x06000281 RID: 641 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnPostRender()
	{
		throw null;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_20(RenderTexture source, RenderTexture destination, Vector4 blurStep)
	{
		throw null;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PostProcess(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x040000F4 RID: 244
	[Header("Motion Blur")]
	public Quality QualityLevel;

	// Token: 0x040000F5 RID: 245
	public int QualitySteps;

	// Token: 0x040000F6 RID: 246
	public float MotionScale;

	// Token: 0x040000F7 RID: 247
	public float CameraMotionMult;

	// Token: 0x040000F8 RID: 248
	public float MinVelocity;

	// Token: 0x040000F9 RID: 249
	public float MaxVelocity;

	// Token: 0x040000FA RID: 250
	public float DepthThreshold;

	// Token: 0x040000FB RID: 251
	public bool Noise;

	// Token: 0x040000FC RID: 252
	[Header("Camera")]
	public Camera[] OverlayCameras;

	// Token: 0x040000FD RID: 253
	public LayerMask CullingMask;

	// Token: 0x040000FE RID: 254
	[Header("Objects")]
	public bool AutoRegisterObjs;

	// Token: 0x040000FF RID: 255
	public float MinResetDeltaDist;

	// Token: 0x04000100 RID: 256
	[NonSerialized]
	public float MinResetDeltaDistSqr;

	// Token: 0x04000101 RID: 257
	public int ResetFrameDelay;

	// Token: 0x04000102 RID: 258
	[FormerlySerializedAs("workerThreads")]
	[Header("Low-Level")]
	public int WorkerThreads;

	// Token: 0x04000103 RID: 259
	public bool SystemThreadPool;

	// Token: 0x04000104 RID: 260
	public bool ForceCPUOnly;

	// Token: 0x04000105 RID: 261
	public bool DebugMode;

	// Token: 0x04000106 RID: 262
	private Camera camera_0;

	// Token: 0x04000107 RID: 263
	private bool bool_0;

	// Token: 0x04000108 RID: 264
	private int int_0;

	// Token: 0x04000109 RID: 265
	private int int_1;

	// Token: 0x0400010A RID: 266
	private RenderTexture renderTexture_0;

	// Token: 0x0400010B RID: 267
	private Material material_0;

	// Token: 0x0400010C RID: 268
	private Material material_1;

	// Token: 0x0400010D RID: 269
	private Material material_2;

	// Token: 0x0400010E RID: 270
	private Material material_3;

	// Token: 0x0400010F RID: 271
	private Material material_4;

	// Token: 0x04000110 RID: 272
	private Material material_5;

	// Token: 0x04000111 RID: 273
	private Material material_6;

	// Token: 0x04000112 RID: 274
	private Material material_7;

	// Token: 0x04000113 RID: 275
	private Material material_8;

	// Token: 0x04000114 RID: 276
	private Dictionary<Camera, AmplifyMotionCamera> dictionary_0;

	// Token: 0x04000115 RID: 277
	internal Camera[] camera_1;

	// Token: 0x04000116 RID: 278
	internal AmplifyMotionCamera[] amplifyMotionCamera_0;

	// Token: 0x04000117 RID: 279
	internal bool bool_1;

	// Token: 0x04000118 RID: 280
	private AmplifyMotionPostProcess amplifyMotionPostProcess_0;

	// Token: 0x04000119 RID: 281
	private int int_2;

	// Token: 0x0400011A RID: 282
	private float float_0;

	// Token: 0x0400011B RID: 283
	private float float_1;

	// Token: 0x0400011C RID: 284
	private float float_2;

	// Token: 0x0400011D RID: 285
	private float float_3;

	// Token: 0x0400011E RID: 286
	private Quality quality_0;

	// Token: 0x0400011F RID: 287
	private AmplifyMotionCamera amplifyMotionCamera_1;

	// Token: 0x04000120 RID: 288
	private Class3217 class3217_0;

	// Token: 0x04000121 RID: 289
	public static Dictionary<GameObject, AmplifyMotionObjectBase> m_activeObjects;

	// Token: 0x04000122 RID: 290
	public static Dictionary<Camera, AmplifyMotionCamera> m_activeCameras;

	// Token: 0x04000123 RID: 291
	private static bool bool_2;

	// Token: 0x04000124 RID: 292
	private bool bool_3;

	// Token: 0x04000125 RID: 293
	private const CameraEvent cameraEvent_0 = CameraEvent.BeforeImageEffectsOpaque;

	// Token: 0x04000126 RID: 294
	private CommandBuffer commandBuffer_0;

	// Token: 0x04000127 RID: 295
	private const CameraEvent cameraEvent_1 = CameraEvent.BeforeImageEffectsOpaque;

	// Token: 0x04000128 RID: 296
	private CommandBuffer commandBuffer_1;

	// Token: 0x04000129 RID: 297
	private static bool bool_4;

	// Token: 0x0400012A RID: 298
	private static AmplifyMotionEffectBase amplifyMotionEffectBase_0;
}
