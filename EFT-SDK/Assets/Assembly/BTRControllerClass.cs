using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EFT;
using EFT.GlobalEvents;
using EFT.InventoryLogic;
using EFT.Vehicle;
using UnityEngine;

// Token: 0x0200266C RID: 9836
public sealed class BTRControllerClass : IDisposable
{
	// Token: 0x170022D8 RID: 8920
	// (get) Token: 0x0600C32E RID: 49966 RVA: 0x00002050 File Offset: 0x00000250
	public static BTRControllerClass Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x170022D9 RID: 8921
	// (get) Token: 0x0600C32F RID: 49967 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C330 RID: 49968 RVA: 0x00002050 File Offset: 0x00000250
	public BTRVehicle BtrVehicle
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

	// Token: 0x170022DA RID: 8922
	// (get) Token: 0x0600C331 RID: 49969 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C332 RID: 49970 RVA: 0x00002050 File Offset: 0x00000250
	public BTRView BtrView
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

	// Token: 0x170022DB RID: 8923
	// (get) Token: 0x0600C333 RID: 49971 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C334 RID: 49972 RVA: 0x00002050 File Offset: 0x00000250
	public bool IsBtrPaid
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

	// Token: 0x170022DC RID: 8924
	// (get) Token: 0x0600C335 RID: 49973 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C336 RID: 49974 RVA: 0x00002050 File Offset: 0x00000250
	public StashClass BtrStash
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

	// Token: 0x170022DD RID: 8925
	// (get) Token: 0x0600C337 RID: 49975 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x0600C338 RID: 49976 RVA: 0x00002050 File Offset: 0x00000250
	public BotOwner BotShooterBtr
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

	// Token: 0x0600C339 RID: 49977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool HasNonEmptyTransferContainer(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C33A RID: 49978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void InitTransferContainer(StashClass newContainer)
	{
		throw null;
	}

	// Token: 0x0600C33B RID: 49979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterBotShooterBTR(BotOwner owner)
	{
		throw null;
	}

	// Token: 0x0600C33C RID: 49980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StashClass GetOrAddTransferContainer(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C33D RID: 49981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_0(CancellationToken cancellationToken)
	{
		throw null;
	}

	// Token: 0x0600C33E RID: 49982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task method_1()
	{
		throw null;
	}

	// Token: 0x0600C33F RID: 49983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_2()
	{
		throw null;
	}

	// Token: 0x0600C340 RID: 49984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_3()
	{
		throw null;
	}

	// Token: 0x0600C341 RID: 49985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_4(string locationID)
	{
		throw null;
	}

	// Token: 0x0600C342 RID: 49986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_5()
	{
		throw null;
	}

	// Token: 0x0600C343 RID: 49987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveToDestination(string idPathDestination, int playerId = -1)
	{
		throw null;
	}

	// Token: 0x0600C344 RID: 49988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void BotCoverPurchase()
	{
		throw null;
	}

	// Token: 0x0600C345 RID: 49989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_6(List<int> playersToNotify, ETraderServiceType serviceType)
	{
		throw null;
	}

	// Token: 0x0600C346 RID: 49990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_7(PathDestination destinationPoint, bool isFirst, bool isFinal, bool lastRoutePoint)
	{
		throw null;
	}

	// Token: 0x0600C347 RID: 49991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_8(string destinationID, int currentDestinationIndex)
	{
		throw null;
	}

	// Token: 0x0600C348 RID: 49992 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_9(PathDestination currentDestinationPoint, bool lastRoutePoint)
	{
		throw null;
	}

	// Token: 0x0600C349 RID: 49993 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_10()
	{
		throw null;
	}

	// Token: 0x0600C34A RID: 49994 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_11(BtrServicePurchaseEvent servicePurchaseEvent)
	{
		throw null;
	}

	// Token: 0x0600C34B RID: 49995 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_12(BtrNotificationInteractionMessageEvent notificationInteractionMessage)
	{
		throw null;
	}

	// Token: 0x0600C34C RID: 49996 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void HandleReconnectOnClient(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C34D RID: 49997 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SyncBTRVehicleFromServer(BTRDataPacket snapshotMessage)
	{
		throw null;
	}

	// Token: 0x0600C34E RID: 49998 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_13()
	{
		throw null;
	}

	// Token: 0x0600C34F RID: 49999 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_14()
	{
		throw null;
	}

	// Token: 0x0600C350 RID: 50000 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void MoveItemsFromTempStashToTransferStash(Player player)
	{
		throw null;
	}

	// Token: 0x0600C351 RID: 50001 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GStruct23 smethod_0(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C352 RID: 50002 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetPlayerTaxiPriceForProfile(string subServiceId, string profileId)
	{
		throw null;
	}

	// Token: 0x0600C353 RID: 50003 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private int method_15(string profileId, ETraderServiceType serviceType, int basePrice)
	{
		throw null;
	}

