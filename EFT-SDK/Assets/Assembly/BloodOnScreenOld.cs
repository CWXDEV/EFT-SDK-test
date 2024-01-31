using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000A3F RID: 2623
[Obsolete]
public sealed class BloodOnScreenOld : Posteffect
{
	// Token: 0x17000993 RID: 2451
	// (get) Token: 0x06003993 RID: 14739 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x06003994 RID: 14740 RVA: 0x00002050 File Offset: 0x00000250
	public float Cutout
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

	// Token: 0x17000994 RID: 2452
	// (get) Token: 0x06003995 RID: 14741 RVA: 0x00002050 File Offset: 0x00000250
	public int TextureSetsAmount
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003996 RID: 14742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x06003997 RID: 14743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTexture(int setNumber)
	{
		throw null;
	}

	// Token: 0x06003998 RID: 14744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnRenderImage(RenderTexture source, RenderTexture destanation)
	{
		throw null;
	}

	// Token: 0x04003C68 RID: 15464
	[SerializeField]
	[Header("Blood")]
	private BloodOnScreenOld.BloodData[] _bloodData;

	// Token: 0x04003C69 RID: 15465
	[SerializeField]
	private string _dudvPropertyName;

	// Token: 0x04003C6A RID: 15466
	[SerializeField]
	private string _bloodPropertyName;

	// Token: 0x04003C6B RID: 15467
	[SerializeField]
	private string _bloodAmountPropertyName;

	// Token: 0x04003C6C RID: 15468
	[SerializeField]
	private string _cutoutPropertyName;

	// Token: 0x04003C6D RID: 15469
	[Range(0f, 1f)]
	[SerializeField]
	private float _cutout;

	// Token: 0x04003C6E RID: 15470
	[Range(0f, 1f)]
	[SerializeField]
	private float _bloodTextureAmount;

	// Token: 0x04003C6F RID: 15471
	[SerializeField]
	[Range(0f, 1f)]
	[Header("Refraction")]
	private float _refraction;

	// Token: 0x04003C70 RID: 15472
	[SerializeField]
	private string _refractionPropertyName;

	// Token: 0x04003C71 RID: 15473
	[Range(0f, 4f)]
	[SerializeField]
	[Header("Downsampling")]
	private int _downsampling;

	// Token: 0x04003C72 RID: 15474
	[Header("Color corection")]
	[HideInInspector]
	[SerializeField]
	public int Mode;

	// Token: 0x04003C73 RID: 15475
	[HideInInspector]
	[SerializeField]
	public float InputMinL;

	// Token: 0x04003C74 RID: 15476
	[HideInInspector]
	[SerializeField]
	public float InputMaxL;

	// Token: 0x04003C75 RID: 15477
	[SerializeField]
	[HideInInspector]
	public float InputGammaL;

	// Token: 0x04003C76 RID: 15478
	[HideInInspector]
	[SerializeField]
	public float InputMinR;

	// Token: 0x04003C77 RID: 15479
	[HideInInspector]
	[SerializeField]
	public float InputMaxR;

	// Token: 0x04003C78 RID: 15480
	[SerializeField]
	[HideInInspector]
	public float InputGammaR;

	// Token: 0x04003C79 RID: 15481
	[HideInInspector]
	[SerializeField]
	public float InputMinG;

	// Token: 0x04003C7A RID: 15482
	[HideInInspector]
	[SerializeField]
	public float InputMaxG;

	// Token: 0x04003C7B RID: 15483
	[SerializeField]
	[HideInInspector]
	public float InputGammaG;

	// Token: 0x04003C7C RID: 15484
	[SerializeField]
	[HideInInspector]
	public float InputMinB;

	// Token: 0x04003C7D RID: 15485
	[HideInInspector]
	[SerializeField]
	public float InputMaxB;

	// Token: 0x04003C7E RID: 15486
	[HideInInspector]
	[SerializeField]
	public float InputGammaB;

	// Token: 0x04003C7F RID: 15487
	[HideInInspector]
	[SerializeField]
	public float OutputMinL;

	// Token: 0x04003C80 RID: 15488
	[SerializeField]
	[HideInInspector]
	public float OutputMaxL;

	// Token: 0x04003C81 RID: 15489
	[HideInInspector]
	[SerializeField]
	public float OutputMinR;

	// Token: 0x04003C82 RID: 15490
	[SerializeField]
	[HideInInspector]
	public float OutputMaxR;

	// Token: 0x04003C83 RID: 15491
	[SerializeField]
	[HideInInspector]
	public float OutputMinG;

	// Token: 0x04003C84 RID: 15492
	[SerializeField]
	[HideInInspector]
	public float OutputMaxG;

	// Token: 0x04003C85 RID: 15493
	[HideInInspector]
	[SerializeField]
	public float OutputMinB;

	// Token: 0x04003C86 RID: 15494
	[HideInInspector]
	[SerializeField]
	public float OutputMaxB;

	// Token: 0x04003C87 RID: 15495
	private Dictionary<int, BloodOnScreenOld.BloodData> dictionary_0;

	// Token: 0x04003C88 RID: 15496
	private static readonly int int_0;

	// Token: 0x04003C89 RID: 15497
	private static readonly int int_1;

	// Token: 0x04003C8A RID: 15498
	private static readonly int int_2;

	// Token: 0x04003C8B RID: 15499
	private static readonly int int_3;

	// Token: 0x04003C8C RID: 15500
	private static readonly int int_4;

	// Token: 0x04003C8D RID: 15501
	private static readonly int int_5;

	// Token: 0x02000A40 RID: 2624
	[Serializable]
	public struct BloodData
	{
		// Token: 0x04003C8E RID: 15502
		public Texture DuDv;

		// Token: 0x04003C8F RID: 15503
		public Texture Blood;
	}
}
