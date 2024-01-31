using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI.Map
{
	// Token: 0x02002F27 RID: 12071
	public class SimplePocketMap : UIElement
	{
		// Token: 0x170028D5 RID: 10453
		// (get) Token: 0x0600EE36 RID: 60982 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EE37 RID: 60983 RVA: 0x00002050 File Offset: 0x00000250
		public bool Shown
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600EE38 RID: 60984 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x0600EE39 RID: 60985 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show(MapComponent map)
		{
			throw null;
		}

		// Token: 0x0600EE3A RID: 60986 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void BundleLoaded(PocketMapConfig config)
		{
			throw null;
		}

		// Token: 0x0600EE3B RID: 60987 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ShowOnPath(string path)
		{
			throw null;
		}

		// Token: 0x0600EE3C RID: 60988 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void CheckTilesForUpdate()
		{
			throw null;
		}

		// Token: 0x0600EE3D RID: 60989 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void LoadConfig(string configRelativePath)
		{
			throw null;
		}

		// Token: 0x0600EE3E RID: 60990 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600EE3F RID: 60991 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void UnloadMapBundle()
		{
			throw null;
		}

		// Token: 0x0400F371 RID: 62321
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0400F372 RID: 62322
		[SerializeField]
		private PocketMapTile _pocketMapTile;

		// Token: 0x0400F373 RID: 62323
		[SerializeField]
		private RectTransform _tilesContainer;

		// Token: 0x0400F374 RID: 62324
		[SerializeField]
		private GameObject _loader;

		// Token: 0x0400F376 RID: 62326
		protected MapComponent Map;

		// Token: 0x0400F377 RID: 62327
		protected Vector2 MapSize;

		// Token: 0x0400F378 RID: 62328
		private Vector2 _tileSize;

		// Token: 0x0400F379 RID: 62329
		private string _bundlePath;

		// Token: 0x0400F37A RID: 62330
		private PocketMapConfig _pocketMapConfig;

		// Token: 0x0400F37B RID: 62331
		protected readonly List<PocketMapTile> Tiles;

		// Token: 0x0400F37C RID: 62332
		private readonly List<int> _tileScaleVariants;

		// Token: 0x0400F37D RID: 62333
		private GClass3186 _bundleLoader;

		// Token: 0x02002F28 RID: 12072
		public class JsonMapConfig
		{
			// Token: 0x0400F37E RID: 62334
			public string bundlePath;

			// Token: 0x0400F37F RID: 62335
			public int mapSizeX;

			// Token: 0x0400F380 RID: 62336
			public int mapSizeY;

			// Token: 0x0400F381 RID: 62337
			public int tileSizeX;

			// Token: 0x0400F382 RID: 62338
			public int tileSizeY;

			// Token: 0x0400F383 RID: 62339
			public int scaledVariantsCount;
		}

		// Token: 0x02002F29 RID: 12073
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2983
		{
			// Token: 0x0400F384 RID: 62340
			public static readonly SimplePocketMap.Class2983 class2983_0;

			// Token: 0x0400F385 RID: 62341
			public static Comparison<int> comparison_0;
		}
	}
}
