using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000BCD RID: 3021
[ExecuteInEditMode]
public class EditorScreenshoter : MonoBehaviour
{
	// Token: 0x060041E3 RID: 16867 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture2D MakeScreenshot(Camera camera, int width, int height)
	{
		throw null;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MakeScreenshotAndSave()
	{
		throw null;
	}

	// Token: 0x04004AD2 RID: 19154
	[SerializeField]
	private Camera _camera;

	// Token: 0x04004AD3 RID: 19155
	[SerializeField]
	private Vector2 _textureDimensions;

	// Token: 0x04004AD4 RID: 19156
	[SerializeField]
	private Texture2D _screenshot;

	// Token: 0x04004AD5 RID: 19157
	public const string ScreenshotsDirectory = "/EFT_Screenshots/";
}
