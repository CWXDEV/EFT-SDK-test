using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;

namespace PlayerIcons
{
	// Token: 0x02000C79 RID: 3193
	[CreateAssetMenu(fileName = "PlayerIconCreatorSettings", menuName = "Scriptable objects/PlayerIconCreatorSettings")]
	public class PlayerIconCreatorSettings : ScriptableObject
	{
		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 LocalPosition
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x00002050 File Offset: 0x00000250
		public RenderingPath RenderingPath
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveLastRequest(GClass821 lastRequest)
		{
			throw null;
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task CheckForcePause(params GameObject[] objects)
		{
			throw null;
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryForceRenderLastIco(out GClass818 icon)
		{
			throw null;
		}

		// Token: 0x04004F79 RID: 20345
		public const string PlayerIconCreatorSettingsName = "PlayerIconCreatorSettings";

		// Token: 0x04004F7A RID: 20346
		public const float GRAPHIC_SETTINGS_PREPARE = 0.1f;

		// Token: 0x04004F7B RID: 20347
		public const float MODEL_VIEW_PREPARE = 0.2f;

		// Token: 0x04004F7C RID: 20348
		public const float BUNDLES_LOADED = 0.6f;

		// Token: 0x04004F7D RID: 20349
		public const float PLAYER_BODY_INITED = 0.7f;

		// Token: 0x04004F7E RID: 20350
		public const float MODEL_CREATED = 0.8f;

		// Token: 0x04004F7F RID: 20351
		public const float SPRITE_RENDER_PREPARE = 0.9f;

		// Token: 0x04004F80 RID: 20352
		[Space]
		public Vector3 orthographicLocalPosition;

		// Token: 0x04004F81 RID: 20353
		public Vector3 orthographicRotation;

		// Token: 0x04004F82 RID: 20354
		public RenderingPath orthographicRenderingPath;

		// Token: 0x04004F83 RID: 20355
		public float orthographicSize;

		// Token: 0x04004F84 RID: 20356
		[Space]
		public Vector3 perspectiveLocalPosition;

		// Token: 0x04004F85 RID: 20357
		public Vector3 perspectiveRotation;

		// Token: 0x04004F86 RID: 20358
		public RenderingPath perspectiveRenderingPath;

		// Token: 0x04004F87 RID: 20359
		[Space]
		public bool isOrthographic;

		// Token: 0x04004F88 RID: 20360
		[Space]
		[Range(0.01f, 179f)]
		public float fieldOfView;

		// Token: 0x04004F89 RID: 20361
		public float nearClipPlane;

		// Token: 0x04004F8A RID: 20362
		public float farClipPlane;

		// Token: 0x04004F8B RID: 20363
		[Space]
		public bool isForceRenderActive;

		// Token: 0x04004F8C RID: 20364
		[Space]
		public bool isForceSetHelmetState;

		// Token: 0x04004F8D RID: 20365
		public bool isHelmetOn;

		// Token: 0x04004F8E RID: 20366
		[Space]
		public Vector2 textureSize;

		// Token: 0x04004F8F RID: 20367
		[Space]
		public List<MeshMaterialSetting> meshMaterialSettings;

		// Token: 0x04004F90 RID: 20368
		[Space]
		public bool isEnablePreview;

		// Token: 0x04004F91 RID: 20369
		[NonSerialized]
		public bool isEditInProgress;

		// Token: 0x04004F92 RID: 20370
		private GClass821 gclass821_0;

		// Token: 0x02000C7A RID: 3194
		[CompilerGenerated]
		[Serializable]
		private sealed class Class640
		{
			// Token: 0x06004533 RID: 17715 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(GameObject o)
			{
				throw null;
			}

			// Token: 0x04004F93 RID: 20371
			public static readonly PlayerIconCreatorSettings.Class640 class640_0;

			// Token: 0x04004F94 RID: 20372
			public static Action<GameObject> action_0;
		}
	}
}
