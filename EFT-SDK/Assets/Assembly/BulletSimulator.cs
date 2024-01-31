using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EFT.Ballistics;
using EFT.InventoryLogic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200082B RID: 2091
public class BulletSimulator : MonoBehaviour
{
	// Token: 0x06002FDD RID: 12253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task Start()
	{
		throw null;
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Task smethod_0()
	{
		throw null;
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SimulateShot()
	{
		throw null;
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnShotFinishedHandler(GClass2988 shot)
	{
		throw null;
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Update()
	{
		throw null;
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4()
	{
		throw null;
	}

	// Token: 0x06002FE7 RID: 12263 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5(float value)
	{
		throw null;
	}

	// Token: 0x06002FE8 RID: 12264 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6()
	{
		throw null;
	}

	// Token: 0x06002FE9 RID: 12265 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnDrawGizmos()
	{
		throw null;
	}

	// Token: 0x04002F1E RID: 12062
	private BallisticsCalculator ballisticsCalculator_0;

	// Token: 0x04002F1F RID: 12063
	private GClass2988 gclass2988_0;

	// Token: 0x04002F20 RID: 12064
	private Text text_0;

	// Token: 0x04002F21 RID: 12065
	[Header("Ammo data")]
	public AmmoTemplate AmmoTemplate;

	// Token: 0x04002F22 RID: 12066
	public BulletClass Ammo;

	// Token: 0x04002F23 RID: 12067
	[Header("Aiming data")]
	public float MaxDistance;

	// Token: 0x04002F24 RID: 12068
	public float CurrentDistance;

	// Token: 0x04002F25 RID: 12069
	public float DistanceStep;

	// Token: 0x04002F26 RID: 12070
	[Header("Simulation data")]
	public float SimulationStep;

	// Token: 0x04002F27 RID: 12071
	public float SimulationTime;

	// Token: 0x04002F28 RID: 12072
	public float MarkerScaleStep;

	// Token: 0x04002F29 RID: 12073
	private GameObject gameObject_0;
}
