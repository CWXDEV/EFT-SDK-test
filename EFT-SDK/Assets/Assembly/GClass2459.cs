using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EFT.HealthSystem;
using EFT.InventoryLogic;

// Token: 0x020021F5 RID: 8693
public static class GClass2459
{
	// Token: 0x0600B1B8 RID: 45496 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Type ExtractEffectInterface(IEffect effect)
	{
		throw null;
	}

	// Token: 0x0600B1B9 RID: 45497 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string EffectName(IEffect effect)
	{
		throw null;
	}

	// Token: 0x0600B1BA RID: 45498 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GClass2457[] GetDisplayVariation(IEffect effect, bool exactTime)
	{
		throw null;
	}

	// Token: 0x0600B1BB RID: 45499 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool FromBodyPart(this IEffect effect, EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600B1BC RID: 45500 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool IsVital(this EBodyPart bodyPart)
	{
		throw null;
	}

	// Token: 0x0600B1BD RID: 45501 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool TryGetDamageEffectType(Type type, out EDamageEffectType effectType)
	{
		throw null;
	}

	// Token: 0x0400B629 RID: 46633
	public static readonly IReadOnlyList<EBodyPart> AllBodyParts;

	// Token: 0x0400B62A RID: 46634
	public static readonly IReadOnlyList<EBodyPart> RealBodyParts;

	// Token: 0x0400B62B RID: 46635
	public static readonly IReadOnlyList<EBodyPart> VitalBodyParts;

	// Token: 0x0400B62C RID: 46636
	public static readonly IReadOnlyList<EDamageEffectType> DamageEffectTypes;

	// Token: 0x0400B62D RID: 46637
	private static readonly Dictionary<Type, EDamageEffectType> dictionary_0;

	// Token: 0x0400B62E RID: 46638
	private static readonly Dictionary<Type, string> dictionary_1;

	// Token: 0x020021F6 RID: 8694
	public static class GClass2460
	{
		// Token: 0x0600B1BE RID: 45502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static byte Make(IEffect effect)
		{
			throw null;
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static string Resolve(byte effectType)
		{
			throw null;
		}

		// Token: 0x0400B62F RID: 46639
		private static readonly Type[] type_0;

		// Token: 0x0400B630 RID: 46640
		private static readonly Dictionary<string, byte> dictionary_0;

		// Token: 0x0400B631 RID: 46641
		private static readonly Dictionary<byte, string> dictionary_1;

		// Token: 0x020021F7 RID: 8695
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1917
		{
			// Token: 0x0600B1C0 RID: 45504 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type t)
			{
				throw null;
			}

			// Token: 0x0600B1C1 RID: 45505 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_1(Type t)
			{
				throw null;
			}

			// Token: 0x0600B1C2 RID: 45506 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_2(Type t)
			{
				throw null;
			}

			// Token: 0x0600B1C3 RID: 45507 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal byte method_3(Type t)
			{
				throw null;
			}

			// Token: 0x0600B1C4 RID: 45508 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal byte method_4(KeyValuePair<string, byte> kv)
			{
				throw null;
			}

			// Token: 0x0600B1C5 RID: 45509 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_5(KeyValuePair<string, byte> kv)
			{
				throw null;
			}

			// Token: 0x0400B632 RID: 46642
			public static readonly GClass2459.GClass2460.Class1917 class1917_0;
		}
	}

	// Token: 0x020021F8 RID: 8696
	public static class GClass2461<T> where T : IHealthController
	{
		// Token: 0x0600B1C6 RID: 45510 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static object Create(string effectType)
		{
			throw null;
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Func<object> smethod_0(string effectType)
		{
			throw null;
		}

		// Token: 0x0400B633 RID: 46643
		private static readonly Dictionary<string, Func<object>> dictionary_0;

		// Token: 0x0400B634 RID: 46644
		private static readonly Type[] type_0;

		// Token: 0x020021F9 RID: 8697
		[CompilerGenerated]
		private sealed class Class1918
		{
			// Token: 0x0600B1C8 RID: 45512 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Type t)
			{
				throw null;
			}

			// Token: 0x0600B1C9 RID: 45513 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal object method_1()
			{
				throw null;
			}

			// Token: 0x0400B635 RID: 46645
			public string effectType;

			// Token: 0x0400B636 RID: 46646
			public ConstructorInfo constructor;
		}
	}

	// Token: 0x020021FB RID: 8699
	[CompilerGenerated]
	private sealed class Class1920
	{
		// Token: 0x0600B1CB RID: 45515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Type type)
		{
			throw null;
		}

		// Token: 0x0400B638 RID: 46648
		public IEffect effect;
	}

	// Token: 0x020021FC RID: 8700
	[CompilerGenerated]
	private sealed class Class1921
	{
		// Token: 0x0600B1CC RID: 45516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Type type2)
		{
			throw null;
		}

		// Token: 0x0400B639 RID: 46649
		public Type type;
	}

	// Token: 0x020021FD RID: 8701
	[CompilerGenerated]
	[Serializable]
	private sealed class Class1922
	{
		// Token: 0x0600B1CD RID: 45517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(Type type)
		{
			throw null;
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(Type type1)
		{
			throw null;
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_2(EBodyPart bp)
		{
			throw null;
		}

		// Token: 0x0400B63A RID: 46650
		public static readonly GClass2459.Class1922 class1922_0;

		// Token: 0x0400B63B RID: 46651
		public static Func<Type, bool> func_0;

		// Token: 0x0400B63C RID: 46652
		public static Func<Type, bool> func_1;
	}

	// Token: 0x020021FE RID: 8702
	[CompilerGenerated]
	private sealed class Class1923
	{
		// Token: 0x0600B1D0 RID: 45520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal float method_0()
		{
			throw null;
		}

		// Token: 0x0400B63D RID: 46653
		public IEffect effect;
	}
}
