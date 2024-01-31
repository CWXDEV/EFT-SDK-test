using System;
using System.Runtime.CompilerServices;
using EFT.CameraControl;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200095F RID: 2399
public class ScopePrefabCache : MonoBehaviour
{
	// Token: 0x17000944 RID: 2372
	// (get) Token: 0x0600363E RID: 13886 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600363F RID: 13887 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasOptics
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

	// Token: 0x17000945 RID: 2373
	// (get) Token: 0x06003640 RID: 13888 RVA: 0x00002050 File Offset: 0x00000250
	public bool CurrentModHasOptics
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000946 RID: 2374
	// (get) Token: 0x06003641 RID: 13889 RVA: 0x00002050 File Offset: 0x00000250
	public bool CurrentModIgnoreOpticsForCameraPlane
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000947 RID: 2375
	// (get) Token: 0x06003642 RID: 13890 RVA: 0x00002050 File Offset: 0x00000250
	public OpticSight CurrentModOpticSight
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003643 RID: 13891 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public OpticSight GetOpticSight(int index)
	{
		throw null;
	}

	// Token: 0x06003644 RID: 13892 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ScopePrefabCache.ScopeModeInfo GetScopeModeInfo(int index)
	{
		throw null;
	}

	// Token: 0x17000948 RID: 2376
	// (get) Token: 0x06003645 RID: 13893 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003646 RID: 13894 RVA: 0x00002050 File Offset: 0x00000250
	public bool HasCollimators
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

	// Token: 0x17000949 RID: 2377
	// (get) Token: 0x06003647 RID: 13895 RVA: 0x00002050 File Offset: 0x00000250
	public int ModesCount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700094A RID: 2378
	// (get) Token: 0x06003648 RID: 13896 RVA: 0x00002050 File Offset: 0x00000250
	public OpticSight FirstOptic
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700094B RID: 2379
	// (get) Token: 0x06003649 RID: 13897 RVA: 0x00002050 File Offset: 0x00000250
	public CollimatorSight FirstCollimator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x1700094C RID: 2380
	// (get) Token: 0x0600364A RID: 13898 RVA: 0x00002050 File Offset: 0x00000250
	public int CurrentModeId
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600364B RID: 13899 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600364C RID: 13900 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RotateToAngleByDistance(float distance)
	{
		throw null;
	}

	// Token: 0x0600364D RID: 13901 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_0(float distance, out float angle)
	{
		throw null;
	}

	// Token: 0x0600364E RID: 13902 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOpticBone(Transform bone)
	{
		throw null;
	}

	// Token: 0x0600364F RID: 13903 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetMode(int modeId)
	{
		throw null;
	}

	// Token: 0x06003650 RID: 13904 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookAt(Vector3 point, Vector3 worldUp)
	{
		throw null;
	}

	// Token: 0x06003651 RID: 13905 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LookAtCollimatorOnly(Vector3 point, Vector3 worldUp)
	{
		throw null;
	}

	// Token: 0x06003652 RID: 13906 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Transform GetLensCenter()
	{
		throw null;
	}

	// Token: 0x06003653 RID: 13907 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetLocalCollimatorCameraTarget(Vector3 worldCameraTarget)
	{
		throw null;
	}

	// Token: 0x06003654 RID: 13908 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetLocalOpticCameraTarget(Vector3 worldCameraTarget)
	{
		throw null;
	}

	// Token: 0x06003655 RID: 13909 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetLensTransformForward()
	{
		throw null;
	}

	// Token: 0x06003656 RID: 13910 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetCollimatorWorldCameraPosition(Vector3 localCameraTarget)
	{
		throw null;
	}

	// Token: 0x06003657 RID: 13911 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector3 GetOpticsWorldCameraPosition(Vector3 localCameraTarget)
	{
		throw null;
	}

	// Token: 0x06003658 RID: 13912 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetAnyOpticsDistanceToCamera()
	{
		throw null;
	}

	// Token: 0x0400373B RID: 14139
	[SerializeField]
	public bool CanChangeAngleByDistance;

	// Token: 0x0400373C RID: 14140
	[SerializeField]
	public Transform WeaponScopeAxis;

	// Token: 0x0400373D RID: 14141
	[SerializeField]
	public ScopePrefabCache.DistaneAngle[] AngleByRange;

	// Token: 0x0400373E RID: 14142
	private const string string_0 = "mode_";

	// Token: 0x0400373F RID: 14143
	[SerializeField]
	private ScopePrefabCache.ScopeModeInfo[] _scopeModeInfos;

	// Token: 0x04003740 RID: 14144
	private int int_0;

	// Token: 0x04003741 RID: 14145
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x04003742 RID: 14146
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x02000960 RID: 2400
	[Serializable]
	public class ScopeModeInfo
	{
		// Token: 0x04003743 RID: 14147
		public GameObject ModeGameObject;

		// Token: 0x04003744 RID: 14148
		public CollimatorSight CollimatorSight;

		// Token: 0x04003745 RID: 14149
		public OpticSight OpticSight;

		// Token: 0x04003746 RID: 14150
		public bool IgnoreOpticsForCameraPlane;
	}

	// Token: 0x02000961 RID: 2401
	[Serializable]
	public struct DistaneAngle
	{
		// Token: 0x04003747 RID: 14151
		public float Distance;

		// Token: 0x04003748 RID: 14152
		public float Angle;
	}

	// Token: 0x02000962 RID: 2402
	[CompilerGenerated]
	[Serializable]
	private sealed class Class503
	{
		// Token: 0x06003659 RID: 13913 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(ScopePrefabCache.ScopeModeInfo sm)
		{
			throw null;
		}

		// Token: 0x0600365A RID: 13914 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(ScopePrefabCache.ScopeModeInfo sm)
		{
			throw null;
		}

		// Token: 0x04003749 RID: 14153
		public static readonly ScopePrefabCache.Class503 class503_0;

		// Token: 0x0400374A RID: 14154
		public static Func<ScopePrefabCache.ScopeModeInfo, bool> func_0;

		// Token: 0x0400374B RID: 14155
		public static Func<ScopePrefabCache.ScopeModeInfo, bool> func_1;
	}
}
