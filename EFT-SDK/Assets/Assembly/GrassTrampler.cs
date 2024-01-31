using System;
using System.Runtime.CompilerServices;
using EFT;
using UnityEngine;

// Token: 0x02000A84 RID: 2692
public class GrassTrampler : MonoBehaviour
{
	// Token: 0x170009C9 RID: 2505
	// (get) Token: 0x06003B50 RID: 15184 RVA: 0x00002050 File Offset: 0x00000250
	private Player Player_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170009CA RID: 2506
	// (get) Token: 0x06003B51 RID: 15185 RVA: 0x00002050 File Offset: 0x00000250
	private EPlayerPose EPlayerPose_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06003B54 RID: 15188 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003B55 RID: 15189 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private GrassValues method_1()
	{
		throw null;
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_3(float startTimeOfMove, float delta)
	{
		throw null;
	}

	// Token: 0x06003B58 RID: 15192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_4(float startTimeOfMove, float delta)
	{
		throw null;
	}

	// Token: 0x04003FA8 RID: 16296
	[SerializeField]
	private AnimationCurve _angleCurve;

	// Token: 0x04003FA9 RID: 16297
	[SerializeField]
	public float TransitionTimeBetweenStates;

	// Token: 0x04003FAA RID: 16298
	[SerializeField]
	public GrassValues StandGrassValues;

	// Token: 0x04003FAB RID: 16299
	[SerializeField]
	public GrassValues DuckGrassValues;

	// Token: 0x04003FAC RID: 16300
	[SerializeField]
	public GrassValues ProneGrassValues;

	// Token: 0x04003FAD RID: 16301
	private const string string_0 = "_GrassPlayerPosition";

	// Token: 0x04003FAE RID: 16302
	private const string string_1 = "_GrassPlayerDirection";

	// Token: 0x04003FAF RID: 16303
	private const string string_2 = "_GrassValues";

	// Token: 0x04003FB0 RID: 16304
	private AnimationCurve animationCurve_0;

	// Token: 0x04003FB1 RID: 16305
	private GrassValues grassValues_0;

	// Token: 0x04003FB2 RID: 16306
	private Vector3 vector3_0;

	// Token: 0x04003FB3 RID: 16307
	private Vector3 vector3_1;

	// Token: 0x04003FB4 RID: 16308
	private Vector3 vector3_2;

	// Token: 0x04003FB5 RID: 16309
	private EPlayerPose eplayerPose_0;

	// Token: 0x04003FB6 RID: 16310
	private bool bool_0;

	// Token: 0x04003FB7 RID: 16311
	private float float_0;

	// Token: 0x04003FB8 RID: 16312
	private float float_1;

	// Token: 0x04003FB9 RID: 16313
	private float float_2;

	// Token: 0x04003FBA RID: 16314
	private float float_3;

	// Token: 0x04003FBB RID: 16315
	private float float_4;

	// Token: 0x04003FBC RID: 16316
	private float float_5;

	// Token: 0x04003FBD RID: 16317
	private GrassValues grassValues_1;

	// Token: 0x04003FBE RID: 16318
	private float float_6;
}
