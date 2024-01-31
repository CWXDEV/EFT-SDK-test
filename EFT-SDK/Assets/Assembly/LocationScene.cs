using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EFT.Airdrop;
using EFT.BufferZone;
using EFT.Game.Spawning;
using EFT.Hideout;
using EFT.Interactive;
using EFT.MovingPlatforms;
using EFT.SpeedTree;
using EFT.SynchronizableObjects;
using UnityEngine;
using UnityEngine.SceneManagement;

// Token: 0x02000685 RID: 1669
[ExecuteInEditMode]
public sealed class LocationScene : MonoBehaviour, IBotController
{
	// Token: 0x170006E4 RID: 1764
	// (get) Token: 0x0600260E RID: 9742 RVA: 0x00002050 File Offset: 0x00000250
	private int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600260F RID: 9743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0<T>(T[] array)
	{
		throw null;
	}

	// Token: 0x06002610 RID: 9744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private T[] method_1<T>()
	{
		throw null;
	}

	// Token: 0x06002611 RID: 9745 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> GetAll<T>()
	{
		throw null;
	}

	// Token: 0x06002612 RID: 9746 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> GetAllObjects<T>(bool withDisabled = false) where T : Behaviour
	{
		throw null;
	}

	// Token: 0x06002613 RID: 9747 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static IEnumerable<T> GetAllObjectsAndWhenISayAllIActuallyMeanIt<T>() where T : Behaviour
	{
		throw null;
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(Type type, Behaviour[] objects)
	{
		throw null;
	}

	// Token: 0x06002616 RID: 9750 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FillArrays()
	{
		throw null;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FillArraysFrom(Scene scene)
	{
		throw null;
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnPreProcess()
	{
		throw null;
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T[] smethod_0<T>(ref Scene scene, bool includeInactive = true)
	{
		throw null;
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static T[] smethod_1<T>(bool includeInactive, ref LocationScene.Struct63 struct63_0)
	{
		throw null;
	}

	// Token: 0x04002532 RID: 9522
	public StaticLoot[] StaticLoot;

	// Token: 0x04002533 RID: 9523
	public LootableContainer[] LootableContainers;

	// Token: 0x04002534 RID: 9524
	public WorldInteractiveObject[] WorldInteractiveObjects;

	// Token: 0x04002535 RID: 9525
	public NavMeshDoorLink[] NavMeshLinks;

	// Token: 0x04002536 RID: 9526
	public SpawnPointMarker[] SpawnPointMarkers;

	// Token: 0x04002537 RID: 9527
	public BotZone[] BotZones;

	// Token: 0x04002538 RID: 9528
	public ExfiltrationPoint[] ExfiltrationPoints;

	// Token: 0x04002539 RID: 9529
	public AIPlaceInfo[] AIPlaceInfos;

	// Token: 0x0400253A RID: 9530
	public StationaryWeapon[] StationaryWeapons;

	// Token: 0x0400253B RID: 9531
	public MovingPlatform[] MovingPlatforms;

	// Token: 0x0400253C RID: 9532
	public BorderZone[] BorderZones;

	// Token: 0x0400253D RID: 9533
	public BaseRestrictableZone[] RestrictableZones;

	// Token: 0x0400253E RID: 9534
	public LampController[] Lamps;

	// Token: 0x0400253F RID: 9535
	public WindowBreaker[] Windows;

	// Token: 0x04002540 RID: 9536
	public SynchronizableObject[] SynchronizableObjects;

	// Token: 0x04002541 RID: 9537
	public AirdropPoint[] AirdropPoints;

	// Token: 0x04002542 RID: 9538
	public BufferZoneContainer[] BufferZoneContainers;

	// Token: 0x04002543 RID: 9539
	public AreasController[] AreasControllers;

	// Token: 0x04002544 RID: 9540
	public AudioSource[] AudioSources;

	// Token: 0x04002545 RID: 9541
	[HideInInspector]
	public TreeWind[] treeWinds;

	// Token: 0x04002546 RID: 9542
	[HideInInspector]
	public TreeWind.Settings[] treeWindSettingsPresets;

	// Token: 0x04002547 RID: 9543
	public static readonly List<LocationScene> LoadedScenes;

	// Token: 0x04002548 RID: 9544
	public static readonly List<Collider> DoorsCollisionColliders;

	// Token: 0x04002549 RID: 9545
	private readonly Dictionary<Type, Array> dictionary_0;

	// Token: 0x02000686 RID: 1670
	[CompilerGenerated]
	[Serializable]
	private sealed class Class322<T>
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(LocationScene scene)
		{
			throw null;
		}

		// Token: 0x0400254A RID: 9546
		public static readonly LocationScene.Class322<T> class322_0;

		// Token: 0x0400254B RID: 9547
		public static Func<LocationScene, IEnumerable<T>> func_0;
	}

	// Token: 0x02000687 RID: 1671
	[CompilerGenerated]
	private sealed class Class323<T> where T : Behaviour
	{
		// Token: 0x0600261E RID: 9758 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(LocationScene scene)
		{
			throw null;
		}

		// Token: 0x0400254C RID: 9548
		public bool withDisabled;
	}

	// Token: 0x02000688 RID: 1672
	[CompilerGenerated]
	private sealed class Class324<T> where T : Behaviour
	{
		// Token: 0x0600261F RID: 9759 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(T obj)
		{
			throw null;
		}

		// Token: 0x0400254D RID: 9549
		public LocationScene scene;

		// Token: 0x0400254E RID: 9550
		public LocationScene.Class323<T> class323_0;
	}

	// Token: 0x02000689 RID: 1673
	[CompilerGenerated]
	[Serializable]
	private sealed class Class325<T> where T : Behaviour
	{
		// Token: 0x06002620 RID: 9760 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(LocationScene x)
		{
			throw null;
		}

		// Token: 0x0400254F RID: 9551
		public static readonly LocationScene.Class325<T> class325_0;

		// Token: 0x04002550 RID: 9552
		public static Func<LocationScene, IEnumerable<T>> func_0;
	}

	// Token: 0x0200068A RID: 1674
	[CompilerGenerated]
	[StructLayout(LayoutKind.Auto)]
	public struct Struct63
	{
		// Token: 0x04002551 RID: 9553
		public Scene scene;
	}

	// Token: 0x0200068B RID: 1675
	[CompilerGenerated]
	private sealed class Class326
	{
		// Token: 0x06002621 RID: 9761 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(TreeWind x)
		{
			throw null;
		}

		// Token: 0x04002552 RID: 9554
		public Scene scene;
	}

	// Token: 0x0200068C RID: 1676
	[CompilerGenerated]
	private sealed class Class327<T>
	{
		// Token: 0x06002622 RID: 9762 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<T> method_0(GameObject x)
		{
			throw null;
		}

		// Token: 0x04002553 RID: 9555
		public bool includeInactive;
	}
}
