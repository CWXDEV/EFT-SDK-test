using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio.Data;
using UnityEngine;

// Token: 0x02000D56 RID: 3414
public class GClass986 : GClass985
{
	// Token: 0x17000B8F RID: 2959
	// (get) Token: 0x060048C0 RID: 18624 RVA: 0x00002050 File Offset: 0x00000250
	public override bool IsPlaying
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060048C1 RID: 18625 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnPlay(SoundBankWithSettings bank, bool stereo = false)
	{
		throw null;
	}

	// Token: 0x060048C2 RID: 18626 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnUpdate(float dt)
	{
		throw null;
	}

	// Token: 0x060048C3 RID: 18627 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void OnStop()
	{
		throw null;
	}

	// Token: 0x060048C4 RID: 18628 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Dispose()
	{
		throw null;
	}

	// Token: 0x0400537E RID: 21374
	private const float float_0 = 1f;

	// Token: 0x0400537F RID: 21375
	private readonly Queue<GClass986.Struct154> queue_0;

	// Token: 0x04005380 RID: 21376
	private readonly Transform transform_0;

	// Token: 0x04005381 RID: 21377
	private readonly BetterSource betterSource_0;

	// Token: 0x04005382 RID: 21378
	private float float_1;

	// Token: 0x04005383 RID: 21379
	private int int_0;

	// Token: 0x02000D57 RID: 3415
	[StructLayout(LayoutKind.Auto)]
	public readonly struct Struct154
	{
		// Token: 0x04005384 RID: 21380
		public readonly SoundBankWithSettings Bank;

		// Token: 0x04005385 RID: 21381
		public readonly bool Stereo;
	}
}
