using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.UI.WeaponModding;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x020009EA RID: 2538
public class WeaponPreviewPool : MonoBehaviour
{
	// Token: 0x06003843 RID: 14403 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Awake()
	{
		throw null;
	}

	// Token: 0x06003844 RID: 14404 RVA: 0x00002050 File Offset: 0x00000250
	[CanBeNull]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WeaponPreview GetWeaponPreview()
	{
		throw null;
	}

	// Token: 0x06003845 RID: 14405 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnToPool(WeaponPreview weaponPreview)
	{
		throw null;
	}

	// Token: 0x040039FF RID: 14847
	[SerializeField]
	private WeaponPreview _weaponPreviewTemplate;

	// Token: 0x04003A00 RID: 14848
	[SerializeField]
	private int _count;

	// Token: 0x04003A01 RID: 14849
	private readonly List<WeaponPreview> list_0;
}
