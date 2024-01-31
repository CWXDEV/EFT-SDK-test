using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace EFT
{
	// Token: 0x02001775 RID: 6005
	public sealed class AudioSequence : ScriptableObject
	{
		// Token: 0x06008069 RID: 32873 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AudioSequence.GStruct230 GetSequenceSettings(EAudioSequenceType sequenceType)
		{
			throw null;
		}

		// Token: 0x040088B8 RID: 35000
		public AudioClip SequenceClip;

		// Token: 0x040088B9 RID: 35001
		public double OnTime;

		// Token: 0x040088BA RID: 35002
		public double WorkingTime;

		// Token: 0x040088BB RID: 35003
		public double OffTime;

		// Token: 0x040088BC RID: 35004
		public double DisabledTime;

		// Token: 0x040088BD RID: 35005
		public double OverlapTime;

		// Token: 0x040088BE RID: 35006
		[HideInInspector]
		public AudioClip OnSource;

		// Token: 0x040088BF RID: 35007
		[HideInInspector]
		public AudioClip WorkingSource;

		// Token: 0x040088C0 RID: 35008
		[HideInInspector]
		public AudioClip OffSource;

		// Token: 0x040088C1 RID: 35009
		[HideInInspector]
		public AudioClip DisabledSource;

		// Token: 0x02001776 RID: 6006
		[StructLayout(LayoutKind.Auto)]
		public struct GStruct230
		{
			// Token: 0x040088C2 RID: 35010
			public double StartTime;

			// Token: 0x040088C3 RID: 35011
			public double LoopLength;

			// Token: 0x040088C4 RID: 35012
			public double SkipTime;

			// Token: 0x040088C5 RID: 35013
			public double JumpTime;

			// Token: 0x040088C6 RID: 35014
			public double InitialLength;

			// Token: 0x040088C7 RID: 35015
			public double LoopStartTime;

			// Token: 0x040088C8 RID: 35016
			public float Delay;
		}
	}
}
