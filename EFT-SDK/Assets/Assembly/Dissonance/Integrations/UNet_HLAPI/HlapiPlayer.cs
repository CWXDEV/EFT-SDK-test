using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Networking;

namespace Dissonance.Integrations.UNet_HLAPI
{
	// Token: 0x02000ECE RID: 3790
	[RequireComponent(typeof(NetworkIdentity))]
	public class HlapiPlayer : NetworkBehaviour, IDissonancePlayer
	{
		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06004F0A RID: 20234 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004F0B RID: 20235 RVA: 0x00002050 File Offset: 0x00000250
		AudioSource IDissonancePlayer.VoipAudioSource
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06004F0C RID: 20236 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004F0D RID: 20237 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsTracking
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

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x00002050 File Offset: 0x00000250
		public string PlayerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x00002050 File Offset: 0x00000250
		public Vector3 Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x06004F10 RID: 20240 RVA: 0x00002050 File Offset: 0x00000250
		public Quaternion Rotation
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x00002050 File Offset: 0x00000250
		public NetworkPlayerType Type
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06004F12 RID: 20242 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDestroy()
		{
			throw null;
		}

		// Token: 0x06004F13 RID: 20243 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnEnable()
		{
			throw null;
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnDisable()
		{
			throw null;
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStartLocalPlayer()
		{
			throw null;
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(string playerName)
		{
			throw null;
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnStartClient()
		{
			throw null;
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x00002050 File Offset: 0x00000250
		[Command]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(string playerName)
		{
			throw null;
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x00002050 File Offset: 0x00000250
		[ClientRpc]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(string playerName)
		{
			throw null;
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004F1E RID: 20254 RVA: 0x00002050 File Offset: 0x00000250
		public string Network_playerId
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			[param: In]
			set
			{
				throw null;
			}
		}

		// Token: 0x06004F1F RID: 20255 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeCmdCmdSetPlayerName(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06004F20 RID: 20256 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallCmdSetPlayerName(string playerName)
		{
			throw null;
		}

		// Token: 0x06004F21 RID: 20257 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void InvokeRpcRpcSetPlayerName(NetworkBehaviour obj, NetworkReader reader)
		{
			throw null;
		}

		// Token: 0x06004F22 RID: 20258 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CallRpcSetPlayerName(string playerName)
		{
			throw null;
		}

		// Token: 0x06004F23 RID: 20259 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override bool OnSerialize(NetworkWriter writer, bool forceAll)
		{
			throw null;
		}

		// Token: 0x06004F24 RID: 20260 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void OnDeserialize(NetworkReader reader, bool initialState)
		{
			throw null;
		}

		// Token: 0x06004F25 RID: 20261 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void PreStartClient()
		{
			throw null;
		}

		// Token: 0x04005BCF RID: 23503
		[CompilerGenerated]
		private AudioSource audioSource_0;

		// Token: 0x04005BD0 RID: 23504
		private static readonly Log log_0;

		// Token: 0x04005BD1 RID: 23505
		private DissonanceComms dissonanceComms_0;

		// Token: 0x04005BD2 RID: 23506
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04005BD3 RID: 23507
		[SyncVar]
		private string string_0;

		// Token: 0x04005BD4 RID: 23508
		private static int int_0;

		// Token: 0x04005BD5 RID: 23509
		private static int int_1;
	}
}
