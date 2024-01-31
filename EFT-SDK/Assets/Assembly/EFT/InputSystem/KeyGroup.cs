using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

namespace EFT.InputSystem
{
	// Token: 0x02001A62 RID: 6754
	[Serializable]
	public sealed class KeyGroup
	{
		// Token: 0x1700159C RID: 5532
		// (get) Token: 0x06008EA2 RID: 36514 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool PressTypeAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public KeyGroup Clone()
		{
			throw null;
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06008EA6 RID: 36518 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Equals(KeyGroup other)
		{
			throw null;
		}

		// Token: 0x06008EA7 RID: 36519 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static bool EqualityCheck(KeyGroup x, KeyGroup y)
		{
			throw null;
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static KeyGroup CopyItem(KeyGroup item)
		{
			throw null;
		}

		// Token: 0x06008EA9 RID: 36521 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static KeyGroup Create(EGameKey gameKey, EPressType press, KeyCode main, KeyCode? alt = null)
		{
			throw null;
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static KeyGroup CreateFrom(KeyGroup source, EGameKey gameKey, EPressType pressType, bool ignorePool)
		{
			throw null;
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06008EAC RID: 36524 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static InputSource smethod_0(KeyCode keyCode)
		{
			throw null;
		}

		// Token: 0x040095E8 RID: 38376
		public EGameKey keyName;

		// Token: 0x040095E9 RID: 38377
		public List<InputSource> variants;

		// Token: 0x040095EA RID: 38378
		public EPressType pressType;

		// Token: 0x040095EB RID: 38379
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		[DefaultValue(true)]
		public bool pressAvailable;

		// Token: 0x040095EC RID: 38380
		[NonSerialized]
		public bool IgnorePool;

		// Token: 0x02001A63 RID: 6755
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1592
		{
			// Token: 0x06008EAD RID: 36525 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(InputSource keyVariant)
			{
				throw null;
			}

			// Token: 0x06008EAE RID: 36526 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal InputSource method_1(InputSource x)
			{
				throw null;
			}

			// Token: 0x040095ED RID: 38381
			public static readonly KeyGroup.Class1592 class1592_0;

			// Token: 0x040095EE RID: 38382
			public static Func<InputSource, bool> func_0;

			// Token: 0x040095EF RID: 38383
			public static Converter<InputSource, InputSource> converter_0;
		}
	}
}
