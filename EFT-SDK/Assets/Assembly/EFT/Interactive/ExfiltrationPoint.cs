using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EFT.InventoryLogic;
using UnityEngine;

namespace EFT.Interactive
{
	// Token: 0x0200272C RID: 10028
	public class ExfiltrationPoint : MonoBehaviour, IPhysicsTrigger, GInterface102
	{
		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600C8C6 RID: 51398 RVA: 0x00002050 File Offset: 0x00000250
		public string Description
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600C8C7 RID: 51399 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C8C8 RID: 51400 RVA: 0x00002050 File Offset: 0x00000250
		public float FenceRep
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

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C8CA RID: 51402 RVA: 0x00002050 File Offset: 0x00000250
		public int CharismaLevel
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

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C8CC RID: 51404 RVA: 0x00002050 File Offset: 0x00000250
		public EExfiltrationStatus Status
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x00002050 File Offset: 0x00000250
		public TransferItemRequirement TransferItemRequirement
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140002D5 RID: 725
		// (add) Token: 0x0600C8CE RID: 51406 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C8CF RID: 51407 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ExfiltrationPoint, EExfiltrationStatus> OnStatusChanged
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600C8D0 RID: 51408 RVA: 0x00002050 File Offset: 0x00000250
		public bool HasRequirements
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x140002D6 RID: 726
		// (add) Token: 0x0600C8D1 RID: 51409 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C8D2 RID: 51410 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ExfiltrationPoint, Player> OnStartExtraction
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x140002D7 RID: 727
		// (add) Token: 0x0600C8D3 RID: 51411 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600C8D4 RID: 51412 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<ExfiltrationPoint, Player> OnCancelExtraction
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x0600C8D5 RID: 51413 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string[] GetTips(string profileId)
		{
			throw null;
		}

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual bool InfiltrationMatch(Player player)
		{
			throw null;
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadSettings(GClass1222 settings, bool authority)
		{
			throw null;
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(Player obj)
		{
			throw null;
		}

		// Token: 0x0600C8DA RID: 51418 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1(Player obj)
		{
			throw null;
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetInitialStatus()
		{
			throw null;
		}

		// Token: 0x0600C8DC RID: 51420 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x0600C8DD RID: 51421 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3()
		{
			throw null;
		}

		// Token: 0x0600C8DE RID: 51422 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4(WorldInteractiveObject arg1, EDoorState arg2, EDoorState arg3)
		{
			throw null;
		}

		// Token: 0x0600C8DF RID: 51423 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemTransferred(IPlayer player)
		{
			throw null;
		}

		// Token: 0x0600C8E0 RID: 51424 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void OnItemTransferred(string playerId)
		{
			throw null;
		}

		// Token: 0x0600C8E1 RID: 51425 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5(IPlayer iPlayer)
		{
			throw null;
		}

		// Token: 0x0600C8E2 RID: 51426 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CooperationPlayerDied(Player player, IPlayer lastAgressor, DamageInfo damage, EBodyPart part)
		{
			throw null;
		}

		// Token: 0x0600C8E3 RID: 51427 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TransferExitItem(Player player, Item item)
		{
			throw null;
		}

		// Token: 0x0600C8E4 RID: 51428 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Enable()
		{
			throw null;
		}

		// Token: 0x0600C8E5 RID: 51429 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600C8E6 RID: 51430 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable(EExfiltrationStatus prevStatus)
		{
			throw null;
		}

		// Token: 0x0600C8E7 RID: 51431 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Disable()
		{
			throw null;
		}

		// Token: 0x0600C8E8 RID: 51432 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void OnDestroy()
		{
			throw null;
		}

		// Token: 0x0600C8E9 RID: 51433 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<ExfiltrationRequirement> UnmetRequirements(Player player)
		{
			throw null;
		}

		// Token: 0x0600C8EA RID: 51434 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public IEnumerable<ExfiltrationRequirement> UnmetRequirements(string profileId)
		{
			throw null;
		}

		// Token: 0x0600C8EB RID: 51435 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Proceed(Player player, bool manuallyStarted = false)
		{
			throw null;
		}

		// Token: 0x0600C8EC RID: 51436 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhysicsTrigger.OnTriggerEnter(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C8ED RID: 51437 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPhysicsTrigger.OnTriggerExit(Collider col)
		{
			throw null;
		}

		// Token: 0x0600C8EE RID: 51438 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool HasMetRequirements(string profileId)
		{
			throw null;
		}

		// Token: 0x0600C8EF RID: 51439 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExternalSetStatus(EExfiltrationStatus targetStatus, string signature = "")
		{
			throw null;
		}

		// Token: 0x0600C8F0 RID: 51440 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetStatusLogged(EExfiltrationStatus targetStatus, string signature = "")
		{
			throw null;
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600C8F1 RID: 51441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C8F2 RID: 51442 RVA: 0x00002050 File Offset: 0x00000250
		bool IPhysicsTrigger.enabled
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600C8F3 RID: 51443 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private ExfiltrationRequirement method_7(ExfiltrationRequirement x)
		{
			throw null;
		}

		// Token: 0x0400C8F3 RID: 51443
		public Collider ExtendedCollider;

		// Token: 0x0400C8F4 RID: 51444
		public Switch Switch;

		// Token: 0x0400C8F5 RID: 51445
		private string _currentTip;

		// Token: 0x0400C8F6 RID: 51446
		private readonly List<string> _playersMetAllRequirements;

		// Token: 0x0400C8F7 RID: 51447
		[SerializeField]
		private EExfiltrationStatus _status;

		// Token: 0x0400C8FB RID: 51451
		public float ExfiltrationStartTime;

		// Token: 0x0400C8FD RID: 51453
		[SerializeField]
		private GameObject _root;

		// Token: 0x0400C8FE RID: 51454
		[NonSerialized]
		public List<string> QueuedPlayers;

		// Token: 0x0400C8FF RID: 51455
		public ExitTriggerSettings Settings;

		// Token: 0x0400C900 RID: 51456
		public ExfiltrationRequirement[] Requirements;

		// Token: 0x0400C903 RID: 51459
		public readonly GClass3357<Player> Entered;

		// Token: 0x0400C904 RID: 51460
		public string[] EligibleEntryPoints;

		// Token: 0x0400C905 RID: 51461
		public bool Reusable;

		// Token: 0x0400C906 RID: 51462
		private BoxCollider _collider;

		// Token: 0x0400C907 RID: 51463
		private Coroutine _maxTimeCoroutine;

		// Token: 0x0400C908 RID: 51464
		private Coroutine _minTimeCoroutine;

		// Token: 0x0400C909 RID: 51465
		private bool _authorityToChangeStatusExternally;

		// Token: 0x0400C90A RID: 51466
		private List<Switch> _switches;

		// Token: 0x0200272D RID: 10029
		[CompilerGenerated]
		private sealed class Class2252
		{
			// Token: 0x0600C8F4 RID: 51444 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal string method_0(ExfiltrationRequirement x)
			{
				throw null;
			}

			// Token: 0x0400C90B RID: 51467
			public string profileId;
		}

		// Token: 0x0200272E RID: 10030
		[CompilerGenerated]
		private sealed class Class2253
		{
			// Token: 0x0600C8F5 RID: 51445 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(IPlayer x)
			{
				throw null;
			}

			// Token: 0x0400C90C RID: 51468
			public string playerId;
		}

		// Token: 0x0200272F RID: 10031
		[CompilerGenerated]
		private sealed class Class2254
		{
			// Token: 0x0600C8F6 RID: 51446 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ExfiltrationRequirement x)
			{
				throw null;
			}

			// Token: 0x0400C90D RID: 51469
			public Player player;

			// Token: 0x0400C90E RID: 51470
			public ExfiltrationPoint exfiltrationPoint_0;
		}
	}
}
