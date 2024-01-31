using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B0E RID: 2830
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class Posteffect : MonoBehaviour
{
	// Token: 0x170009FE RID: 2558
	// (get) Token: 0x06003D75 RID: 15733 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003D76 RID: 15734 RVA: 0x00002050 File Offset: 0x00000250
	public float EffectAmount
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

	// Token: 0x06003D77 RID: 15735 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Start()
	{
		throw null;
	}

	// Token: 0x06003D78 RID: 15736 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destanation)
	{
		throw null;
	}

	// Token: 0x040043BE RID: 17342
	[SerializeField]
	protected Shader EffectShader;

	// Token: 0x040043BF RID: 17343
	[SerializeField]
	protected string EffectValueName;

	// Token: 0x040043C0 RID: 17344
	[SerializeField]
	[Range(0f, 1f)]
	private float _effectAmount;

	// Token: 0x040043C1 RID: 17345
	protected Material EffectMaterial;
}
