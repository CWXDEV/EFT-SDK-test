using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationEventSystem;
using EFT;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using EFT.Visual;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x02000716 RID: 1814
[DisallowMultipleComponent]
public class WeaponPrefab : AssetPoolObject, GInterface27
{
	// Token: 0x17000751 RID: 1873
	// (get) Token: 0x06002A2E RID: 10798 RVA: 0x00002050 File Offset: 0x00000250
	public IAnimator Animator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000752 RID: 1874
	// (get) Token: 0x06002A2F RID: 10799 RVA: 0x00002050 File Offset: 0x00000250
	public FirearmsAnimator FirearmsAnimator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000753 RID: 1875
	// (get) Token: 0x06002A30 RID: 10800 RVA: 0x00002050 File Offset: 0x00000250
	public AnimationEventsEmitter AnimationEventsEmitter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000754 RID: 1876
	// (get) Token: 0x06002A31 RID: 10801 RVA: 0x00002050 File Offset: 0x00000250
	public GameObject WeaponObject
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000755 RID: 1877
	// (get) Token: 0x06002A32 RID: 10802 RVA: 0x00002050 File Offset: 0x00000250
	public RuntimeAnimatorController AnimatorController
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000756 RID: 1878
	// (get) Token: 0x06002A33 RID: 10803 RVA: 0x00002050 File Offset: 0x00000250
	public List<HotObject> HotObjects
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000757 RID: 1879
	// (get) Token: 0x06002A34 RID: 10804 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsUnderbarrelWeaponPrefab
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000758 RID: 1880
	// (get) Token: 0x06002A35 RID: 10805 RVA: 0x00002050 File Offset: 0x00000250
	public new Renderer[] Renderers
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00002050 File Offset: 0x00000250
	public float CurrentOverheat
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RecalculateObjectInstanceRenderers()
	{
		throw null;
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetUnderbarrelFastAnimator(Player player)
	{
		throw null;
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetUnderbarrelFastAnimator(Player player)
	{
		throw null;
	}

	// Token: 0x06002A3A RID: 10810 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform Init(IPlayer player, bool parent)
	{
		throw null;
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitMalfunctionState(Weapon weapon, bool hasPlayer, bool malfunctionKnown, out AmmoPoolObject ammoPoolObject)
	{
		throw null;
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RevertMalfunctionState(Weapon weapon, bool hasPlayer, bool force = false)
	{
		throw null;
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitHotObjects(Weapon weapon)
	{
		throw null;
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Transform method_2([CanBeNull] IPlayer player)
	{
		throw null;
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3(Player player)
	{
		throw null;
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RebindAnimator(IPlayer player)
	{
		throw null;
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReturnToPool()
	{
		throw null;
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetStatesToDefault()
	{
		throw null;
	}

	// Token: 0x06002A45 RID: 10821 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreatePoolRoleModel()
	{
		throw null;
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent)
	{
		throw null;
	}

	// Token: 0x06002A47 RID: 10823 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void InheritRoleModelData<TAssetPoolObject>(TAssetPoolObject roleModel)
	{
		throw null;
	}

	// Token: 0x06002A48 RID: 10824 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x06002A49 RID: 10825 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void CacheInternalObjects()
	{
		throw null;
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8()
	{
		throw null;
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x06002A4E RID: 10830 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06002A52 RID: 10834 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateAnimatorHierarchy()
	{
		throw null;
	}

	// Token: 0x06002A53 RID: 10835 RVA: 0x00002050 File Offset: 0x00000250
	[CompilerGenerated]
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IAnimator method_11()
	{
		throw null;
	}

	// Token: 0x0400285D RID: 10333
	public const string BONE_ALT_GRIP = "altpose";

	// Token: 0x0400285E RID: 10334
	public const string BONE_SMOKEPORT = "smokeport";

	// Token: 0x0400285F RID: 10335
	public const string BONE_FIREPORT = "fireport";

	// Token: 0x04002860 RID: 10336
	public const string EXTRACTOR_GO_NAME = "extractor_smoke";

	// Token: 0x04002861 RID: 10337
	private const string string_0 = "HIDE_SHADOW";

	// Token: 0x04002862 RID: 10338
	[SerializeField]
	public GameObject _weaponObject;

	// Token: 0x04002863 RID: 10339
	[SerializeField]
	public GameObject _weaponObjectSimple;

	// Token: 0x04002864 RID: 10340
	[SerializeField]
	public RuntimeAnimatorController _originalAnimatorController;

	// Token: 0x04002865 RID: 10341
	[SerializeField]
	public RuntimeAnimatorController _animatorSimple;

	// Token: 0x04002866 RID: 10342
	[SerializeField]
	public RuntimeAnimatorController _animatorSpirit;

	// Token: 0x04002867 RID: 10343
	[SerializeField]
	public TextAsset _fastAnimatorControllerBinaryData;

	// Token: 0x04002868 RID: 10344
	[SerializeField]
	private Avatar _avatar;

	// Token: 0x04002869 RID: 10345
	[SerializeField]
	public RestSettings RestSettings;

	// Token: 0x0400286A RID: 10346
	public GameObject DefaultMuzzlePrefab;

	// Token: 0x0400286B RID: 10347
	public GameObject DefaultSmokeport;

	// Token: 0x0400286C RID: 10348
	public GameObject DefaultHeatHazeEffect;

	// Token: 0x0400286D RID: 10349
	public Vector3 RecoilCenter;

	// Token: 0x0400286E RID: 10350
	public Vector3 RotationCenter;

	// Token: 0x0400286F RID: 10351
	public Vector3 RotationCenterNoStock;

	// Token: 0x04002870 RID: 10352
	public Vector2 DupletAccuracyPenaltyX;

	// Token: 0x04002871 RID: 10353
	public Vector2 DupletAccuracyPenaltyY;

	// Token: 0x04002872 RID: 10354
	public WeaponPrefab.AimPlane FarPlane;

	// Token: 0x04002873 RID: 10355
	public WeaponPrefab.AimPlane DefaultAimPlane;

	// Token: 0x04002874 RID: 10356
	public WeaponPrefab.AimPlane[] CustomAimPlanes;

	// Token: 0x04002875 RID: 10357
	[SerializeField]
	public GameObject _objectInstance;

	// Token: 0x04002876 RID: 10358
	[SerializeField]
	private Transform _localWeaponRoot;

	// Token: 0x04002877 RID: 10359
	private IPlayer iplayer_0;

	// Token: 0x04002878 RID: 10360
	private IAnimator ianimator_0;

	// Token: 0x04002879 RID: 10361
	private IAnimator ianimator_1;

	// Token: 0x0400287A RID: 10362
	private FirearmsAnimator firearmsAnimator_0;

	// Token: 0x0400287B RID: 10363
	private GClass1107 gclass1107_0;

	// Token: 0x0400287C RID: 10364
	private AnimationEventsEmitter animationEventsEmitter_0;

	// Token: 0x0400287D RID: 10365
	private GClass1139.GClass1140 gclass1140_0;

	// Token: 0x0400287E RID: 10366
	private Weapon weapon_0;

	// Token: 0x0400287F RID: 10367
	private Vector3 vector3_0;

	// Token: 0x04002880 RID: 10368
	private Quaternion quaternion_0;

	// Token: 0x04002881 RID: 10369
	private Vector3 vector3_1;

	// Token: 0x04002882 RID: 10370
	private bool bool_3;

	// Token: 0x04002883 RID: 10371
	private bool bool_4;

	// Token: 0x04002884 RID: 10372
	private float float_0;

	// Token: 0x04002885 RID: 10373
	private List<HotObject> list_0;

	// Token: 0x04002886 RID: 10374
	private List<Material> list_1;

	// Token: 0x04002887 RID: 10375
	private GunShadowDisabler[] gunShadowDisabler_0;

	// Token: 0x04002888 RID: 10376
	private float float_1;

	// Token: 0x04002889 RID: 10377
	private Animator animator_0;

	// Token: 0x0400288A RID: 10378
	[Header("Extractor params")]
	public string[] RemoveChildrenOf;

	// Token: 0x0400288B RID: 10379
	public string[] AnimatedBones;

	// Token: 0x0400288C RID: 10380
	public TransformLinks Hierarchy;

	// Token: 0x0400288D RID: 10381
	public GClass1664 ObjectInHands;

	// Token: 0x0400288E RID: 10382
	public int[] LayersDefaultStates;

	// Token: 0x0400288F RID: 10383
	public WeaponPrefab.MaterialConfig[] MaterialsConfig;

	// Token: 0x04002890 RID: 10384
	[Header("Extractor params for LODs")]
	public WeaponPrefab.LODConfig[] LodsConfig;

	// Token: 0x04002891 RID: 10385
	private Renderer[] renderer_0;

	// Token: 0x04002892 RID: 10386
	private List<Mod> list_2;

	// Token: 0x02000717 RID: 1815
	[Serializable]
	public class AimPlane
	{
		// Token: 0x04002893 RID: 10387
		public string Name;

		// Token: 0x04002894 RID: 10388
		public float Depth;
	}

	// Token: 0x02000718 RID: 1816
	[Serializable]
	public class MaterialConfig
	{
		// Token: 0x04002895 RID: 10389
		public string renderer;

		// Token: 0x04002896 RID: 10390
		public Material material;
	}

	// Token: 0x02000719 RID: 1817
	[Serializable]
	public class LODConfig
	{
		// Token: 0x04002897 RID: 10391
		public float screenRelativeTransitionHeight;

		// Token: 0x04002898 RID: 10392
		public float fadeTransitionWidth;

		// Token: 0x04002899 RID: 10393
		public string[] renderers;
	}

	// Token: 0x0200071A RID: 1818
	[CompilerGenerated]
	[Serializable]
	private sealed class Class379
	{
		// Token: 0x06002A54 RID: 10836 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_0(GInterface85 x)
		{
			throw null;
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GInterface85 method_1(GInterface85 x)
		{
			throw null;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int method_2(GInterface85 x)
		{
			throw null;
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GInterface85 method_3(GInterface85 x)
		{
			throw null;
		}

		// Token: 0x0400289A RID: 10394
		public static readonly WeaponPrefab.Class379 class379_0;

		// Token: 0x0400289B RID: 10395
		public static Func<GInterface85, int> func_0;

		// Token: 0x0400289C RID: 10396
		public static Func<GInterface85, GInterface85> func_1;

		// Token: 0x0400289D RID: 10397
		public static Func<GInterface85, int> func_2;

		// Token: 0x0400289E RID: 10398
		public static Func<GInterface85, GInterface85> func_3;
	}
}
