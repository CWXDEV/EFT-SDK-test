using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

namespace EFT
{
	// Token: 0x020016AD RID: 5805
	public class PhraseSounds : ScriptableObject
	{
		// Token: 0x06007D6A RID: 32106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryGetVoice(string voice, out TagBank[] result)
		{
			throw null;
		}

		// Token: 0x06007D6B RID: 32107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public TagBank[] GetVoice(string voice, EPlayerSide side)
		{
			throw null;
		}

		// Token: 0x06007D6C RID: 32108 RVA: 0x00002050 File Offset: 0x00000250
		[CanBeNull]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TagBank[] method_0(string voice)
		{
			throw null;
		}

		// Token: 0x04008454 RID: 33876
		public Voice[] Voices;

		// Token: 0x020016AE RID: 5806
		[CompilerGenerated]
		private sealed class Class1194
		{
			// Token: 0x06007D6D RID: 32109 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Voice x)
			{
				throw null;
			}

			// Token: 0x04008455 RID: 33877
			public string voice;
		}
	}
}
