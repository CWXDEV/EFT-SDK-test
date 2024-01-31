using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000AD4 RID: 2772
public class MuzzleManager : BaseSystemComponent<MuzzleManager>, GInterface38, GInterface40, GInterface41
{
	// Token: 0x170009EB RID: 2539
	// (get) Token: 0x06003C75 RID: 15477 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003C76 RID: 15478 RVA: 0x00002050 File Offset: 0x00000250
	public GameObject[] MuzzleJets
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

	// Token: 0x06003C77 RID: 15479 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualLateUpdate()
	{
		throw null;
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetT(float t)
	{
		throw null;
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LauncherShot()
	{
		throw null;
	}

	// Token: 0x06003C7D RID: 15485 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Shot(bool isVisible = true, float sqrCameraDistance = 0f)
	{
		throw null;
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface41.Emit(Vector3 position, Vector3 velocity, float time, float gravity, float drag, float lifeTime, byte emission, byte size, byte turbulence, byte frequency)
	{
		throw null;
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface40.Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
	{
		throw null;
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	void GInterface38.Emit(Vector3 position, float rotation, Vector3 velocity, float size, float lifetime, Color32 color)
	{
		throw null;
	}

	// Token: 0x06003C81 RID: 15489 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateJetsAndFumes()
	{
		throw null;
	}

	// Token: 0x06003C82 RID: 15490 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private T[] method_0<T>() where T : MonoBehaviour
	{
		throw null;
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06003C84 RID: 15492 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void LateUpdateMuzzleEffectsValues(Camera cam)
	{
		throw null;
	}

	// Token: 0x06003C85 RID: 15493 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(float t)
	{
		throw null;
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_4()
	{
		throw null;
	}

	// Token: 0x04004246 RID: 16966
	private const string string_0 = "Muzzle Light";

	// Token: 0x04004247 RID: 16967
	public Material JetMaterial;

	// Token: 0x04004248 RID: 16968
	public int AtlasXCount;

	// Token: 0x04004249 RID: 16969
	public int AtlasYCount;

	// Token: 0x0400424A RID: 16970
	public AnimationCurve MoveCurve;

	// Token: 0x0400424B RID: 16971
	public AnimationCurve JetLightCurve;

	// Token: 0x0400424C RID: 16972
	public float ShotLength;

	// Token: 0x0400424D RID: 16973
	public bool TestPlay;

	// Token: 0x0400424E RID: 16974
	public bool TestShoot;

	// Token: 0x0400424F RID: 16975
	public bool TestHold;

	// Token: 0x04004250 RID: 16976
	public float TestDebugPosition;

	// Token: 0x04004251 RID: 16977
	public float TestDelay;

	// Token: 0x04004252 RID: 16978
	public MuzzleLight Light;

	// Token: 0x04004253 RID: 16979
	public string MeshParentName;

	// Token: 0x04004254 RID: 16980
	private MuzzleJet[] muzzleJet_0;

	// Token: 0x04004255 RID: 16981
	private MuzzleSparks[] muzzleSparks_0;

	// Token: 0x04004256 RID: 16982
	private MuzzleFume[] muzzleFume_0;

	// Token: 0x04004257 RID: 16983
	private MuzzleFume[] muzzleFume_1;

	// Token: 0x04004258 RID: 16984
	private MuzzleSmoke[] muzzleSmoke_0;

	// Token: 0x04004259 RID: 16985
	private HeatEmitter[] heatEmitter_0;

	// Token: 0x0400425A RID: 16986
	private HeatHazeEmitter[] heatHazeEmitter_0;

	// Token: 0x0400425B RID: 16987
	private Vector2 vector2_0;

	// Token: 0x0400425C RID: 16988
	private float float_0;

	// Token: 0x0400425D RID: 16989
	public Transform Hierarchy;

	// Token: 0x0400425E RID: 16990
	private float float_1;

	// Token: 0x0400425F RID: 16991
	private static readonly int int_0;

	// Token: 0x04004260 RID: 16992
	private float float_2;

	// Token: 0x04004261 RID: 16993
	private float float_3;

	// Token: 0x04004262 RID: 16994
	private bool bool_0;

	// Token: 0x04004263 RID: 16995
	private bool bool_1;

	// Token: 0x04004264 RID: 16996
	[CompilerGenerated]
	private GameObject[] gameObject_0;

	// Token: 0x02000AD5 RID: 2773
	[CompilerGenerated]
	private sealed class Class555
	{
		// Token: 0x06003C88 RID: 15496 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(MuzzleEffect x)
		{
			throw null;
		}

		// Token: 0x04004265 RID: 16997
		public GameObject[] launcherGo;
	}

	// Token: 0x02000AD6 RID: 2774
	[CompilerGenerated]
	[Serializable]
	private sealed class Class556
	{
		// Token: 0x06003C89 RID: 15497 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GameObject method_0(MuzzleFume f)
		{
			throw null;
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal GameObject method_1(MuzzleEffect x)
		{
			throw null;
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_2(MuzzleJet x)
		{
			throw null;
		}

		// Token: 0x04004266 RID: 16998
		public static readonly MuzzleManager.Class556 class556_0;

		// Token: 0x04004267 RID: 16999
		public static Func<MuzzleFume, GameObject> func_0;

		// Token: 0x04004268 RID: 17000
		public static Func<MuzzleEffect, GameObject> func_1;

		// Token: 0x04004269 RID: 17001
		public static Func<MuzzleJet, float> func_2;
	}
}
