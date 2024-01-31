using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.InventoryLogic;
using UnityEngine;

// Token: 0x0200070D RID: 1805
public class TacticalComboVisualController : MonoBehaviour
{
	// Token: 0x06002A18 RID: 10776 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Init()
	{
		throw null;
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateBeams(bool isYourPlayer = false)
	{
		throw null;
	}

	// Token: 0x06002A1B RID: 10779 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetPointOfView(EPointOfView pointOfView)
	{
		throw null;
	}

	// Token: 0x04002832 RID: 10290
	public const string DISABLED_TRANSFORM_NAME = "mode_000";

	// Token: 0x04002833 RID: 10291
	public const string LIGHT_BEAM_TRANSFORM_NAME = "mode_";

	// Token: 0x04002834 RID: 10292
	private readonly List<Transform> list_0;

	// Token: 0x04002835 RID: 10293
	public LightComponent LightMod;

	// Token: 0x04002836 RID: 10294
	private Transform transform_0;

	// Token: 0x04002837 RID: 10295
	[SerializeField]
	private float _shadowNearPlaneShift;

	// Token: 0x04002838 RID: 10296
	private Light[] light_0;

	// Token: 0x04002839 RID: 10297
	private LaserBeam[] laserBeam_0;

	// Token: 0x0200070E RID: 1806
	[CompilerGenerated]
	[Serializable]
	private sealed class Class376
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Transform mod)
		{
			throw null;
		}

		// Token: 0x0400283A RID: 10298
		public static readonly TacticalComboVisualController.Class376 class376_0;

		// Token: 0x0400283B RID: 10299
		public static Predicate<Transform> predicate_0;
	}
}
