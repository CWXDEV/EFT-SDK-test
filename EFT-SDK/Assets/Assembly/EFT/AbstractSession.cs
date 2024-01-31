using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Networking;

namespace EFT
{
	// Token: 0x0200119F RID: 4511
	public abstract class AbstractSession : NetworkBehaviour
	{
		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06006046 RID: 24646 RVA: 0x00002050 File Offset: 0x00000250
		internal static NetworkHash128 NetworkHash128_0
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06006047 RID: 24647 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006048 RID: 24648 RVA: 0x00002050 File Offset: 0x00000250
		public EMemberCategory MemberCategory
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06006049 RID: 24649 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600604A RID: 24650 RVA: 0x00002050 File Offset: 0x00000250
		public NetworkConnection Connection
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x0600604B RID: 24651 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static T CreateSession<T>(Transform parent, string name, string profileId, string token) where T : AbstractSession
		{
			throw null;
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x0600604C RID: 24652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600604D RID: 24653 RVA: 0x00002050 File Offset: 0x00000250
		public string ProfileId
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x0600604E RID: 24654 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600604F RID: 24655 RVA: 0x00002050 File Offset: 0x00000250
		public string Token
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06006050 RID: 24656 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void ProfileResourcesLoadProgress(int id, float progress)
		{
			throw null;
		}

		// Token: 0x06006051 RID: 24657 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06006052 RID: 24658 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			throw null;
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			throw null;
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PreStartClient()
		{
			throw null;
		}

		// Token: 0x040069DC RID: 27100
		internal const short short_0 = 147;

		// Token: 0x040069DD RID: 27101
		internal const short short_1 = 148;

		// Token: 0x040069DE RID: 27102
		internal const short short_2 = 188;

		// Token: 0x040069DF RID: 27103
		internal const short short_3 = 189;

		// Token: 0x040069E0 RID: 27104
		internal const short short_4 = 190;

		// Token: 0x040069E1 RID: 27105
		internal const short short_5 = 151;

		// Token: 0x040069E2 RID: 27106
		internal const short short_6 = 152;

		// Token: 0x040069E3 RID: 27107
		internal const short short_7 = 191;

		// Token: 0x040069E4 RID: 27108
		internal const short short_8 = 192;

		// Token: 0x040069E5 RID: 27109
		internal const short short_9 = 154;

		// Token: 0x040069E6 RID: 27110
		internal const short short_10 = 155;

		// Token: 0x040069E7 RID: 27111
		internal const short short_11 = 156;

		// Token: 0x040069E8 RID: 27112
		internal const short short_12 = 157;

		// Token: 0x040069E9 RID: 27113
		internal const short short_13 = 158;

		// Token: 0x040069EA RID: 27114
		internal const short short_14 = 160;

		// Token: 0x040069EB RID: 27115
		internal const short short_15 = 168;

		// Token: 0x040069EC RID: 27116
		internal const short short_16 = 170;

		// Token: 0x040069ED RID: 27117
		internal const short short_17 = 171;

		// Token: 0x040069EE RID: 27118
		internal const short short_18 = 172;

		// Token: 0x040069EF RID: 27119
		internal const short short_19 = 173;

		// Token: 0x040069F0 RID: 27120
		internal const short short_20 = 174;

		// Token: 0x040069F1 RID: 27121
		internal const short short_21 = 175;

		// Token: 0x040069F2 RID: 27122
		internal const short short_22 = 180;

		// Token: 0x040069F3 RID: 27123
		internal const short short_23 = 181;

		// Token: 0x040069F4 RID: 27124
		internal const short short_24 = 182;

		// Token: 0x040069F5 RID: 27125
		internal const short short_25 = 183;

		// Token: 0x040069F6 RID: 27126
		internal const short short_26 = 184;

		// Token: 0x040069F7 RID: 27127
		[CompilerGenerated]
		private EMemberCategory ememberCategory_0;

		// Token: 0x040069F8 RID: 27128
		[CompilerGenerated]
		private NetworkConnection networkConnection_0;

		// Token: 0x040069F9 RID: 27129
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040069FA RID: 27130
		[CompilerGenerated]
		private string string_1;
	}
}
