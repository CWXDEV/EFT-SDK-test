using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000B2C RID: 2860
[DefaultExecutionOrder(100)]
[RequireComponent(typeof(Renderer))]
public class HotObject : MonoBehaviour
{
	// Token: 0x17000A03 RID: 2563
	// (get) Token: 0x06003DEC RID: 15852 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000A04 RID: 2564
	// (get) Token: 0x06003DED RID: 15853 RVA: 0x00002050 File Offset: 0x00000250
	private float Single_1
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003DEE RID: 15854 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003DEF RID: 15855 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06003DF0 RID: 15856 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float ConvertHeat2Celsio(float heatTemp)
	{
		throw null;
	}

	// Token: 0x06003DF1 RID: 15857 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_1(float celcio)
	{
		throw null;
	}

	// Token: 0x06003DF2 RID: 15858 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private float method_2(float celcio)
	{
		throw null;
	}

	// Token: 0x06003DF3 RID: 15859 RVA: 0x00002050 File Offset: 0x00000250
	[ContextMenu("SetTemperatureToRenderer")]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void DebugSetTemperatureToRenderer()
	{
		throw null;
	}

	// Token: 0x06003DF4 RID: 15860 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTemperatureToRenderer()
	{
		throw null;
	}

	// Token: 0x06003DF5 RID: 15861 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetTemperatureToRenderer(float temperatureCelsio, bool force = false)
	{
		throw null;
	}

	// Token: 0x06003DF6 RID: 15862 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool NeedProcessEffects(Vector3 camPos, Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06003DF7 RID: 15863 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualSyncEffects()
	{
		throw null;
	}

	// Token: 0x06003DF8 RID: 15864 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncPosition()
	{
		throw null;
	}

	// Token: 0x06003DF9 RID: 15865 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void PrepareForEffects()
	{
		throw null;
	}

	// Token: 0x040044B2 RID: 17586
	[Header("Выставляет температуру конкретному объекту")]
	[Tooltip("Применить ко всем материалам на Renderer")]
	[SerializeField]
	public bool IsApplyAllMaterials;

	// Token: 0x040044B3 RID: 17587
	[SerializeField]
	[Tooltip("(min, max, factor)")]
	public Vector3 Temperature;

	// Token: 0x040044B4 RID: 17588
	[SerializeField]
	[Tooltip("Множитель Temperature.z для управления температуры из скрипта")]
	public float TemperatureCelsio;

	// Token: 0x040044B5 RID: 17589
	[SerializeField]
	[Tooltip("Порядковый номер материала в Renderer к которым необходимо применить температуру")]
	private List<int> materialsId;

	// Token: 0x040044B6 RID: 17590
	[SerializeField]
	public Bounds HeatBounds;

	// Token: 0x040044B7 RID: 17591
	[SerializeField]
	public float VisibleHeatAlpha;

	// Token: 0x040044B8 RID: 17592
	[Header("Эффект HeatHaze")]
	[SerializeField]
	[Space]
	public bool UseHeatHaze;

	// Token: 0x040044B9 RID: 17593
	[SerializeField]
	public Bounds HeatHazeBounds;

	// Token: 0x040044BA RID: 17594
	[SerializeField]
	private Vector2 HeatParticleLifetimeDelta;

	// Token: 0x040044BB RID: 17595
	[SerializeField]
	private AnimationCurve HeatParticleCountByTemp;

	// Token: 0x040044BC RID: 17596
	[SerializeField]
	private AnimationCurve HeatParticleLifeTimeByTemp;

	// Token: 0x040044BD RID: 17597
	[SerializeField]
	private AnimationCurve HeatParticleSizeByTemp;

	// Token: 0x040044BE RID: 17598
	private const float float_0 = 0.5f;

	// Token: 0x040044BF RID: 17599
	private const float float_1 = 5f;

	// Token: 0x040044C0 RID: 17600
	private const float float_2 = 4f;

	// Token: 0x040044C1 RID: 17601
	private static readonly int int_0;

	// Token: 0x040044C2 RID: 17602
	private static readonly int int_1;

	// Token: 0x040044C3 RID: 17603
	private static readonly int int_2;

	// Token: 0x040044C4 RID: 17604
	private static readonly int int_3;

	// Token: 0x040044C5 RID: 17605
	private static readonly int int_4;

	// Token: 0x040044C6 RID: 17606
	private static readonly int int_5;

	// Token: 0x040044C7 RID: 17607
	private static readonly int int_6;

	// Token: 0x040044C8 RID: 17608
	private static readonly int int_7;

	// Token: 0x040044C9 RID: 17609
	private static readonly string string_0;

	// Token: 0x040044CA RID: 17610
	private MaterialPropertyBlock materialPropertyBlock_0;

	// Token: 0x040044CB RID: 17611
	private Renderer renderer_0;

	// Token: 0x040044CC RID: 17612
	private Vector3 vector3_0;

	// Token: 0x040044CD RID: 17613
	private int int_8;

	// Token: 0x040044CE RID: 17614
	private float float_3;

	// Token: 0x040044CF RID: 17615
	private int int_9;

	// Token: 0x040044D0 RID: 17616
	private Transform transform_0;

	// Token: 0x040044D1 RID: 17617
	private float float_4;

	// Token: 0x040044D2 RID: 17618
	private float float_5;

	// Token: 0x040044D3 RID: 17619
	private float float_6;

	// Token: 0x040044D4 RID: 17620
	private float float_7;

	// Token: 0x040044D5 RID: 17621
	private bool bool_0;
}
