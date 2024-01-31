using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009E5 RID: 2533
public class RadialLayoutGroup : LayoutGroup
{
	// Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003835 RID: 14389 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayoutHorizontal()
	{
		throw null;
	}

	// Token: 0x06003836 RID: 14390 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLayoutVertical()
	{
		throw null;
	}

	// Token: 0x06003837 RID: 14391 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CalculateLayoutInputVertical()
	{
		throw null;
	}

	// Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void CalculateLayoutInputHorizontal()
	{
		throw null;
	}

	// Token: 0x06003839 RID: 14393 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x040039F6 RID: 14838
	[SerializeField]
	private float _fDistance;

	// Token: 0x040039F7 RID: 14839
	[Range(0f, 360f)]
	[SerializeField]
	private float _minAngle;

	// Token: 0x040039F8 RID: 14840
	[Range(0f, 360f)]
	[SerializeField]
	private float _maxAngle;

	// Token: 0x040039F9 RID: 14841
	[Range(0f, 360f)]
	public float StartAngle;
}
