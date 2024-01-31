using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.AssetsManager;
using EFT.InventoryLogic;
using EFT.MovingPlatforms;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;

namespace EFT.Interactive
{
	// Token: 0x02002771 RID: 10097
	public class LootItem : InteractableObject, MovingPlatform.GInterface347
	{
		// Token: 0x170023E7 RID: 9191
		// (get) Token: 0x0600CA3A RID: 51770 RVA: 0x00002050 File Offset: 0x00000250
		public Item Item
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023E8 RID: 9192
		// (get) Token: 0x0600CA3B RID: 51771 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA3C RID: 51772 RVA: 0x00002050 File Offset: 0x00000250
		public MovingPlatform Platform
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170023E9 RID: 9193
		// (get) Token: 0x0600CA3D RID: 51773 RVA: 0x00002050 File Offset: 0x00000250
		public Rigidbody RigidBody
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x0600CA3E RID: 51774 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA3F RID: 51775 RVA: 0x00002050 File Offset: 0x00000250
		public IPlayer LastOwner
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x0600CA40 RID: 51776 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsPhysicsOn
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0600CA41 RID: 51777 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CA42 RID: 51778 RVA: 0x00002050 File Offset: 0x00000250
		public bool PerformPickUpValidation
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

		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x0600CA43 RID: 51779 RVA: 0x00002050 File Offset: 0x00000250
		private LayerMask LayerMask_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CA44 RID: 51780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateStaticLoot<T>(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, string staticId = null, bool performPickUpValidation = true, Vector3 shift = default(Vector3)) where T : LootItem
		{
			throw null;
		}

		// Token: 0x0600CA45 RID: 51781 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static T smethod_0<T>(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, string staticId = null, bool performPickUpValidation = true) where T : LootItem
		{
			throw null;
		}

		// Token: 0x0600CA46 RID: 51782 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected LootItem Init(Item item, string itemName, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, string staticId = null, bool performPickUpValidation = true)
		{
			throw null;
		}

		// Token: 0x0600CA47 RID: 51783 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnCreatePoolRoleModel(AssetPoolObject assetPoolObject)
		{
			throw null;
		}

		// Token: 0x0600CA48 RID: 51784 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnReturnToPool(AssetPoolObject assetPoolObject)
		{
			throw null;
		}

		// Token: 0x0600CA49 RID: 51785 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CacheParameters()
		{
			throw null;
		}

		// Token: 0x0600CA4A RID: 51786 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void CacheComponents()
		{
			throw null;
		}

		// Token: 0x0600CA4B RID: 51787 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void AddCacheComponents(IEnumerable<Renderer> renderers, IEnumerable<LODGroup> lodGroups)
		{
			throw null;
		}

		// Token: 0x0600CA4C RID: 51788 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RemoveCacheComponents(IEnumerable<Renderer> renderers, IEnumerable<LODGroup> lodGroups)
		{
			throw null;
		}

		// Token: 0x0600CA4D RID: 51789 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateLootContainer(LootableContainer lc, Item item, string name, GameWorld gameWorld, string staticId = null)
		{
			throw null;
		}

		// Token: 0x0600CA4E RID: 51790 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void CreateStationaryWeapon(StationaryWeapon stationaryWeapon, Item item, string name, GameWorld gameWorld, string staticId = null)
		{
			throw null;
		}

		// Token: 0x0600CA4F RID: 51791 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Bounds smethod_1(GameObject lootItemGameobject, IEnumerable<Collider> colliders, BoxCollider resultCollider)
		{
			throw null;
		}

		// Token: 0x0600CA50 RID: 51792 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T CreateLootWithRigidbody<T>(GameObject gameObject, Item item, string name, GameWorld gameWorld, bool randomRotation, [CanBeNull] string[] validProfiles, out BoxCollider collider, bool forceLayerSetup = false, bool performPickUpValidation = true, float makeVisibleAfterDelay = 0f) where T : LootItem
		{
			throw null;
		}

		// Token: 0x0600CA51 RID: 51793 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Vector3 shift)
		{
			throw null;
		}

		// Token: 0x0600CA52 RID: 51794 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600CA53 RID: 51795 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x170023EE RID: 9198
		// (get) Token: 0x0600CA54 RID: 51796 RVA: 0x00002050 File Offset: 0x00000250
		public virtual float PhysicsQuality
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CA55 RID: 51797 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600CA56 RID: 51798 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual GClass735 GetVisibilityChecker()
		{
			throw null;
		}

		// Token: 0x0600CA57 RID: 51799 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnRigidbodyStarted()
		{
			throw null;
		}

		// Token: 0x0600CA58 RID: 51800 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnRigidbodyStopped()
		{
			throw null;
		}

		// Token: 0x0600CA59 RID: 51801 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void RemoveLootItem(GEventArgs3 args)
		{
			throw null;
		}

		// Token: 0x0600CA5A RID: 51802 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_4()
		{
			throw null;
		}

		// Token: 0x0600CA5B RID: 51803 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600CA5C RID: 51804 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RegisterInCullingObject(IEnumerable<Renderer> renderers, IEnumerable<LODGroup> lodGroups)
		{
			throw null;
		}

		// Token: 0x170023EF RID: 9199
		// (get) Token: 0x0600CA5D RID: 51805 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsVisibilityEnabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600CA5E RID: 51806 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual bool IsRigidbodyDone()
		{
			throw null;
		}

		// Token: 0x0600CA5F RID: 51807 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void StopPhysics()
		{
			throw null;
		}

