using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A78 RID: 2680
[RequireComponent(typeof(Camera))]
public class InventoryBlur : MonoBehaviour
{
	// Token: 0x06003AFC RID: 15100 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003AFD RID: 15101 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Enable(float time = 0.5f)
	{
		throw null;
	}

	// Token: 0x06003AFE RID: 15102 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Disable()
	{
		throw null;
	}

	// Token: 0x06003AFF RID: 15103 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06003B00 RID: 15104 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x04003E82 RID: 16002
	[Header("Blur Setup")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _value;

	// Token: 0x04003E83 RID: 16003
	[SerializeField]
	private Material _material;

	// Token: 0x04003E84 RID: 16004
	[SerializeField]
	private InventoryBlur.Dimensions _upsampleTexDimension;

	// Token: 0x04003E85 RID: 16005
	[SerializeField]
	private InventoryBlur.Dimensions _downsampleTexDimension;

	// Token: 0x04003E86 RID: 16006
	[Range(1f, 8f)]
	[SerializeField]
	private int _blurCount;

	// Token: 0x04003E87 RID: 16007
	private float float_0;

	// Token: 0x04003E88 RID: 16008
	private bool bool_0;

	// Token: 0x04003E89 RID: 16009
	private static readonly int int_0;

	// Token: 0x04003E8A RID: 16010
	private static readonly int int_1;

	// Token: 0x04003E8B RID: 16011
	private SSAAPropagator ssaapropagator_0;

	// Token: 0x02000A79 RID: 2681
	[Serializable]
	public enum Dimensions
	{
		// Token: 0x04003E8D RID: 16013
		_128 = 128,
		// Token: 0x04003E8E RID: 16014
		_256 = 256,
		// Token: 0x04003E8F RID: 16015
		_512 = 512,
		// Token: 0x04003E90 RID: 16016
		_1024 = 1024,
		// Token: 0x04003E91 RID: 16017
		_2048 = 2048
	}
}
