using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Jobs;
using UnityEngine;

// Token: 0x02000BB5 RID: 2997
[ExecuteInEditMode]
public class CullingManager : MonoBehaviour
{
	// Token: 0x17000A8C RID: 2700
	// (get) Token: 0x06004108 RID: 16648 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06004109 RID: 16649 RVA: 0x00002050 File Offset: 0x00000250
	public static CullingManager Instance
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

	// Token: 0x140000D4 RID: 212
	// (add) Token: 0x0600410A RID: 16650 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600410B RID: 16651 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action OnInstanceCreated
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x140000D5 RID: 213
	// (add) Token: 0x0600410C RID: 16652 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x0600410D RID: 16653 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action OnInstanceDestroyed
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		add
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		remove
		{
			throw null;
		}
	}

	// Token: 0x0600410E RID: 16654 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x0600410F RID: 16655 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x06004110 RID: 16656 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06004111 RID: 16657 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06004112 RID: 16658 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int Register(GInterface42 cullableObject)
	{
		throw null;
	}

	// Token: 0x06004113 RID: 16659 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void AddEarlyObject(GInterface42 cullableObject)
	{
		throw null;
	}

	// Token: 0x06004114 RID: 16660 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RemoveEarlyObject(GInterface42 cullableObject)
	{
		throw null;
	}

	// Token: 0x06004115 RID: 16661 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(GInterface42 cullableObject, int index)
	{
		throw null;
	}

	// Token: 0x06004116 RID: 16662 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Unregister(GInterface42 o)
	{
		throw null;
	}

	// Token: 0x06004117 RID: 16663 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06004118 RID: 16664 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Reload()
	{
		throw null;
	}

	// Token: 0x06004119 RID: 16665 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(Camera cam)
	{
		throw null;
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(Camera cam, CullingGroup cullingGroup, bool isOpticCam)
	{
		throw null;
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public float GetCameraDistanceSqr(int index)
	{
		throw null;
	}

	// Token: 0x0600411C RID: 16668 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsOpticEnabled()
	{
		throw null;
	}

	// Token: 0x0600411D RID: 16669 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSphere(GInterface42 cullingObject, int index)
	{
		throw null;
	}

	// Token: 0x0600411E RID: 16670 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateSphere(GInterface42 cullingObject)
	{
		throw null;
	}

	// Token: 0x0600411F RID: 16671 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06004120 RID: 16672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDestroy()
	{
		throw null;
	}

	// Token: 0x06004121 RID: 16673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06004122 RID: 16674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LockState(bool lockState)
	{
		throw null;
	}

	// Token: 0x06004123 RID: 16675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ForceEnable(bool enable)
	{
		throw null;
	}

	// Token: 0x06004124 RID: 16676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7()
	{
		throw null;
	}

	// Token: 0x06004125 RID: 16677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_8(Camera cam)
	{
		throw null;
	}

	// Token: 0x06004126 RID: 16678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9()
	{
		throw null;
	}

	// Token: 0x06004127 RID: 16679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x06004128 RID: 16680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11()
	{
		throw null;
	}

	// Token: 0x06004129 RID: 16681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12()
	{
		throw null;
	}

	// Token: 0x04004A3E RID: 19006
	private static CullingManager cullingManager_0;

	// Token: 0x04004A3F RID: 19007
	[CompilerGenerated]
	private static Action action_0;

	// Token: 0x04004A40 RID: 19008
	[CompilerGenerated]
	private static Action action_1;

	// Token: 0x04004A41 RID: 19009
	[SerializeField]
	private Camera _debugCamera;

	// Token: 0x04004A42 RID: 19010
	private const int int_0 = 10000;

	// Token: 0x04004A43 RID: 19011
	private int int_1;

	// Token: 0x04004A44 RID: 19012
	private readonly Dictionary<Camera, CullingGroup> dictionary_0;

	// Token: 0x04004A45 RID: 19013
	private readonly Queue<int> queue_0;

	// Token: 0x04004A46 RID: 19014
	private readonly BoundingSphere[] boundingSphere_0;

	// Token: 0x04004A47 RID: 19015
	private readonly List<int> list_0;

	// Token: 0x04004A48 RID: 19016
	private readonly CullingManager.GStruct60[] gstruct60_0;

	// Token: 0x04004A49 RID: 19017
	private static readonly List<GInterface42> list_1;

	// Token: 0x04004A4A RID: 19018
	private Camera camera_0;

	// Token: 0x04004A4B RID: 19019
	private bool bool_0;

	// Token: 0x04004A4C RID: 19020
	private List<JobHandle> list_2;

	// Token: 0x02000BB6 RID: 2998
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct60
	{
		// Token: 0x0600412A RID: 16682 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04004A4D RID: 19021
		public GInterface42 CullingObject;

		// Token: 0x04004A4E RID: 19022
		public float CullingDistanceSqr;

		// Token: 0x04004A4F RID: 19023
		public CullingManager.GStruct61 VisibilityData;

		// Token: 0x04004A50 RID: 19024
		public bool JobVisibilityFlag;
	}

	// Token: 0x02000BB7 RID: 2999
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct61
	{
		// Token: 0x0600412C RID: 16684 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool IsObjectVisible()
		{
			throw null;
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04004A51 RID: 19025
		public bool InOpticFructum;

		// Token: 0x04004A52 RID: 19026
		public bool InFpsFrustum;

		// Token: 0x04004A53 RID: 19027
		public bool IsCulledByDistance;

		// Token: 0x04004A54 RID: 19028
		public float CurrentCameraDistanceSqr;

		// Token: 0x04004A55 RID: 19029
		public bool IsAimingOn;

		// Token: 0x04004A56 RID: 19030
		public bool CullingByDistanceOnly;
	}

	// Token: 0x02000BB8 RID: 3000
	public sealed class GClass880
	{
		// Token: 0x0600412F RID: 16687 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool UpdateParameters()
		{
			throw null;
		}

		// Token: 0x04004A57 RID: 19031
		public GClass1870 CameraFrustrum;

		// Token: 0x04004A58 RID: 19032
		public Camera CameraInstance;

		// Token: 0x04004A59 RID: 19033
		public bool IsCameraEnabled;

		// Token: 0x04004A5A RID: 19034
		public Vector3 CameraPosition;

		// Token: 0x04004A5B RID: 19035
		public bool IsOpticCamera;

		// Token: 0x04004A5C RID: 19036
		public float FovMultiplicator;
	}

	// Token: 0x02000BB9 RID: 3001
	[StructLayout(LayoutKind.Auto)]
	public struct Struct122 : IJob
	{
		// Token: 0x06004131 RID: 16689 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Execute()
		{
			throw null;
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(CullingManager.GClass880 parameters)
		{
			throw null;
		}

		// Token: 0x04004A5D RID: 19037
		public static readonly Dictionary<int, CullingManager.GClass880> JobParameters;

		// Token: 0x04004A5E RID: 19038
		public int JobId;
	}
}
