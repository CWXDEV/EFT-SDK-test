using System;
using System.Runtime.CompilerServices;
using EFT.Ballistics;
using UnityEngine;

// Token: 0x020009EB RID: 2539
public class ArmorDummy : MonoBehaviour
{
	// Token: 0x06003846 RID: 14406 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x06003847 RID: 14407 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void CooliderOnOnHitAction(DamageInfo damageInfo)
	{
		throw null;
	}

	// Token: 0x06003848 RID: 14408 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x04003A02 RID: 14850
	[Header("Armor class [1..10]")]
	public int ArmorClass;

	// Token: 0x04003A03 RID: 14851
	public float Durability;

	// Token: 0x04003A04 RID: 14852
	public int MaxDurability;

	// Token: 0x04003A05 RID: 14853
	public int MaxHealth;

	// Token: 0x04003A06 RID: 14854
	public float Health;

	// Token: 0x04003A07 RID: 14855
	public Renderer[] Body;

	// Token: 0x04003A08 RID: 14856
	public CustomTextMeshProUGUI PopupText;

	// Token: 0x04003A09 RID: 14857
	public RectTransform ArmorImage;

	// Token: 0x04003A0A RID: 14858
	public RectTransform HealthImage;

	// Token: 0x04003A0B RID: 14859
	public BallisticCollider Coolider;

	// Token: 0x04003A0C RID: 14860
	public Transform PivotBars;

	// Token: 0x04003A0D RID: 14861
	public RectTransform Panel;
}
