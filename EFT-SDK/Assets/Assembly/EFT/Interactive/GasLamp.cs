using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x020027E5 RID: 10213
	public class GasLamp : Turnable
	{
		// Token: 0x0600CC92 RID: 52370 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnValidate()
		{
			throw null;
		}

		// Token: 0x0600CC93 RID: 52371 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600CC94 RID: 52372 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Update()
		{
			throw null;
		}

		// Token: 0x0600CC95 RID: 52373 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PlaySound(AudioClip clip)
		{
			throw null;
		}

		// Token: 0x0600CC96 RID: 52374 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Switch(Turnable.EState switchTo)
		{
			throw null;
		}

		// Token: 0x0400CCB3 RID: 52403
		private static readonly int int_0;

		// Token: 0x0400CCB4 RID: 52404
		[SerializeField]
		private AudioSource _audioSource;

		// Token: 0x0400CCB5 RID: 52405
		[SerializeField]
		private float _intensity;

		// Token: 0x0400CCB6 RID: 52406
		private float float_0;

		// Token: 0x0400CCB7 RID: 52407
		private GasLamp.Struct774[] struct774_0;

		// Token: 0x0400CCB8 RID: 52408
		private GasLamp.Struct775[] struct775_0;

		// Token: 0x020027E6 RID: 10214
		public enum FlickerSounds
		{
			// Token: 0x0400CCBA RID: 52410
			Flicker1,
			// Token: 0x0400CCBB RID: 52411
			Flicker2,
			// Token: 0x0400CCBC RID: 52412
			Flicker3,
			// Token: 0x0400CCBD RID: 52413
			Flicker4
		}

		// Token: 0x020027E7 RID: 10215
		[StructLayout(LayoutKind.Auto)]
		public struct Struct774
		{
			// Token: 0x0400CCBE RID: 52414
			public Light Light;

			// Token: 0x0400CCBF RID: 52415
			public float OriginalIntensity;
		}

		// Token: 0x020027E8 RID: 10216
		[StructLayout(LayoutKind.Auto)]
		public struct Struct775
		{
			// Token: 0x0400CCC0 RID: 52416
			public MultiFlareLight Light;

			// Token: 0x0400CCC1 RID: 52417
			public float OriginalAlpha;
		}

		// Token: 0x020027E9 RID: 10217
		[CompilerGenerated]
		[Serializable]
		private sealed class Class2312
		{
			// Token: 0x0600CC97 RID: 52375 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GasLamp.Struct774 method_0(Light x)
			{
				throw null;
			}

			// Token: 0x0600CC98 RID: 52376 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal GasLamp.Struct775 method_1(MultiFlareLight x)
			{
				throw null;
			}

			// Token: 0x0400CCC2 RID: 52418
			public static readonly GasLamp.Class2312 class2312_0;

			// Token: 0x0400CCC3 RID: 52419
			public static Func<Light, GasLamp.Struct774> func_0;

			// Token: 0x0400CCC4 RID: 52420
			public static Func<MultiFlareLight, GasLamp.Struct775> func_1;
		}
	}
}