	// Token: 0x0600C354 RID: 50004 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public double GetDeliveryPriceForProfile(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C355 RID: 50005 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetBotCoverPriceForProfile(string profileId)
	{
		throw null;
	}

	// Token: 0x0600C356 RID: 50006 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public int GetGridItemsPrice(StashClass stashContainer)
	{
		throw null;
	}

	// Token: 0x0600C357 RID: 50007 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		throw null;
	}

	// Token: 0x0400C50D RID: 50445
	public const string BTR_INTERACTION_MESSAGE_KEY = "Btr/InteractionMessage";

	// Token: 0x0400C50E RID: 50446
	private const string string_0 = "Btr/ServicePurchased";

	// Token: 0x0400C50F RID: 50447
	private const string string_1 = "MapPathsConfigurations";

	// Token: 0x0400C510 RID: 50448
	private const string string_2 = "MapPathsConfiguration";

	// Token: 0x0400C511 RID: 50449
	private const string string_3 = "BTRTemplates/Server/BTRTemplate";

	// Token: 0x0400C512 RID: 50450
	private const string string_4 = "BTRTemplates/Client/BTRViewTemplate";

	// Token: 0x0400C513 RID: 50451
	private Dictionary<string, int> dictionary_0;

	// Token: 0x0400C514 RID: 50452
	public Vector2 WaitForPassengerRange;

	// Token: 0x0400C515 RID: 50453
	private float float_0;

	// Token: 0x0400C516 RID: 50454
	private Vector2 vector2_0;

	// Token: 0x0400C517 RID: 50455
	private int int_0;

	// Token: 0x0400C518 RID: 50456
	private bool bool_0;

	// Token: 0x0400C519 RID: 50457
	[CompilerGenerated]
	private BTRVehicle btrvehicle_0;

	// Token: 0x0400C51A RID: 50458
	[CompilerGenerated]
	private BTRView btrview_0;

	// Token: 0x0400C51B RID: 50459
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x0400C51C RID: 50460
	public MapPathConfig MapPathsConfiguration;

	// Token: 0x0400C51D RID: 50461
	private CancellationTokenSource cancellationTokenSource_0;

	// Token: 0x0400C51E RID: 50462
	private TraderControllerClass gclass2754_0;

	// Token: 0x0400C51F RID: 50463
	private Action action_0;

	// Token: 0x0400C520 RID: 50464
	private Action action_1;

	// Token: 0x0400C521 RID: 50465
	private readonly List<Item> list_0;

	// Token: 0x0400C522 RID: 50466
	private readonly List<StashClass> list_1;

	// Token: 0x0400C523 RID: 50467
	[CompilerGenerated]
	private StashClass gclass2698_0;

	// Token: 0x0400C524 RID: 50468
	private BackendConfigSettingsClass.BTRGlobalSettings btrglobalSettings_0;

	// Token: 0x0400C525 RID: 50469
	[CompilerGenerated]
	private BotOwner botOwner_0;

	// Token: 0x0200266D RID: 9837
	[CompilerGenerated]
	private sealed class Class2199
	{
		// Token: 0x0600C358 RID: 50008 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(StashClass container)
		{
			throw null;
		}

		// Token: 0x0400C526 RID: 50470
		public string profileId;
	}

	// Token: 0x0200266E RID: 9838
	[CompilerGenerated]
	private sealed class Class2200
	{
		// Token: 0x0600C359 RID: 50009 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(StashClass container)
		{
			throw null;
		}

		// Token: 0x0400C527 RID: 50471
		public string profileId;
	}

	// Token: 0x02002670 RID: 9840
	[CompilerGenerated]
	private sealed class Class2201
	{
		// Token: 0x0600C35C RID: 50012 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(KeyValuePair<string, BTRMapPath> x)
		{
			throw null;
		}

		// Token: 0x0400C52B RID: 50475
		public GameWorld game;
	}

	// Token: 0x02002672 RID: 9842
	[CompilerGenerated]
	private sealed class Class2202
	{
		// Token: 0x0600C35F RID: 50015 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(StashClass grid)
		{
			throw null;
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_1(GClass2495 grid)
		{
			throw null;
		}

		// Token: 0x0400C531 RID: 50481
		public Player player;
	}

	// Token: 0x02002673 RID: 9843
	[CompilerGenerated]
	private sealed class Class2203
	{
		// Token: 0x0600C361 RID: 50017 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(BackendConfigSettingsClass.SubService x)
		{
			throw null;
		}

		// Token: 0x0400C532 RID: 50482
		public string subServiceId;
	}

	// Token: 0x02002674 RID: 9844
	[CompilerGenerated]
	private sealed class Class2204
	{
		// Token: 0x0600C362 RID: 50018 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool method_0(StashClass grid)
		{
			throw null;
		}

		// Token: 0x0400C533 RID: 50483
		public string profileId;
	}
}
