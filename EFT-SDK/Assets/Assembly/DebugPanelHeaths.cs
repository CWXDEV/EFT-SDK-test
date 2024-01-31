using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020009B0 RID: 2480
public class DebugPanelHeaths : MonoBehaviour
{
	// Token: 0x17000966 RID: 2406
	// (get) Token: 0x0600376F RID: 14191 RVA: 0x00002050 File Offset: 0x00000250
	public RectTransform RectTransform
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x06003770 RID: 14192 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateHealth(GStruct13 heathsData)
	{
		throw null;
	}

	// Token: 0x06003771 RID: 14193 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Color GetHealthColor(int currentHealth, int maxHealth)
	{
		throw null;
	}

	// Token: 0x040038E0 RID: 14560
	public Image IconsHealthHead;

	// Token: 0x040038E1 RID: 14561
	public Image IconsHealthBody;

	// Token: 0x040038E2 RID: 14562
	public Image IconsHealthStomach;

	// Token: 0x040038E3 RID: 14563
	public Image IconsHealthLeftArm;

	// Token: 0x040038E4 RID: 14564
	public Image IconsHealthRightArm;

	// Token: 0x040038E5 RID: 14565
	public Image IconsHealthLeftLeg;

	// Token: 0x040038E6 RID: 14566
	public Image IconsHealthRightLeg;

	// Token: 0x040038E7 RID: 14567
	private RectTransform rectTransform_0;
}
