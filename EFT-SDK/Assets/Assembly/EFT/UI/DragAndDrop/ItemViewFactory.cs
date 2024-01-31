using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.InventoryLogic;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT.UI.DragAndDrop
{
	// Token: 0x02002E1B RID: 11803
	public class ItemViewFactory : MonoBehaviour
	{
		// Token: 0x0600E87D RID: 59517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateFromPool<T>(string prefabName) where T : UnityEngine.Object
		{
			throw null;
		}

		// Token: 0x0600E87E RID: 59518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateFromPrefab<T>(string prefabName) where T : UnityEngine.Object
		{
			throw null;
		}

		// Token: 0x0600E87F RID: 59519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GStruct23 GetCellPixelSize(GStruct23 size)
		{
			throw null;
		}

		// Token: 0x0600E880 RID: 59520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GClass818 LoadItemIcon(Item item, int scaleFactor = 1, bool forcedGeneration = false)
		{
			throw null;
		}

		// Token: 0x0600E881 RID: 59521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Task<Sprite> GetItemSpriteAsync(Item item, int scaleFactor = 1)
		{
			throw null;
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sprite LoadModIconSprite(Item item)
		{
			throw null;
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sprite LoadModIconSprite(Type type)
		{
			throw null;
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetModIconName(Item item)
		{
			throw null;
		}

		// Token: 0x0600E885 RID: 59525 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetModIconName(Type type)
		{
			throw null;
		}

		// Token: 0x0600E886 RID: 59526 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EModSubclass GetModSubclass(Type modType)
		{
			throw null;
		}

		// Token: 0x0600E887 RID: 59527 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sprite LoadModClassIconSprite(Item item)
		{
			throw null;
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sprite LoadModClassIconSprite(Type type)
		{
			throw null;
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetModClassIconName(Item item)
		{
			throw null;
		}

		// Token: 0x0600E88A RID: 59530 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetModClassIconName(Type type)
		{
			throw null;
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EModClass GetModClass(Type modType)
		{
			throw null;
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EModClass GetSlotModClass(EWeaponModType modType)
		{
			throw null;
		}

		// Token: 0x0600E88D RID: 59533 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetModSlotName(EWeaponModType modType)
		{
			throw null;
		}

		// Token: 0x0600E88E RID: 59534 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool IsSecureContainer(Item item)
		{
			throw null;
		}

		// Token: 0x0600E88F RID: 59535 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string GetSpecialIcon(Item item)
		{
			throw null;
		}

		// Token: 0x0600E890 RID: 59536 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Sprite LoadItemTypeSprite(Type type)
		{
			throw null;
		}

		// Token: 0x0600E891 RID: 59537 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EItemType GetItemType(Type itemType)
		{
			throw null;
		}

		// Token: 0x0400ED82 RID: 60802
		public static readonly Quaternion VerticalRotation;

		// Token: 0x0400ED83 RID: 60803
		public static readonly Quaternion HorizontalRotation;

		// Token: 0x0400ED84 RID: 60804
		public const int CellSize = 62;

		// Token: 0x0400ED85 RID: 60805
		public const int BorderSize = 1;

		// Token: 0x0400ED86 RID: 60806
		public const string PrefabLayoutsPath = "Prefabs/UGUI/Layouts/";
	}
}
