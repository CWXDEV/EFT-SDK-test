using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AmplifyMotion;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x0200005E RID: 94
[AddComponentMenu("")]
public class AmplifyMotionObjectBase : MonoBehaviour
{
	// Token: 0x170000FF RID: 255
	// (get) Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
	internal bool Boolean_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
	internal int Int32_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
	public ObjectType Type
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_0(AmplifyMotionCamera camera)
	{
		throw null;
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_1(AmplifyMotionCamera camera)
	{
		throw null;
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private bool method_2()
	{
		throw null;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_0(Transform transform, AmplifyMotionObjectBase obj, int frame)
	{
		throw null;
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetMotionNow()
	{
		throw null;
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ResetMotionAtFrame(int frame)
	{
		throw null;
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(AmplifyMotionEffectBase inst)
	{
		throw null;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_5(AmplifyMotionEffectBase inst, Camera camera, CommandBuffer updateCB, bool starting)
	{
		throw null;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void method_6(Camera camera, CommandBuffer renderCB, float scale, Quality quality)
	{
		throw null;
	}

	// Token: 0x0400013F RID: 319
	internal static bool bool_0;

	// Token: 0x04000140 RID: 320
	[SerializeField]
	private bool m_applyToChildren;

	// Token: 0x04000141 RID: 321
	private ObjectType objectType_0;

	// Token: 0x04000142 RID: 322
	private Dictionary<Camera, MotionState> dictionary_0;

	// Token: 0x04000143 RID: 323
	private bool bool_1;

	// Token: 0x04000144 RID: 324
	private int int_0;

	// Token: 0x04000145 RID: 325
	private Vector3 vector3_0;

	// Token: 0x04000146 RID: 326
	private int int_1;

	// Token: 0x0200005F RID: 95
	public enum MinMaxCurveState
	{
		// Token: 0x04000148 RID: 328
		Scalar,
		// Token: 0x04000149 RID: 329
		Curve,
		// Token: 0x0400014A RID: 330
		TwoCurves,
		// Token: 0x0400014B RID: 331
		TwoScalars
	}
}
