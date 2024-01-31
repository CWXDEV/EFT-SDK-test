using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.SceneManagement;

// Token: 0x020006BC RID: 1724
public static class GClass646
{
	// Token: 0x060026E7 RID: 9959 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void IgnoreCollision(Collider collider1, Collider collider2, bool ignore = true)
	{
		throw null;
	}

	// Token: 0x060026E8 RID: 9960 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Collider collider1, Collider collider2, bool ignore)
	{
		throw null;
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool GetIgnoreCollision(Collider collider1, Collider collider2)
	{
		throw null;
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		throw null;
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool SphereCast(Ray ray, float radius, out RaycastHit hitInfo, float maxDistance, int layerMask)
	{
		throw null;
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		throw null;
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, [DefaultValue("Quaternion.identity")] Quaternion orientation, [DefaultValue("AllLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
	{
		throw null;
	}

	// Token: 0x170006FE RID: 1790
	// (get) Token: 0x060026EE RID: 9966 RVA: 0x00002050 File Offset: 0x00000250
	public static bool RebuildingStaticCollidersDetected
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void FixedUpdate()
	{
		throw null;
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Update()
	{
		throw null;
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LinecastInBothSides(Vector3 start, Vector3 end, out RaycastHit bestHit, out bool isForwardHit, LayerMask forwardLayerMask, LayerMask backwardLayerMask, RaycastHit[] raycastHits, Func<RaycastHit, bool> isHitIgnoredTest)
	{
		throw null;
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool LinecastPrecise(Vector3 start, Vector3 end, out RaycastHit bestHit, LayerMask layerMask, bool reverseCheck, RaycastHit[] raycastHits, Func<RaycastHit, bool> isHitIgnoredTest)
	{
		throw null;
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Linecast(Vector3 start, Vector3 end, out RaycastHit bestHit, LayerMask layerMask, bool reverseCheck, RaycastHit[] raycastHits, Func<RaycastHit, bool> isHitIgnoredTest)
	{
		throw null;
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool Linecast(Vector3 start, Vector3 end, LayerMask layerMask, QueryTriggerInteraction queryTriggerInteraction, out RaycastHit hit)
	{
		throw null;
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SyncTransforms()
	{
		throw null;
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ForceSyncTransforms()
	{
		throw null;
	}

	// Token: 0x04002631 RID: 9777
	private static Dictionary<Collider, HashSet<Collider>> dictionary_0;

	// Token: 0x04002632 RID: 9778
	private const int int_0 = 8;

	// Token: 0x04002633 RID: 9779
	private const float float_0 = 0.001f;

	// Token: 0x020006BD RID: 1725
	public class ColliderSync : MonoBehaviour
	{
		// Token: 0x060026F7 RID: 9975 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Assign(GClass645 searcher, BoxCollider collider)
		{
			throw null;
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Sync()
		{
			throw null;
		}

		// Token: 0x060026F9 RID: 9977 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnEnable()
		{
			throw null;
		}

		// Token: 0x060026FA RID: 9978 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDisable()
		{
			throw null;
		}

		// Token: 0x04002634 RID: 9780
		private GClass645 gclass645_0;

		// Token: 0x04002635 RID: 9781
		private BoxCollider boxCollider_0;

		// Token: 0x04002636 RID: 9782
		private int? nullable_0;
	}

	// Token: 0x020006BE RID: 1726
	private static class Class366
	{
		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060026FC RID: 9980 RVA: 0x00002050 File Offset: 0x00000250
		public static bool RebuildingStaticCollidersDetected
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

		// Token: 0x060026FD RID: 9981 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void BeginOperation()
		{
			throw null;
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void EndOperation()
		{
			throw null;
		}

		// Token: 0x060026FF RID: 9983 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(long passed)
		{
			throw null;
		}

		// Token: 0x04002637 RID: 9783
		private const long long_0 = 30000L;

		// Token: 0x04002638 RID: 9784
		private const float float_0 = 5f;

		// Token: 0x04002639 RID: 9785
		private const int int_0 = 100;

		// Token: 0x0400263A RID: 9786
		private static Stopwatch stopwatch_0;

		// Token: 0x0400263B RID: 9787
		private static long long_1;

		// Token: 0x0400263C RID: 9788
		private static float float_1;

		// Token: 0x0400263D RID: 9789
		private static int int_1;

		// Token: 0x0400263E RID: 9790
		[CompilerGenerated]
		private static bool bool_0;
	}

	// Token: 0x020006BF RID: 1727
	public static class GClass647
	{
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002701 RID: 9985 RVA: 0x00002050 File Offset: 0x00000250
		public static bool UpdateControlledByUnity
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

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002703 RID: 9987 RVA: 0x00002050 File Offset: 0x00000250
		public static bool SyncTransformsControlledByUnity
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

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002705 RID: 9989 RVA: 0x00002050 File Offset: 0x00000250
		public static bool UpdateEnabled
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

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x00002050 File Offset: 0x00000250
		public static float Quality
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

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002709 RID: 9993 RVA: 0x00002050 File Offset: 0x00000250
		public static int SmoothSimulationSamplesCount
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

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x00002050 File Offset: 0x00000250
		public static double SimulationAVGDeltaTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00002050 File Offset: 0x00000250
		private static bool Boolean_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void FixedUpdate()
		{
			throw null;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SyncTransforms()
		{
			throw null;
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ForceSyncTransforms()
		{
			throw null;
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SetAVGSimulationDeltaTime(float time)
		{
			throw null;
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_2(float deltaTime)
		{
			throw null;
		}

		// Token: 0x0400263F RID: 9791
		private static bool bool_0;

		// Token: 0x04002640 RID: 9792
		public static GClass646.GClass647.UpdateModeType UpdateMode;

		// Token: 0x04002641 RID: 9793
		private static float float_0;

		// Token: 0x04002642 RID: 9794
		private static int int_0;

		// Token: 0x04002643 RID: 9795
		private static GClass730 gclass730_0;

		// Token: 0x020006C0 RID: 1728
		public enum UpdateModeType
		{
			// Token: 0x04002645 RID: 9797
			FixedUpdate,
			// Token: 0x04002646 RID: 9798
			Update,
			// Token: 0x04002647 RID: 9799
			QualityControl,
			// Token: 0x04002648 RID: 9800
			SmoothSimulate
		}
	}

	// Token: 0x020006C1 RID: 1729
	public static class GClass648
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x00002050 File Offset: 0x00000250
		public static bool Enabled
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

		// Token: 0x06002716 RID: 10006 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void SupportRigidbody(Rigidbody rigidbody, float quality = 1f, GClass735 visibilityChecker = null)
		{
			throw null;
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void UnsupportRigidbody(Rigidbody rigidbody)
		{
			throw null;
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_0()
		{
			throw null;
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void smethod_1(bool enabled)
		{
			throw null;
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Update()
		{
			throw null;
		}

		// Token: 0x04002649 RID: 9801
		private const float float_0 = 1f;

		// Token: 0x0400264A RID: 9802
		private static List<GClass646.GClass648.GStruct29> list_0;

		// Token: 0x0400264B RID: 9803
		private static bool bool_0;

		// Token: 0x020006C2 RID: 1730
		public static class GClass649
		{
			// Token: 0x0400264C RID: 9804
			public const float Low = 0f;

			// Token: 0x0400264D RID: 9805
			public const float High = 1f;
		}

		// Token: 0x020006C3 RID: 1731
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct29
		{
			// Token: 0x0400264E RID: 9806
			public Rigidbody rigidbody;

			// Token: 0x0400264F RID: 9807
			public GClass735 visibilityChecker;
		}
	}

	// Token: 0x020006C4 RID: 1732
	public static class GClass650
	{
		// Token: 0x0600271B RID: 10011 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_0(PhysicsScene physicsScene, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw null;
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static int smethod_1(PhysicsScene physicsScene, Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw null;
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static ValueTuple<Scene, PhysicsScene> smethod_2(string sceneName)
		{
			throw null;
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Create()
		{
			throw null;
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static GClass646.GClass650.GClass655 OverlapBoxAsync(GClass646.GClass650.EWorldType worldTypeMask, Vector3 center, Vector3 halfExtents, Collider[][] buffers, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction, GClass646.GClass650.GClass655 complete)
		{
			throw null;
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int OverlapBoxNonAlloc(GClass646.GClass650.EWorldType worldTypeMask, Vector3 center, Vector3 halfExtents, Collider[] results, Collider[] tempBuffer, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw null;
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static int OverlapSphereNonAlloc(GClass646.GClass650.EWorldType worldTypeMask, Vector3 position, float radius, Collider[] results, Collider[] tempBuffer, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
		{
			throw null;
		}

		// Token: 0x04002650 RID: 9808
		public static GClass646.GClass650.GClass652 Default;

		// Token: 0x04002651 RID: 9809
		public static GClass646.GClass650.GClass654 VolumePropagationAndEnvironmentSwitcherTriggers;

		// Token: 0x04002652 RID: 9810
		public static GClass646.GClass650.GClass653 DisablerCullingObjectTriggers;

		// Token: 0x04002653 RID: 9811
		private static List<GClass646.GClass650.GClass651> list_0;

		// Token: 0x020006C5 RID: 1733
		public class GClass652 : GClass646.GClass650.GClass651
		{
			// Token: 0x06002722 RID: 10018 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override void Create()
			{
				throw null;
			}

			// Token: 0x06002723 RID: 10019 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsSupportingMask(int mask)
			{
				throw null;
			}

			// Token: 0x06002724 RID: 10020 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ExtractGameObjectsToPhysicsScene()
			{
				throw null;
			}
		}

		// Token: 0x020006C6 RID: 1734
		public class GClass653 : GClass646.GClass650.GClass651
		{
			// Token: 0x06002725 RID: 10021 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsSupportingMask(int mask)
			{
				throw null;
			}

			// Token: 0x06002726 RID: 10022 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ExtractGameObjectsToPhysicsScene()
			{
				throw null;
			}
		}

		// Token: 0x020006C7 RID: 1735
		public class GClass654 : GClass646.GClass650.GClass651
		{
			// Token: 0x06002727 RID: 10023 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool IsSupportingMask(int mask)
			{
				throw null;
			}

			// Token: 0x06002728 RID: 10024 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected override void ExtractGameObjectsToPhysicsScene()
			{
				throw null;
			}

			// Token: 0x06002729 RID: 10025 RVA: 0x00002050 File Offset: 0x00000250
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_2(IEnumerable<Component> betterPropagationVolumes1, bool moveWithChild)
			{
				throw null;
			}
		}

		// Token: 0x020006C8 RID: 1736
		public abstract class GClass651
		{
			// Token: 0x17000708 RID: 1800
			// (get) Token: 0x0600272A RID: 10026 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600272B RID: 10027 RVA: 0x00002050 File Offset: 0x00000250
			public bool IsCreated
			{
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				[MethodImpl(MethodImplOptions.NoInlining)]
				protected set
				{
					throw null;
				}
			}

			// Token: 0x17000709 RID: 1801
			// (get) Token: 0x0600272C RID: 10028 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600272D RID: 10029 RVA: 0x00002050 File Offset: 0x00000250
			public GClass646.GClass650.EWorldType WorldType
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

			// Token: 0x1700070A RID: 1802
			// (get) Token: 0x0600272E RID: 10030 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600272F RID: 10031 RVA: 0x00002050 File Offset: 0x00000250
			public string Name
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

			// Token: 0x06002730 RID: 10032
			public abstract bool IsSupportingMask(int mask);

			// Token: 0x06002731 RID: 10033 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public bool CanBeUsed(GClass646.GClass650.EWorldType worldTypeMask, int castMask)
			{
				throw null;
			}

			// Token: 0x06002732 RID: 10034 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public virtual void Create()
			{
				throw null;
			}

			// Token: 0x06002733 RID: 10035 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			private void method_0(Scene scene)
			{
				throw null;
			}

			// Token: 0x06002734 RID: 10036
			protected abstract void ExtractGameObjectsToPhysicsScene();

			// Token: 0x06002735 RID: 10037 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected void method_1(GameObject target, bool moveWithChild = false)
			{
				throw null;
			}

			// Token: 0x06002736 RID: 10038 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int OverlapBoxNonAlloc(Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction)
			{
				throw null;
			}

			// Token: 0x06002737 RID: 10039 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OverlapBoxNonAllocAsync(int index, Vector3 center, Vector3 halfExtents, Collider[] results, Quaternion orientation, int mask, QueryTriggerInteraction queryTriggerInteraction, GClass646.GClass650.GClass655 asyncData)
			{
				throw null;
			}

			// Token: 0x06002738 RID: 10040 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int OverlapSphereNonAlloc(Vector3 position, float radius, Collider[] results, int layerMask, QueryTriggerInteraction queryTriggerInteraction)
			{
				throw null;
			}

			// Token: 0x06002739 RID: 10041 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public int RaycastNonAlloc(Ray ray, RaycastHit[] results, [DefaultValue("Mathf.Infinity")] float maxDistance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("QueryTriggerInteraction.UseGlobal")] QueryTriggerInteraction queryTriggerInteraction)
			{
				throw null;
			}

			// Token: 0x04002654 RID: 9812
			protected Scene scene_0;

			// Token: 0x04002655 RID: 9813
			protected PhysicsScene physicsScene_0;

			// Token: 0x04002656 RID: 9814
			protected GClass645 gclass645_0;

			// Token: 0x04002657 RID: 9815
			[CompilerGenerated]
			private bool bool_0;

			// Token: 0x04002658 RID: 9816
			[CompilerGenerated]
			private GClass646.GClass650.EWorldType eworldType_0;

			// Token: 0x04002659 RID: 9817
			[CompilerGenerated]
			private string string_0;
		}

		// Token: 0x020006C9 RID: 1737
		[Flags]
		public enum EWorldType
		{
			// Token: 0x0400265B RID: 9819
			Default = 2,
			// Token: 0x0400265C RID: 9820
			VolumePropagationAndEnvironmentSwitcherTriggers = 4,
			// Token: 0x0400265D RID: 9821
			DisablerCullingObjectTriggers = 8
		}

		// Token: 0x020006CA RID: 1738
		public sealed class GClass655
		{
			// Token: 0x0600273A RID: 10042 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void OneWorldCompleteCallback(int index, int count)
			{
				throw null;
			}

			// Token: 0x0600273B RID: 10043 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x0400265E RID: 9822
			public static readonly GClass646.GClass650.GClass655 EmptyComplete;

			// Token: 0x0400265F RID: 9823
			public Collider[] Results;

			// Token: 0x04002660 RID: 9824
			public Collider[][] Buffers;

			// Token: 0x04002661 RID: 9825
			public bool IsComplete;

			// Token: 0x04002662 RID: 9826
			public int TotalWorldsCount;

			// Token: 0x04002663 RID: 9827
			public int Count;

			// Token: 0x04002664 RID: 9828
			private int int_0;
		}
	}
}
