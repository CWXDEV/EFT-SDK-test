using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x0200006F RID: 111
[ExecuteInEditMode]
[AddComponentMenu("Colorful/Glitch")]
public class CC_Glitch : CC_Base
{
	// Token: 0x17000104 RID: 260
	// (get) Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsActive
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnEnable()
	{
		throw null;
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Start()
	{
		throw null;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void Update()
	{
		throw null;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		throw null;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoInterferences(RenderTexture source, RenderTexture destination, CC_Glitch.InterferenceSettings settings)
	{
		throw null;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void DoTearing(RenderTexture source, RenderTexture destination, CC_Glitch.TearingSettings settings)
	{
		throw null;
	}

	// Token: 0x040001BF RID: 447
	public bool randomActivation;

	// Token: 0x040001C0 RID: 448
	public Vector2 randomEvery;

	// Token: 0x040001C1 RID: 449
	public Vector2 randomDuration;

	// Token: 0x040001C2 RID: 450
	public CC_Glitch.Mode mode;

	// Token: 0x040001C3 RID: 451
	public CC_Glitch.InterferenceSettings interferencesSettings;

	// Token: 0x040001C4 RID: 452
	public CC_Glitch.TearingSettings tearingSettings;

	// Token: 0x040001C5 RID: 453
	protected Camera m_Camera;

	// Token: 0x040001C6 RID: 454
	protected bool m_Activated;

	// Token: 0x040001C7 RID: 455
	protected float m_EveryTimer;

	// Token: 0x040001C8 RID: 456
	protected float m_EveryTimerEnd;

	// Token: 0x040001C9 RID: 457
	protected float m_DurationTimer;

	// Token: 0x040001CA RID: 458
	protected float m_DurationTimerEnd;

	// Token: 0x040001CB RID: 459
	private static readonly int int_0;

	// Token: 0x02000070 RID: 112
	public enum Mode
	{
		// Token: 0x040001CD RID: 461
		Interferences,
		// Token: 0x040001CE RID: 462
		Tearing,
		// Token: 0x040001CF RID: 463
		Complete
	}

	// Token: 0x02000071 RID: 113
	[Serializable]
	public class InterferenceSettings
	{
		// Token: 0x040001D0 RID: 464
		public float speed;

		// Token: 0x040001D1 RID: 465
		public float density;

		// Token: 0x040001D2 RID: 466
		public float maxDisplacement;
	}

	// Token: 0x02000072 RID: 114
	[Serializable]
	public class TearingSettings
	{
		// Token: 0x040001D3 RID: 467
		public float speed;

		// Token: 0x040001D4 RID: 468
		[Range(0f, 1f)]
		public float intensity;

		// Token: 0x040001D5 RID: 469
		[Range(0f, 0.5f)]
		public float maxDisplacement;

		// Token: 0x040001D6 RID: 470
		public bool allowFlipping;

		// Token: 0x040001D7 RID: 471
		public bool yuvColorBleeding;

		// Token: 0x040001D8 RID: 472
		[Range(-2f, 2f)]
		public float yuvOffset;
	}
}
