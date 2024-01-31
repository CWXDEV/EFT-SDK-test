using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000132 RID: 306
[CreateAssetMenu(fileName = "CoverPointCreatorPresetCollection", menuName = "Scriptable objects/AI/CoverPointCreator Preset Collection")]
public class CoverPointCreatorPresetCollection : ScriptableObject
{
	// Token: 0x170001DF RID: 479
	// (get) Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
	public List<CoverPointCreatorPreset> Presets
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static CoverPointCreatorPreset GetDefault()
	{
		throw null;
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoverPointCreatorPreset GetPresetByName(string name)
	{
		throw null;
	}

	// Token: 0x04000758 RID: 1880
	[SerializeField]
	private List<CoverPointCreatorPreset> _presets;
}
