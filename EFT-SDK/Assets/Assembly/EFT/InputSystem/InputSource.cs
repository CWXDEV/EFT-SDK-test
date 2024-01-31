using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using UnityEngine;

namespace EFT.InputSystem
{
	// Token: 0x02001A60 RID: 6752
	[Serializable]
	public sealed class InputSource
	{
		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x06008E93 RID: 36499 RVA: 0x00002050 File Offset: 0x00000250
		[JsonIgnore]
		public bool IsEmpty
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public InputSource Clone()
		{
			throw null;
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddKey(KeyCode key)
		{
			throw null;
		}

		// Token: 0x06008E97 RID: 36503 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Check(EGameKey gameKey)
		{
			throw null;
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06008E9A RID: 36506 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static EKeyPress Listen(ref InputSource inputSource, EGameKey gameKey)
		{
			throw null;
		}

		// Token: 0x040095DE RID: 38366
		private static readonly KeyCode[] ValidKeyCodes;

		// Token: 0x040095DF RID: 38367
		private static readonly string[] ValidAxes;

		// Token: 0x040095E0 RID: 38368
		private static readonly Dictionary<EGameKey, List<KeyCode>> ForbiddenForAxisWithDefaultKey;

		// Token: 0x040095E1 RID: 38369
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool isAxis;

		// Token: 0x040095E2 RID: 38370
		public List<KeyCode> keyCode;

		// Token: 0x040095E3 RID: 38371
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string axisName;

		// Token: 0x040095E4 RID: 38372
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool positiveAxis;

		// Token: 0x040095E5 RID: 38373
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public float deadZone;

		// Token: 0x040095E6 RID: 38374
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		[DefaultValue(1f)]
		public float sensitivity;
	}
}
