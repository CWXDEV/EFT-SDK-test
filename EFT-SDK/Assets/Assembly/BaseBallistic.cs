using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x020005B4 RID: 1460
public class BaseBallistic : MonoBehaviour
{
	// Token: 0x06002225 RID: 8741 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BaseBallistic.ESurfaceSound GetSurfaceSound(Vector3 position)
	{
		throw null;
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual BallisticCollider Get(Vector3 pos)
	{
		throw null;
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Associate(MaterialType typeOfMaterial)
	{
		throw null;
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TakeSettingsFrom(BaseBallistic collider)
	{
		throw null;
	}

	// Token: 0x04002135 RID: 8501
	[HideInInspector]
	public BaseBallistic.ESurfaceSound SurfaceSound;

	// Token: 0x020005B5 RID: 1461
	public enum ESurfaceSound
	{
		// Token: 0x04002137 RID: 8503
		Concrete,
		// Token: 0x04002138 RID: 8504
		Metal,
		// Token: 0x04002139 RID: 8505
		Wood,
		// Token: 0x0400213A RID: 8506
		Soil,
		// Token: 0x0400213B RID: 8507
		Grass,
		// Token: 0x0400213C RID: 8508
		Asphalt,
		// Token: 0x0400213D RID: 8509
		Glass,
		// Token: 0x0400213E RID: 8510
		Gravel,
		// Token: 0x0400213F RID: 8511
		MetalThin,
		// Token: 0x04002140 RID: 8512
		Puddle,
		// Token: 0x04002141 RID: 8513
		Slate,
		// Token: 0x04002142 RID: 8514
		Tile,
		// Token: 0x04002143 RID: 8515
		WoodThick,
		// Token: 0x04002144 RID: 8516
		Swamp,
		// Token: 0x04002145 RID: 8517
		Garbage,
		// Token: 0x04002146 RID: 8518
		GarbageMetal,
		// Token: 0x04002147 RID: 8519
		Plastic,
		// Token: 0x04002148 RID: 8520
		WholeGlass,
		// Token: 0x04002149 RID: 8521
		WoodThin,
		// Token: 0x0400214A RID: 8522
		Snow
	}
}