		// Token: 0x0600CA60 RID: 51808 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Kill()
		{
			throw null;
		}

		// Token: 0x0600CA61 RID: 51809 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600CA62 RID: 51810 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void UnregisterFromCullingObject(IEnumerable<Renderer> renderers, IEnumerable<LODGroup> lodGroups)
		{
			throw null;
		}

		// Token: 0x0600CA63 RID: 51811 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7()
		{
			throw null;
		}

		// Token: 0x0600CA64 RID: 51812 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void TryDisableShadow(IEnumerable<Renderer> renderers)
		{
			throw null;
		}

		// Token: 0x0600CA65 RID: 51813 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_8(IEnumerable<Renderer> renderers)
		{
			throw null;
		}

		// Token: 0x0600CA66 RID: 51814 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_9()
		{
			throw null;
		}

		// Token: 0x0600CA67 RID: 51815 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void RestoreShadows(IEnumerable<Renderer> renderers)
		{
			throw null;
		}

		// Token: 0x0600CA68 RID: 51816 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetNetId()
		{
			throw null;
		}

		// Token: 0x0600CA69 RID: 51817 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600CA6A RID: 51818 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Board(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x0600CA6B RID: 51819 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void GetOff(MovingPlatform platform)
		{
			throw null;
		}

		// Token: 0x0600CA6C RID: 51820 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_10(bool isVisible)
		{
			throw null;
		}

		// Token: 0x0600CA6D RID: 51821 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_11(float delay)
		{
			throw null;
		}

		// Token: 0x0600CA6E RID: 51822 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetItemAndRigidbody(Item item, Rigidbody rigidbody)
		{
			throw null;
		}

		// Token: 0x0600CA6F RID: 51823 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void PlayDropSound()
		{
			throw null;
		}

		// Token: 0x0600CA70 RID: 51824 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnCollisionEnter(Collision collision)
		{
			throw null;
		}

		// Token: 0x0600CA71 RID: 51825 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float method_12()
		{
			throw null;
		}

		// Token: 0x0600CA72 RID: 51826 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_13(Collision collision, float delayToNextCheck = 1f)
		{
			throw null;
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected bool CheckSurfaceRayCast(Vector3 center, float delayToNextCheck = 1f)
		{
			throw null;
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_14(Vector3 center)
		{
			throw null;
		}

		// Token: 0x0400CA5B RID: 51803
		protected const float _maxPhysicsTime = 15f;

		// Token: 0x0400CA5C RID: 51804
		protected const float _maxPhysicsTimeForContinuousDetectionMode = 7.5f;

		// Token: 0x0400CA5D RID: 51805
		protected const float _sqrSpeedToStopContinuousDetectionMode = 0.008f;

		// Token: 0x0400CA5E RID: 51806
		protected const float DELAY_NEXT_CHECK_COLLISION = 0.5f;

		// Token: 0x0400CA5F RID: 51807
		protected const float DEFAULT_ENERGY_VALUE = 50f;

		// Token: 0x0400CA60 RID: 51808
		public Vector3 Shift;

		// Token: 0x0400CA61 RID: 51809
		public TraderControllerClass ItemOwner;

		// Token: 0x0400CA62 RID: 51810
		[CompilerGenerated]
		private MovingPlatform movingPlatform_0;

		// Token: 0x0400CA63 RID: 51811
		public string Name;

		// Token: 0x0400CA64 RID: 51812
		public string StaticId;

		// Token: 0x0400CA65 RID: 51813
		public string ItemId;

		// Token: 0x0400CA66 RID: 51814
		public string TemplateId;

		// Token: 0x0400CA67 RID: 51815
		public bool RandomRotation;

		// Token: 0x0400CA68 RID: 51816
		public string[] ValidProfiles;

		// Token: 0x0400CA69 RID: 51817
		[CompilerGenerated]
		private IPlayer iplayer_0;

		// Token: 0x0400CA6A RID: 51818
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400CA6B RID: 51819
		protected Rigidbody _rigidBody;

		// Token: 0x0400CA6C RID: 51820
		protected float _currentPhysicsTime;

		// Token: 0x0400CA6D RID: 51821
		protected float _cullingRegisterRadius;

		// Token: 0x0400CA6E RID: 51822
		protected BaseBallistic.ESurfaceSound _currentSurface;

		// Token: 0x0400CA6F RID: 51823
		private List<Renderer> _renderers;

		// Token: 0x0400CA70 RID: 51824
		private List<LODGroup> _lodGroups;

		// Token: 0x0400CA71 RID: 51825
		private List<ShadowCastingMode> _renderersShadowCastingMode;

		// Token: 0x0400CA72 RID: 51826
		private BoxCollider _boundCollider;

		// Token: 0x0400CA73 RID: 51827
		public DisablerCullingObject CullingObject;

		// Token: 0x0400CA74 RID: 51828
		private static Collider[] collider_0;

		// Token: 0x0400CA75 RID: 51829
		private static Collider[] collider_1;

		// Token: 0x0400CA76 RID: 51830
		private float float_0;

		// Token: 0x0400CA77 RID: 51831
		private Item item_0;

		// Token: 0x0400CA78 RID: 51832
		private bool bool_1;

		// Token: 0x0400CA79 RID: 51833
		private IEnumerator ienumerator_0;

		// Token: 0x0400CA7A RID: 51834
		private bool bool_2;

		// Token: 0x0400CA7B RID: 51835
		private const int int_0 = 8;

		// Token: 0x0400CA7C RID: 51836
		private Vector3 vector3_0;
	}
}
