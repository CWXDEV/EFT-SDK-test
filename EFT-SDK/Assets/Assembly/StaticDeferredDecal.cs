using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A51 RID: 2641
[ExecuteInEditMode]
public class StaticDeferredDecal : MonoBehaviour
{
	// Token: 0x170009A6 RID: 2470
	// (get) Token: 0x060039F1 RID: 14833 RVA: 0x00002050 File Offset: 0x00000250
	public int DecalQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170009A7 RID: 2471
	// (get) Token: 0x060039F2 RID: 14834 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039F3 RID: 14835 RVA: 0x00002050 File Offset: 0x00000250
	public Material DecalMaterial
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x140000C5 RID: 197
	// (add) Token: 0x060039F4 RID: 14836 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060039F5 RID: 14837 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<StaticDeferredDecal, bool> OnDecalRegister
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

	// Token: 0x140000C6 RID: 198
	// (add) Token: 0x060039F6 RID: 14838 RVA: 0x00002050 File Offset: 0x00000250
	// (remove) Token: 0x060039F7 RID: 14839 RVA: 0x00002050 File Offset: 0x00000250
	public static event Action<StaticDeferredDecal, bool> OnDecalUnregister
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

	// Token: 0x170009A8 RID: 2472
	// (get) Token: 0x060039F8 RID: 14840 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060039F9 RID: 14841 RVA: 0x00002050 File Offset: 0x00000250
	public Texture2D Tex
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

	// Token: 0x170009A9 RID: 2473
	// (get) Token: 0x060039FA RID: 14842 RVA: 0x00002050 File Offset: 0x00000250
	public Color Tint
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Awake()
	{
		throw null;
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4 GetUVStartEnd()
	{
		throw null;
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vector4 GetNormalEdgeClipAndFadeoff()
	{
		throw null;
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnEnable()
	{
		throw null;
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void OnDisable()
	{
		throw null;
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Refresh()
	{
		throw null;
	}

	// Token: 0x04003D0D RID: 15629
	[HideInInspector]
	public Vector2 LowerLeftPixel;

	// Token: 0x04003D0E RID: 15630
	[HideInInspector]
	public Vector2 UpperRightPixel;

	// Token: 0x04003D0F RID: 15631
	[SerializeField]
	public Material _material;

	// Token: 0x04003D10 RID: 15632
	[Range(0f, 9f)]
	[SerializeField]
	private int _decalQueue;

	// Token: 0x04003D11 RID: 15633
	[SerializeField]
	[Range(-1f, 1f)]
	private float _normalClip;

	// Token: 0x04003D12 RID: 15634
	[SerializeField]
	private float _normalAlphaFadeoff;

	// Token: 0x04003D13 RID: 15635
	[SerializeField]
	[Range(0f, 1f)]
	private float _edgeClip;

	// Token: 0x04003D14 RID: 15636
	[SerializeField]
	private float _edgeAlphaFadeoff;

	// Token: 0x04003D15 RID: 15637
	[SerializeField]
	private Color _tint;

	// Token: 0x04003D16 RID: 15638
	private Action action_0;

	// Token: 0x04003D17 RID: 15639
	private Action action_1;

	// Token: 0x04003D18 RID: 15640
	private Vector3 vector3_0;

	// Token: 0x04003D19 RID: 15641
	private Quaternion quaternion_0;

	// Token: 0x04003D1A RID: 15642
	private Vector3 vector3_1;

	// Token: 0x04003D1B RID: 15643
	[CompilerGenerated]
	private static Action<StaticDeferredDecal, bool> action_2;

	// Token: 0x04003D1C RID: 15644
	[CompilerGenerated]
	private static Action<StaticDeferredDecal, bool> action_3;

	// Token: 0x04003D1D RID: 15645
	private static readonly int int_0;

	// Token: 0x04003D1E RID: 15646
	private static readonly int int_1;

	// Token: 0x04003D1F RID: 15647
	private static readonly int int_2;

	// Token: 0x04003D20 RID: 15648
	[CompilerGenerated]
	private Texture2D texture2D_0;

	// Token: 0x04003D21 RID: 15649
	[HideInInspector]
	public Vector2 LastTexSize;
}
