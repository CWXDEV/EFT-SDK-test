using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT;
using EFT.AssetsManager;
using JetBrains.Annotations;
using UnityEngine;

// Token: 0x0200070A RID: 1802
[DisallowMultipleComponent]
public class MagVisualController : WeaponModPoolObject
{
	// Token: 0x06002A08 RID: 10760 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_1()
	{
		throw null;
	}

	// Token: 0x06002A09 RID: 10761 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void OnCreatePoolObject<TAssetPoolObject>([CanBeNull] GClass3001<TAssetPoolObject> assetsPoolParent)
	{
		throw null;
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void ReturnToPool()
	{
		throw null;
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ReturnAmmo()
	{
		throw null;
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitMagazine(MagazineClass mag, IPlayer player, bool isAnimated = true)
	{
		throw null;
	}

	// Token: 0x06002A0D RID: 10765 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ObservedUpdate(int magCount)
	{
		throw null;
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		throw null;
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2(int magCount)
	{
		throw null;
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x04002827 RID: 10279
	private const string string_0 = "patron_";

	// Token: 0x04002828 RID: 10280
	private GClass675[] gclass675_0;

	// Token: 0x04002829 RID: 10281
	private MagazineClass gclass2665_0;

	// Token: 0x0400282A RID: 10282
	private List<AmmoPoolObject> list_0;

	// Token: 0x0400282B RID: 10283
	private Animation animation_0;

	// Token: 0x0400282C RID: 10284
	private int int_0;

	// Token: 0x0400282D RID: 10285
	private bool bool_3;

	// Token: 0x0200070B RID: 1803
	[CompilerGenerated]
	[Serializable]
	private sealed class Class375
	{
		// Token: 0x06002A11 RID: 10769 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_0(AmmoPoolObject ammo)
		{
			throw null;
		}

		// Token: 0x0400282E RID: 10286
		public static readonly MagVisualController.Class375 class375_0;

		// Token: 0x0400282F RID: 10287
		public static Action<AmmoPoolObject> action_0;
	}
}
