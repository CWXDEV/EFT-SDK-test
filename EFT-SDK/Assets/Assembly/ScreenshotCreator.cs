using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BED RID: 3053
[ExecuteInEditMode]
public class ScreenshotCreator : MonoBehaviour
{
	// Token: 0x06004272 RID: 17010 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Create()
	{
		throw null;
	}

	// Token: 0x06004273 RID: 17011 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RequestDelete(int id)
	{
		throw null;
	}

	// Token: 0x06004274 RID: 17012 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Delete(int id)
	{
		throw null;
	}

	// Token: 0x06004275 RID: 17013 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06004276 RID: 17014 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void LateUpdate()
	{
		throw null;
	}

	// Token: 0x06004277 RID: 17015 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0(int id)
	{
		throw null;
	}

	// Token: 0x06004278 RID: 17016 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private string method_1()
	{
		throw null;
	}

	// Token: 0x06004279 RID: 17017 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600427A RID: 17018 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600427B RID: 17019 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnGUI()
	{
		throw null;
	}

	// Token: 0x0600427C RID: 17020 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CaptureCutoutVoid(int id)
	{
		throw null;
	}

	// Token: 0x0600427D RID: 17021 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerator CaptureCutout(int id)
	{
		throw null;
	}

	// Token: 0x0600427E RID: 17022 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x0600427F RID: 17023 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CaptureScreenshots(int id, bool fallback)
	{
		throw null;
	}

	// Token: 0x06004280 RID: 17024 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CaptureRenderTexture(Camera attachedCam, int id)
	{
		throw null;
	}

	// Token: 0x06004281 RID: 17025 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getFileName(int camID)
	{
		throw null;
	}

	// Token: 0x06004282 RID: 17026 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public string getResolution()
	{
		throw null;
	}

	// Token: 0x04004B8E RID: 19342
	[HideInInspector]
	public Color signatureColor;

	// Token: 0x04004B8F RID: 19343
	public List<ScreenshotCreator.CameraObject> list;

	// Token: 0x04004B90 RID: 19344
	[HideInInspector]
	public bool foldoutSettings;

	// Token: 0x04004B91 RID: 19345
	[Tooltip("The name of your screenshot or screenshot session. Camera name and current date will be added automatically.")]
	public string customName;

	// Token: 0x04004B92 RID: 19346
	public string customDirectory;

	// Token: 0x04004B93 RID: 19347
	[HideInInspector]
	public int lastCamID;

	// Token: 0x04004B94 RID: 19348
	[HideInInspector]
	public Camera lastCam;

	// Token: 0x04004B95 RID: 19349
	public bool includeCamName;

	// Token: 0x04004B96 RID: 19350
	public bool includeDate;

	// Token: 0x04004B97 RID: 19351
	public bool includeResolution;

	// Token: 0x04004B98 RID: 19352
	public ScreenshotCreator.FileType fileType;

	// Token: 0x04004B99 RID: 19353
	public ScreenshotCreator.CaptureMethod captureMethod;

	// Token: 0x04004B9A RID: 19354
	public bool singleCamera;

	// Token: 0x04004B9B RID: 19355
	public float renderSizeMultiplier;

	// Token: 0x04004B9C RID: 19356
	public int captureSizeMultiplier;

	// Token: 0x04004B9D RID: 19357
	public Vector2 cutoutPosition;

	// Token: 0x04004B9E RID: 19358
	public Vector2 cutoutSize;

	// Token: 0x04004B9F RID: 19359
	private GUIStyle guistyle_0;

	// Token: 0x04004BA0 RID: 19360
	public bool applicationPath;

	// Token: 0x04004BA1 RID: 19361
	private Vector2 vector2_0;

	// Token: 0x04004BA2 RID: 19362
	private Vector2 vector2_1;

	// Token: 0x04004BA3 RID: 19363
	private float float_0;

	// Token: 0x02000BEE RID: 3054
	[Serializable]
	public class CameraObject
	{
		// Token: 0x04004BA4 RID: 19364
		public GameObject cam;

		// Token: 0x04004BA5 RID: 19365
		public bool deleteQuestion;

		// Token: 0x04004BA6 RID: 19366
		public ScreenshotCreator.CameraObject.Hotkey hotkey;

		// Token: 0x02000BEF RID: 3055
		public enum Hotkey
		{
			// Token: 0x04004BA8 RID: 19368
			Hotkey,
			// Token: 0x04004BA9 RID: 19369
			A,
			// Token: 0x04004BAA RID: 19370
			B,
			// Token: 0x04004BAB RID: 19371
			C,
			// Token: 0x04004BAC RID: 19372
			D,
			// Token: 0x04004BAD RID: 19373
			E,
			// Token: 0x04004BAE RID: 19374
			F,
			// Token: 0x04004BAF RID: 19375
			G,
			// Token: 0x04004BB0 RID: 19376
			H,
			// Token: 0x04004BB1 RID: 19377
			I,
			// Token: 0x04004BB2 RID: 19378
			J,
			// Token: 0x04004BB3 RID: 19379
			K,
			// Token: 0x04004BB4 RID: 19380
			L,
			// Token: 0x04004BB5 RID: 19381
			M,
			// Token: 0x04004BB6 RID: 19382
			N,
			// Token: 0x04004BB7 RID: 19383
			O,
			// Token: 0x04004BB8 RID: 19384
			P,
			// Token: 0x04004BB9 RID: 19385
			Q,
			// Token: 0x04004BBA RID: 19386
			R,
			// Token: 0x04004BBB RID: 19387
			S,
			// Token: 0x04004BBC RID: 19388
			T,
			// Token: 0x04004BBD RID: 19389
			U,
			// Token: 0x04004BBE RID: 19390
			V,
			// Token: 0x04004BBF RID: 19391
			W,
			// Token: 0x04004BC0 RID: 19392
			X,
			// Token: 0x04004BC1 RID: 19393
			Y,
			// Token: 0x04004BC2 RID: 19394
			Z
		}
	}

	// Token: 0x02000BF0 RID: 3056
	public enum FileType
	{
		// Token: 0x04004BC4 RID: 19396
		PNG,
		// Token: 0x04004BC5 RID: 19397
		JPG
	}

	// Token: 0x02000BF1 RID: 3057
	public enum CaptureMethod
	{
		// Token: 0x04004BC7 RID: 19399
		CaptureScreenshot,
		// Token: 0x04004BC8 RID: 19400
		RenderTexture,
		// Token: 0x04004BC9 RID: 19401
		Cutout
	}
}
